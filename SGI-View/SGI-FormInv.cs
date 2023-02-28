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
        public string datagridSelected;
        public int ValorDataGrid;
        public int ValorLab;
        Controllers.cbController ocbController = new Controllers.cbController();
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
            cb_Art.SelectedIndex = 0;
            cb_Lab.Text = ("Seleccionar");
            cb_Lab.SelectedIndex = 0;

            ValorDataGrid = 0;
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
                cb_Art.Text = ("Seleccionar");

                //Cargar lista de equipos con lo seleccionado en el DROPDOWN "LAB"
                dataGridView.DataSource = ocbController.EquiposGetList1(ValueLab);
                ValorLab = ValueLab;
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
                if (cb_Lab.SelectedIndex == 0)
                {
                    //Imprime en el datagrid el listado de Equipos con la seleccion de dropdown de articulos
                    dataGridView.DataSource = ocbController.EquiposGetList2(ValueArt);
                }
                else
                {
                    //Imprime en el datagrid el listado de Equipos con la seleccion de dropdown de articulos y laboratorio
                    dataGridView.DataSource = ocbController.EquiposGetList3(ValueArt, ValorLab);
                }
            }
            catch (InvalidCastException)
            {
            }
        }
        #endregion

        #region DataGridView Selection
        //Se guarda la seleccion del EQUIPO seleccionado en el datagridview
        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ValorDataGrid = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;
            //MessageBox.Show("uwu : " + ValorDataGrid);
        }
        #endregion

        #region ------------ Acciones de botones ------------
        private void closewnd_Click(object sender, EventArgs e)
        {
            this.Close();/*Cerrar Formulario Inventario*/
        }

        private void Prestar_Click(object sender, EventArgs e)
        {
            //  Boton prestar equipo *Form para genera un ticket del prestamo*
            if (String.IsNullOrEmpty(ValorGridSelected))
            {
                MessageBox.Show("Seleccione una fila de la tabla equipos para generar prestamo");
            }
            else
            {
                var f = new SGI_CrearPrest
                {
                    MinimizeBox = false
                };
                f.textBox6.Text = ValorGridSelected;
                f.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Abre la ventana para agregar Equipo
            var f = new SGI_AddItem
            {
                MinimizeBox = false
            };
            f.ShowDialog();
        }

        private void addArt_Click(object sender, EventArgs e)
        {
            //  Abre la ventana para agregar Lab
            var f = new SGI_AddArt
            {
                MinimizeBox = false
            };
            f.ShowDialog();
        }

        private void addLab_Click(object sender, EventArgs e)
        {
            var f = new SGI_AddLab
            {
                MinimizeBox = false
            };
            f.ShowDialog();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            var f = new SGI_EditLab
            {
                MinimizeBox = false
            };
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new SGI_EditArt
            {
                MinimizeBox = false
            };
            f.ShowDialog();
            MessageBox.Show("uwu:  " + datagridSelected);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Vuelve a cargar los datos de los combobox y datagrid
            FormInv_Load(sender, e);
        }
        #endregion

        public string ValorGridSelected;

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                ValorGridSelected = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                MessageBox.Show("Equipo seleccionado: " + ValorGridSelected);
            }
            catch(Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
        }
    }
}