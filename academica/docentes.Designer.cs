namespace academica
{
    partial class docentes
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
            this.components = new System.ComponentModel.Container();
            this.lblBuscarDocentes = new System.Windows.Forms.Label();
            this.txtBuscarDocentes = new System.Windows.Forms.TextBox();
            this.grbEdicionDocentes = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocentes = new System.Windows.Forms.Button();
            this.btnModificarDocentes = new System.Windows.Forms.Button();
            this.btnNuevoDocentes = new System.Windows.Forms.Button();
            this.grbNavegacionDocentes = new System.Windows.Forms.GroupBox();
            this.lblRegistrosDocentes = new System.Windows.Forms.Label();
            this.btnUltimoDocentes = new System.Windows.Forms.Button();
            this.btnSiguienteDocentes = new System.Windows.Forms.Button();
            this.btnAnteriorDocentes = new System.Windows.Forms.Button();
            this.btnPrimeroDocentes = new System.Windows.Forms.Button();
            this.grbDatosDocentes = new System.Windows.Forms.GroupBox();
            this.lblEmailDocentes = new System.Windows.Forms.Label();
            this.txtEmailDocentes = new System.Windows.Forms.TextBox();
            this.cmbEspecialidadDocentes = new System.Windows.Forms.ComboBox();
            this.lblEspecialidadDocentes = new System.Windows.Forms.Label();
            this.lblDuiDocentes = new System.Windows.Forms.Label();
            this.txtDuiDocentes = new System.Windows.Forms.TextBox();
            this.lblTelefonoDocentes = new System.Windows.Forms.Label();
            this.txtTelefonoDocentes = new System.Windows.Forms.TextBox();
            this.lblDireccionDocentes = new System.Windows.Forms.Label();
            this.txtDireccionDocentes = new System.Windows.Forms.TextBox();
            this.lblNombreDocentes = new System.Windows.Forms.Label();
            this.txtNombreDocentes = new System.Windows.Forms.TextBox();
            this.lblCodigoDocentes = new System.Windows.Forms.Label();
            this.txtCodigoDocentes = new System.Windows.Forms.TextBox();
            this.grdDatosDocentes = new System.Windows.Forms.DataGridView();
            this.idDocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_academicaDataSet6 = new academica.db_academicaDataSet6();
            this.docentesTableAdapter = new academica.db_academicaDataSet6TableAdapters.docentesTableAdapter();
            this.grbEdicionDocentes.SuspendLayout();
            this.grbNavegacionDocentes.SuspendLayout();
            this.grbDatosDocentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarDocentes
            // 
            this.lblBuscarDocentes.AutoSize = true;
            this.lblBuscarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDocentes.Location = new System.Drawing.Point(410, 22);
            this.lblBuscarDocentes.Name = "lblBuscarDocentes";
            this.lblBuscarDocentes.Size = new System.Drawing.Size(91, 24);
            this.lblBuscarDocentes.TabIndex = 21;
            this.lblBuscarDocentes.Text = "BUSCAR:";
            // 
            // txtBuscarDocentes
            // 
            this.txtBuscarDocentes.Location = new System.Drawing.Point(501, 27);
            this.txtBuscarDocentes.Name = "txtBuscarDocentes";
            this.txtBuscarDocentes.Size = new System.Drawing.Size(347, 20);
            this.txtBuscarDocentes.TabIndex = 22;
            this.txtBuscarDocentes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarDocentes_KeyUp);
            // 
            // grbEdicionDocentes
            // 
            this.grbEdicionDocentes.Controls.Add(this.btnEliminarDocentes);
            this.grbEdicionDocentes.Controls.Add(this.btnModificarDocentes);
            this.grbEdicionDocentes.Controls.Add(this.btnNuevoDocentes);
            this.grbEdicionDocentes.Location = new System.Drawing.Point(232, 356);
            this.grbEdicionDocentes.Name = "grbEdicionDocentes";
            this.grbEdicionDocentes.Size = new System.Drawing.Size(327, 68);
            this.grbEdicionDocentes.TabIndex = 19;
            this.grbEdicionDocentes.TabStop = false;
            this.grbEdicionDocentes.Text = "Navegacion";
            // 
            // btnEliminarDocentes
            // 
            this.btnEliminarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocentes.Location = new System.Drawing.Point(224, 17);
            this.btnEliminarDocentes.Name = "btnEliminarDocentes";
            this.btnEliminarDocentes.Size = new System.Drawing.Size(97, 38);
            this.btnEliminarDocentes.TabIndex = 6;
            this.btnEliminarDocentes.Text = "Eliminar";
            this.btnEliminarDocentes.UseVisualStyleBackColor = true;
            this.btnEliminarDocentes.Click += new System.EventHandler(this.btnEliminarDocentes_Click);
            // 
            // btnModificarDocentes
            // 
            this.btnModificarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocentes.Location = new System.Drawing.Point(105, 19);
            this.btnModificarDocentes.Name = "btnModificarDocentes";
            this.btnModificarDocentes.Size = new System.Drawing.Size(104, 38);
            this.btnModificarDocentes.TabIndex = 5;
            this.btnModificarDocentes.Text = "Modificar";
            this.btnModificarDocentes.UseVisualStyleBackColor = true;
            this.btnModificarDocentes.Click += new System.EventHandler(this.btnModificarDocentes_Click_1);
            // 
            // btnNuevoDocentes
            // 
            this.btnNuevoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocentes.Location = new System.Drawing.Point(6, 17);
            this.btnNuevoDocentes.Name = "btnNuevoDocentes";
            this.btnNuevoDocentes.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoDocentes.TabIndex = 4;
            this.btnNuevoDocentes.Text = "Nuevo";
            this.btnNuevoDocentes.UseVisualStyleBackColor = true;
            this.btnNuevoDocentes.Click += new System.EventHandler(this.btnNuevoDocentes_Click_1);
            // 
            // grbNavegacionDocentes
            // 
            this.grbNavegacionDocentes.Controls.Add(this.lblRegistrosDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnUltimoDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnSiguienteDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnAnteriorDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnPrimeroDocentes);
            this.grbNavegacionDocentes.Location = new System.Drawing.Point(13, 356);
            this.grbNavegacionDocentes.Name = "grbNavegacionDocentes";
            this.grbNavegacionDocentes.Size = new System.Drawing.Size(213, 58);
            this.grbNavegacionDocentes.TabIndex = 18;
            this.grbNavegacionDocentes.TabStop = false;
            this.grbNavegacionDocentes.Text = "Navegacion";
            // 
            // lblRegistrosDocentes
            // 
            this.lblRegistrosDocentes.AutoSize = true;
            this.lblRegistrosDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosDocentes.Location = new System.Drawing.Point(76, 24);
            this.lblRegistrosDocentes.Name = "lblRegistrosDocentes";
            this.lblRegistrosDocentes.Size = new System.Drawing.Size(63, 24);
            this.lblRegistrosDocentes.TabIndex = 10;
            this.lblRegistrosDocentes.Text = "x de n";
            // 
            // btnUltimoDocentes
            // 
            this.btnUltimoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDocentes.Location = new System.Drawing.Point(172, 14);
            this.btnUltimoDocentes.Name = "btnUltimoDocentes";
            this.btnUltimoDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnUltimoDocentes.TabIndex = 3;
            this.btnUltimoDocentes.Text = ">|";
            this.btnUltimoDocentes.UseVisualStyleBackColor = true;
            this.btnUltimoDocentes.Click += new System.EventHandler(this.btnUltimoDocentes_Click_1);
            // 
            // btnSiguienteDocentes
            // 
            this.btnSiguienteDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocentes.Location = new System.Drawing.Point(139, 14);
            this.btnSiguienteDocentes.Name = "btnSiguienteDocentes";
            this.btnSiguienteDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnSiguienteDocentes.TabIndex = 2;
            this.btnSiguienteDocentes.Text = ">";
            this.btnSiguienteDocentes.UseVisualStyleBackColor = true;
            this.btnSiguienteDocentes.Click += new System.EventHandler(this.btnSiguienteDocentes_Click);
            // 
            // btnAnteriorDocentes
            // 
            this.btnAnteriorDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorDocentes.Location = new System.Drawing.Point(40, 18);
            this.btnAnteriorDocentes.Name = "btnAnteriorDocentes";
            this.btnAnteriorDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnAnteriorDocentes.TabIndex = 1;
            this.btnAnteriorDocentes.Text = "<";
            this.btnAnteriorDocentes.UseVisualStyleBackColor = true;
            this.btnAnteriorDocentes.Click += new System.EventHandler(this.btnAnteriorDocentes_Click_1);
            // 
            // btnPrimeroDocentes
            // 
            this.btnPrimeroDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroDocentes.Location = new System.Drawing.Point(7, 18);
            this.btnPrimeroDocentes.Name = "btnPrimeroDocentes";
            this.btnPrimeroDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnPrimeroDocentes.TabIndex = 0;
            this.btnPrimeroDocentes.Text = "|<";
            this.btnPrimeroDocentes.UseVisualStyleBackColor = true;
            this.btnPrimeroDocentes.Click += new System.EventHandler(this.btnPrimeroDocentes_Click_1);
            // 
            // grbDatosDocentes
            // 
            this.grbDatosDocentes.Controls.Add(this.lblEmailDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtEmailDocentes);
            this.grbDatosDocentes.Controls.Add(this.cmbEspecialidadDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblEspecialidadDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblDuiDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtDuiDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblTelefonoDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtTelefonoDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblDireccionDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtDireccionDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblNombreDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtNombreDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblCodigoDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtCodigoDocentes);
            this.grbDatosDocentes.Enabled = false;
            this.grbDatosDocentes.Location = new System.Drawing.Point(5, 12);
            this.grbDatosDocentes.Name = "grbDatosDocentes";
            this.grbDatosDocentes.Size = new System.Drawing.Size(399, 320);
            this.grbDatosDocentes.TabIndex = 17;
            this.grbDatosDocentes.TabStop = false;
            this.grbDatosDocentes.Text = "Datos Docentes";
            // 
            // lblEmailDocentes
            // 
            this.lblEmailDocentes.AutoSize = true;
            this.lblEmailDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDocentes.Location = new System.Drawing.Point(12, 225);
            this.lblEmailDocentes.Name = "lblEmailDocentes";
            this.lblEmailDocentes.Size = new System.Drawing.Size(62, 24);
            this.lblEmailDocentes.TabIndex = 14;
            this.lblEmailDocentes.Text = "Email:";
            // 
            // txtEmailDocentes
            // 
            this.txtEmailDocentes.Location = new System.Drawing.Point(131, 232);
            this.txtEmailDocentes.Name = "txtEmailDocentes";
            this.txtEmailDocentes.Size = new System.Drawing.Size(251, 20);
            this.txtEmailDocentes.TabIndex = 13;
            // 
            // cmbEspecialidadDocentes
            // 
            this.cmbEspecialidadDocentes.FormattingEnabled = true;
            this.cmbEspecialidadDocentes.Items.AddRange(new object[] {
            "Informatico",
            "Contador",
            "Matematico",
            "Abogado",
            "Salud"});
            this.cmbEspecialidadDocentes.Location = new System.Drawing.Point(131, 267);
            this.cmbEspecialidadDocentes.Name = "cmbEspecialidadDocentes";
            this.cmbEspecialidadDocentes.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidadDocentes.TabIndex = 12;
            // 
            // lblEspecialidadDocentes
            // 
            this.lblEspecialidadDocentes.AutoSize = true;
            this.lblEspecialidadDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadDocentes.Location = new System.Drawing.Point(11, 267);
            this.lblEspecialidadDocentes.Name = "lblEspecialidadDocentes";
            this.lblEspecialidadDocentes.Size = new System.Drawing.Size(123, 24);
            this.lblEspecialidadDocentes.TabIndex = 11;
            this.lblEspecialidadDocentes.Text = "Especialidad:";
            // 
            // lblDuiDocentes
            // 
            this.lblDuiDocentes.AutoSize = true;
            this.lblDuiDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiDocentes.Location = new System.Drawing.Point(12, 190);
            this.lblDuiDocentes.Name = "lblDuiDocentes";
            this.lblDuiDocentes.Size = new System.Drawing.Size(43, 24);
            this.lblDuiDocentes.TabIndex = 9;
            this.lblDuiDocentes.Text = "Dui:";
            // 
            // txtDuiDocentes
            // 
            this.txtDuiDocentes.Location = new System.Drawing.Point(131, 197);
            this.txtDuiDocentes.Name = "txtDuiDocentes";
            this.txtDuiDocentes.Size = new System.Drawing.Size(251, 20);
            this.txtDuiDocentes.TabIndex = 8;
            // 
            // lblTelefonoDocentes
            // 
            this.lblTelefonoDocentes.AutoSize = true;
            this.lblTelefonoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoDocentes.Location = new System.Drawing.Point(12, 151);
            this.lblTelefonoDocentes.Name = "lblTelefonoDocentes";
            this.lblTelefonoDocentes.Size = new System.Drawing.Size(90, 24);
            this.lblTelefonoDocentes.TabIndex = 7;
            this.lblTelefonoDocentes.Text = "Telefono:";
            // 
            // txtTelefonoDocentes
            // 
            this.txtTelefonoDocentes.Location = new System.Drawing.Point(131, 158);
            this.txtTelefonoDocentes.Name = "txtTelefonoDocentes";
            this.txtTelefonoDocentes.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoDocentes.TabIndex = 6;
            // 
            // lblDireccionDocentes
            // 
            this.lblDireccionDocentes.AutoSize = true;
            this.lblDireccionDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionDocentes.Location = new System.Drawing.Point(12, 113);
            this.lblDireccionDocentes.Name = "lblDireccionDocentes";
            this.lblDireccionDocentes.Size = new System.Drawing.Size(95, 24);
            this.lblDireccionDocentes.TabIndex = 5;
            this.lblDireccionDocentes.Text = "Direccion:";
            // 
            // txtDireccionDocentes
            // 
            this.txtDireccionDocentes.Location = new System.Drawing.Point(131, 120);
            this.txtDireccionDocentes.Name = "txtDireccionDocentes";
            this.txtDireccionDocentes.Size = new System.Drawing.Size(138, 20);
            this.txtDireccionDocentes.TabIndex = 4;
            // 
            // lblNombreDocentes
            // 
            this.lblNombreDocentes.AutoSize = true;
            this.lblNombreDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDocentes.Location = new System.Drawing.Point(12, 73);
            this.lblNombreDocentes.Name = "lblNombreDocentes";
            this.lblNombreDocentes.Size = new System.Drawing.Size(84, 24);
            this.lblNombreDocentes.TabIndex = 3;
            this.lblNombreDocentes.Text = "Nombre:";
            // 
            // txtNombreDocentes
            // 
            this.txtNombreDocentes.Location = new System.Drawing.Point(131, 80);
            this.txtNombreDocentes.Name = "txtNombreDocentes";
            this.txtNombreDocentes.Size = new System.Drawing.Size(251, 20);
            this.txtNombreDocentes.TabIndex = 2;
            // 
            // lblCodigoDocentes
            // 
            this.lblCodigoDocentes.AutoSize = true;
            this.lblCodigoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDocentes.Location = new System.Drawing.Point(12, 34);
            this.lblCodigoDocentes.Name = "lblCodigoDocentes";
            this.lblCodigoDocentes.Size = new System.Drawing.Size(76, 24);
            this.lblCodigoDocentes.TabIndex = 1;
            this.lblCodigoDocentes.Text = "Codigo:";
            // 
            // txtCodigoDocentes
            // 
            this.txtCodigoDocentes.Location = new System.Drawing.Point(131, 41);
            this.txtCodigoDocentes.Name = "txtCodigoDocentes";
            this.txtCodigoDocentes.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDocentes.TabIndex = 0;
            // 
            // grdDatosDocentes
            // 
            this.grdDatosDocentes.AllowUserToAddRows = false;
            this.grdDatosDocentes.AllowUserToDeleteRows = false;
            this.grdDatosDocentes.AutoGenerateColumns = false;
            this.grdDatosDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocenteDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.duiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.especialidadDataGridViewTextBoxColumn});
            this.grdDatosDocentes.DataSource = this.docentesBindingSource;
            this.grdDatosDocentes.Location = new System.Drawing.Point(414, 67);
            this.grdDatosDocentes.Name = "grdDatosDocentes";
            this.grdDatosDocentes.ReadOnly = true;
            this.grdDatosDocentes.Size = new System.Drawing.Size(481, 246);
            this.grdDatosDocentes.TabIndex = 23;
            // 
            // idDocenteDataGridViewTextBoxColumn
            // 
            this.idDocenteDataGridViewTextBoxColumn.DataPropertyName = "idDocente";
            this.idDocenteDataGridViewTextBoxColumn.HeaderText = "idDocente";
            this.idDocenteDataGridViewTextBoxColumn.Name = "idDocenteDataGridViewTextBoxColumn";
            this.idDocenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocenteDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duiDataGridViewTextBoxColumn
            // 
            this.duiDataGridViewTextBoxColumn.DataPropertyName = "dui";
            this.duiDataGridViewTextBoxColumn.HeaderText = "Dui";
            this.duiDataGridViewTextBoxColumn.Name = "duiDataGridViewTextBoxColumn";
            this.duiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especialidadDataGridViewTextBoxColumn
            // 
            this.especialidadDataGridViewTextBoxColumn.DataPropertyName = "especialidad";
            this.especialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad";
            this.especialidadDataGridViewTextBoxColumn.Name = "especialidadDataGridViewTextBoxColumn";
            this.especialidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docentesBindingSource
            // 
            this.docentesBindingSource.DataMember = "docentes";
            this.docentesBindingSource.DataSource = this.db_academicaDataSet6;
            // 
            // db_academicaDataSet6
            // 
            this.db_academicaDataSet6.DataSetName = "db_academicaDataSet6";
            this.db_academicaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docentesTableAdapter
            // 
            this.docentesTableAdapter.ClearBeforeFill = true;
            // 
            // docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 452);
            this.Controls.Add(this.grdDatosDocentes);
            this.Controls.Add(this.lblBuscarDocentes);
            this.Controls.Add(this.txtBuscarDocentes);
            this.Controls.Add(this.grbEdicionDocentes);
            this.Controls.Add(this.grbNavegacionDocentes);
            this.Controls.Add(this.grbDatosDocentes);
            this.Name = "docentes";
            this.Text = "docentes";
            this.Load += new System.EventHandler(this.docentes_Load);
            this.grbEdicionDocentes.ResumeLayout(false);
            this.grbNavegacionDocentes.ResumeLayout(false);
            this.grbNavegacionDocentes.PerformLayout();
            this.grbDatosDocentes.ResumeLayout(false);
            this.grbDatosDocentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarDocentes;
        private System.Windows.Forms.TextBox txtBuscarDocentes;
        private System.Windows.Forms.GroupBox grbEdicionDocentes;
        private System.Windows.Forms.Button btnEliminarDocentes;
        private System.Windows.Forms.Button btnModificarDocentes;
        private System.Windows.Forms.Button btnNuevoDocentes;
        private System.Windows.Forms.GroupBox grbNavegacionDocentes;
        private System.Windows.Forms.Label lblRegistrosDocentes;
        private System.Windows.Forms.Button btnUltimoDocentes;
        private System.Windows.Forms.Button btnSiguienteDocentes;
        private System.Windows.Forms.Button btnAnteriorDocentes;
        private System.Windows.Forms.Button btnPrimeroDocentes;
        private System.Windows.Forms.GroupBox grbDatosDocentes;
        private System.Windows.Forms.Label lblDireccionDocentes;
        private System.Windows.Forms.TextBox txtDireccionDocentes;
        private System.Windows.Forms.Label lblNombreDocentes;
        private System.Windows.Forms.TextBox txtNombreDocentes;
        private System.Windows.Forms.Label lblCodigoDocentes;
        private System.Windows.Forms.TextBox txtCodigoDocentes;
        private System.Windows.Forms.Label lblEspecialidadDocentes;
        private System.Windows.Forms.Label lblDuiDocentes;
        private System.Windows.Forms.TextBox txtDuiDocentes;
        private System.Windows.Forms.Label lblTelefonoDocentes;
        private System.Windows.Forms.TextBox txtTelefonoDocentes;
        private System.Windows.Forms.ComboBox cmbEspecialidadDocentes;
        private System.Windows.Forms.Label lblEmailDocentes;
        private System.Windows.Forms.TextBox txtEmailDocentes;
        private System.Windows.Forms.DataGridView grdDatosDocentes;
        private db_academicaDataSet6 db_academicaDataSet6;
        private System.Windows.Forms.BindingSource docentesBindingSource;
        private db_academicaDataSet6TableAdapters.docentesTableAdapter docentesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
    }
}