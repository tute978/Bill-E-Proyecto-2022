using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace Bill_E_Proyecto_2022
{
    public partial class Form8 : Form
    {
        GeneralButton volver;
        bool moveRight, moveLeft, moveUp, moveDown;
        int velocidad = 3;

        string color;
        int vida = 3;
        bool excLife = false;

        ArrayList ball = new ArrayList();

        Random rand = new Random();

        public Form8()
        {
            InitializeComponent();
            volver = new GeneralButton(btnVoler2);

            PauseScreen p = new PauseScreen(this, 300, 300, 35);
            p.setVisible(false);
            p.setImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Menú Pausa.png");
            p.replayImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Pantalla de carga programa.png");

            generateBalls(20);
            color = setColor();
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
                    removeBall((PictureBox) x);
                    ballCollisions((PictureBox)x);
                }
                else if (x is PictureBox && (string)x.Tag == "yellowBall")
                {
                    removeBall((PictureBox)x);
                    ballCollisions((PictureBox)x);
                }
                else if (x is PictureBox && (string)x.Tag == "blueBall")
                {
                    removeBall((PictureBox)x);
                    ballCollisions((PictureBox)x);
                }
                else if (x is PictureBox && (string)x.Tag == "greenBall")
                {
                    removeBall((PictureBox)x);
                    ballCollisions((PictureBox)x);
                }
                else if(x == bar)
                {
                    //x.Width--;
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
            if (moveDown == true && Player.Top < 390)
            {
                Player.Top += velocidad;
            }

            //---------------------------------------------------------------------------------------------
        }

        private void createBall(String type)
        {
            PictureBox picBall = new PictureBox();

            picBall.Width = 35;
            picBall.Height = 35;

            picBall.Tag = type;
            picBall.BackColor = Color.Transparent;
            picBall.BackgroundImageLayout = ImageLayout.Stretch;

            int x = rand.Next(10, this.ClientSize.Width - picBall.Width);
            int y = rand.Next(10, this.ClientSize.Height - picBall.Height);
            picBall.Location = new Point(x, y);

            switch (type)
            {
                case "redBall":
                    picBall.BackgroundImage = Image.FromFile(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Ellipse 5.png");
                break;

                case "blueBall":
                    picBall.BackgroundImage = Image.FromFile(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Ellipse 9.png");
                break;

                case "yellowBall":
                    picBall.BackgroundImage = Image.FromFile(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Ellipse 19.png");
                break;

                case "greenBall":
                    picBall.BackgroundImage = Image.FromFile(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Ellipse 11.png");
                break;
            }


            this.Controls.Add(picBall);
        }

        private void generateBalls(int amount)
        {
            for(int i = 0; i < amount; i++)
            {
                int r = rand.Next(0, 4);

                switch (r)
                {
                    case 0:
                        createBall("redBall");
                        break;

                    case 1:
                        createBall("blueBall");
                        break;

                    case 2:
                        createBall("yellowBall");
                        break;

                    case 3:
                        createBall("greenBall");
                        break;
                }
            }
        }

        private void ballCollisions(PictureBox x)
        {
            List<String> tags = new List<string>();

            tags.Add("redBall");
            tags.Add("blueBall");
            tags.Add("yellowBall");
            tags.Add("greenBall");

            for(int i = 0; i < tags.Count; i++)
            {
                foreach(Control p in this.Controls)
                {
                    if (p != x)
                    {
                        if (p is PictureBox && (string)p.Tag == tags[i])
                        {
                            if (x.Bounds.IntersectsWith(p.Bounds))
                            {
                                int x1 = rand.Next(10, this.ClientSize.Width - x.Width);
                                int y = rand.Next(10, this.ClientSize.Height - x.Height);
                                x.Location = new Point(x1, y);
                            }
                        }
                    }
                }
            }
        } 

        private void setPicSize(PictureBox x, int ns)
        {
            x.Size = new Size(x.Size.Width - ns, x.Size.Height - ns);
            x.Location = new Point(x.Location.X + (ns / 2), x.Location.Y + (ns / 2));
        }

        private void removeBall(PictureBox x)
        {

            if (Player.Bounds.IntersectsWith(x.Bounds))
            {
                ball.Add((PictureBox)x);

                if (!excLife && color != (string)x.Tag  && x.Visible)
                {
                    vida--;
                    checkLife();
                    excLife = true;
                }
            }

            if (x.Width == 0 && x.Height == 0 && x.Visible == true)
            {
                ball.Remove(x);
                x.Visible = false;
                excLife = false;
                color = setColor();
                Console.WriteLine("color: " + color);
            }
            else if (ball.Contains(x))
            {
                for (int i = 0; i < ball.Count; i++)
                {
                    if (ball[i] == x)
                    {
                        setPicSize((PictureBox)x, 10);
                    }
                }
            }
        }

        private string setColor()
        {
            bool colorFound = false;
            string prevColor = "";
            List<String> tags = new List<string>();

            tags.Add("redBall");
            tags.Add("blueBall");
            tags.Add("yellowBall");
            tags.Add("greenBall");

            while (!colorFound)
            {
                colorFound = true;
                int r = rand.Next(0, 4);

                switch (r)
                {
                    case 0:
                        prevColor = "redBall";
                        break;

                    case 1:
                        prevColor = "blueBall";
                        break;

                    case 2:
                        prevColor = "yellowBall";
                        break;

                    case 3:
                        prevColor = "greenBall";
                        break;
                }

                for (int i = 0; i < tags.Count; i++)
                {
                    foreach (Control p in this.Controls)
                    {
                        if (p is PictureBox && (string)p.Tag == tags[i] && p.Visible == true)
                        {
                            colorFound = false;
                            if (prevColor.Equals(tags[i]))
                            {
                                return prevColor;
                            }
                        }
                    }
                }
            }

            return "";
        }

        private void checkLife()
        {
            switch (vida)
            {
                case 0:
                    Heart.Visible = false;
                    break;

                case 1:
                    Heart1.Visible = false;
                    break;

                case 2:
                    Heart2.Visible = false;
                    break;
            }
        }
    }
}
