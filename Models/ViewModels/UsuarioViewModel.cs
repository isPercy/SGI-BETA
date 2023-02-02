using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    internal class UsuarioViewModel
    {
        public int ID_User { get; set; }
        public string RUT { get; set; }
        public string Nom_Usuario { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public int Carrera_UsuarioID_Carrera { get; set; }
    }
}
