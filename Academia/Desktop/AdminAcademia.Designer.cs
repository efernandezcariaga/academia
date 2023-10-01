namespace Desktop
{
    partial class AdminAcademia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            administrarToolStripMenuItem = new ToolStripMenuItem();
            entidadesToolStripMenuItem = new ToolStripMenuItem();
            personasToolStripMenuItem = new ToolStripMenuItem();
            especialidadesToolStripMenuItem = new ToolStripMenuItem();
            planesToolStripMenuItem = new ToolStripMenuItem();
            lblWelcomeHome = new Label();
            label1 = new Label();
            btnShortcutAdmPersonas = new Button();
            btnShortcutAdmEspecialidades = new Button();
            btnShortcutAdmPlanes = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { administrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(482, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // administrarToolStripMenuItem
            // 
            administrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entidadesToolStripMenuItem });
            administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            administrarToolStripMenuItem.Size = new Size(81, 20);
            administrarToolStripMenuItem.Text = "Administrar";
            // 
            // entidadesToolStripMenuItem
            // 
            entidadesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personasToolStripMenuItem, especialidadesToolStripMenuItem, planesToolStripMenuItem });
            entidadesToolStripMenuItem.Name = "entidadesToolStripMenuItem";
            entidadesToolStripMenuItem.Size = new Size(125, 22);
            entidadesToolStripMenuItem.Text = "Entidades";
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new Size(150, 22);
            personasToolStripMenuItem.Text = "Personas";
            personasToolStripMenuItem.Click += personasToolStripMenuItem_Click;
            // 
            // especialidadesToolStripMenuItem
            // 
            especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            especialidadesToolStripMenuItem.Size = new Size(150, 22);
            especialidadesToolStripMenuItem.Text = "Especialidades";
            // 
            // planesToolStripMenuItem
            // 
            planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            planesToolStripMenuItem.Size = new Size(150, 22);
            planesToolStripMenuItem.Text = "Planes";
            // 
            // lblWelcomeHome
            // 
            lblWelcomeHome.AutoSize = true;
            lblWelcomeHome.Location = new Point(12, 38);
            lblWelcomeHome.Name = "lblWelcomeHome";
            lblWelcomeHome.Size = new Size(259, 15);
            lblWelcomeHome.TabIndex = 1;
            lblWelcomeHome.Text = "Sistema de Administracion de la Academia .NET";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 2;
            label1.Text = "Opciones de acceso rapido";
            // 
            // btnShortcutAdmPersonas
            // 
            btnShortcutAdmPersonas.Location = new Point(12, 95);
            btnShortcutAdmPersonas.Name = "btnShortcutAdmPersonas";
            btnShortcutAdmPersonas.Size = new Size(149, 101);
            btnShortcutAdmPersonas.TabIndex = 3;
            btnShortcutAdmPersonas.Text = "Administrar Personas";
            btnShortcutAdmPersonas.UseVisualStyleBackColor = true;
            btnShortcutAdmPersonas.Click += btnShortcutAdmPersonas_Click;
            // 
            // btnShortcutAdmEspecialidades
            // 
            btnShortcutAdmEspecialidades.Location = new Point(167, 95);
            btnShortcutAdmEspecialidades.Name = "btnShortcutAdmEspecialidades";
            btnShortcutAdmEspecialidades.Size = new Size(149, 101);
            btnShortcutAdmEspecialidades.TabIndex = 4;
            btnShortcutAdmEspecialidades.Text = "Administrar Especialidades";
            btnShortcutAdmEspecialidades.UseVisualStyleBackColor = true;
            // 
            // btnShortcutAdmPlanes
            // 
            btnShortcutAdmPlanes.Location = new Point(322, 95);
            btnShortcutAdmPlanes.Name = "btnShortcutAdmPlanes";
            btnShortcutAdmPlanes.Size = new Size(149, 101);
            btnShortcutAdmPlanes.TabIndex = 5;
            btnShortcutAdmPlanes.Text = "Administrar Planes";
            btnShortcutAdmPlanes.UseVisualStyleBackColor = true;
            // 
            // AdminAcademia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 208);
            Controls.Add(btnShortcutAdmPlanes);
            Controls.Add(btnShortcutAdmEspecialidades);
            Controls.Add(btnShortcutAdmPersonas);
            Controls.Add(label1);
            Controls.Add(lblWelcomeHome);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminAcademia";
            Text = "Sistema de Administracion de la Academia .NET";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem administrarToolStripMenuItem;
        private ToolStripMenuItem entidadesToolStripMenuItem;
        private ToolStripMenuItem personasToolStripMenuItem;
        private Label lblWelcomeHome;
        private Label label1;
        private Button btnShortcutAdmPersonas;
        private Button btnShortcutAdmEspecialidades;
        private Button btnShortcutAdmPlanes;
        private ToolStripMenuItem especialidadesToolStripMenuItem;
        private ToolStripMenuItem planesToolStripMenuItem;
    }
}