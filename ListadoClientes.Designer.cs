namespace WoofGroomer
{
    partial class ListadoClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoClientes));
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.lblTelefono1 = new System.Windows.Forms.Label();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.btnOpciones = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.MenuClientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemMascotas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemVisitas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemLPD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemEditarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEliminarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 29);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1557, 1);
            this.guna2Separator1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 29);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1547, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 29);
            this.panel2.TabIndex = 2;
            // 
            // lblDNI
            // 
            this.lblDNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDNI.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDNI.ForeColor = System.Drawing.Color.Gray;
            this.lblDNI.Location = new System.Drawing.Point(12, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(110, 29);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "dni";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDNI.MouseEnter += new System.EventHandler(this.lblDNI_MouseEnter);
            this.lblDNI.MouseLeave += new System.EventHandler(this.lblDNI_MouseLeave);
            // 
            // lblNombre
            // 
            this.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblNombre.Location = new System.Drawing.Point(122, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(430, 29);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombre.MouseEnter += new System.EventHandler(this.lblDNI_MouseEnter);
            this.lblNombre.MouseLeave += new System.EventHandler(this.lblDNI_MouseLeave);
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPoblacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPoblacion.ForeColor = System.Drawing.Color.Gray;
            this.lblPoblacion.Location = new System.Drawing.Point(552, 0);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(430, 29);
            this.lblPoblacion.TabIndex = 5;
            this.lblPoblacion.Text = "poblacion";
            this.lblPoblacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPoblacion.MouseEnter += new System.EventHandler(this.lblDNI_MouseEnter);
            this.lblPoblacion.MouseLeave += new System.EventHandler(this.lblDNI_MouseLeave);
            // 
            // lblTelefono1
            // 
            this.lblTelefono1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTelefono1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTelefono1.ForeColor = System.Drawing.Color.Gray;
            this.lblTelefono1.Location = new System.Drawing.Point(982, 0);
            this.lblTelefono1.Name = "lblTelefono1";
            this.lblTelefono1.Size = new System.Drawing.Size(110, 29);
            this.lblTelefono1.TabIndex = 6;
            this.lblTelefono1.Text = "telefono1";
            this.lblTelefono1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTelefono1.MouseEnter += new System.EventHandler(this.lblDNI_MouseEnter);
            this.lblTelefono1.MouseLeave += new System.EventHandler(this.lblDNI_MouseLeave);
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTelefono2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTelefono2.ForeColor = System.Drawing.Color.Gray;
            this.lblTelefono2.Location = new System.Drawing.Point(1092, 0);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(110, 29);
            this.lblTelefono2.TabIndex = 7;
            this.lblTelefono2.Text = "telefono2";
            this.lblTelefono2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTelefono2.MouseEnter += new System.EventHandler(this.lblDNI_MouseEnter);
            this.lblTelefono2.MouseLeave += new System.EventHandler(this.lblDNI_MouseLeave);
            // 
            // btnOpciones
            // 
            this.btnOpciones.CheckedState.Parent = this.btnOpciones;
            this.btnOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpciones.CustomImages.Parent = this.btnOpciones;
            this.btnOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpciones.FillColor = System.Drawing.Color.Transparent;
            this.btnOpciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpciones.ForeColor = System.Drawing.Color.White;
            this.btnOpciones.HoverState.Parent = this.btnOpciones;
            this.btnOpciones.Image = ((System.Drawing.Image)(resources.GetObject("btnOpciones.Image")));
            this.btnOpciones.Location = new System.Drawing.Point(1516, 0);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.ShadowDecoration.Parent = this.btnOpciones;
            this.btnOpciones.Size = new System.Drawing.Size(31, 29);
            this.btnOpciones.TabIndex = 8;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            this.btnOpciones.MouseEnter += new System.EventHandler(this.lblDNI_MouseEnter);
            this.btnOpciones.MouseLeave += new System.EventHandler(this.lblDNI_MouseLeave);
            // 
            // lblEmail
            // 
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(1202, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(314, 29);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.MouseEnter += new System.EventHandler(this.lblDNI_MouseEnter);
            this.lblEmail.MouseLeave += new System.EventHandler(this.lblDNI_MouseLeave);
            // 
            // MenuClientes
            // 
            this.MenuClientes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MenuClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMascotas,
            this.menuItemCitas,
            this.menuItemVisitas,
            this.toolStripMenuItem1,
            this.menuItemLPD,
            this.toolStripMenuItem2,
            this.menuItemEditarCliente,
            this.menuItemEliminarCliente});
            this.MenuClientes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(217, 170);
            // 
            // menuItemMascotas
            // 
            this.menuItemMascotas.Image = ((System.Drawing.Image)(resources.GetObject("menuItemMascotas.Image")));
            this.menuItemMascotas.ImageTransparentColor = System.Drawing.Color.Silver;
            this.menuItemMascotas.Name = "menuItemMascotas";
            this.menuItemMascotas.Size = new System.Drawing.Size(216, 22);
            this.menuItemMascotas.Text = "Mascotas";
            // 
            // menuItemCitas
            // 
            this.menuItemCitas.Name = "menuItemCitas";
            this.menuItemCitas.Size = new System.Drawing.Size(216, 22);
            this.menuItemCitas.Text = "Citas";
            // 
            // menuItemVisitas
            // 
            this.menuItemVisitas.Name = "menuItemVisitas";
            this.menuItemVisitas.Size = new System.Drawing.Size(216, 22);
            this.menuItemVisitas.Text = "Visitas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // menuItemLPD
            // 
            this.menuItemLPD.Name = "menuItemLPD";
            this.menuItemLPD.Size = new System.Drawing.Size(216, 22);
            this.menuItemLPD.Text = "Ley de Protección de datos";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // menuItemEditarCliente
            // 
            this.menuItemEditarCliente.Name = "menuItemEditarCliente";
            this.menuItemEditarCliente.Size = new System.Drawing.Size(216, 22);
            this.menuItemEditarCliente.Text = "Editar Cliente";
            // 
            // menuItemEliminarCliente
            // 
            this.menuItemEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuItemEliminarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuItemEliminarCliente.ForeColor = System.Drawing.Color.Red;
            this.menuItemEliminarCliente.Name = "menuItemEliminarCliente";
            this.menuItemEliminarCliente.Size = new System.Drawing.Size(216, 22);
            this.menuItemEliminarCliente.Text = "Eliminar Cliente";
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnOpciones);
            this.Controls.Add(this.lblTelefono2);
            this.Controls.Add(this.lblTelefono1);
            this.Controls.Add(this.lblPoblacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Separator1);
            this.Name = "ListadoClientes";
            this.Size = new System.Drawing.Size(1557, 30);
            this.MenuClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.Label lblTelefono1;
        private System.Windows.Forms.Label lblTelefono2;
        private Guna.UI2.WinForms.Guna2Button btnOpciones;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ContextMenuStrip MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuItemMascotas;
        private System.Windows.Forms.ToolStripMenuItem menuItemCitas;
        private System.Windows.Forms.ToolStripMenuItem menuItemVisitas;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemLPD;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditarCliente;
        private System.Windows.Forms.ToolStripMenuItem menuItemEliminarCliente;
    }
}
