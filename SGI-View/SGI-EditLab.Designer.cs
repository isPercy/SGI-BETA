namespace SGI_View
{
    partial class SGI_EditLab
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
            this.txtNomLab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Lab = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomLab
            // 
            this.txtNomLab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomLab.Location = new System.Drawing.Point(49, 111);
            this.txtNomLab.Name = "txtNomLab";
            this.txtNomLab.Size = new System.Drawing.Size(245, 20);
            this.txtNomLab.TabIndex = 0;
            this.txtNomLab.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laboratorio a editar";
            // 
            // cb_Lab
            // 
            this.cb_Lab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Lab.FormattingEnabled = true;
            this.cb_Lab.Location = new System.Drawing.Point(49, 50);
            this.cb_Lab.Name = "cb_Lab";
            this.cb_Lab.Size = new System.Drawing.Size(245, 21);
            this.cb_Lab.TabIndex = 2;
            this.cb_Lab.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo nombre de laboratorio";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(264, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SGI_EditLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 204);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Lab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomLab);
            this.MaximumSize = new System.Drawing.Size(500, 330);
            this.MinimumSize = new System.Drawing.Size(356, 243);
            this.Name = "SGI_EditLab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGI_EditLab";
            this.Load += new System.EventHandler(this.SGI_EditLab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Lab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}