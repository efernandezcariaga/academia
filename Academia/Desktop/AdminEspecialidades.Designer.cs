﻿namespace Desktop
{
    partial class AdminEspecialidades
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
            lblAdminEspecialidadesHome = new Label();
            dgvEspecialidades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // btnCancelClean
            // 
            btnCancelClean.Location = new Point(365, 260);
            btnCancelClean.Name = "btnCancelClean";
            btnCancelClean.Size = new Size(120, 23);
            btnCancelClean.TabIndex = 54;
            btnCancelClean.Text = "Cancelar / Limpiar";
            btnCancelClean.UseVisualStyleBackColor = true;
            btnCancelClean.Click += btnCancelClean_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(681, 231);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 53;
            btnLoad.Text = "Cargar lista";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(681, 288);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 52;
            btnClose.Text = "Salir";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(365, 231);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 51;
            btnAddNew.Text = "Nuevo";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(541, 289);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 50;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(365, 288);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 23);
            btnSave.TabIndex = 49;
            btnSave.Text = "Guardar cambios";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(141, 257);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(188, 23);
            txtDescripcion.TabIndex = 48;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(141, 228);
            txtId.Name = "txtId";
            txtId.Size = new Size(188, 23);
            txtId.TabIndex = 47;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 260);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 46;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 231);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 45;
            lblId.Text = "ID";
            // 
            // lblAdminEspecialidadesHome
            // 
            lblAdminEspecialidadesHome.AutoSize = true;
            lblAdminEspecialidadesHome.Location = new Point(12, 25);
            lblAdminEspecialidadesHome.Name = "lblAdminEspecialidadesHome";
            lblAdminEspecialidadesHome.Size = new Size(183, 15);
            lblAdminEspecialidadesHome.TabIndex = 44;
            lblAdminEspecialidadesHome.Text = "Administracion de Especialidades";
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Location = new Point(12, 53);
            dgvEspecialidades.MultiSelect = false;
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowTemplate.Height = 25;
            dgvEspecialidades.Size = new Size(744, 150);
            dgvEspecialidades.TabIndex = 43;
            dgvEspecialidades.CellClick += dgvEspecialidades_CellClick;
            // 
            // AdminEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 325);
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
            Controls.Add(lblAdminEspecialidadesHome);
            Controls.Add(dgvEspecialidades);
            Name = "AdminEspecialidades";
            Text = "Administracion de Especialidades";
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
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
        private Label lblAdminEspecialidadesHome;
        private DataGridView dgvEspecialidades;
    }
}