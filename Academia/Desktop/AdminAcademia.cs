namespace Desktop
{
    public partial class AdminAcademia : Form
    {
        public AdminPersonas? AdminPersonas { get; set; }
        public AdminEspecialidades? AdminEspecialidades { get; set; }
        public AdminPlanes? AdminPlanes { get; set; }

        public AdminAcademia()
        {
            InitializeComponent();
        }

        public void OpenAdminPersonas()
        {
            if (AdminPersonas is not null)
            {
                AdminPersonas.ShowDialog();
            }
            else
            {
                AdminPersonas = new AdminPersonas();
                AdminPersonas.ShowDialog();
            }
        }

        public void OpenAdminEspecialidades()
        {
            if (AdminEspecialidades is not null)
            {
                AdminEspecialidades.ShowDialog();
            }
            else
            {
                AdminEspecialidades = new AdminEspecialidades();
                AdminEspecialidades.ShowDialog();
            }
        }

        public void OpenAdminPlanes()
        {
            if (AdminPlanes is not null)
            {
                AdminPlanes.ShowDialog();
            }
            else
            {
                AdminPlanes = new AdminPlanes();
                AdminPlanes.ShowDialog();
            }
        }

        private void btnShortcutAdmPersonas_Click(object sender, EventArgs e)
        {
            OpenAdminPersonas();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAdminPersonas();
        }

        private void btnShortcutAdmEspecialidades_Click(object sender, EventArgs e)
        {
            OpenAdminEspecialidades();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAdminEspecialidades();
        }

        private void btnShortcutAdmPlanes_Click(object sender, EventArgs e)
        {
            OpenAdminPlanes();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAdminPlanes();
        }
    }
}