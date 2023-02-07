using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class ARTxLAB
    {
        public int ID_Articulo { get; set; }
        public int ID_Equipo { get; set; }
        public string Num_Serie { get; set; }
        public string Nom_Articulo { get; set; }
        public int Inventario_LabID_Lab { get; set; }
    }
}
