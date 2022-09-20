using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_E_Proyecto_2022
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 VentanaJuegos = new Form4();
            VentanaJuegos.Show();
        }

        private void BtnManejar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Manejo = new Form3();
            Manejo.Show();
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
