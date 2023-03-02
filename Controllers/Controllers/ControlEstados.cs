using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Controllers
{
    public class ControlEstados
    {
        public IEnumerable<Models.ViewModels.EstadoViewModel> LstEstados()
        {
            using (Models.BD.Model_BDContainer db = new Models.BD.Model_BDContainer())
            {
                IEnumerable<Models.ViewModels.EstadoViewModel> lst = (from d in db.Estados
                                                                        select new Models.ViewModels.EstadoViewModel
                                                                        {
                                                                            ID_Estado = d.ID_Estado,
                                                                            Nom_Estado = d.Nom_Estado
                                                                        }).ToList();
                return lst;
            }
        }
    }
}
