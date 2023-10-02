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
    public partial class AdminPersonas : Form
    {
        private List<PersonaDto> _personas;
        private PersonaDto? _selectedItem;
        private bool _isEdit;
        private string _baseEndpointUrl = "personas";

        public AdminPersonas()
        {
            InitializeComponent();
            
            CheckActions();
        }

        private async Task LoadPersonasAsync()
        {
            var allPersonas = await HttpClientHelper.GetAsync<List<PersonaDto>>(_baseEndpointUrl);
            if (allPersonas is not null)
            {
                _personas = allPersonas;
            }
        }

        private void LoadPersona(PersonaDto persona)
        {
            txtId.Text = persona.Id.ToString();
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            txtDireccion.Text = persona.Direccion;
            txtEmail.Text = persona.Email;
            txtTelefono.Text = persona.Telefono;
            txtLegajo.Text = persona.Legajo.ToString();

            // TBD
            txtFechaNacimientoDay.Text = string.Empty;
            txtFechaNacimientoMonth.Text = string.Empty;
            txtFechaNacimientoYear.Text = string.Empty;

            //cmbPlan
            //cmbEspecialidad
        }

        private async Task RefreshGridAsync()
        {
            await LoadPersonasAsync();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _personas;
            dgvPersonas.DataSource = bindingSource;
        }

        private void CleanForm()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtLegajo.Text = string.Empty;

            // TBD
            txtFechaNacimientoDay.Text = string.Empty;
            txtFechaNacimientoMonth.Text = string.Empty;
            txtFechaNacimientoYear.Text = string.Empty;

            //cmbPlan
            //cmbEspecialidad

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

        private async void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedItem = _personas[e.RowIndex];
            var selectedItemId = selectedItem.Id;

            var persona = await HttpClientHelper.GetAsync<PersonaDto>($"{_baseEndpointUrl}/{selectedItemId.ToString()}");
            if (persona is not null)
            {
                _selectedItem = persona;
                _isEdit = true;
                LoadPersona(persona);
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
            var newItemToAdd = new PersonaCreateRequest
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                Legajo = Int32.Parse(txtLegajo.Text),

                // TBD
                //FechaNac
                //Plan
                //Espc
            };

            var result = await HttpClientHelper.PostAsync<PersonaResponse>(
                $"{_baseEndpointUrl}",
                newItemToAdd);
            // TBD: Error handling, validar result

            CleanForm();
            await RefreshGridAsync();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var itemToUpdate = new PersonaUpdateRequest
            {
                Id = Guid.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                Legajo = Int32.Parse(txtLegajo.Text),

                // TBD
                //FechaNac
                //Plan
                //Espc
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
