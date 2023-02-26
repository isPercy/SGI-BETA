using Controllers;
using Models.BD;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI_View
{
    public partial class SGI_CrearPrest : Form
    {    
        public DateTime FechaInicio;
        public DateTime FechaFin;
        public string TxtRutData = "";

        public SGI_CrearPrest()
        {
            InitializeComponent();
        }

        private void SGI_CrearPrest_Load(object sender, EventArgs e)
        {
            AutoCompletar();    //se llama a la funcion de sugerir autocompletado

            dateTimePicker2.Value = DateTime.Now.AddDays(7);
        }

        #region Captura datos de datetime del prestamo
            //Conexion a la base de datos
        SqlConnection db = new SqlConnection("server=DESKTOP-807DCL7 ; database=BD_CPI ; integrated security=true");
            //Objeto para la tabla de datos a almacenar
        DataTable dt = new DataTable();


            //Pasa el valor de la fecha vencimiento
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FechaInicio = dateTimePicker1.Value;
        }


            //Pasa el valor de la fecha vencimiento
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value >= dateTimePicker1.Value)
            {
                FechaFin = dateTimePicker2.Value;
            }
            else
            {
                MessageBox.Show("No se puede asignar una fecha inferior a la de inicio");
            }
        }
        #endregion

        #region Sugerir relleno de datos por el RUT
        private void AutoCompletar()
        {
                //Recorrer usuarios para sugerir en el TextBox
            AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Usuario", db); /*<--- Crear objeto para adaptardor indicando en nombre de la conexion*/

            adaptador.Fill(dt); //Rellenar contenedor de sugerencia

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst.Add(dt.Rows[i]["RUT"].ToString());
            }
            TxtRut.AutoCompleteCustomSource = lst;
        }
        #endregion

        /*----------- AUN NO ESTA EN USO DONDE NO SE OBTIENE LA TUPLA CORRESPONDIENTE RESPECTO AL RUT -----------*/
        #region acciona el relleno de informacion en los TXTBOX
        private void TxtRut_Leave(object sender, EventArgs e)
        {
            //AccionPosRut();
        }
        
        private void TxtRut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //AccionPosRut();
            }
        }
        #endregion


    }
}