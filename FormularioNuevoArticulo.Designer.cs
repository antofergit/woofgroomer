namespace WoofGroomer
{
    partial class FormularioNuevoArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioNuevoArticulo));
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImporteIVA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPorcentajeIVA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoIVA = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoArticulo = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotal.ForeColor = System.Drawing.Color.Gray;
            this.txtTotal.Location = new System.Drawing.Point(136, 274);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(86, 23);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.Click += new System.EventHandler(this.txtTotal_Click);
            this.txtTotal.Enter += new System.EventHandler(this.txtTotal_Enter);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            this.txtTotal.Leave += new System.EventHandler(this.txtTotal_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(133, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 273;
            this.label8.Text = "P.V.P.";
            // 
            // txtImporteIVA
            // 
            this.txtImporteIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImporteIVA.Enabled = false;
            this.txtImporteIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtImporteIVA.ForeColor = System.Drawing.Color.Gray;
            this.txtImporteIVA.Location = new System.Drawing.Point(357, 212);
            this.txtImporteIVA.Name = "txtImporteIVA";
            this.txtImporteIVA.Size = new System.Drawing.Size(86, 23);
            this.txtImporteIVA.TabIndex = 272;
            this.txtImporteIVA.Text = "0,00";
            this.txtImporteIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(354, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 271;
            this.label7.Text = "Importe I.V.A. €";
            // 
            // txtPorcentajeIVA
            // 
            this.txtPorcentajeIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcentajeIVA.Enabled = false;
            this.txtPorcentajeIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPorcentajeIVA.ForeColor = System.Drawing.Color.Gray;
            this.txtPorcentajeIVA.Location = new System.Drawing.Point(246, 212);
            this.txtPorcentajeIVA.Name = "txtPorcentajeIVA";
            this.txtPorcentajeIVA.Size = new System.Drawing.Size(86, 23);
            this.txtPorcentajeIVA.TabIndex = 270;
            this.txtPorcentajeIVA.Text = "0,00";
            this.txtPorcentajeIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(243, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 269;
            this.label6.Text = "% I.V.A.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(26, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 268;
            this.label5.Text = "Tipo de I.V.A.";
            // 
            // cmbTipoIVA
            // 
            this.cmbTipoIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIVA.ForeColor = System.Drawing.Color.Gray;
            this.cmbTipoIVA.FormattingEnabled = true;
            this.cmbTipoIVA.Location = new System.Drawing.Point(29, 214);
            this.cmbTipoIVA.Name = "cmbTipoIVA";
            this.cmbTipoIVA.Size = new System.Drawing.Size(193, 21);
            this.cmbTipoIVA.TabIndex = 2;
            this.cmbTipoIVA.SelectedIndexChanged += new System.EventHandler(this.cmbTipoIVA_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(284, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 266;
            this.label4.Text = "Tipo";
            // 
            // cmbTipoArticulo
            // 
            this.cmbTipoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoArticulo.ForeColor = System.Drawing.Color.Gray;
            this.cmbTipoArticulo.FormattingEnabled = true;
            this.cmbTipoArticulo.Items.AddRange(new object[] {
            "PRODUCTO",
            "SERVICIO"});
            this.cmbTipoArticulo.Location = new System.Drawing.Point(287, 51);
            this.cmbTipoArticulo.Name = "cmbTipoArticulo";
            this.cmbTipoArticulo.Size = new System.Drawing.Size(157, 21);
            this.cmbTipoArticulo.TabIndex = 265;
            // 
            // txtStock
            // 
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStock.ForeColor = System.Drawing.Color.Gray;
            this.txtStock.Location = new System.Drawing.Point(29, 155);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(193, 23);
            this.txtStock.TabIndex = 1;
            this.txtStock.Text = "0,00";
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStock.Click += new System.EventHandler(this.txtStock_Click);
            this.txtStock.Enter += new System.EventHandler(this.txtStock_Enter);
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            this.txtStock.Leave += new System.EventHandler(this.txtStock_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(26, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 263;
            this.label3.Text = "Stock";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.txtDescripcion.Location = new System.Drawing.Point(29, 100);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(415, 23);
            this.txtDescripcion.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 261;
            this.label2.Text = "Descripción";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.ForeColor = System.Drawing.Color.Gray;
            this.txtID.Location = new System.Drawing.Point(29, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 23);
            this.txtID.TabIndex = 260;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 259;
            this.label1.Text = "ID del Producto / Servicio";
            // 
            // txtNeto
            // 
            this.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNeto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNeto.ForeColor = System.Drawing.Color.Gray;
            this.txtNeto.Location = new System.Drawing.Point(29, 274);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(86, 23);
            this.txtNeto.TabIndex = 3;
            this.txtNeto.Text = "0,00";
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNeto.Click += new System.EventHandler(this.txtNeto_Click);
            this.txtNeto.Enter += new System.EventHandler(this.txtNeto_Enter);
            this.txtNeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNeto_KeyPress);
            this.txtNeto.Leave += new System.EventHandler(this.txtNeto_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(26, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 257;
            this.label15.Text = "Neto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 50);
            this.panel1.TabIndex = 275;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Animated = true;
            this.btnAceptar.BorderRadius = 5;
            this.btnAceptar.CheckedState.Parent = this.btnAceptar;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.CustomImages.Parent = this.btnAceptar;
            this.btnAceptar.FillColor = System.Drawing.Color.Silver;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.HoverState.Parent = this.btnAceptar;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageSize = new System.Drawing.Size(16, 16);
            this.btnAceptar.Location = new System.Drawing.Point(357, 10);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.ShadowDecoration.Parent = this.btnAceptar;
            this.btnAceptar.Size = new System.Drawing.Size(88, 28);
            this.btnAceptar.TabIndex = 170;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Animated = true;
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FillColor = System.Drawing.Color.Silver;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageSize = new System.Drawing.Size(16, 16);
            this.btnCancelar.Location = new System.Drawing.Point(252, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(88, 28);
            this.btnCancelar.TabIndex = 171;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormularioNuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtImporteIVA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPorcentajeIVA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoIVA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipoArticulo);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioNuevoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Producto / Servicio";
            this.Load += new System.EventHandler(this.FormularioNuevoArticulo_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImporteIVA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPorcentajeIVA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoIVA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoArticulo;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}