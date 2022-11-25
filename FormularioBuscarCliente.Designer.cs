namespace WoofGroomer
{
    partial class FormularioBuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioBuscarCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnBorrarBusqueda = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSelecciona = new Guna.UI2.WinForms.Guna2Button();
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
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
            this.panel8.TabIndex = 26;
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
            this.txtBuscar.PlaceholderText = "Buscar Cliente...";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.ShadowDecoration.Parent = this.txtBuscar;
            this.txtBuscar.Size = new System.Drawing.Size(760, 33);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextOffset = new System.Drawing.Point(10, 0);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 389);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(790, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 389);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSelecciona);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 54);
            this.panel3.TabIndex = 31;
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
            this.btnSelecciona.Location = new System.Drawing.Point(596, 10);
            this.btnSelecciona.Name = "btnSelecciona";
            this.btnSelecciona.ShadowDecoration.Parent = this.btnSelecciona;
            this.btnSelecciona.Size = new System.Drawing.Size(166, 34);
            this.btnSelecciona.TabIndex = 5;
            this.btnSelecciona.Text = "Seleccionar Mascota";
            this.btnSelecciona.Click += new System.EventHandler(this.btnSelecciona_Click);
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.AllowUserToResizeColumns = false;
            this.dataClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Noto Sans", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataClientes.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataClientes.EnableHeadersVisualStyles = false;
            this.dataClientes.Location = new System.Drawing.Point(10, 61);
            this.dataClientes.MultiSelect = false;
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataClientes.RowHeadersVisible = false;
            this.dataClientes.RowHeadersWidth = 20;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Noto Sans", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataClientes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClientes.Size = new System.Drawing.Size(780, 335);
            this.dataClientes.TabIndex = 65;
            // 
            // FormularioBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.Load += new System.EventHandler(this.FormularioBuscarCliente_Load);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2CircleButton btnBorrarBusqueda;
        public Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnSelecciona;
        public System.Windows.Forms.DataGridView dataClientes;
    }
}