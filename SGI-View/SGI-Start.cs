using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI_View
{
    public partial class Frame1 : Form
    {
        public Frame1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btn_Inv_Click(object sender, EventArgs e)
        {
            openPanelForm(new FormInv());
        }
        private void btn_Pres_Click(object sender, EventArgs e)
        {
            openPanelForm(new SGI_FormPres());
        }
        #region Función Desplegar Formulario en Panel Hijo
        private Form activeForm = null;
        public void openPanelForm(Form FormHijo)
        {
            activeForm?.Close();
            activeForm = FormHijo;
            FormHijo.TopLevel = false;
            panelChildForm.Controls.Add(FormHijo);
            FormHijo.Show();
        }
        #endregion
    }
}