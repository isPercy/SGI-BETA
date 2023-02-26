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
            this.label3 = new System.Windows.Forms.Label();
            this.closewnd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_ArticuloID_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventario_LabID_Lab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestar = new System.Windows.Forms.Button();
            this.btnAddEq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Art = new System.Windows.Forms.ComboBox();
            this.cb_Lab = new System.Windows.Forms.ComboBox();
            this.addArt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addLab = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lista de equipos";
            // 
            // closewnd
            // 
            this.closewnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closewnd.Location = new System.Drawing.Point(700, 12);
            this.closewnd.Name = "closewnd";
            this.closewnd.Size = new System.Drawing.Size(32, 23);
            this.closewnd.TabIndex = 17;
            this.closewnd.Text = "X";
            this.closewnd.UseVisualStyleBackColor = true;
            this.closewnd.Click += new System.EventHandler(this.closewnd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Equipo,
            this.Num_Serie,
            this.Activo,
            this.Tipo_ArticuloID_Articulo,
            this.Inventario_LabID_Lab});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(8, 127);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(724, 343);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowEnter);
            // 
            // ID_Equipo
            // 
            this.ID_Equipo.DataPropertyName = "ID_Equipo";
            this.ID_Equipo.HeaderText = "#";
            this.ID_Equipo.Name = "ID_Equipo";
            this.ID_Equipo.ReadOnly = true;
            // 
            // Num_Serie
            // 
            this.Num_Serie.DataPropertyName = "Num_Serie";
            this.Num_Serie.HeaderText = "N° Serie";
            this.Num_Serie.Name = "Num_Serie";
            this.Num_Serie.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "En bodega";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // Tipo_ArticuloID_Articulo
            // 
            this.Tipo_ArticuloID_Articulo.DataPropertyName = "Tipo_ArticuloID_Articulo";
            this.Tipo_ArticuloID_Articulo.HeaderText = "ID de tipo de articulo";
            this.Tipo_ArticuloID_Articulo.Name = "Tipo_ArticuloID_Articulo";
            this.Tipo_ArticuloID_Articulo.ReadOnly = true;
            // 
            // Inventario_LabID_Lab
            // 
            this.Inventario_LabID_Lab.DataPropertyName = "Inventario_LabID_Lab";
            this.Inventario_LabID_Lab.HeaderText = "ID de laboratorio";
            this.Inventario_LabID_Lab.Name = "Inventario_LabID_Lab";
            this.Inventario_LabID_Lab.ReadOnly = true;
            // 
            // Prestar
            // 
            this.Prestar.Location = new System.Drawing.Point(657, 476);
            this.Prestar.Name = "Prestar";
            this.Prestar.Size = new System.Drawing.Size(75, 23);
            this.Prestar.TabIndex = 24;
            this.Prestar.Text = "Prestar";
            this.Prestar.UseVisualStyleBackColor = true;
            this.Prestar.Click += new System.EventHandler(this.Prestar_Click);
            // 
            // btnAddEq
            // 
            this.btnAddEq.Location = new System.Drawing.Point(12, 476);
            this.btnAddEq.Name = "btnAddEq";
            this.btnAddEq.Size = new System.Drawing.Size(75, 23);
            this.btnAddEq.TabIndex = 25;
            this.btnAddEq.Text = "Agregar";
            this.btnAddEq.UseVisualStyleBackColor = true;
            this.btnAddEq.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Laboratorios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo de articulos:";
            // 
            // cb_Art
            // 
            this.cb_Art.FormattingEnabled = true;
            this.cb_Art.Location = new System.Drawing.Point(12, 38);
            this.cb_Art.Name = "cb_Art";
            this.cb_Art.Size = new System.Drawing.Size(237, 21);
            this.cb_Art.TabIndex = 15;
            this.cb_Art.SelectedIndexChanged += new System.EventHandler(this.cb_Art_SelectedIndexChanged);
            // 
            // cb_Lab
            // 
            this.cb_Lab.FormattingEnabled = true;
            this.cb_Lab.Location = new System.Drawing.Point(397, 38);
            this.cb_Lab.Name = "cb_Lab";
            this.cb_Lab.Size = new System.Drawing.Size(237, 21);
            this.cb_Lab.TabIndex = 16;
            this.cb_Lab.SelectedIndexChanged += new System.EventHandler(this.cb_Lab_SelectedIndexChanged);
            // 
            // addArt
            // 
            this.addArt.Location = new System.Drawing.Point(12, 70);
            this.addArt.Name = "addArt";
            this.addArt.Size = new System.Drawing.Size(75, 23);
            this.addArt.TabIndex = 18;
            this.addArt.Text = "Agregar";
            this.addArt.UseVisualStyleBackColor = true;
            this.addArt.Click += new System.EventHandler(this.addArt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // addLab
            // 
            this.addLab.Location = new System.Drawing.Point(397, 70);
            this.addLab.Name = "addLab";
            this.addLab.Size = new System.Drawing.Size(75, 23);
            this.addLab.TabIndex = 21;
            this.addLab.Text = "Agregar";
            this.addLab.UseVisualStyleBackColor = true;
            this.addLab.Click += new System.EventHandler(this.addLab_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(478, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Editar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(559, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(654, 111);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 13);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Actualizar tabla";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormInv
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(744, 511);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnAddEq);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(744, 511);
            this.Name = "FormInv";
            this.Text = "Inventario de laboratorio";
            this.Load += new System.EventHandler(this.FormInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closewnd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Prestar;
        private System.Windows.Forms.Button btnAddEq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Art;
        private System.Windows.Forms.ComboBox cb_Lab;
        private System.Windows.Forms.Button addArt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addLab;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_ArticuloID_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventario_LabID_Lab;
    }
}