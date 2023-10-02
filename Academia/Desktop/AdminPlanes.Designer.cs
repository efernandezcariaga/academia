namespace Desktop
{
    partial class AdminPlanes
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
            btnCancelClean = new Button();
            btnLoad = new Button();
            btnClose = new Button();
            btnAddNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtDescripcion = new TextBox();
            txtId = new TextBox();
            lblDescripcion = new Label();
            lblId = new Label();
            lblAdminPlanesHome = new Label();
            dgvPlanes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // btnCancelClean
            // 
            btnCancelClean.Location = new Point(365, 259);
            btnCancelClean.Name = "btnCancelClean";
            btnCancelClean.Size = new Size(120, 23);
            btnCancelClean.TabIndex = 42;
            btnCancelClean.Text = "Cancelar / Limpiar";
            btnCancelClean.UseVisualStyleBackColor = true;
            btnCancelClean.Click += btnCancelClean_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(681, 230);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 41;
            btnLoad.Text = "Cargar lista";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(681, 287);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 40;
            btnClose.Text = "Salir";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(365, 230);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 39;
            btnAddNew.Text = "Nuevo";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(541, 288);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(365, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 23);
            btnSave.TabIndex = 37;
            btnSave.Text = "Guardar cambios";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(141, 256);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(188, 23);
            txtDescripcion.TabIndex = 36;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(141, 227);
            txtId.Name = "txtId";
            txtId.Size = new Size(188, 23);
            txtId.TabIndex = 35;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 259);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 34;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 230);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 33;
            lblId.Text = "ID";
            // 
            // lblAdminPlanesHome
            // 
            lblAdminPlanesHome.AutoSize = true;
            lblAdminPlanesHome.Location = new Point(12, 24);
            lblAdminPlanesHome.Name = "lblAdminPlanesHome";
            lblAdminPlanesHome.Size = new Size(141, 15);
            lblAdminPlanesHome.TabIndex = 32;
            lblAdminPlanesHome.Text = "Administracion de Planes";
            // 
            // dgvPlanes
            // 
            dgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanes.Location = new Point(12, 52);
            dgvPlanes.MultiSelect = false;
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.ReadOnly = true;
            dgvPlanes.RowTemplate.Height = 25;
            dgvPlanes.Size = new Size(744, 150);
            dgvPlanes.TabIndex = 31;
            dgvPlanes.CellClick += dgvPlanes_CellClick;
            // 
            // AdminPlanes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 332);
            Controls.Add(btnCancelClean);
            Controls.Add(btnLoad);
            Controls.Add(btnClose);
            Controls.Add(btnAddNew);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtDescripcion);
            Controls.Add(txtId);
            Controls.Add(lblDescripcion);
            Controls.Add(lblId);
            Controls.Add(lblAdminPlanesHome);
            Controls.Add(dgvPlanes);
            Name = "AdminPlanes";
            Text = "Administracion de Planes";
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelClean;
        private Button btnLoad;
        private Button btnClose;
        private Button btnAddNew;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtDescripcion;
        private TextBox txtId;
        private Label lblDescripcion;
        private Label lblId;
        private Label lblAdminPlanesHome;
        private DataGridView dgvPlanes;
    }
}