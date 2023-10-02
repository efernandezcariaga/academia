using Desktop.Helpers;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApi.DTO.Dto;
using WebApi.DTO.Request;
using WebApi.DTO.Response;

namespace Desktop
{
    public partial class AdminEspecialidades : Form
    {
        private List<EspecialidadDto> _especialidades;
        private EspecialidadDto? _selectedItem;
        private bool _isEdit;
        private string _baseEndpointUrl = "especialidades";

        public AdminEspecialidades()
        {
            InitializeComponent();
            CheckActions();
        }

        private async Task LoadEspecialidadesAsync()
        {
            var all = await HttpClientHelper.GetAsync<List<EspecialidadDto>>(_baseEndpointUrl);
            if (all is not null)
            {
                _especialidades = all;
            }
        }

        private void LoadEspecialidad(EspecialidadDto dto)
        {
            txtId.Text = dto.Id.ToString();
            txtDescripcion.Text = dto.Descripcion;
        }

        private async Task RefreshGridAsync()
        {
            await LoadEspecialidadesAsync();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _especialidades;
            dgvEspecialidades.DataSource = bindingSource;
        }

        private void CleanForm()
        {
            txtId.Text = string.Empty;
            txtDescripcion.Text = string.Empty;

            _isEdit = false;
        }

        private void CheckActions()
        {
            btnAddNew.Enabled = !_isEdit;
            btnSave.Enabled = _isEdit;
            btnDelete.Enabled = _isEdit;

            // TBD: Agregar mas reglas
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            _isEdit = false;
            await RefreshGridAsync();
        }

        private async void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedItem = _especialidades[e.RowIndex];
            var selectedItemId = selectedItem.Id;

            var especialidad = await HttpClientHelper.GetAsync<EspecialidadDto>($"{_baseEndpointUrl}/{selectedItemId.ToString()}");
            if (especialidad is not null)
            {
                _selectedItem = especialidad;
                _isEdit = true;
                LoadEspecialidad(especialidad);
                CheckActions();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CleanForm();
            Close();
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            var newItemToAdd = new EspecialidadCreateRequest
            {
                Descripcion = txtDescripcion.Text,
            };

            var result = await HttpClientHelper.PostAsync<EspecialidadResponse>(
                $"{_baseEndpointUrl}",
                newItemToAdd);
            // TBD: Error handling, validar result

            CleanForm();
            await RefreshGridAsync();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var itemToUpdate = new EspecialidadUpdateRequest
            {
                Id = Guid.Parse(txtId.Text),
                Descripcion = txtDescripcion.Text,
            };

            var result = await HttpClientHelper.PutAsync<BooleanResultResponse>(
                $"{_baseEndpointUrl}",
                itemToUpdate);
            // TBD: Error handling, validar result

            _isEdit = false;

            CleanForm();
            await RefreshGridAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var itemToDelete = _selectedItem.Id;

            var result = await HttpClientHelper.DeleteAsync<BooleanResultResponse>(
                $"{_baseEndpointUrl}",
                itemToDelete);
            // TBD: Error handling, validar results

            CleanForm();
            await RefreshGridAsync();
        }

        private void btnCancelClean_Click(object sender, EventArgs e)
        {
            _isEdit = false;
            CleanForm();
            CheckActions();
        }
    }
}
