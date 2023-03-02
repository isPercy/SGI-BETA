using Controllers;
using Controllers.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI_View
{
    public partial class SGI_EstadosPres : Form
    {
        ControlEstados controlE = new ControlEstados();
        public SGI_EstadosPres()
        {
            InitializeComponent();
        }

        private void SGI_EstadosPres_Load(object sender, EventArgs e)
        {
            //Settea los DROPDOWN con un texto de "Seleccionar" como predeterminado
            cb_Estados.Text = ("Seleccione para cambiar estado");
            //cb_Estados.SelectedIndex = 0;

            cb_Estados.DataSource = controlE.LstEstados();
            cb_Estados.ValueMember = "ID_Estado";
            cb_Estados.DisplayMember = "Nom_Estado";

        }
    }
}