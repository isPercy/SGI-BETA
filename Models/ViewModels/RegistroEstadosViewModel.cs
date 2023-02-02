using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class Registro_EstadosViewModel
    {
        public int ID_Reg_Est { get; set; }
        public int PrestamoID_Prestamo { get; set; }
        public int EstadoID_Estado { get; set; }
        public DateTime Date_Registro { get; set; }
        public int Inventario_LabID_Lab { get; set; }
    }
}
