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
    public partial class SGI_AddArt : Form
    {
        Controllers.AddArticulo addA = new Controllers.AddArticulo();
        public string CaptureArt = "";
        public SGI_AddArt()
        {
            InitializeComponent();
        }
        private void SGI_AddArt_Load(object sender, EventArgs e)
        {
        }
        private void txtNomArt_TextChanged(object sender, EventArgs e)
        {
                //  Captura el texto de TextBox
            try
            {
                string ValueTxtBox = (string)txtNomArt.Text;
                CaptureArt = ValueTxtBox;
            }
            catch (InvalidCastException)
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //  Verifica si el ARTICULO esta lleno o vacio, y no valida simbolos ni espacios
            if (string.IsNullOrEmpty(CaptureArt))
            {
                MessageBox.Show("El Nombre de ARTICULO no es válido (no debe contener espacios, ni contener caracteres especiales)");
            }
            else
            {
                MessageBox.Show("Guardado con éxito");
                addA.AddAr(CaptureArt);
                Close();
            }
        }
    }
}