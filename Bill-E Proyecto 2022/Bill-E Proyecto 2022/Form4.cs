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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BtnVoler2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Menu = new Form2();
            Menu.Show();
        }

        private void BtnLaberinto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 Laberinto = new Form5();
            Laberinto.Show();
        }

        private void BtnContrarreloj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 Contrarreloj = new Form6();
            Contrarreloj.Show();
        }
    }
}
