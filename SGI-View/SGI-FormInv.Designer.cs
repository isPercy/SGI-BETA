namespace SGI_View
{
    partial class FormInv
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
            this.cb_Lab = new System.Windows.Forms.ComboBox();
            this.cb_Art = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closewnd = new System.Windows.Forms.Button();
            this.addArt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addLab = new System.Windows.Forms.Button();
            this.Prestar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Lab
            // 
            this.cb_Lab.FormattingEnabled = true;
            this.cb_Lab.Location = new System.Drawing.Point(361, 39);
            this.cb_Lab.Name = "cb_Lab";
            this.cb_Lab.Size = new System.Drawing.Size(183, 21);
            this.cb_Lab.TabIndex = 16;
            this.cb_Lab.SelectedIndexChanged += new System.EventHandler(this.cb_Lab_SelectedIndexChanged);
            // 
            // cb_Art
            // 
            this.cb_Art.FormattingEnabled = true;
            this.cb_Art.Location = new System.Drawing.Point(21, 39);
            this.cb_Art.Name = "cb_Art";
            this.cb_Art.Size = new System.Drawing.Size(183, 21);
            this.cb_Art.TabIndex = 15;
            this.cb_Art.SelectedIndexChanged += new System.EventHandler(this.cb_Art_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(720, 360);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lista de equipos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo de articulos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Laboratorios:";
            // 
            // closewnd
            // 
            this.closewnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closewnd.Location = new System.Drawing.Point(700, 12);
            this.closewnd.Name = "closewnd";
            this.closewnd.Size = new System.Drawing.Size(32, 23);
            this.closewnd.TabIndex = 17;
            this.closewnd.Text = "X";
            this.closewnd.UseVisualStyleBackColor = true;
            this.closewnd.Click += new System.EventHandler(this.closewnd_Click);
            // 
            // addArt
            // 
            this.addArt.Location = new System.Drawing.Point(225, 13);
            this.addArt.Name = "addArt";
            this.addArt.Size = new System.Drawing.Size(75, 23);
            this.addArt.TabIndex = 18;
            this.addArt.Text = "Agregar";
            this.addArt.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(562, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(562, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Editar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // addLab
            // 
            this.addLab.Location = new System.Drawing.Point(562, 13);
            this.addLab.Name = "addLab";
            this.addLab.Size = new System.Drawing.Size(75, 23);
            this.addLab.TabIndex = 21;
            this.addLab.Text = "Agregar";
            this.addLab.UseVisualStyleBackColor = true;
            // 
            // Prestar
            // 
            this.Prestar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Prestar.Location = new System.Drawing.Point(657, 468);
            this.Prestar.Name = "Prestar";
            this.Prestar.Size = new System.Drawing.Size(75, 23);
            this.Prestar.TabIndex = 24;
            this.Prestar.Text = "Prestar";
            this.Prestar.UseVisualStyleBackColor = true;
            this.Prestar.Click += new System.EventHandler(this.Prestar_Click);
            // 
            // FormInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 511);
            this.Controls.Add(this.Prestar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.addLab);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addArt);
            this.Controls.Add(this.closewnd);
            this.Controls.Add(this.cb_Lab);
            this.Controls.Add(this.cb_Art);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(744, 511);
            this.Name = "FormInv";
            this.Text = "Inventario de laboratorio";
            this.Load += new System.EventHandler(this.FormInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Lab;
        private System.Windows.Forms.ComboBox cb_Art;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closewnd;
        private System.Windows.Forms.Button addArt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button addLab;
        private System.Windows.Forms.Button Prestar;
    }
}