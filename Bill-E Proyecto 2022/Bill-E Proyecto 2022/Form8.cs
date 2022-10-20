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
    public partial class Form8 : Form
    {
        GeneralButton volver;
        bool moveRight, moveLeft, moveUp, moveDown;
        int velocidad = 3;
        public Form8()
        {
            InitializeComponent();
            volver = new GeneralButton(btnVoler2);
        }

        private void BtnVoler2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 Contrarreloj = new Form6();
            Contrarreloj.Show();
        }

        private void BtnVolver_MouseEnter(object sender, EventArgs e)
        {
            volver.setSize(4);
        }

        private void BtnVolver_MouseLeave(object sender, EventArgs e)
        {
            volver.setDefault();
        }

        private void Form8_KeyDown(object sender, KeyEventArgs e)
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

        private void Form8_KeyUp(object sender, KeyEventArgs e)
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

        private void EventoMoveTimer(object sender, EventArgs e)
        {
            //Hitbox Programe
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "redBall")
                {
                    //Makes the player unable to move to a certain direction inside the cube.
//                  | Defines the left perimeter |       Defines the top perimeter       |    Defines the down perimeter    | Defines the Right Perimeter |
                    if((x.Left - Player.Right) < 1  && (x.Top - Player.Top) < (Player.Height - 2) && (Player.Top - x.Top) < (x.Height -2) && (Player.Left + 2) < x.Right)
                    {
                        moveRight = false;
                    }
                    if ((Player.Left - x.Right) < 1 && (x.Top - Player.Top) < (Player.Height - 2) && (Player.Top - x.Top) < (x.Height - 2) && (x.Left + 2) < Player.Right)
                    {
                        moveLeft = false;
                    }
                    if((x.Top - Player.Top) < (Player.Height + 2) && (x.Left + 2) < Player.Right && (Player.Left + 2) < x.Right && (Player.Top - x.Top) < (x.Height - 2)){
                        moveDown = false;
                    }
                    if((Player.Top - x.Top) < (x.Height + 2) && (x.Left + 2) < Player.Right && (Player.Left + 2) < x.Right && (x.Top - Player.Top) < (Player.Height - 2))
                    {
                     moveUp = false;
                    }
                }
            }

            if (moveLeft == true && Player.Left > 0)
            {
                Player.Left -= velocidad;
            }
            if (moveRight == true && Player.Left < 739)
            {
                Player.Left += velocidad;
            }
            if (moveUp == true && Player.Top > 0)
            {
                Player.Top -= velocidad;
            }
            if (moveDown == true && Player.Top < 353)
            {
                Player.Top += velocidad;
            }
        }
    }
}
