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
        private List<PlanToDisplay> _planes;
        private PlanToDisplay? _selectedItem;
        private bool _isEdit;
        private string _baseEndpointUrl = "planes";
        private List<EspecialidadDto> _especialidades;

        public AdminPlanes()
        {
            InitializeComponent();

            _ = LoadDropdownListsAsync();
            CheckActions();
        }

        private async Task LoadPlanesAsync()
        {
            var all = await HttpClientHelper.GetAsync<List<PlanToDisplay>>(_baseEndpointUrl);
            if (all is not null)
            {
                _planes = all;
            }
        }

        private void LoadPlan(PlanToDisplay dto)
        {
            txtId.Text = dto.Id.ToString();
            txtDescripcion.Text = dto.Descripcion;

            cmbEspecialidad.SelectedIndex = _especialidades.FindIndex(x => x.Id == dto.EspecialidadId);
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

        private async Task LoadDropdownListsAsync()
        {
            var allEspecialidades = await HttpClientHelper.GetAsync<List<EspecialidadDto>>("especialidades");
            if (allEspecialidades is not null)
            {
                _especialidades = allEspecialidades;

                var bindingSource = new BindingSource();
                bindingSource.DataSource = _especialidades;
                cmbEspecialidad.ValueMember = "Id";
                cmbEspecialidad.DisplayMember = "Descripcion";
                cmbEspecialidad.DataSource = bindingSource;
            }
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            _isEdit = false;
            await RefreshGridAsync();
        }

        private async void dgvPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var selectedItem = _planes[e.RowIndex];
            var selectedItemId = selectedItem.Id;

            var plan = await HttpClientHelper.GetAsync<PlanToDisplay>($"{_baseEndpointUrl}/{selectedItemId.ToString()}");
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
            var descripcion = txtDescripcion.Text;

            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Debe completar todos los campos.", "Validacion");
                return;
            }

            if (!string.IsNullOrEmpty(descripcion))
            {
                var selectedEspecialidad = cmbEspecialidad.SelectedIndex;
                var newItemToAdd = new PlanCreateRequest
                {
                    Descripcion = txtDescripcion.Text,
                    EspecialidadId = _especialidades[selectedEspecialidad].Id,
                };

                await HttpClientHelper.PostAsync<PlanResponse>(
                    $"{_baseEndpointUrl}",
                    newItemToAdd);

                CleanForm();
                await RefreshGridAsync();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(txtId.Text);
            var descripcion = txtDescripcion.Text;

            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Debe completar todos los campos.", "Validacion");
                return;
            }

            if (!string.IsNullOrEmpty(descripcion))
            {
                var dialogResult = MessageBox.Show($"Guardar cambios sobre Plan Id: {id}?", "Guardar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var itemToUpdate = new PlanUpdateRequest
                    {
                        Id = id,
                        Descripcion = txtDescripcion.Text,
                    };

                    await HttpClientHelper.PutAsync<BooleanResultResponse>(
                        $"{_baseEndpointUrl}",
                        itemToUpdate);

                    _isEdit = false;

                    CleanForm();
                    await RefreshGridAsync();
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var itemToDelete = _selectedItem.Id;

            var dialogResult = MessageBox.Show($"Borrar Plan Id: {itemToDelete}?", "Borrar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await HttpClientHelper.DeleteAsync<BooleanResultResponse>(
                $"{_baseEndpointUrl}",
                itemToDelete);

                CleanForm();
                await RefreshGridAsync();
            }
        }

        private void btnCancelClean_Click(object sender, EventArgs e)
        {
            _isEdit = false;
            CleanForm();
            CheckActions();
        }
    }

    public class PlanToDisplay
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public Guid EspecialidadId { get; set; }
        public string EspecialidadDescripcion { get; set; }
    }
}
