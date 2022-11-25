namespace WoofGroomer
{
    partial class FichaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichaEmpleado));
            this.btnEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Animated = true;
            this.btnEmpleado.BorderRadius = 5;
            this.btnEmpleado.CheckedState.Parent = this.btnEmpleado;
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.CustomImages.Parent = this.btnEmpleado;
            this.btnEmpleado.FillColor = System.Drawing.Color.Silver;
            this.btnEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEmpleado.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.HoverState.Image")));
            this.btnEmpleado.HoverState.Parent = this.btnEmpleado;
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmpleado.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEmpleado.Location = new System.Drawing.Point(5, 5);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.ShadowDecoration.Parent = this.btnEmpleado;
            this.btnEmpleado.Size = new System.Drawing.Size(224, 28);
            this.btnEmpleado.TabIndex = 247;
            this.btnEmpleado.Text = "Salida";
            this.btnEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // FichaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEmpleado);
            this.Name = "FichaEmpleado";
            this.Size = new System.Drawing.Size(235, 38);
            this.Load += new System.EventHandler(this.FichaEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btnEmpleado;
    }
}
