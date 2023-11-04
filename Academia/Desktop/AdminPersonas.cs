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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Desktop
{
    public partial class AdminPersonas : Form
    {
        private List<PersonaToDisplay> _personas;
        private PersonaToDisplay? _selectedItem;
        private bool _isEdit;
        private string _baseEndpointUrl = "personas";
        private List<PlanDto> _planes;
        private List<EspecialidadDto> _especialidades;

        public AdminPersonas()
        {
            InitializeComponent();

            _ = LoadDropdownListsAsync();
            CheckActions();
        }

        private async Task LoadPersonasAsync()
        {
            var allPersonas = await HttpClientHelper.GetAsync<List<PersonaToDisplay>>(_baseEndpointUrl);
            if (allPersonas is not null)
            {
                _personas = allPersonas;
            }
        }

        private void LoadPersona(PersonaToDisplay persona)
        {
            txtId.Text = persona.Id.ToString();
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            txtDireccion.Text = persona.Direccion;
            txtEmail.Text = persona.Email;
            txtTelefono.Text = persona.Telefono;
            txtLegajo.Text = persona.Legajo.ToString();

            txtFechaNacimientoDay.Text = persona.FechaNacimiento.Day.ToString();
            txtFechaNacimientoMonth.Text = persona.FechaNacimiento.Month.ToString();
            txtFechaNacimientoYear.Text = persona.FechaNacimiento.Year.ToString();

            cmbPlan.SelectedIndex = _planes.FindIndex(x => x.Id == persona.PlanId);
            cmbEspecialidad.SelectedIndex = _especialidades.FindIndex(x => x.Id == persona.EspecialidadId);
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

            txtFechaNacimientoDay.Text = string.Empty;
            txtFechaNacimientoMonth.Text = string.Empty;
            txtFechaNacimientoYear.Text = string.Empty;

            cmbPlan.SelectedIndex = 0;
            cmbEspecialidad.SelectedIndex = 0;

            _isEdit = false;
        }

        private void CheckActions()
        {
            btnAddNew.Enabled = !_isEdit;
            btnSave.Enabled = _isEdit;
            btnDelete.Enabled = _isEdit;
        }

        private async Task LoadDropdownListsAsync()
        {
            var allPlanes = await HttpClientHelper.GetAsync<List<PlanDto>>("planes");
            if (allPlanes is not null)
            {
                _planes = allPlanes;

                var bindingSource = new BindingSource();
                bindingSource.DataSource = _planes;
                cmbPlan.ValueMember = "Id";
                cmbPlan.DisplayMember = "Descripcion";
                cmbPlan.DataSource = bindingSource;
            }

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

        private bool isValidFormForAddAndSave(
            string nombre,
            string apellido,
            string direccion,
            string email,
            string telefono,
            string legajo,
            string fechaNacimientoDay,
            string fechaNacimientoMonth,
            string fechaNacimientoYear,
            int selectedPlan,
            int selectedEspecialidad
            )
        {
            // Validate fields
            var isAnyEmptyValue = string.IsNullOrEmpty(nombre)
                || string.IsNullOrEmpty(apellido)
                || string.IsNullOrEmpty(direccion)
                || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(telefono)
                || string.IsNullOrEmpty(legajo)
                || string.IsNullOrEmpty(fechaNacimientoDay)
                || string.IsNullOrEmpty(fechaNacimientoMonth)
                || string.IsNullOrEmpty(fechaNacimientoYear)
                || selectedPlan == -1
                || selectedEspecialidad == -1;
            if (isAnyEmptyValue)
            {
                MessageBox.Show("Debe completar todos los campos.", "Validacion");
                return false;
            }

            var isLegajoValid = int.TryParse(legajo, out _) && legajo.Length == 5;
            if (!isLegajoValid) {
                MessageBox.Show("El Legajo debe ser un Numero entero de 5 digitos.", "Validacion");
                return false;
            }

            // Validate date values
            var isFechaNacimientoValidDate = DateFormatHelper.IsValidDate(fechaNacimientoDay, fechaNacimientoMonth, fechaNacimientoYear);
            if (!isFechaNacimientoValidDate)
            {
                MessageBox.Show("La fecha de nacimiento NO es valida. El formato correcto es: DD MM AAA (DD: DÍA; MM: MES: MM; AAAA: AÑO). Valores numericos enteros.", "Validacion");
                return false;
            }

            return true;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            _isEdit = false;
            await RefreshGridAsync();
        }

        private async void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var selectedItem = _personas[e.RowIndex];
            var selectedItemId = selectedItem.Id;

            var persona = await HttpClientHelper.GetAsync<PersonaToDisplay>($"{_baseEndpointUrl}/{selectedItemId.ToString()}");
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
            var nombre = txtNombre.Text;
            var apellido = txtApellido.Text;
            var direccion = txtDireccion.Text;
            var email = txtEmail.Text;
            var telefono = txtTelefono.Text;
            var legajo = txtLegajo.Text;

            var fechaNacimientoDay = txtFechaNacimientoDay.Text;
            var fechaNacimientoMonth = txtFechaNacimientoMonth.Text;
            var fechaNacimientoYear = txtFechaNacimientoYear.Text;

            var selectedPlan = cmbPlan.SelectedIndex;
            var selectedEspecialidad = cmbEspecialidad.SelectedIndex;

            if (isValidFormForAddAndSave(
                nombre,
                apellido,
                direccion,
                email,
                telefono,
                legajo,
                fechaNacimientoDay,
                fechaNacimientoMonth,
                fechaNacimientoYear,
                selectedPlan,
                selectedEspecialidad))
            {
                var newItemToAdd = new PersonaCreateRequest
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Direccion = direccion,
                    Email = email,
                    Telefono = telefono,
                    Legajo = int.Parse(legajo),
                    FechaNacimiento = new DateTime(int.Parse(fechaNacimientoYear), int.Parse(fechaNacimientoMonth), int.Parse(fechaNacimientoDay)),

                    PlanId = _planes[selectedPlan].Id,
                    EspecialidadId = _especialidades[selectedEspecialidad].Id,
                };

                await HttpClientHelper.PostAsync<PersonaResponse>(
                    $"{_baseEndpointUrl}",
                    newItemToAdd);

                CleanForm();
                await RefreshGridAsync();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(txtId.Text);
            var nombre = txtNombre.Text;
            var apellido = txtApellido.Text;
            var direccion = txtDireccion.Text;
            var email = txtEmail.Text;
            var telefono = txtTelefono.Text;
            var legajo = txtLegajo.Text;

            var fechaNacimientoDay = txtFechaNacimientoDay.Text;
            var fechaNacimientoMonth = txtFechaNacimientoMonth.Text;
            var fechaNacimientoYear = txtFechaNacimientoYear.Text;

            var selectedPlan = cmbPlan.SelectedIndex;
            var selectedEspecialidad = cmbEspecialidad.SelectedIndex;

            if (isValidFormForAddAndSave(
                nombre,
                apellido,
                direccion,
                email,
                telefono,
                legajo,
                fechaNacimientoDay,
                fechaNacimientoMonth,
                fechaNacimientoYear,
                selectedPlan,
                selectedEspecialidad))
            {
                var dialogResult = MessageBox.Show($"Guardar cambios sobre Persona Id: {id}?", "Guardar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var itemToUpdate = new PersonaUpdateRequest
                    {
                        Id = id,
                        Nombre = nombre,
                        Apellido = apellido,
                        Direccion = direccion,
                        Email = email,
                        Telefono = telefono,
                        Legajo = int.Parse(legajo),
                        FechaNacimiento = new DateTime(int.Parse(fechaNacimientoYear), int.Parse(fechaNacimientoMonth), int.Parse(fechaNacimientoDay)),

                        PlanId = _planes[selectedPlan].Id,
                        EspecialidadId = _especialidades[selectedEspecialidad].Id,
                    };

                    var result = await HttpClientHelper.PutAsync<BooleanResultResponse>(
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

            var dialogResult = MessageBox.Show($"Borrar Persona Id: {itemToDelete}?", "Borrar", MessageBoxButtons.YesNo);
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

    public class PersonaToDisplay
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int Legajo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Guid PlanId { get; set; }
        public string PlanDescripcion { get; set; }
        public Guid EspecialidadId { get; set; }
        public string EspecialidadDescripcion { get; set; }
    }
}
