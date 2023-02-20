using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using Models.BD;
using System.Globalization;
using System.Data.Entity.Migrations;
using Models.ViewModels;

namespace Controllers
{
    public class AddArticulo
    {
        public void AddAr(string NomArt)
        {
            using (Model_BDContainer db = new Model_BDContainer())
            {
                    //  Se crea un objeto
                Tipo_Articulo nObj = new Tipo_Articulo();
                nObj.Nom_Articulo = NomArt;
                nObj.Activo = true;

                    //  Se graba la informacion
                    //  Importante que tenga esta dos lineas de codigo
                db.Tipo_Articulo.Add(nObj);
                db.SaveChanges();

                    //  Se despliega en consola (no se usa ya que trabajamos atravez de interfaz de windows)
                var lst = db.EquipoUnico;
                foreach (var nObj_ in lst)
                {
                    Console.WriteLine("ok");
                }
            }
        }
    }
}
