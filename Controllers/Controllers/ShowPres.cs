using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ShowPres
    {
        public IEnumerable<Models.ViewModels.PrestamoViewModel> LstPres()
        {
            using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
            {
                IEnumerable<Models.ViewModels.PrestamoViewModel> lst = (from d in db.Prestamo
                                                                        select new Models.ViewModels.PrestamoViewModel
                                                                        {
                                                                            ID_Prestamo = d.ID_Prestamo,
                                                                            EquipoUnicoID_Equipo = d.EquipoUnicoID_Equipo,
                                                                            UsuarioID_User = d.UsuarioID_User,
                                                                            Date_Entrega = d.Date_Entrega,
                                                                            Date_Vencimiento = d.Date_Vencimiento
                                                                        }).ToList();
                return lst;
            }
        }
    }
}
