using Desktop.Helpers;
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
    public partial class AdminPlanes : Form
    {
        private List<PlanDto> _planes;
        private PlanDto? _selectedItem;
        private bool _isEdit;
        private string _baseEndpointUrl = "planes";
        public AdminPlanes()
        {
            InitializeComponent();
            CheckActions();
        }

        private async Task LoadPlanesAsync()
        {
            var all = await HttpClientHelper.GetAsync<List<PlanDto>>(_baseEndpointUrl);
            if (all is not null)
            {
                _planes = all;
            }
        }

        private void LoadPlan(PlanDto dto)
        {
            txtId.Text = dto.Id.ToString();
            txtDescripcion.Text = dto.Descripcion;
        }

        private async Task RefreshGridAsync()
        {
            await LoadPlanesAsync();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _planes;
            dgvPlanes.DataSource = bindingSource;
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

        private async void dgvPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedItem = _planes[e.RowIndex];
            var selectedItemId = selectedItem.Id;

            var plan = await HttpClientHelper.GetAsync<PlanDto>($"{_baseEndpointUrl}/{selectedItemId.ToString()}");
            if (plan is not null)
            {
                _selectedItem = plan;
                _isEdit = true;
                LoadPlan(plan);
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
            var newItemToAdd = new PlanCreateRequest
            {
                Descripcion = txtDescripcion.Text,
            };

            var result = await HttpClientHelper.PostAsync<PlanResponse>(
                $"{_baseEndpointUrl}",
                newItemToAdd);
            // TBD: Error handling, validar result

            CleanForm();
            await RefreshGridAsync();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var itemToUpdate = new PlanUpdateRequest
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
