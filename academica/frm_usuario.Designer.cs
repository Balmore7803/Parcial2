namespace academica
{
    partial class frm_usuario
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
            this.grdDatosDocentes = new System.Windows.Forms.DataGridView();
            this.lblBuscarUsuarios = new System.Windows.Forms.Label();
            this.txtBuscarUsuarios = new System.Windows.Forms.TextBox();
            this.grbEdicionUsuarios = new System.Windows.Forms.GroupBox();
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.btnModificarUsuarios = new System.Windows.Forms.Button();
            this.btnNuevoUsuarios = new System.Windows.Forms.Button();
            this.grbNavegacionUsuarios = new System.Windows.Forms.GroupBox();
            this.lblRegistrosUsuarios = new System.Windows.Forms.Label();
            this.btnUltimoUsuarios = new System.Windows.Forms.Button();
            this.btnSiguienteUsuarios = new System.Windows.Forms.Button();
            this.btnAnteriorUsuarios = new System.Windows.Forms.Button();
            this.btnPrimeroUsuarios = new System.Windows.Forms.Button();
            this.grbDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.lblClaveUsuarios = new System.Windows.Forms.Label();
            this.txtClaveUsuarios = new System.Windows.Forms.TextBox();
            this.lblTelefonoUsuarios = new System.Windows.Forms.Label();
            this.txtTelefonoUsuarios = new System.Windows.Forms.TextBox();
            this.lblDireccionUsuarios = new System.Windows.Forms.Label();
            this.txtDireccionUsuarios = new System.Windows.Forms.TextBox();
            this.lblNombreUsuarios = new System.Windows.Forms.Label();
            this.txtNombreUsuarios = new System.Windows.Forms.TextBox();
            this.lblUsuarioUsuarios = new System.Windows.Forms.Label();
            this.txtUsuarioUsuarios = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).BeginInit();
            this.grbEdicionUsuarios.SuspendLayout();
            this.grbNavegacionUsuarios.SuspendLayout();
            this.grbDatosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDatosDocentes
            // 
            this.grdDatosDocentes.AllowUserToAddRows = false;
            this.grdDatosDocentes.AllowUserToDeleteRows = false;
            this.grdDatosDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosDocentes.Location = new System.Drawing.Point(410, 72);
            this.grdDatosDocentes.Name = "grdDatosDocentes";
            this.grdDatosDocentes.ReadOnly = true;
            this.grdDatosDocentes.Size = new System.Drawing.Size(481, 246);
            this.grdDatosDocentes.TabIndex = 29;
            // 
            // lblBuscarUsuarios
            // 
            this.lblBuscarUsuarios.AutoSize = true;
            this.lblBuscarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUsuarios.Location = new System.Drawing.Point(406, 27);
            this.lblBuscarUsuarios.Name = "lblBuscarUsuarios";
            this.lblBuscarUsuarios.Size = new System.Drawing.Size(91, 24);
            this.lblBuscarUsuarios.TabIndex = 27;
            this.lblBuscarUsuarios.Text = "BUSCAR:";
            // 
            // txtBuscarUsuarios
            // 
            this.txtBuscarUsuarios.Location = new System.Drawing.Point(497, 32);
            this.txtBuscarUsuarios.Name = "txtBuscarUsuarios";
            this.txtBuscarUsuarios.Size = new System.Drawing.Size(347, 20);
            this.txtBuscarUsuarios.TabIndex = 28;
            // 
            // grbEdicionUsuarios
            // 
            this.grbEdicionUsuarios.Controls.Add(this.btnEliminarUsuarios);
            this.grbEdicionUsuarios.Controls.Add(this.btnModificarUsuarios);
            this.grbEdicionUsuarios.Controls.Add(this.btnNuevoUsuarios);
            this.grbEdicionUsuarios.Location = new System.Drawing.Point(228, 361);
            this.grbEdicionUsuarios.Name = "grbEdicionUsuarios";
            this.grbEdicionUsuarios.Size = new System.Drawing.Size(327, 68);
            this.grbEdicionUsuarios.TabIndex = 26;
            this.grbEdicionUsuarios.TabStop = false;
            this.grbEdicionUsuarios.Text = "Navegacion";
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(224, 17);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(97, 38);
            this.btnEliminarUsuarios.TabIndex = 6;
            this.btnEliminarUsuarios.Text = "Eliminar";
            this.btnEliminarUsuarios.UseVisualStyleBackColor = true;
            this.btnEliminarUsuarios.Click += new System.EventHandler(this.btnEliminarUsuarios_Click);
            // 
            // btnModificarUsuarios
            // 
            this.btnModificarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuarios.Location = new System.Drawing.Point(105, 19);
            this.btnModificarUsuarios.Name = "btnModificarUsuarios";
            this.btnModificarUsuarios.Size = new System.Drawing.Size(104, 38);
            this.btnModificarUsuarios.TabIndex = 5;
            this.btnModificarUsuarios.Text = "Modificar";
            this.btnModificarUsuarios.UseVisualStyleBackColor = true;
            this.btnModificarUsuarios.Click += new System.EventHandler(this.btnModificarUsuarios_Click);
            // 
            // btnNuevoUsuarios
            // 
            this.btnNuevoUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuarios.Location = new System.Drawing.Point(6, 17);
            this.btnNuevoUsuarios.Name = "btnNuevoUsuarios";
            this.btnNuevoUsuarios.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoUsuarios.TabIndex = 4;
            this.btnNuevoUsuarios.Text = "Nuevo";
            this.btnNuevoUsuarios.UseVisualStyleBackColor = true;
            this.btnNuevoUsuarios.Click += new System.EventHandler(this.btnNuevoUsuarios_Click);
            // 
            // grbNavegacionUsuarios
            // 
            this.grbNavegacionUsuarios.Controls.Add(this.lblRegistrosUsuarios);
            this.grbNavegacionUsuarios.Controls.Add(this.btnUltimoUsuarios);
            this.grbNavegacionUsuarios.Controls.Add(this.btnSiguienteUsuarios);
            this.grbNavegacionUsuarios.Controls.Add(this.btnAnteriorUsuarios);
            this.grbNavegacionUsuarios.Controls.Add(this.btnPrimeroUsuarios);
            this.grbNavegacionUsuarios.Location = new System.Drawing.Point(9, 361);
            this.grbNavegacionUsuarios.Name = "grbNavegacionUsuarios";
            this.grbNavegacionUsuarios.Size = new System.Drawing.Size(213, 58);
            this.grbNavegacionUsuarios.TabIndex = 25;
            this.grbNavegacionUsuarios.TabStop = false;
            this.grbNavegacionUsuarios.Text = "Navegacion";
            // 
            // lblRegistrosUsuarios
            // 
            this.lblRegistrosUsuarios.AutoSize = true;
            this.lblRegistrosUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosUsuarios.Location = new System.Drawing.Point(76, 24);
            this.lblRegistrosUsuarios.Name = "lblRegistrosUsuarios";
            this.lblRegistrosUsuarios.Size = new System.Drawing.Size(63, 24);
            this.lblRegistrosUsuarios.TabIndex = 10;
            this.lblRegistrosUsuarios.Text = "x de n";
            // 
            // btnUltimoUsuarios
            // 
            this.btnUltimoUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoUsuarios.Location = new System.Drawing.Point(172, 14);
            this.btnUltimoUsuarios.Name = "btnUltimoUsuarios";
            this.btnUltimoUsuarios.Size = new System.Drawing.Size(35, 38);
            this.btnUltimoUsuarios.TabIndex = 3;
            this.btnUltimoUsuarios.Text = ">|";
            this.btnUltimoUsuarios.UseVisualStyleBackColor = true;
            this.btnUltimoUsuarios.Click += new System.EventHandler(this.btnUltimoUsuarios_Click);
            // 
            // btnSiguienteUsuarios
            // 
            this.btnSiguienteUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteUsuarios.Location = new System.Drawing.Point(139, 14);
            this.btnSiguienteUsuarios.Name = "btnSiguienteUsuarios";
            this.btnSiguienteUsuarios.Size = new System.Drawing.Size(35, 38);
            this.btnSiguienteUsuarios.TabIndex = 2;
            this.btnSiguienteUsuarios.Text = ">";
            this.btnSiguienteUsuarios.UseVisualStyleBackColor = true;
            this.btnSiguienteUsuarios.Click += new System.EventHandler(this.btnSiguienteUsuarios_Click);
            // 
            // btnAnteriorUsuarios
            // 
            this.btnAnteriorUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorUsuarios.Location = new System.Drawing.Point(40, 18);
            this.btnAnteriorUsuarios.Name = "btnAnteriorUsuarios";
            this.btnAnteriorUsuarios.Size = new System.Drawing.Size(35, 38);
            this.btnAnteriorUsuarios.TabIndex = 1;
            this.btnAnteriorUsuarios.Text = "<";
            this.btnAnteriorUsuarios.UseVisualStyleBackColor = true;
            this.btnAnteriorUsuarios.Click += new System.EventHandler(this.btnAnteriorUsuarios_Click);
            // 
            // btnPrimeroUsuarios
            // 
            this.btnPrimeroUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroUsuarios.Location = new System.Drawing.Point(7, 18);
            this.btnPrimeroUsuarios.Name = "btnPrimeroUsuarios";
            this.btnPrimeroUsuarios.Size = new System.Drawing.Size(35, 38);
            this.btnPrimeroUsuarios.TabIndex = 0;
            this.btnPrimeroUsuarios.Text = "|<";
            this.btnPrimeroUsuarios.UseVisualStyleBackColor = true;
            this.btnPrimeroUsuarios.Click += new System.EventHandler(this.btnPrimeroUsuarios_Click);
            // 
            // grbDatosUsuarios
            // 
            this.grbDatosUsuarios.Controls.Add(this.lblClaveUsuarios);
            this.grbDatosUsuarios.Controls.Add(this.txtClaveUsuarios);
            this.grbDatosUsuarios.Controls.Add(this.lblTelefonoUsuarios);
            this.grbDatosUsuarios.Controls.Add(this.txtTelefonoUsuarios);
            this.grbDatosUsuarios.Controls.Add(this.lblDireccionUsuarios);
            this.grbDatosUsuarios.Controls.Add(this.txtDireccionUsuarios);
            this.grbDatosUsuarios.Controls.Add(this.lblNombreUsuarios);
            this.grbDatosUsuarios.Controls.Add(this.txtNombreUsuarios);
            this.grbDatosUsuarios.Controls.Add(this.lblUsuarioUsuarios);
            this.grbDatosUsuarios.Controls.Add(this.txtUsuarioUsuarios);
            this.grbDatosUsuarios.Enabled = false;
            this.grbDatosUsuarios.Location = new System.Drawing.Point(1, 17);
            this.grbDatosUsuarios.Name = "grbDatosUsuarios";
            this.grbDatosUsuarios.Size = new System.Drawing.Size(399, 320);
            this.grbDatosUsuarios.TabIndex = 24;
            this.grbDatosUsuarios.TabStop = false;
            this.grbDatosUsuarios.Text = "Datos Usuario";
            // 
            // lblClaveUsuarios
            // 
            this.lblClaveUsuarios.AutoSize = true;
            this.lblClaveUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveUsuarios.Location = new System.Drawing.Point(12, 75);
            this.lblClaveUsuarios.Name = "lblClaveUsuarios";
            this.lblClaveUsuarios.Size = new System.Drawing.Size(62, 24);
            this.lblClaveUsuarios.TabIndex = 9;
            this.lblClaveUsuarios.Text = "Clave:";
            // 
            // txtClaveUsuarios
            // 
            this.txtClaveUsuarios.Location = new System.Drawing.Point(131, 82);
            this.txtClaveUsuarios.Name = "txtClaveUsuarios";
            this.txtClaveUsuarios.Size = new System.Drawing.Size(251, 20);
            this.txtClaveUsuarios.TabIndex = 8;
            // 
            // lblTelefonoUsuarios
            // 
            this.lblTelefonoUsuarios.AutoSize = true;
            this.lblTelefonoUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoUsuarios.Location = new System.Drawing.Point(12, 206);
            this.lblTelefonoUsuarios.Name = "lblTelefonoUsuarios";
            this.lblTelefonoUsuarios.Size = new System.Drawing.Size(90, 24);
            this.lblTelefonoUsuarios.TabIndex = 7;
            this.lblTelefonoUsuarios.Text = "Telefono:";
            // 
            // txtTelefonoUsuarios
            // 
            this.txtTelefonoUsuarios.Location = new System.Drawing.Point(131, 213);
            this.txtTelefonoUsuarios.Name = "txtTelefonoUsuarios";
            this.txtTelefonoUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoUsuarios.TabIndex = 6;
            // 
            // lblDireccionUsuarios
            // 
            this.lblDireccionUsuarios.AutoSize = true;
            this.lblDireccionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionUsuarios.Location = new System.Drawing.Point(12, 168);
            this.lblDireccionUsuarios.Name = "lblDireccionUsuarios";
            this.lblDireccionUsuarios.Size = new System.Drawing.Size(95, 24);
            this.lblDireccionUsuarios.TabIndex = 5;
            this.lblDireccionUsuarios.Text = "Direccion:";
            // 
            // txtDireccionUsuarios
            // 
            this.txtDireccionUsuarios.Location = new System.Drawing.Point(131, 175);
            this.txtDireccionUsuarios.Name = "txtDireccionUsuarios";
            this.txtDireccionUsuarios.Size = new System.Drawing.Size(138, 20);
            this.txtDireccionUsuarios.TabIndex = 4;
            // 
            // lblNombreUsuarios
            // 
            this.lblNombreUsuarios.AutoSize = true;
            this.lblNombreUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuarios.Location = new System.Drawing.Point(12, 128);
            this.lblNombreUsuarios.Name = "lblNombreUsuarios";
            this.lblNombreUsuarios.Size = new System.Drawing.Size(84, 24);
            this.lblNombreUsuarios.TabIndex = 3;
            this.lblNombreUsuarios.Text = "Nombre:";
            // 
            // txtNombreUsuarios
            // 
            this.txtNombreUsuarios.Location = new System.Drawing.Point(131, 135);
            this.txtNombreUsuarios.Name = "txtNombreUsuarios";
            this.txtNombreUsuarios.Size = new System.Drawing.Size(251, 20);
            this.txtNombreUsuarios.TabIndex = 2;
            // 
            // lblUsuarioUsuarios
            // 
            this.lblUsuarioUsuarios.AutoSize = true;
            this.lblUsuarioUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioUsuarios.Location = new System.Drawing.Point(12, 34);
            this.lblUsuarioUsuarios.Name = "lblUsuarioUsuarios";
            this.lblUsuarioUsuarios.Size = new System.Drawing.Size(79, 24);
            this.lblUsuarioUsuarios.TabIndex = 1;
            this.lblUsuarioUsuarios.Text = "Usuario:";
            // 
            // txtUsuarioUsuarios
            // 
            this.txtUsuarioUsuarios.Location = new System.Drawing.Point(131, 41);
            this.txtUsuarioUsuarios.Name = "txtUsuarioUsuarios";
            this.txtUsuarioUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioUsuarios.TabIndex = 0;
            // 
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.grdDatosDocentes);
            this.Controls.Add(this.lblBuscarUsuarios);
            this.Controls.Add(this.txtBuscarUsuarios);
            this.Controls.Add(this.grbEdicionUsuarios);
            this.Controls.Add(this.grbNavegacionUsuarios);
            this.Controls.Add(this.grbDatosUsuarios);
            this.Name = "frm_usuario";
            this.Text = "frm_usuario";
            this.Load += new System.EventHandler(this.frm_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).EndInit();
            this.grbEdicionUsuarios.ResumeLayout(false);
            this.grbNavegacionUsuarios.ResumeLayout(false);
            this.grbNavegacionUsuarios.PerformLayout();
            this.grbDatosUsuarios.ResumeLayout(false);
            this.grbDatosUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDatosDocentes;
        private System.Windows.Forms.Label lblBuscarUsuarios;
        private System.Windows.Forms.TextBox txtBuscarUsuarios;
        private System.Windows.Forms.GroupBox grbEdicionUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.Button btnModificarUsuarios;
        private System.Windows.Forms.Button btnNuevoUsuarios;
        private System.Windows.Forms.GroupBox grbNavegacionUsuarios;
        private System.Windows.Forms.Label lblRegistrosUsuarios;
        private System.Windows.Forms.Button btnUltimoUsuarios;
        private System.Windows.Forms.Button btnSiguienteUsuarios;
        private System.Windows.Forms.Button btnAnteriorUsuarios;
        private System.Windows.Forms.Button btnPrimeroUsuarios;
        private System.Windows.Forms.GroupBox grbDatosUsuarios;
        private System.Windows.Forms.Label lblClaveUsuarios;
        private System.Windows.Forms.TextBox txtClaveUsuarios;
        private System.Windows.Forms.Label lblTelefonoUsuarios;
        private System.Windows.Forms.TextBox txtTelefonoUsuarios;
        private System.Windows.Forms.Label lblDireccionUsuarios;
        private System.Windows.Forms.TextBox txtDireccionUsuarios;
        private System.Windows.Forms.Label lblNombreUsuarios;
        private System.Windows.Forms.TextBox txtNombreUsuarios;
        private System.Windows.Forms.Label lblUsuarioUsuarios;
        private System.Windows.Forms.TextBox txtUsuarioUsuarios;
    }
}