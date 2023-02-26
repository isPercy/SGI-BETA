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
    public partial class SGI_AddItem : Form
    {
        Controllers.cbController ocbController = new Controllers.cbController();
        Controllers.AddEquipo addE = new Controllers.AddEquipo();
        public int CaptureLab;
        public int CaptureArt;
        public string CaptureNumSerie = "";
        public SGI_AddItem()
        {
            InitializeComponent();
        }

        private void SGI_AddItem_Load(object sender, EventArgs e)
        {
                //  Pasar lista a los dropdown
            comboBox1.DataSource = ocbController.LabGetList();
            comboBox2.DataSource = ocbController.ArtGetList();

                //  Definir atributos de ARTICULOS
            comboBox2.ValueMember = "ID_Articulo";
            comboBox2.DisplayMember = "Nom_Articulo";

                //  Definir atributos de LABORATORIOS
            comboBox1.ValueMember = "ID_Lab";
            comboBox1.DisplayMember = "Nom_Lab";

                //  Settea los DROPDOWN con un texto de inicialpredeterminado
            comboBox2.Text = ("-- ES UN --");
            comboBox1.Text = ("-- PERTENECE A --");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                //  CAPTURAR DROPDOWN LABORATORIO
            try
            {
                int ValueLab = (int)comboBox1.SelectedValue;
                CaptureLab = ValueLab;
            }
            catch (InvalidCastException)
            {
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                //  CAPTURAR DROPDOWN ARTICULO
            try
            {
                int ValueArt = (int)comboBox2.SelectedValue;
                CaptureArt = ValueArt;
            }
            catch(InvalidCastException) 
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                //  CAPTURAR EL TEXTO DEL TEXTBOX
            string ValueTxtBox = (string)textBox1.Text;
            CaptureNumSerie = ValueTxtBox;
 
        }

        private void button1_Click(object sender, EventArgs e) //ADD equipo
        {
                //  Verifica si el NUM DE SERIE esta lleno o vacio, y no valida simbolos ni espacios
            if (String.IsNullOrEmpty(CaptureNumSerie))
            {
                MessageBox.Show("El Numero de serie no es válido (no debe contener espacios, ni contener caracteres especiales)");
            }
            else if (CaptureNumSerie.Contains(" "))
            {
                MessageBox.Show("No se permite espacios.");
            }
            else
            {
                MessageBox.Show("Guardado con éxito");
                addE.AddEq(CaptureNumSerie, CaptureArt, CaptureLab);/*addE es el objeto de la clase; AddEq es la funcion de la clase*/
                Close();
            }
        }
    }
}