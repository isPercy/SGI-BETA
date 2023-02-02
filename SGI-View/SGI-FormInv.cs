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
        Controllers.FillInv.FillEquipo oFillEquipo = new Controllers.FillInv.FillEquipo();

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
            dataGridView2.DataSource = oFillEquipo.EquiposGetList();

            cb_Art.Text = ("Seleccionar");
            cb_Lab.Text = ("Seleccionar");
        }
        #endregion

        #region Cargar con Lab
        private void cb_Lab_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Mostrar equipos filtrando solo por Lab
            //try
            //{
            //    int ValueLab = (int)cb_Lab.SelectedValue;
            //    cb_Art.DataSource = ocbController.Art_por_Lab(ValueLab);
            //    cb_Art.ValueMember = "ID_Articulo";
            //    cb_Art.DisplayMember = "Nom_Articulo";

            //    dataGridView2.DataSource = oFillEquipo.EquiposGetList1(ValueLab);
            //    uwu = ValueLab;
            //}
            //catch (InvalidCastException ex)
            //{
            //}
        }
        #endregion

        #region Cargar con laboratorio y articulo
        private void cb_Art_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Mostrar equipos filtrando por lab y art
            //try
            //{
            //    int ValueArt = (int)cb_Art.SelectedValue;
            //    dataGridView2.DataSource = oFillEquipo.EquiposGetList3(ValueArt, uwu);
            //}
            //catch (InvalidCastException ex)
            //{
            //}
        }
        #endregion

        //Acciones de botones
        private void closewnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Prestar_Click(object sender, EventArgs e)
        {
            Frame1 n = new Frame1();
            n.openPanelForm(new FormPres());
            n.Show();
        }
    }
}