namespace WoofGroomer
{
    partial class FormularioBuscarTipoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioBuscarTipoPago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnBorrarBusqueda = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataTipoPago = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSelecciona = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTipoPago)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnBorrarBusqueda);
            this.panel8.Controls.Add(this.txtBuscar);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(800, 61);
            this.panel8.TabIndex = 27;
            // 
            // btnBorrarBusqueda
            // 
            this.btnBorrarBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarBusqueda.Animated = true;
            this.btnBorrarBusqueda.BackColor = System.Drawing.Color.White;
            this.btnBorrarBusqueda.CheckedState.Parent = this.btnBorrarBusqueda;
            this.btnBorrarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarBusqueda.CustomImages.Parent = this.btnBorrarBusqueda;
            this.btnBorrarBusqueda.FillColor = System.Drawing.Color.Transparent;
            this.btnBorrarBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBorrarBusqueda.ForeColor = System.Drawing.Color.Transparent;
            this.btnBorrarBusqueda.HoverState.Parent = this.btnBorrarBusqueda;
            this.btnBorrarBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarBusqueda.Image")));
            this.btnBorrarBusqueda.ImageSize = new System.Drawing.Size(16, 16);
            this.btnBorrarBusqueda.Location = new System.Drawing.Point(744, 21);
            this.btnBorrarBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarBusqueda.Name = "btnBorrarBusqueda";
            this.btnBorrarBusqueda.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBorrarBusqueda.ShadowDecoration.Parent = this.btnBorrarBusqueda;
            this.btnBorrarBusqueda.Size = new System.Drawing.Size(21, 20);
            this.btnBorrarBusqueda.TabIndex = 60;
            this.btnBorrarBusqueda.Click += new System.EventHandler(this.btnBorrarBusqueda_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BorderRadius = 15;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.Parent = this.txtBuscar;
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.Enabled = false;
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtBuscar.FocusedState.Parent = this.txtBuscar;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtBuscar.HoverState.Parent = this.txtBuscar;
            this.txtBuscar.Location = new System.Drawing.Point(20, 15);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "Buscar Tipo de pago";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.ShadowDecoration.Parent = this.txtBuscar;
            this.txtBuscar.Size = new System.Drawing.Size(760, 33);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // dataTipoPago
            // 
            this.dataTipoPago.AllowUserToAddRows = false;
            this.dataTipoPago.AllowUserToDeleteRows = false;
            this.dataTipoPago.AllowUserToResizeColumns = false;
            this.dataTipoPago.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataTipoPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTipoPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTipoPago.BackgroundColor = System.Drawing.Color.White;
            this.dataTipoPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataTipoPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTipoPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTipoPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTipoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTipoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTipoPago.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTipoPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTipoPago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTipoPago.EnableHeadersVisualStyles = false;
            this.dataTipoPago.Location = new System.Drawing.Point(10, 61);
            this.dataTipoPago.MultiSelect = false;
            this.dataTipoPago.Name = "dataTipoPago";
            this.dataTipoPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTipoPago.RowHeadersVisible = false;
            this.dataTipoPago.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Noto Sans", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataTipoPago.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTipoPago.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTipoPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTipoPago.Size = new System.Drawing.Size(780, 335);
            this.dataTipoPago.TabIndex = 69;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSelecciona);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 54);
            this.panel3.TabIndex = 68;
            // 
            // btnSelecciona
            // 
            this.btnSelecciona.Animated = true;
            this.btnSelecciona.BorderRadius = 5;
            this.btnSelecciona.CheckedState.Parent = this.btnSelecciona;
            this.btnSelecciona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecciona.CustomImages.Parent = this.btnSelecciona;
            this.btnSelecciona.FillColor = System.Drawing.Color.Silver;
            this.btnSelecciona.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelecciona.ForeColor = System.Drawing.Color.White;
            this.btnSelecciona.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnSelecciona.HoverState.ForeColor = System.Drawing.Color.Gold;
            this.btnSelecciona.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecciona.HoverState.Image")));
            this.btnSelecciona.HoverState.Parent = this.btnSelecciona;
            this.btnSelecciona.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecciona.Image")));
            this.btnSelecciona.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSelecciona.Location = new System.Drawing.Point(604, 9);
            this.btnSelecciona.Name = "btnSelecciona";
            this.btnSelecciona.ShadowDecoration.Parent = this.btnSelecciona;
            this.btnSelecciona.Size = new System.Drawing.Size(166, 34);
            this.btnSelecciona.TabIndex = 5;
            this.btnSelecciona.Text = "Seleccionar Mascota";
            this.btnSelecciona.Click += new System.EventHandler(this.btnSelecciona_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(790, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 389);
            this.panel2.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 389);
            this.panel1.TabIndex = 66;
            // 
            // FormularioBuscarTipoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataTipoPago);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioBuscarTipoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Tipo de pago";
            this.Load += new System.EventHandler(this.FormularioBuscarTipoPago_Load);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTipoPago)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2CircleButton btnBorrarBusqueda;
        public Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        public System.Windows.Forms.DataGridView dataTipoPago;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnSelecciona;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}