namespace SGI_View
{
    partial class SGI_EditArt
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
            this.SaveEditArt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Art = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomArt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveEditArt
            // 
            this.SaveEditArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveEditArt.Location = new System.Drawing.Point(264, 167);
            this.SaveEditArt.Name = "SaveEditArt";
            this.SaveEditArt.Size = new System.Drawing.Size(64, 25);
            this.SaveEditArt.TabIndex = 9;
            this.SaveEditArt.Text = "Guardar";
            this.SaveEditArt.UseVisualStyleBackColor = true;
            this.SaveEditArt.Click += new System.EventHandler(this.SaveEditArt_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nuevo nombre del articulo";
            // 
            // cb_Art
            // 
            this.cb_Art.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Art.FormattingEnabled = true;
            this.cb_Art.Location = new System.Drawing.Point(50, 50);
            this.cb_Art.Name = "cb_Art";
            this.cb_Art.Size = new System.Drawing.Size(245, 21);
            this.cb_Art.TabIndex = 7;
            this.cb_Art.SelectedIndexChanged += new System.EventHandler(this.cb_Lab_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Articulo a editar";
            // 
            // txtNomArt
            // 
            this.txtNomArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomArt.Location = new System.Drawing.Point(50, 111);
            this.txtNomArt.Name = "txtNomArt";
            this.txtNomArt.Size = new System.Drawing.Size(245, 20);
            this.txtNomArt.TabIndex = 5;
            this.txtNomArt.TextChanged += new System.EventHandler(this.txtNomLab_TextChanged);
            // 
            // SGI_EditArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 204);
            this.Controls.Add(this.SaveEditArt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Art);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomArt);
            this.Name = "SGI_EditArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGI_EditArt";
            this.Load += new System.EventHandler(this.SGI_EditArt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveEditArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Art;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomArt;
    }
}