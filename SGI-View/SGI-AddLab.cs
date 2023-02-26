using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGI_View
{
    public partial class SGI_AddLab : Form
    {
        Controllers.AddLab addL = new Controllers.AddLab();
        string CaptureLab = "";
        public SGI_AddLab()
        {
            InitializeComponent();
        }
        private void SGI_AddLab_Load(object sender, EventArgs e)
        {

        }

        private void txtNomArt_TextChanged(object sender, EventArgs e)
        {
                //  CAPTURAR EL TEXTO DEL TEXTBOX
            string ValueTxtBox = (string)txtNomLab.Text;
            CaptureLab = ValueTxtBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CaptureLab) /*|| CaptureLab.Contains(" ")*/)
            {
                MessageBox.Show("El Nombre de LABORATORIO no es válido (no debe contener espacios");
            }
            else
            {
                MessageBox.Show("Guardado con éxito");
                addL.AddLa(CaptureLab);
                Close();
            }
        }
    }
}
