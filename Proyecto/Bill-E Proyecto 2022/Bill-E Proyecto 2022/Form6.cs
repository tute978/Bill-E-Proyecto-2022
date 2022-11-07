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
        GeneralButton volver;
        GeneralButton iniciar;
        public Form6()
        {
            InitializeComponent();
            volver = new GeneralButton(btnVoler2);
            iniciar = new GeneralButton(btnIniciar2);
        }

        private void BtnIniciar2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 form = new Form8();
            form.Show();
        }

        private void BtnVolver_MouseEnter(object sender, EventArgs e)
        {
            if((Button) sender == btnVoler2)
            {
                volver.setSize(4);
            }
            else if((Button)sender == btnIniciar2)
            {
                iniciar.setSize(4);
            }
        }

        private void BtnVolver_MouseLeave(object sender, EventArgs e)
        {
            if ((Button)sender == btnVoler2)
            {
                volver.setDefault();
            }
            else if ((Button)sender == btnIniciar2)
            {
                iniciar.setDefault();
            }
        }

        private void BtnVoler2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Juegos = new Form4();
            Juegos.Show();
        }
    }
}
