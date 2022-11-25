namespace WoofGroomer
{
    partial class ListaHistorial
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaHistorial));
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHistorial = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbTicket = new System.Windows.Forms.ComboBox();
            this.btnAbrirVisita = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblFecha.Location = new System.Drawing.Point(12, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 15);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "14/01/2021";
            // 
            // lblImporte
            // 
            this.lblImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImporte.BackColor = System.Drawing.Color.Transparent;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblImporte.Location = new System.Drawing.Point(782, 12);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(60, 15);
            this.lblImporte.TabIndex = 2;
            this.lblImporte.Text = "36,00€";
            this.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ticket";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Historial : ";
            // 
            // txtHistorial
            // 
            this.txtHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistorial.AutoScroll = true;
            this.txtHistorial.BorderRadius = 6;
            this.txtHistorial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHistorial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHistorial.DefaultText = "";
            this.txtHistorial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHistorial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHistorial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHistorial.DisabledState.Parent = this.txtHistorial;
            this.txtHistorial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHistorial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHistorial.FocusedState.Parent = this.txtHistorial;
            this.txtHistorial.ForeColor = System.Drawing.Color.DarkGray;
            this.txtHistorial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHistorial.HoverState.Parent = this.txtHistorial;
            this.txtHistorial.Location = new System.Drawing.Point(15, 67);
            this.txtHistorial.Multiline = true;
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.PasswordChar = '\0';
            this.txtHistorial.PlaceholderText = "";
            this.txtHistorial.SelectedText = "";
            this.txtHistorial.ShadowDecoration.Parent = this.txtHistorial;
            this.txtHistorial.Size = new System.Drawing.Size(826, 109);
            this.txtHistorial.TabIndex = 188;
            this.txtHistorial.TextChanged += new System.EventHandler(this.txtHistorial_TextChanged);
            this.txtHistorial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHistorial_KeyUp);
            // 
            // cmbTicket
            // 
            this.cmbTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTicket.ForeColor = System.Drawing.Color.Gray;
            this.cmbTicket.FormattingEnabled = true;
            this.cmbTicket.Location = new System.Drawing.Point(15, 197);
            this.cmbTicket.Name = "cmbTicket";
            this.cmbTicket.Size = new System.Drawing.Size(826, 21);
            this.cmbTicket.TabIndex = 255;
            // 
            // btnAbrirVisita
            // 
            this.btnAbrirVisita.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAbrirVisita.Animated = true;
            this.btnAbrirVisita.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirVisita.BorderRadius = 5;
            this.btnAbrirVisita.CheckedState.Parent = this.btnAbrirVisita;
            this.btnAbrirVisita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirVisita.CustomImages.Parent = this.btnAbrirVisita;
            this.btnAbrirVisita.FillColor = System.Drawing.Color.Silver;
            this.btnAbrirVisita.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbrirVisita.ForeColor = System.Drawing.Color.White;
            this.btnAbrirVisita.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAbrirVisita.HoverState.Parent = this.btnAbrirVisita;
            this.btnAbrirVisita.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirVisita.Image")));
            this.btnAbrirVisita.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbrirVisita.ImageSize = new System.Drawing.Size(16, 16);
            this.btnAbrirVisita.Location = new System.Drawing.Point(683, 10);
            this.btnAbrirVisita.Name = "btnAbrirVisita";
            this.btnAbrirVisita.ShadowDecoration.Parent = this.btnAbrirVisita;
            this.btnAbrirVisita.Size = new System.Drawing.Size(93, 21);
            this.btnAbrirVisita.TabIndex = 256;
            this.btnAbrirVisita.Text = "Ver Visita";
            this.btnAbrirVisita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.Controls.Add(this.lblFecha);
            this.guna2GroupBox1.Controls.Add(this.cmbTicket);
            this.guna2GroupBox1.Controls.Add(this.btnAbrirVisita);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.lblImporte);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.txtHistorial);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(33, 15);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Depth = 15;
            this.guna2GroupBox1.ShadowDecoration.Enabled = true;
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(857, 232);
            this.guna2GroupBox1.TabIndex = 257;
            // 
            // ListaHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "ListaHistorial";
            this.Size = new System.Drawing.Size(935, 274);
            this.Load += new System.EventHandler(this.ListaHistorial_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtHistorial;
        private System.Windows.Forms.ComboBox cmbTicket;
        private Guna.UI2.WinForms.Guna2Button btnAbrirVisita;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}
