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
    public class AddEquipo
    {
        public void AddEq(string NSerie, int idArt, int idLab)
        {
            using (Model_BDContainer db  = new Model_BDContainer())
            {
                    //  Se crea un objeto
                EquipoUnico nObj = new EquipoUnico();
                nObj.Num_Serie = NSerie;
                nObj.Tipo_ArticuloID_Articulo = idArt;
                nObj.Inventario_LabID_Lab = idLab;
                nObj.Activo = true;

                    //  Se graba la informacion
                    //  Importante que tenga esta dos lineas de codigo
                db.EquipoUnico.Add(nObj);
                db.SaveChanges();
            }
        }
    }        
}