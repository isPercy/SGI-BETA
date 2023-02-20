using Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class EquiposViewModel
    {
        public int ID_Equipo { get; set; }
        public string Num_Serie { get; set; }
        public int Tipo_ArticuloID_Articulo { get; set; }
        public int Inventario_LabID_Lab { get; set; }
        public bool Activo { get; set; }
    }    
}
