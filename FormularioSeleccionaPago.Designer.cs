namespace WoofGroomer
{
    partial class FormularioSeleccionaPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioSeleccionaPago));
            this.label22 = new System.Windows.Forms.Label();
            this.cmbTiposPago = new System.Windows.Forms.ComboBox();
            this.txtCobrar = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCambio = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPagado = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkGray;
            this.label22.Location = new System.Drawing.Point(23, 119);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(175, 17);
            this.label22.TabIndex = 257;
            this.label22.Text = "Seleccione el tipo de pago";
            // 
            // cmbTiposPago
            // 
            this.cmbTiposPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTiposPago.ForeColor = System.Drawing.Color.Gray;
            this.cmbTiposPago.FormattingEnabled = true;
            this.cmbTiposPago.Location = new System.Drawing.Point(26, 143);
            this.cmbTiposPago.Name = "cmbTiposPago";
            this.cmbTiposPago.Size = new System.Drawing.Size(255, 24);
            this.cmbTiposPago.TabIndex = 256;
            // 
            // txtCobrar
            // 
            this.txtCobrar.BorderRadius = 6;
            this.txtCobrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCobrar.DefaultText = "";
            this.txtCobrar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCobrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCobrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCobrar.DisabledState.Parent = this.txtCobrar;
            this.txtCobrar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCobrar.Enabled = false;
            this.txtCobrar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCobrar.FocusedState.Parent = this.txtCobrar;
            this.txtCobrar.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.txtCobrar.ForeColor = System.Drawing.Color.Silver;
            this.txtCobrar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCobrar.HoverState.Parent = this.txtCobrar;
            this.txtCobrar.Location = new System.Drawing.Point(26, 19);
            this.txtCobrar.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtCobrar.Name = "txtCobrar";
            this.txtCobrar.PasswordChar = '\0';
            this.txtCobrar.PlaceholderText = "";
            this.txtCobrar.SelectedText = "";
            this.txtCobrar.ShadowDecoration.Parent = this.txtCobrar;
            this.txtCobrar.Size = new System.Drawing.Size(255, 91);
            this.txtCobrar.TabIndex = 259;
            this.txtCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCambio
            // 
            this.txtCambio.BorderRadius = 6;
            this.txtCambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCambio.DefaultText = "";
            this.txtCambio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCambio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCambio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCambio.DisabledState.Parent = this.txtCambio;
            this.txtCambio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCambio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCambio.FocusedState.Parent = this.txtCambio;
            this.txtCambio.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.txtCambio.ForeColor = System.Drawing.Color.Silver;
            this.txtCambio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCambio.HoverState.Parent = this.txtCambio;
            this.txtCambio.Location = new System.Drawing.Point(306, 128);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.PasswordChar = '\0';
            this.txtCambio.PlaceholderText = "";
            this.txtCambio.SelectedText = "";
            this.txtCambio.ShadowDecoration.Parent = this.txtCambio;
            this.txtCambio.Size = new System.Drawing.Size(255, 90);
            this.txtCambio.TabIndex = 262;
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCambio.TextChanged += new System.EventHandler(this.txtCambio_TextChanged);
            // 
            // txtPagado
            // 
            this.txtPagado.BorderRadius = 6;
            this.txtPagado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPagado.DefaultText = "";
            this.txtPagado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPagado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPagado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPagado.DisabledState.Parent = this.txtPagado;
            this.txtPagado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPagado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPagado.FocusedState.Parent = this.txtPagado;
            this.txtPagado.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.txtPagado.ForeColor = System.Drawing.Color.Silver;
            this.txtPagado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPagado.HoverState.Parent = this.txtPagado;
            this.txtPagado.Location = new System.Drawing.Point(306, 19);
            this.txtPagado.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtPagado.Name = "txtPagado";
            this.txtPagado.PasswordChar = '\0';
            this.txtPagado.PlaceholderText = "";
            this.txtPagado.SelectedText = "";
            this.txtPagado.ShadowDecoration.Parent = this.txtPagado;
            this.txtPagado.Size = new System.Drawing.Size(255, 91);
            this.txtPagado.TabIndex = 0;
            this.txtPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagado.TextChanged += new System.EventHandler(this.txtPagado_TextChanged);
            this.txtPagado.Click += new System.EventHandler(this.txtPagado_Click);
            this.txtPagado.Enter += new System.EventHandler(this.txtPagado_Enter);
            this.txtPagado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagado_KeyPress);
            this.txtPagado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPagado_KeyUp);
            this.txtPagado.Leave += new System.EventHandler(this.txtPagado_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(185, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 264;
            this.label2.Text = "Importe a cobrar €";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(502, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 265;
            this.label3.Text = "Cobrado €";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(491, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 266;
            this.label4.Text = "A devolver €";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Animated = true;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAceptar.BorderRadius = 5;
            this.btnAceptar.CheckedState.Parent = this.btnAceptar;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.CustomImages.Parent = this.btnAceptar;
            this.btnAceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.HoverState.Parent = this.btnAceptar;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageSize = new System.Drawing.Size(16, 16);
            this.btnAceptar.Location = new System.Drawing.Point(26, 183);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.ShadowDecoration.Parent = this.btnAceptar;
            this.btnAceptar.Size = new System.Drawing.Size(255, 33);
            this.btnAceptar.TabIndex = 170;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // FormularioSeleccionaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(578, 258);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPagado);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtCobrar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cmbTiposPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioSeleccionaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione Tipo de Pago";
            this.Load += new System.EventHandler(this.FormularioSeleccionaPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.ComboBox cmbTiposPago;
        public Guna.UI2.WinForms.Guna2TextBox txtCobrar;
        public Guna.UI2.WinForms.Guna2TextBox txtCambio;
        public Guna.UI2.WinForms.Guna2TextBox txtPagado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
    }
}