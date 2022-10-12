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
        GeneralButton jugar;
        GeneralButton manejar;

        public Form2()
        {
            InitializeComponent();

            jugar = new GeneralButton(btnJugar);
            manejar = new GeneralButton(btnManejar);
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

        private void BtnJugar_MouseEnter(object sender, EventArgs e)
        {
            if((Button) sender == btnJugar)
            {
                jugar.setSize(4);
            }
            else if ((Button)sender == btnManejar)
            {
                manejar.setSize(4);
            }
        }

        private void BtnJugar_MouseLeave(object sender, EventArgs e)
        {
            if((Button)sender == btnJugar)
            {
                jugar.setDefault();
            }
            else if ((Button)sender == btnManejar)
            {
                manejar.setDefault();
            }
        }
    }
}
