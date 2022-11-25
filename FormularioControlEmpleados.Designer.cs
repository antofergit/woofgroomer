namespace WoofGroomer
{
    partial class FormularioControlEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioControlEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbEmpleado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnPique = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataHoras = new System.Windows.Forms.DataGridView();
            this.cmbMes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbAnio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnListado = new Guna.UI2.WinForms.Guna2Button();
            this.lblHoras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEmpleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEmpleado.FocusedState.Parent = this.cmbEmpleado;
            this.cmbEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.HoverState.Parent = this.cmbEmpleado;
            this.cmbEmpleado.ItemHeight = 30;
            this.cmbEmpleado.ItemsAppearance.Parent = this.cmbEmpleado;
            this.cmbEmpleado.Location = new System.Drawing.Point(37, 62);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.ShadowDecoration.Parent = this.cmbEmpleado;
            this.cmbEmpleado.Size = new System.Drawing.Size(214, 36);
            this.cmbEmpleado.TabIndex = 0;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            this.cmbEmpleado.SelectionChangeCommitted += new System.EventHandler(this.cmbEmpleado_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(33, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 186;
            this.label2.Text = "Empleado";
            // 
            // lblDia
            // 
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDia.Location = new System.Drawing.Point(34, 380);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(217, 51);
            this.lblDia.TabIndex = 187;
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnPique);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(37, 157);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(214, 220);
            this.guna2ShadowPanel1.TabIndex = 188;
            // 
            // btnPique
            // 
            this.btnPique.CheckedState.Parent = this.btnPique;
            this.btnPique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPique.CustomImages.Parent = this.btnPique;
            this.btnPique.Enabled = false;
            this.btnPique.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPique.ForeColor = System.Drawing.Color.White;
            this.btnPique.HoverState.Parent = this.btnPique;
            this.btnPique.Image = ((System.Drawing.Image)(resources.GetObject("btnPique.Image")));
            this.btnPique.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnPique.ImageSize = new System.Drawing.Size(96, 96);
            this.btnPique.Location = new System.Drawing.Point(6, 6);
            this.btnPique.Name = "btnPique";
            this.btnPique.ShadowDecoration.Parent = this.btnPique;
            this.btnPique.Size = new System.Drawing.Size(203, 209);
            this.btnPique.TabIndex = 64;
            this.btnPique.Text = "Marcar Entrada";
            this.btnPique.TextOffset = new System.Drawing.Point(0, 10);
            this.btnPique.Click += new System.EventHandler(this.btnPique_Click);
            // 
            // lblMes
            // 
            this.lblMes.BackColor = System.Drawing.Color.Transparent;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.Silver;
            this.lblMes.Location = new System.Drawing.Point(36, 431);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(215, 46);
            this.lblMes.TabIndex = 189;
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DarkGray;
            this.lblHora.Location = new System.Drawing.Point(34, 113);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(217, 41);
            this.lblHora.TabIndex = 190;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(292, 39);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 438);
            this.guna2VSeparator1.TabIndex = 192;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataHoras
            // 
            this.dataHoras.AllowUserToAddRows = false;
            this.dataHoras.AllowUserToDeleteRows = false;
            this.dataHoras.AllowUserToResizeColumns = false;
            this.dataHoras.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Noto Sans", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataHoras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataHoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHoras.BackgroundColor = System.Drawing.Color.White;
            this.dataHoras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataHoras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataHoras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHoras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataHoras.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataHoras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataHoras.EnableHeadersVisualStyles = false;
            this.dataHoras.Location = new System.Drawing.Point(317, 113);
            this.dataHoras.MultiSelect = false;
            this.dataHoras.Name = "dataHoras";
            this.dataHoras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataHoras.RowHeadersVisible = false;
            this.dataHoras.RowHeadersWidth = 20;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Noto Sans", 8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataHoras.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataHoras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataHoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHoras.Size = new System.Drawing.Size(467, 364);
            this.dataHoras.TabIndex = 193;
            // 
            // cmbMes
            // 
            this.cmbMes.BackColor = System.Drawing.Color.Transparent;
            this.cmbMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Enabled = false;
            this.cmbMes.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMes.FocusedState.Parent = this.cmbMes;
            this.cmbMes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.HoverState.Parent = this.cmbMes;
            this.cmbMes.ItemHeight = 30;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.ItemsAppearance.Parent = this.cmbMes;
            this.cmbMes.Location = new System.Drawing.Point(511, 62);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.ShadowDecoration.Parent = this.cmbMes;
            this.cmbMes.Size = new System.Drawing.Size(124, 36);
            this.cmbMes.TabIndex = 195;
            this.cmbMes.SelectionChangeCommitted += new System.EventHandler(this.cmbMes_SelectionChangeCommitted);
            // 
            // cmbAnio
            // 
            this.cmbAnio.BackColor = System.Drawing.Color.Transparent;
            this.cmbAnio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAnio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio.Enabled = false;
            this.cmbAnio.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAnio.FocusedState.Parent = this.cmbAnio;
            this.cmbAnio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.HoverState.Parent = this.cmbAnio;
            this.cmbAnio.ItemHeight = 30;
            this.cmbAnio.ItemsAppearance.Parent = this.cmbAnio;
            this.cmbAnio.Location = new System.Drawing.Point(641, 62);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.ShadowDecoration.Parent = this.cmbAnio;
            this.cmbAnio.Size = new System.Drawing.Size(143, 36);
            this.cmbAnio.TabIndex = 196;
            this.cmbAnio.SelectionChangeCommitted += new System.EventHandler(this.cmbAnio_SelectionChangeCommitted);
            // 
            // btnListado
            // 
            this.btnListado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListado.Animated = true;
            this.btnListado.BorderRadius = 5;
            this.btnListado.CheckedState.Parent = this.btnListado;
            this.btnListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListado.CustomImages.Parent = this.btnListado;
            this.btnListado.Enabled = false;
            this.btnListado.FillColor = System.Drawing.Color.Silver;
            this.btnListado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListado.ForeColor = System.Drawing.Color.White;
            this.btnListado.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.btnListado.HoverState.Parent = this.btnListado;
            this.btnListado.Image = ((System.Drawing.Image)(resources.GetObject("btnListado.Image")));
            this.btnListado.ImageSize = new System.Drawing.Size(16, 16);
            this.btnListado.Location = new System.Drawing.Point(317, 62);
            this.btnListado.Name = "btnListado";
            this.btnListado.ShadowDecoration.Parent = this.btnListado;
            this.btnListado.Size = new System.Drawing.Size(130, 36);
            this.btnListado.TabIndex = 194;
            this.btnListado.Text = "ver listado";
            this.btnListado.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblHoras.Location = new System.Drawing.Point(720, 485);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(64, 17);
            this.lblHoras.TabIndex = 261;
            this.lblHoras.Text = "0";
            this.lblHoras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(624, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 260;
            this.label1.Text = "Total Horas :";
            // 
            // FormularioControlEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 516);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.dataHoras);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioControlEmpleados";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de empleados";
            this.Load += new System.EventHandler(this.FormularioControlEmpleados_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbEmpleado;
        private Guna.UI2.WinForms.Guna2TileButton btnPique;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDia;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblHora;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView dataHoras;
        private Guna.UI2.WinForms.Guna2Button btnListado;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAnio;
        public System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label label1;
    }
}