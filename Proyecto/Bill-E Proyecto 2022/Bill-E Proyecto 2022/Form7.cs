using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bill_E_Proyecto_2022
{
    public partial class Form7 : Form
    {
        GeneralButton volver;
        bool moveRight, moveLeft, moveUp, moveDown;
        int velocidad = 2;
        int vidas;
        public static int i = 0;
        void vidas_index()
        {
            if (vidas == 1)
            {
                life3.Hide();
            }
            if(vidas == 2)
            {
                life2.Hide();
            }
            if (vidas == 3)
            {
                life1.Hide();
                moveTimer.Stop();
                Cronometro.Stop();
                Form9 Perdiste = new Form9();
                Perdiste.Show();
                this.Hide();
            }
        }
        public void Game_update(PictureBox x)
        {
            if (PBLaberinto.Bounds.IntersectsWith(x.Bounds))
            {
                vidas += 1;
                vidas_index();
                PBLaberinto.Location = new Point(114, 345);
            }
        }
        public static int getTimer()
        {
            return i;
        }

        public Form7()
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

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void PBGanaste_Click(object sender, EventArgs e)
        {
           
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 0 && i <= 9)
            {
                lblCronometro.Text = "0" + i.ToString();
            }
            else
            {
                lblCronometro.Text = i.ToString();
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
            //Hitbox Programme
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Pared")
                {
                    Game_update((PictureBox)x);
                    //Makes the player unable to move to a certain direction inside the cube.
                    //                  | Defines the left perimeter |       Defines the top perimeter       |    Defines the down perimeter    | Defines the Right Perimeter |
                    if ((x.Left - PBLaberinto.Right) < 1 && (x.Top - PBLaberinto.Top) < (PBLaberinto.Height - 4) && (PBLaberinto.Top - x.Top) < (x.Height - 4) && (PBLaberinto.Left + 2) < x.Right)
                    {
                        moveRight = false;
                    }
                    if ((PBLaberinto.Left - x.Right) < 1 && (x.Top - PBLaberinto.Top) < (PBLaberinto.Height - 4) && (PBLaberinto.Top - x.Top) < (x.Height - 4) && (x.Left + 2) < PBLaberinto.Right)
                    {
                        moveLeft = false;
                    }
                    if ((x.Top - PBLaberinto.Top) < (PBLaberinto.Height - 2) && (x.Left + 2) < PBLaberinto.Right && (PBLaberinto.Left + 2) < x.Right && (PBLaberinto.Top - x.Top) < (x.Height + 2))
                    {
                        moveDown = false;
                    }
                    if ((PBLaberinto.Top - x.Top) < (x.Height - 2) && (x.Left + 2) < PBLaberinto.Right && (PBLaberinto.Left + 2) < x.Right && (x.Top - PBLaberinto.Top) < (PBLaberinto.Height + 2))
                    {
                        moveUp = false;
                    }
                }
                else if (x is PictureBox && (string)x.Tag == "Rojo")
                {
                    if (PBLaberinto.Bounds.IntersectsWith(x.Bounds))
                    { 
                        x.BackColor = Color.Red;
                    }
                    else
                    {
                        x.BackColor = Color.Transparent;
                    }
                }
                else if (x is PictureBox && (string)x.Tag == "Ganaste")
                {
                    if (PBLaberinto.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Hide();
                        Form10 Ganaste = new Form10();
                        Ganaste.Show();
                        moveTimer.Stop();
                        Cronometro.Stop();
                        lblCronometro.Text = "";
                        i = 0;
                    }
                }
            }
            if (moveLeft == true && PBLaberinto.Left > 114)
            {
                PBLaberinto.Left -= velocidad;
            }
            if (moveRight == true && PBLaberinto.Left < 1226)
            {
                PBLaberinto.Left += velocidad;
            }
            if (moveUp == true && PBLaberinto.Top > 46)
            {
                PBLaberinto.Top -= velocidad;
            }
            if (moveDown == true && PBLaberinto.Top < 633)
            {
                PBLaberinto.Top += velocidad;
            }
        }
    }
}
