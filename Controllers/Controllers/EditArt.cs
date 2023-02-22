using Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class EditArt
    {
        public void EditAr(int idArt, string NomArt)
        {
            using (Model_BDContainer db = new Model_BDContainer())
            {
                    //Inventario_Lab nObj = db.Inventario_Lab.Where(d => d.Nom_Lab == NomLab)First();
                Tipo_Articulo nObj = db.Tipo_Articulo.Find(idArt);
                nObj.Nom_Articulo = NomArt;

                    //  Se graba la informacion
                    //  Importante que tenga esta dos lineas de codigo
                db.Entry(nObj).State = System.Data.Entity.EntityState.Modified;
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
