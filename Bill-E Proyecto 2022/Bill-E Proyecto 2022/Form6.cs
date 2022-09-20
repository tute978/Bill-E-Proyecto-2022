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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void BtnIniciar2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 ContrarrelojJuego = new Form8();
            ContrarrelojJuego.Show();
        }

        private void BtnVolver5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Juegos = new Form4();
            Juegos.Show();

        }
    }
}
