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

namespace Desktop
{
    public partial class AdminPersonas : Form
    {
        private List<PersonaDto> Personas;
        private PersonaDto? SelectedPersona;

        public AdminPersonas()
        {
            InitializeComponent();
        }

        private async Task LoadPersonas()
        {
            var allPersonas = await HttpClientHelper.GetAsync<List<PersonaDto>>("personas");
            if (allPersonas is not null)
            {
                Personas = allPersonas;
            }
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadPersonas();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = Personas;
            dgvPersonas.DataSource = bindingSource;
        }

        private async void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedPersonaFromGrid = Personas[e.RowIndex];
            var personaId = selectedPersonaFromGrid.Id;

            var persona = await HttpClientHelper.GetAsync<PersonaDto>($"personas/{personaId.ToString()}");
            if (persona is not null)
            {
                SelectedPersona = persona;
                LoadPersona(persona);
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
            txtLegajo.Text = persona.Telefono;

            // TBD
            txtFechaNacimientoDay.Text = string.Empty;
            txtFechaNacimientoMonth.Text = string.Empty;
            txtFechaNacimientoYear.Text = string.Empty;

            //cmbPlan
            //cmbEspecialidad
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
