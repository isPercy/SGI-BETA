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
    public partial class FormInv : Form
    {
        public int uwu;
        Controllers.cbController ocbController = new Controllers.cbController();
        //Controllers.FillInv.FillEquipo oFillEquipo = new Controllers.FillInv.FillEquipo();

        public FormInv()
        {
            InitializeComponent();

        }
        #region Cargar sin filtro
        private void FormInv_Load(object sender, EventArgs e)
        {
                //dropdown LABORATORIOS
            cb_Lab.DataSource = ocbController.LabGetList();
            cb_Lab.ValueMember = "ID_Lab";
            cb_Lab.DisplayMember = "Nom_Lab";

                //dropdown ARTICULOS
            cb_Art.DataSource = ocbController.ArtGetList();
            cb_Art.ValueMember = "ID_Articulo";
            cb_Art.DisplayMember = "Nom_Articulo";

                //EQUIPOS MOSTRADOS
            dataGridView.DataSource = ocbController.EquiposGetList();

                //Settea los DROPDOWN con un texto de "Seleccionar" como predeterminado
            cb_Art.Text = ("Seleccionar");
            cb_Lab.Text = ("Seleccionar");
        }
        #endregion

        #region Cargar con Lab
        private void cb_Lab_SelectedIndexChanged(object sender, EventArgs e)
        {
                //Mostrar equipos filtrando solo por Lab
            try
            {
                    //Captura el valor del "DROPDOWN de LAB"
                int ValueLab = (int)cb_Lab.SelectedValue;
                    //crea una lista de ARTICULOS segun lo seleccionado en "DROPDOWN LAB"
                cb_Art.DataSource = ocbController.Art_por_Lab(ValueLab);
                cb_Art.ValueMember = "ID_Articulo";
                cb_Art.DisplayMember = "Nom_Articulo";

                    //Cargar lista de equipos con lo seleccionado en el DROPDOWN "LAB"
                dataGridView.DataSource = ocbController.EquiposGetList1(ValueLab);
                uwu = ValueLab;
            }
            catch (InvalidCastException)
            {
            }
        }
        #endregion

        #region Cargar con laboratorio y articulo
        private void cb_Art_SelectedIndexChanged(object sender, EventArgs e)
        {
                //Mostrar equipos filtrando por lab y art
            try
            {
                    //Captura el valor del "DROPDOWN ART"
                int ValueArt = (int)cb_Art.SelectedValue;
                
                    //Imprime en el datagrid el listado de Equipos con la seleccion de dropdown de articulos
                dataGridView.DataSource = ocbController.EquiposGetList2(ValueArt);
                    //Imprime en el datagrid el listado de Equipos con la seleccion de dropdown de articulos y laboratorio
                dataGridView.DataSource = ocbController.EquiposGetList3(ValueArt, uwu);
                
            }
            catch (InvalidCastException)
            {
            }
        }
        #endregion

        //Acciones de botones
        private void closewnd_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrar Formulario Inventario
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //                     No se usa                     //
        }

        private void Prestar_Click(object sender, EventArgs e)
        {
            // Boton prestar equipo *genera un ticket del prestamo*
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Crea la ventana para agregar Equipo
            var f = new SGI_AddItem
            {
                MinimizeBox = false
            };
            f.ShowDialog();
        }
    }
}