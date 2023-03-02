using Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class EditLab
    {
        public void EditLa(int NumLab, string nNomLab)
        {
            using (Model_BDContainer db = new Model_BDContainer())
            {
                    //Inventario_Lab nObj = db.Inventario_Lab.Where(d => d.Nom_Lab == NomLab)First();
                Inventario_Lab nObj = db.Inventario_Lab.Find(NumLab);
                nObj.Nom_Lab = nNomLab;

                    //  Se graba la informacion
                    //  Importante que tenga esta dos lineas de codigo
                db.Entry(nObj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
