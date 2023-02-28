using Models.BD;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace Controllers
{
    public class CreateTicket
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder() 
        {
            DataSource = "DESKTOP-807DCL7",
            InitialCatalog = "BD_CPI",
            IntegratedSecurity = true,
            ApplicationName = "SGI"
        };
        private string ConnectionString = "Data Source = DESKTOP-807DCL7; Initial Catalog = BD_CPI; Integrated Security = True";
        //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-807DCL7; Initial Catalog = BD_CPI; Integrated Security = True");

        public string uwu() 
        {
            return builder.ToString();
        }

        #region Conexion
        //public string StringDeConexion()
        //{
        //    string sc = "Data Source=DESKTOP-807DCL7;Initial Catalog=BD_CPI;Integrated Security=True;"/*ConnectionString*/;
        //    return sc;
        //}
        //public void OpenConexion()
        //{
        //    try
        //    {
        //        using (connection) { connection.Open(); }
                    
        //    }
        //    catch (Exception ex)
        //    {
        //        uwu = ("No se pudo establecer conexión: " + ex.Message);
        //    }
        //}

        //public void CloseConexion() 
        //{
        //    using (connection) { connection.Close(); }
        //}
        #endregion

        //Almacenar datos en objeto de tipo EQUIPO
        public List<EquiposViewModel> ObtenerEquipo()
        {
            List<EquiposViewModel> LstEquipo = new List<EquiposViewModel>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from EquipoUnico", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EquiposViewModel Equipo = new EquiposViewModel();

                    Equipo.Num_Serie = Convert.ToString(reader["Num_Serie"]);
                    Equipo.Inventario_LabID_Lab = Convert.ToInt32(reader["Inventario_LabID_Lab"]);
                    Equipo.Tipo_ArticuloID_Articulo = Convert.ToInt32(reader["Tipo_ArticuloID_Articulo"]);

                    LstEquipo.Add(Equipo);
                }
                reader.Close();
                connection.Close();
                //connection.Close();
            }

            return LstEquipo;
        }

            //Almacenar datos en objeto de tipo USUARIO
        public List<UsuarioViewModel> ObtenerUsuario()
        {         
            List<UsuarioViewModel> LstUsuario = new List<UsuarioViewModel>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from Usuario", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    UsuarioViewModel Usuario = new UsuarioViewModel();

                    Usuario.ID_User = Convert.ToInt32(reader["ID_User"]);
                    Usuario.RUT = Convert.ToString(reader["RUT"]);
                    Usuario.Nom_Usuario = Convert.ToString(reader["Nom_Usuario"]);
                    Usuario.Celular = Convert.ToString(reader["Celular"]);
                    Usuario.Correo = Convert.ToString(reader["Correo"]);
                    Usuario.Carrera_UsuarioID_Carrera = Convert.ToInt32(reader["Carrera_UsuarioID_Carrera"]);

                    LstUsuario.Add(Usuario);
                }
                reader.Close();
                connection.Close();
            }
            return LstUsuario;
        }
    }
}