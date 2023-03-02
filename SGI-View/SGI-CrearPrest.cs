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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGI_View
{
    public partial class SGI_CrearPrest : Form
    {
        CreateTicket db = new CreateTicket();

        public DateTime FechaInicio;
        public DateTime FechaFin;
        string ValueRut;
        string eq;

        public SGI_CrearPrest()
        {
            InitializeComponent();
        }
        
        private void SGI_CrearPrest_Load(object sender, EventArgs e)
        {
            eq = textBox6.Text;
            CompletarEquipo();
            AutoCompletar();    //se llama a la funcion de sugerir autocompletado RUT
            dateTimePicker2.Value = DateTime.Now.AddDays(7);
            dateTimePicker1.Value = DateTime.Now;
        }

            // ---- Captura datos de datetime del prestamo ----
            //Pasa el valor de la fecha inicio
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FechaInicio = dateTimePicker1.Value;
        }

            // ---- Captura datos de datetime del prestamo ----
            //Pasa el valor de la fecha vencimiento y niega una fecha de vencimiento menor a la de inicio
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



        /*                 ----------- FORM USUARIO -----------                 */



            // ----  Sugerir relleno de datos por el RUT ----
            //Objeto para la tabla de datos a almacenar
        DataTable dt = new DataTable();
        private void AutoCompletar()
        {
            //Recorrer usuarios para sugerir en el TextBox
            AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Usuario", db.uwu()); /*<--- Crear objeto para adaptardor indicando en nombre de la conexion*/

            adaptador.Fill(dt); //Rellenar adaptador de sugerencia

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst.Add(dt.Rows[i]["RUT"].ToString());
            }
            TxtRut.AutoCompleteCustomSource = lst;
        }

        private void TxtRut_TextChanged(object sender, EventArgs e)
        {
            ValueRut = TxtRut.Text;
        }

        // Acciona el relleno de informacion en los TXTBOX
        private void TxtRut_Leave(object sender, EventArgs e)
        {
            ValueRut = TxtRut.Text;
            if (string.IsNullOrEmpty(TxtRut.Text))
            { 
            }
            else
            {

                if (db.ExisteRut(ValueRut) == false)
                {
                    CompletarUsuario();
                    TxtNom.Enabled = false;
                    TxtCelular.Enabled = false;
                    TxtCorreo.Enabled = false;
                    TxtCarrera.Enabled = false;
                }
                else
                {
                    TxtNom.Text = "";
                    TxtCelular.Text = "";
                    TxtCorreo.Text = "";
                    TxtCarrera.Text = "";

                    TxtNom.Enabled = true;
                    TxtCelular.Enabled = true;
                    TxtCorreo.Enabled = true;
                    TxtCarrera.Enabled = true;
                }
            }
        }
        private void TxtRut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValueRut = TxtRut.Text;
                if (string.IsNullOrEmpty(TxtRut.Text))
                { 
                }
                else
                {

                    if (db.ExisteRut(ValueRut) == false)
                    {
                        CompletarUsuario();
                        TxtNom.Enabled = false;
                        TxtCelular.Enabled = false;
                        TxtCorreo.Enabled = false;
                        TxtCarrera.Enabled = false;
                    }
                    else
                    {
                        TxtNom.Text = "";
                        TxtCelular.Text = "";
                        TxtCorreo.Text = "";
                        TxtCarrera.Text = "";

                        TxtNom.Enabled = true;
                        TxtCelular.Enabled = true;
                        TxtCorreo.Enabled = true;
                        TxtCarrera.Enabled = true;
                    }
                }
            }
        }
            // Termina accion de relleno de info en los TXTBOX


            // completando campos de los txtbox con el objeto USUARIO
        public void CompletarUsuario()
        {
            try
            {
                var LstUsuario = db.ObtenerUsuario();
                foreach (var usuario in LstUsuario)
                {
                    var user = LstUsuario.Find(u => u.RUT == ValueRut);
                    TxtNom.Text = user.Nom_Usuario.ToString();
                    TxtCorreo.Text = user.Correo.ToString();
                    TxtCelular.Text = user.Celular.ToString();
                    TxtCarrera.Text = Convert.ToString(user.Carrera_UsuarioID_Carrera);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llevar a cabo el completar de los campos por lo siguiente: " + ex);
            }
        }

            // completando campos de los txtbox con el objeto Equipo
        public void CompletarEquipo()
        {
            try
            {
                var LstEquipo = db.ObtenerEquipo();
                foreach (var Equipo in LstEquipo)
                {
                    var equipo = LstEquipo.Find(u => u.Num_Serie == eq);
                    LblArt.Text = ("Articulo: " + Convert.ToString(equipo.Tipo_ArticuloID_Articulo));
                    LblLab.Text = ("Laboratiorio: " + Convert.ToString(equipo.Inventario_LabID_Lab));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo rellenar datos de equipo por lo siguientes motivos: " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            string dtEquipo = textBox6.Text;
            string dtRut = TxtRut.Text;
            DateTime fstar = FechaInicio;
            DateTime fend = FechaFin;
            try { 
                db.GuardarPrestamo(dtEquipo, dtRut, fstar, fend);
                MessageBox.Show("Guardado con éxito");
                Close();
            }
            catch(Exception ex) 
            {  
                MessageBox.Show("No se pudo completar la operacion por lo siguiente: " + ex);
            }
        }
    }
}