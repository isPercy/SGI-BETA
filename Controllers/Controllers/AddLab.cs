using Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class AddLab
    {
        public void AddLa(string NomLab)
        {
            using (Model_BDContainer db = new Model_BDContainer())
            {
                //  Se crea un objeto
                Inventario_Lab nObj = new Inventario_Lab();
                nObj.Nom_Lab = NomLab;
                nObj.Activo = true;

                //  Se graba la informacion
                //  Importante que tenga esta dos lineas de codigo
                db.Inventario_Lab.Add(nObj);
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
