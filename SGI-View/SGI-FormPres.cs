using Controllers;
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
    public partial class SGI_FormPres : Form
    {
        ShowPres prestamos = new ShowPres();
        public SGI_FormPres()
        {
            InitializeComponent();
        }

        private void SGI_FormPres_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prestamos.LstPres();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ValorGridSelected))
            {
                MessageBox.Show("Seleccione una fila de la tabla equipos para generar prestamo");
            }
            else
            {
                var f = new SGI_EstadosPres//Cambia por ventana q se utilizará
                {
                    MinimizeBox = false
                };
                //f./*textBox6 ()variable publica desde el otro form */.Text = ValorGridSelected;
                f.ShowDialog();
            }
        }
        public string ValorGridSelected;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //ValorGridSelected = dataGridView1.SelectedRows[0].Cells["ID_Prestamo"].Value.ToString();
                //MessageBox.Show("Equipo seleccionado: " + ValorGridSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
        }
    }
}
