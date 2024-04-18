using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_PrototipoMenu;

namespace Vista_PrototipoMenu
{
    public partial class DatosMoneda : Form
    {
        Controlador con = new Controlador();
        public DatosMoneda()
        {
            InitializeComponent();
        }

        private void GuardarDatos()
        {
            try { 
            string monedaNombre = textBox1.Text;
            int monedaValor=Convert.ToInt32(textBox2.Text);

            con.InsertarMoneda(monedaNombre, monedaValor);
            MessageBox.Show("DATOS GUARDADOS");
            }
            catch(Exception e) {
                MessageBox.Show("error al guardar los datos"); 
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string nombreMoneda = textBox3.Text;
            con.BorrarMoneda(nombreMoneda);
        }
    }
}
