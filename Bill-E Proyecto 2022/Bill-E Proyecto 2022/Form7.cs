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
    public partial class yellowBall : Form
    {
        GeneralButton volver;
        bool moveRight, moveLeft, moveUp, moveDown;
        int velocidad = 1;
        public yellowBall()
        {
            InitializeComponent();
            volver = new GeneralButton(btnVoler2);
        }

        private void BtnVoler2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 Laberinto = new Form5();
            Laberinto.Show();
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.W)
            {
                moveUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown = true;
            }
        }

        private void Form7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown = false;
            }
        }

        private void BtnVolver_MouseEnter(object sender, EventArgs e)
        {
            volver.setSize(4);
        }

        private void BtnVolver_MouseLeave(object sender, EventArgs e)
        {
            volver.setDefault();
        }

        private void EventoMoveTimer(object sender, EventArgs e)
        {
            if (moveLeft == true && PBLaberinto.Left > 0)
            {
                PBLaberinto.Left -= velocidad;
            }
            if (moveRight == true && PBLaberinto.Left < 656)
            {
                PBLaberinto.Left += velocidad;
            }
            if (moveUp == true && PBLaberinto.Top > 0)
            {
                PBLaberinto.Top -= velocidad;
            }
            if (moveDown == true && PBLaberinto.Top < 353)
            {
                PBLaberinto.Top += velocidad;
            }
        }
    }
}
