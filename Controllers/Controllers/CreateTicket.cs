using Models.BD;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Controllers
{
    public class CreateTicket
    {
        public void LlenarPorRut(int Rut)
        {
            using(Model_BDContainer db = new Model_BDContainer())
            {

            }
        }
        //Aun NO esta en uso
        #region Aqui se cambia el estado del equipo al pasar el prestamo a devuelto
        public void CambiarEstado(int ID_Pres)
        {
            using (Model_BDContainer db = new Model_BDContainer())
            {
                    //Inventario_Lab nObj = db.Inventario_Lab.Where(d => d.Nom_Lab == NomLab)First();
                EquipoUnico nObj = db.EquipoUnico.Find(ID_Pres);
                if (nObj.Activo == true)
                {
                        //hay que modificarlo para cuando el estado de prestamo cambie a entregado Activo pase a true
                    nObj.Activo = false;
                }
                else 
                { 
                    nObj.Activo = true;
                }

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
        #endregion

    }
}