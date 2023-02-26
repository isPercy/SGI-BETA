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
    public partial class SGI_EditLab : Form
    {
        cbController ocbController = new cbController();
        EditLab EdtL = new EditLab();

        public string NomLab = "";
        public int idLab = 0;

        public SGI_EditLab()
        {
            InitializeComponent();
        }
        private void SGI_EditLab_Load(object sender, EventArgs e)
        {
            cb_Lab.DataSource = ocbController.LabGetList();
            cb_Lab.ValueMember = "ID_Lab";
            cb_Lab.DisplayMember = "Nom_Lab";

            cb_Lab.Text = ("Seleccionar");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                //Mostrar equipos filtrando solo por Lab
            try
            {
                int ValueLab = (int)cb_Lab.SelectedValue;

                idLab = ValueLab;
            }
            catch (InvalidCastException)
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ValueTxtBox = (string)txtNomLab.Text;
            NomLab = ValueTxtBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NomLab))
            {
                MessageBox.Show("El Nombre de LABORATORIO no es válido (no debe contener espacios, ni contener caracteres especiales)");
            }
            /*else if (NomLab.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
            }*/
            else
            {
                MessageBox.Show("Guardado con éxito");
                EdtL.EditLa(idLab ,NomLab);
                Close();
            }
        }
    }
}
