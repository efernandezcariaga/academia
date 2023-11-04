namespace Desktop
{
    partial class AdminPersonas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPersonas = new DataGridView();
            lblAdminPersonasHome = new Label();
            lblId = new Label();
            lblNombre = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtLegajo = new TextBox();
            lblLegajo = new Label();
            txtFechaNacimientoDay = new TextBox();
            lblFechaNacimiento = new Label();
            lblPlan = new Label();
            lblEspecialidad = new Label();
            txtFechaNacimientoMonth = new TextBox();
            txtFechaNacimientoYear = new TextBox();
            cmbPlan = new ComboBox();
            cmbEspecialidad = new ComboBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnAddNew = new Button();
            btnClose = new Button();
            btnLoad = new Button();
            btnCancelClean = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(12, 52);
            dgvPersonas.MultiSelect = false;
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowTemplate.Height = 25;
            dgvPersonas.Size = new Size(744, 150);
            dgvPersonas.TabIndex = 0;
            dgvPersonas.CellClick += dgvPersonas_CellClick;
            // 
            // lblAdminPersonasHome
            // 
            lblAdminPersonasHome.AutoSize = true;
            lblAdminPersonasHome.Location = new Point(12, 24);
            lblAdminPersonasHome.Name = "lblAdminPersonasHome";
            lblAdminPersonasHome.Size = new Size(154, 15);
            lblAdminPersonasHome.TabIndex = 1;
            lblAdminPersonasHome.Text = "Administracion de Personas";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 230);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 2;
            lblId.Text = "ID";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 259);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(141, 227);
            txtId.Name = "txtId";
            txtId.Size = new Size(188, 23);
            txtId.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 256);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(141, 285);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(188, 23);
            txtApellido.TabIndex = 7;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 288);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(141, 314);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(188, 23);
            txtDireccion.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(12, 317);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Direccion";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 343);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 23);
            txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 346);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(141, 372);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(188, 23);
            txtTelefono.TabIndex = 13;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(12, 375);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Telefono";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(141, 401);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(188, 23);
            txtLegajo.TabIndex = 15;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(12, 404);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 14;
            lblLegajo.Text = "Legajo";
            // 
            // txtFechaNacimientoDay
            // 
            txtFechaNacimientoDay.Location = new Point(141, 430);
            txtFechaNacimientoDay.MaxLength = 2;
            txtFechaNacimientoDay.Name = "txtFechaNacimientoDay";
            txtFechaNacimientoDay.PlaceholderText = "DD";
            txtFechaNacimientoDay.Size = new Size(59, 23);
            txtFechaNacimientoDay.TabIndex = 17;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(12, 433);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(103, 15);
            lblFechaNacimiento.TabIndex = 16;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(12, 462);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 18;
            lblPlan.Text = "Plan";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(12, 491);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(72, 15);
            lblEspecialidad.TabIndex = 20;
            lblEspecialidad.Text = "Especialidad";
            // 
            // txtFechaNacimientoMonth
            // 
            txtFechaNacimientoMonth.Location = new Point(206, 430);
            txtFechaNacimientoMonth.MaxLength = 2;
            txtFechaNacimientoMonth.Name = "txtFechaNacimientoMonth";
            txtFechaNacimientoMonth.PlaceholderText = "MM";
            txtFechaNacimientoMonth.Size = new Size(59, 23);
            txtFechaNacimientoMonth.TabIndex = 21;
            // 
            // txtFechaNacimientoYear
            // 
            txtFechaNacimientoYear.Location = new Point(271, 430);
            txtFechaNacimientoYear.MaxLength = 4;
            txtFechaNacimientoYear.Name = "txtFechaNacimientoYear";
            txtFechaNacimientoYear.PlaceholderText = "AAAA";
            txtFechaNacimientoYear.Size = new Size(59, 23);
            txtFechaNacimientoYear.TabIndex = 22;
            // 
            // cmbPlan
            // 
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Location = new Point(141, 459);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(188, 23);
            cmbPlan.TabIndex = 23;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(142, 488);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(188, 23);
            cmbEspecialidad.TabIndex = 24;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(365, 487);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 23);
            btnSave.TabIndex = 25;
            btnSave.Text = "Guardar cambios";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(541, 488);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(365, 230);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 27;
            btnAddNew.Text = "Nuevo";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(681, 487);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 28;
            btnClose.Text = "Salir";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(681, 230);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 29;
            btnLoad.Text = "Cargar lista";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnCancelClean
            // 
            btnCancelClean.Location = new Point(365, 459);
            btnCancelClean.Name = "btnCancelClean";
            btnCancelClean.Size = new Size(120, 23);
            btnCancelClean.TabIndex = 30;
            btnCancelClean.Text = "Cancelar / Limpiar";
            btnCancelClean.UseVisualStyleBackColor = true;
            btnCancelClean.Click += btnCancelClean_Click;
            // 
            // AdminPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 531);
            Controls.Add(btnCancelClean);
            Controls.Add(btnLoad);
            Controls.Add(btnClose);
            Controls.Add(btnAddNew);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(cmbEspecialidad);
            Controls.Add(cmbPlan);
            Controls.Add(txtFechaNacimientoYear);
            Controls.Add(txtFechaNacimientoMonth);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblPlan);
            Controls.Add(txtFechaNacimientoDay);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(txtLegajo);
            Controls.Add(lblLegajo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(lblAdminPersonasHome);
            Controls.Add(dgvPersonas);
            Name = "AdminPersonas";
            Text = "Administracion de Personas";
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonas;
        private Label lblAdminPersonasHome;
        private Label lblId;
        private Label lblNombre;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtLegajo;
        private Label lblLegajo;
        private TextBox txtFechaNacimientoDay;
        private Label lblFechaNacimiento;
        private Label lblPlan;
        private Label lblEspecialidad;
        private TextBox txtFechaNacimientoMonth;
        private TextBox txtFechaNacimientoYear;
        private ComboBox cmbPlan;
        private ComboBox cmbEspecialidad;
        private Button btnSave;
        private Button btnDelete;
        private Button btnAddNew;
        private Button btnClose;
        private Button btnLoad;
        private Button btnCancelClean;
    }
}