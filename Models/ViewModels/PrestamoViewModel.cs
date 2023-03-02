using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class PrestamoViewModel
    {
        public int ID_Prestamo { get; set; }
        public int EquipoUnicoID_Equipo { get; set; }
        public int UsuarioID_User { get; set; }
        public DateTime Date_Entrega { get; set; }
        public DateTime Date_Vencimiento { get; set; }
    }
}
