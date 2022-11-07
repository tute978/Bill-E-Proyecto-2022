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
    public partial class Form9 : Form
    {
        GeneralButton reiniciar;
        GeneralButton menu;
        GeneralButton volver;
        public Form9()
        {
            InitializeComponent();
            reiniciar = new GeneralButton(btnReiniciar);
            menu = new GeneralButton(btnMenu);
            volver = new GeneralButton(button3);
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Form7.i = 0;
            Form7 Laberinto = new Form7();
            Laberinto.Show();
            this.Close();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form2 Menu = new Form2();
            Menu.Show();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Juegos = new Form4();
            Juegos.Show();
        }

        private void btnJugar_MouseEnter(object sender, EventArgs e)
        {
           if ((Button)sender == btnReiniciar)
            {
               reiniciar.setSize(4);
            }
            else if ((Button)sender == btnMenu)
            {
                menu.setSize(4);
            }
            else if ((Button)sender == button3)
            {
                volver.setSize(4);
            }
        }

        private void btnJugar_MouseLeave(object sender, EventArgs e)
        {
            if ((Button)sender == btnReiniciar)
            {
                reiniciar.setDefault();
            }
            else if ((Button)sender == btnMenu)
            {
                menu.setDefault();
            }
            else if ((Button)sender == button3)
            {
                volver.setDefault();
            }
        }
    }
}
