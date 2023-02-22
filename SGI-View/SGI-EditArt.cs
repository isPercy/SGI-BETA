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
    public partial class SGI_EditArt : Form
    {
        cbController ocbController = new cbController();
        EditArt EdtA = new EditArt();

        public string NomArt = string.Empty;
        public int idArt = 0;

        public SGI_EditArt()
        {
            InitializeComponent();
        }

            //Rellenar combobox de Articulos
        private void SGI_EditArt_Load(object sender, EventArgs e)
        {
            cb_Art.DataSource = ocbController.ArtGetList();
            cb_Art.ValueMember = "ID_Articulo";
            cb_Art.DisplayMember = "Nom_Articulo";

            cb_Art.Text = ("Seleccionar");
        }
        private void cb_Lab_SelectedIndexChanged(object sender, EventArgs e)
        {
                //Almacena valor de CB
            try
            {
                int ValueArt = (int)cb_Art.SelectedValue;

                idArt = ValueArt;
            }
            catch (InvalidCastException)
            {
            }
        }

        private void txtNomLab_TextChanged(object sender, EventArgs e)
        {
                //Almacena dato de TextBox
            string ValueTxtBox = (string)txtNomArt.Text;
            NomArt = ValueTxtBox;
        }

        private void SaveEditArt_Click(object sender, EventArgs e)
        {
                //revisa si el campo esta vacio o no para guardar cambios
            if (string.IsNullOrEmpty(NomArt))
            {
                MessageBox.Show("El Nombre de LABORATORIO no es válido (no debe contener espacios, ni contener caracteres especiales)");
            }
            else
            {
                MessageBox.Show("Guardado con éxito");
                EdtA.EditAr(idArt, NomArt);
                Close();
            }
        }

        
    }
}
