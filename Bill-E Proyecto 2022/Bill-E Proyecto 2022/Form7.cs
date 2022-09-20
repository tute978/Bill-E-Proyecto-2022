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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void BtnVolver4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 Laberinto = new Form5();
            Laberinto.Show();
        }
    }
}
