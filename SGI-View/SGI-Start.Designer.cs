namespace SGI_View
{
    partial class Frame1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame1));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Pres = new System.Windows.Forms.Button();
            this.btn_Inv = new System.Windows.Forms.Button();
            this.LogoUVM = new System.Windows.Forms.Panel();
            this.UVMlogo = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.LogoUVM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UVMlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.btn_Pres);
            this.panel1.Controls.Add(this.btn_Inv);
            this.panel1.Controls.Add(this.LogoUVM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 511);
            this.panel1.TabIndex = 2;
            // 
            // btn_Pres
            // 
            this.btn_Pres.FlatAppearance.BorderSize = 0;
            this.btn_Pres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Pres.Location = new System.Drawing.Point(0, 209);
            this.btn_Pres.Name = "btn_Pres";
            this.btn_Pres.Size = new System.Drawing.Size(200, 80);
            this.btn_Pres.TabIndex = 2;
            this.btn_Pres.Text = "Ver préstamos";
            this.btn_Pres.UseVisualStyleBackColor = true;
            this.btn_Pres.Click += new System.EventHandler(this.btn_Pres_Click);
            // 
            // btn_Inv
            // 
            this.btn_Inv.FlatAppearance.BorderSize = 0;
            this.btn_Inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Inv.Location = new System.Drawing.Point(0, 106);
            this.btn_Inv.Name = "btn_Inv";
            this.btn_Inv.Size = new System.Drawing.Size(200, 80);
            this.btn_Inv.TabIndex = 1;
            this.btn_Inv.Text = "Ver inventario";
            this.btn_Inv.UseVisualStyleBackColor = true;
            this.btn_Inv.Click += new System.EventHandler(this.btn_Inv_Click);
            // 
            // LogoUVM
            // 
            this.LogoUVM.Controls.Add(this.UVMlogo);
            this.LogoUVM.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoUVM.Location = new System.Drawing.Point(0, 0);
            this.LogoUVM.Name = "LogoUVM";
            this.LogoUVM.Size = new System.Drawing.Size(200, 100);
            this.LogoUVM.TabIndex = 0;
            // 
            // UVMlogo
            // 
            this.UVMlogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UVMlogo.Image = ((System.Drawing.Image)(resources.GetObject("UVMlogo.Image")));
            this.UVMlogo.Location = new System.Drawing.Point(20, 8);
            this.UVMlogo.Name = "UVMlogo";
            this.UVMlogo.Size = new System.Drawing.Size(158, 83);
            this.UVMlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UVMlogo.TabIndex = 0;
            this.UVMlogo.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(744, 511);
            this.panelChildForm.TabIndex = 3;
            // 
            // Frame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(944, 511);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 550);
            this.Name = "Frame1";
            this.Text = "Sistema de Gestión de Inventario - Escuela de ingeniería y negocio UVM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.LogoUVM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UVMlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Pres;
        private System.Windows.Forms.Button btn_Inv;
        private System.Windows.Forms.Panel LogoUVM;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox UVMlogo;
    }
}

