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
    public partial class Form10 : Form
    {
        GeneralButton reiniciar;
        GeneralButton menu;
        GeneralButton volver;
        public Form10()
        {
            InitializeComponent();
            reiniciar = new GeneralButton(btnReiniciar);
            menu = new GeneralButton(btnHome);
            volver = new GeneralButton(btnJuegos);
            lblTiempo.Text = Form7.getTimer() + " segundos";
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 Laberinto = new Form7();
            Laberinto.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Menu = new Form2();
            Menu.Show();
        }

        private void BtnJuegos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Juegos = new Form4();
            Juegos.Show();
        }

        private void MouseEnter_btn(object sender, EventArgs e)
        {
            if ((Button)sender == btnReiniciar)
            {
                reiniciar.setSize(4);
            }
            else if ((Button)sender == btnHome)
            {
                menu.setSize(4);
            }
            else if ((Button)sender == btnJuegos)
            {
                volver.setSize(4);
            }
        }

        private void MouseLeave_btn(object sender, EventArgs e)
        {
            if ((Button)sender == btnReiniciar)
            {
                reiniciar.setDefault();
            }
            else if ((Button)sender == btnHome)
            {
                menu.setDefault();
            }
            else if ((Button)sender == btnJuegos)
            {
                volver.setDefault();
            }
        }

        private void LblTiempo_Click(object sender, EventArgs e)
        {

        }
    }
}
