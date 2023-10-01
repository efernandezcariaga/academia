namespace Desktop
{
    public partial class AdminAcademia : Form
    {
        public AdminPersonas? AdminPersonas { get; set; }

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

        private void btnShortcutAdmPersonas_Click(object sender, EventArgs e)
        {
            OpenAdminPersonas();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAdminPersonas();
        }
    }
}