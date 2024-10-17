namespace academica
{
    partial class login
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
            this.lblContraseñaLogin = new System.Windows.Forms.Label();
            this.txtContraseñaLogin = new System.Windows.Forms.TextBox();
            this.lblNombreLogin = new System.Windows.Forms.Label();
            this.txtNombreLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContraseñaLogin
            // 
            this.lblContraseñaLogin.AutoSize = true;
            this.lblContraseñaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaLogin.Location = new System.Drawing.Point(130, 91);
            this.lblContraseñaLogin.Name = "lblContraseñaLogin";
            this.lblContraseñaLogin.Size = new System.Drawing.Size(111, 24);
            this.lblContraseñaLogin.TabIndex = 9;
            this.lblContraseñaLogin.Text = "Contraseña:";
            // 
            // txtContraseñaLogin
            // 
            this.txtContraseñaLogin.Location = new System.Drawing.Point(247, 91);
            this.txtContraseñaLogin.Name = "txtContraseñaLogin";
            this.txtContraseñaLogin.Size = new System.Drawing.Size(175, 20);
            this.txtContraseñaLogin.TabIndex = 8;
            // 
            // lblNombreLogin
            // 
            this.lblNombreLogin.AutoSize = true;
            this.lblNombreLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLogin.Location = new System.Drawing.Point(130, 47);
            this.lblNombreLogin.Name = "lblNombreLogin";
            this.lblNombreLogin.Size = new System.Drawing.Size(84, 24);
            this.lblNombreLogin.TabIndex = 7;
            this.lblNombreLogin.Text = "Nombre:";
            // 
            // txtNombreLogin
            // 
            this.txtNombreLogin.Location = new System.Drawing.Point(247, 51);
            this.txtNombreLogin.Name = "txtNombreLogin";
            this.txtNombreLogin.Size = new System.Drawing.Size(251, 20);
            this.txtNombreLogin.TabIndex = 6;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 208);
            this.Controls.Add(this.lblContraseñaLogin);
            this.Controls.Add(this.txtContraseñaLogin);
            this.Controls.Add(this.lblNombreLogin);
            this.Controls.Add(this.txtNombreLogin);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContraseñaLogin;
        private System.Windows.Forms.TextBox txtContraseñaLogin;
        private System.Windows.Forms.Label lblNombreLogin;
        private System.Windows.Forms.TextBox txtNombreLogin;
    }
}