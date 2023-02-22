using Models.BD;
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
        public SGI_CrearPrest()
        {
            InitializeComponent();
        }
        private void SGI_CrearPrest_Load(object sender, EventArgs e)
        {
            autocompletar();//se llama a la funcion de sugerir autocompletado
        }

        #region Sugerir opciones con los datos que se estan dando
            //Conexion a la base de datos
        SqlConnection db = new SqlConnection("server=DESKTOP-807DCL7 ; database=BD_CPI ; integrated security=true");
            //Objeto para la tabla de datos a almacenar
        DataTable dt = new DataTable();
        private void autocompletar()
        {
                    //Recorrer usuarios para sugerir en el TextBox
                AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Usuario", db); /*<--- Crear objeto para adaptardor indicando en nombre de la conexion*/
                adaptador.Fill(dt);//rellenar contenedor de sugerencia

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(dt.Rows[i]["Rut"].ToString());
                }

                TxtRut.AutoCompleteCustomSource = lst;
        }
        #endregion


    }
}