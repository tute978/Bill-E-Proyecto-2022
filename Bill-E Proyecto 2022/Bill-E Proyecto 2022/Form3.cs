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
    public partial class Form3 : Form
    {
        GeneralButton volver;
        public Form3()
        {
            InitializeComponent();
            volver = new GeneralButton(btnVolver);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Menu = new Form2();
            Menu.Show();
        }

        private void BtnVolver_MouseEnter(object sender, EventArgs e)
        {
            volver.setSize(4);
        }

        private void BtnVolver_MouseLeave(object sender, EventArgs e)
        {
            volver.setDefault();
        }
    }
}
