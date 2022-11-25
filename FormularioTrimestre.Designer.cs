namespace WoofGroomer
{
    partial class FormularioTrimestre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioTrimestre));
            this.dataTrimestre = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTrimestre = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrimestre)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTrimestre
            // 
            this.dataTrimestre.AllowUserToAddRows = false;
            this.dataTrimestre.AllowUserToDeleteRows = false;
            this.dataTrimestre.AllowUserToResizeColumns = false;
            this.dataTrimestre.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataTrimestre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTrimestre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTrimestre.BackgroundColor = System.Drawing.Color.White;
            this.dataTrimestre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataTrimestre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTrimestre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTrimestre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTrimestre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrimestre.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTrimestre.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTrimestre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTrimestre.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTrimestre.EnableHeadersVisualStyles = false;
            this.dataTrimestre.Location = new System.Drawing.Point(10, 0);
            this.dataTrimestre.MultiSelect = false;
            this.dataTrimestre.Name = "dataTrimestre";
            this.dataTrimestre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTrimestre.RowHeadersVisible = false;
            this.dataTrimestre.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Noto Sans", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataTrimestre.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTrimestre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTrimestre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTrimestre.Size = new System.Drawing.Size(958, 434);
            this.dataTrimestre.TabIndex = 69;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTrimestre);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 48);
            this.panel3.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(968, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 482);
            this.panel2.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 482);
            this.panel1.TabIndex = 66;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(16, 14);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label1";
            // 
            // btnTrimestre
            // 
            this.btnTrimestre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrimestre.Animated = true;
            this.btnTrimestre.BorderRadius = 5;
            this.btnTrimestre.CheckedState.Parent = this.btnTrimestre;
            this.btnTrimestre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrimestre.CustomImages.Parent = this.btnTrimestre;
            this.btnTrimestre.FillColor = System.Drawing.Color.SeaGreen;
            this.btnTrimestre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTrimestre.ForeColor = System.Drawing.Color.White;
            this.btnTrimestre.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTrimestre.HoverState.Parent = this.btnTrimestre;
            this.btnTrimestre.Image = ((System.Drawing.Image)(resources.GetObject("btnTrimestre.Image")));
            this.btnTrimestre.ImageSize = new System.Drawing.Size(26, 26);
            this.btnTrimestre.Location = new System.Drawing.Point(844, 10);
            this.btnTrimestre.Name = "btnTrimestre";
            this.btnTrimestre.ShadowDecoration.Parent = this.btnTrimestre;
            this.btnTrimestre.Size = new System.Drawing.Size(104, 28);
            this.btnTrimestre.TabIndex = 79;
            this.btnTrimestre.Text = "Exportar";
            this.btnTrimestre.Click += new System.EventHandler(this.btnTrimestre_Click);
            // 
            // FormularioTrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 482);
            this.Controls.Add(this.dataTrimestre);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioTrimestre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desglose de trimestre";
            this.Load += new System.EventHandler(this.FormularioTrimestre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTrimestre)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataTrimestre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private Guna.UI2.WinForms.Guna2Button btnTrimestre;
    }
}