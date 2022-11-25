namespace WoofGroomer
{
    partial class FormularioPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPassword));
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNuevoCliente = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.DarkGray;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconLeft")));
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtPassword.Location = new System.Drawing.Point(27, 59);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(304, 37);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoCliente.Animated = true;
            this.btnNuevoCliente.BorderRadius = 5;
            this.btnNuevoCliente.CheckedState.Parent = this.btnNuevoCliente;
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCliente.CustomImages.Parent = this.btnNuevoCliente;
            this.btnNuevoCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevoCliente.HoverState.Parent = this.btnNuevoCliente;
            this.btnNuevoCliente.ImageSize = new System.Drawing.Size(16, 16);
            this.btnNuevoCliente.Location = new System.Drawing.Point(27, 114);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.ShadowDecoration.Parent = this.btnNuevoCliente;
            this.btnNuevoCliente.Size = new System.Drawing.Size(304, 36);
            this.btnNuevoCliente.TabIndex = 70;
            this.btnNuevoCliente.Text = "VALIDAR";
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEmpleado.Location = new System.Drawing.Point(27, 20);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(304, 35);
            this.lblEmpleado.TabIndex = 187;
            this.lblEmpleado.Text = "Empleado";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormularioPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 191);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PASSWORD";
            this.Load += new System.EventHandler(this.FormularioPassword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnNuevoCliente;
        private System.Windows.Forms.Label lblEmpleado;
    }
}