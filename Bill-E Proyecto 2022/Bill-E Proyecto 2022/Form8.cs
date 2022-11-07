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

        PauseScreen p;
        PauseScreen lose;
        PauseScreen win;

        bool moveRight, moveLeft, moveUp, moveDown;
        int velocidad = 3;

        string color;
        int vida = 3;
        bool excLife = false;
        int lifecooldown = 5;

        int time = 0;

        int tWidth;

        ArrayList ball = new ArrayList();

        Random rand = new Random();

        public Form8()
        {
            InitializeComponent();
            volver = new GeneralButton(btnVoler2);
            p = new PauseScreen(this, 300, 300, 60);
            lose = new PauseScreen(this, 300, 400, 60);
            win = new PauseScreen(this, 300, 400, 60);

            tWidth = bar.Width;

            pauseConfig();
            loseConfig();
            winConfig();
            generateBalls(20);
        }

        private void BtnVoler2_Click(object sender, EventArgs e)
        {
            PauseScreen.stop = true;
            p.setVisible(true);
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
            if(e.KeyCode == Keys.Escape)
            {
                if (!PauseScreen.stop)
                {
                    PauseScreen.stop = true;
                    p.setVisible(true);
                }
                else
                {
                    PauseScreen.stop = false;
                    p.setVisible(false);
                }
            }
        }

        private void GameTick_Tick(object sender, EventArgs e)
        {
            if (!PauseScreen.stop)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "redBall")
                    {
                        removeBall((PictureBox)x);
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
                    else if (x is PictureBox && x == bar)
                    {
                        executeTimer(false);
                    }
                }

                if (lifecooldown > 0)
                {
                    lifecooldown--;
                }
                if (lifecooldown == 1)
                {
                    color = setColor();
                }
                checkColor();
            }
        }

        private void EventoMoveTimer(object sender, EventArgs e)
        {
            if (!PauseScreen.stop)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x == CContenedor)
                    {
                        contenedorcColisions((PictureBox)x);
                    }
                }

                if (moveLeft == true && Player.Left > 0)
                {
                    Player.Left -= velocidad;
                }
                if (moveRight == true && Player.Left < (ClientSize.Width - Player.Width))
                {
                    Player.Left += velocidad;
                }
                if (moveUp == true && Player.Top > 60)
                {
                    Player.Top -= velocidad;
                }
                if (moveDown == true && Player.Top < (ClientSize.Height - Player.Height))
                {
                    Player.Top += velocidad;
                }
            }
        }

        private void Contador_Tick(object sender, EventArgs e)
        {
            if (!PauseScreen.stop)
            {
                time++;
            }
        }
//-----------------------------------------------------------------------------------------------------------------

        private void createBall(String type)
        {
            PictureBox picBall = new PictureBox();

            picBall.Width = 35;
            picBall.Height = 35;

            picBall.Tag = type;
            picBall.BackColor = Color.Transparent;
            picBall.BackgroundImageLayout = ImageLayout.Stretch;

            int x = rand.Next(10, this.ClientSize.Width - picBall.Width);
            int y = rand.Next(60, this.ClientSize.Height - picBall.Height);
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
                        if (p is PictureBox && (string)p.Tag == tags[i] || p is PictureBox && p == Player || p is PictureBox && p == CContenedor)
                        {
                            if (x.Bounds.IntersectsWith(p.Bounds))
                            {
                                int x1 = rand.Next(10, this.ClientSize.Width - x.Width);
                                int y = rand.Next(60, this.ClientSize.Height - x.Height);
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
            if (lifecooldown <= 0)
            {
                if (Player.Bounds.IntersectsWith(x.Bounds))
                {
                    ball.Add((PictureBox)x);

                    if (!excLife && color != (string)x.Tag && x.Visible)
                    {
                        vida--;
                        checkLife();
                        excLife = true;
                    }
                    else if (!excLife && color == (string)x.Tag && x.Visible)
                    {
                        executeTimer(true);
                        excLife = true;
                    }
                }
                //every  ball that is delete
                if (x.Width == 0 && x.Height == 0 && x.Visible == true)
                {
                    ball.Remove(x);
                    x.Visible = false;
                    excLife = false;
                    color = setColor();
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

            PauseScreen.stop = true;
            win.setTime(time);
            win.setVisible(true);
            return "";
        }

        private void checkLife()
        {
            switch (vida)
            {
                case 0:
                    Heart.Visible = false;
                    PauseScreen.stop = true;
                    lose.setVisible(true);
                    break;

                case 1:
                    Heart1.Visible = false;
                    break;

                case 2:
                    Heart2.Visible = false;
                    break;
            }
        }

        private void executeTimer(bool reset)
        {
            if (!reset) {
                if (bar.Width > 0)
                {
                    bar.Width--;
                }
                else
                {
                    PauseScreen.stop = true;
                    lose.setVisible(true);
                }
            }
            else
            {
                bar.Width = tWidth;
            }
        }

        private void checkColor()
        {
            switch (color)
            {
                case "redBall": DColor.BackColor = Color.Red;
                    break;

                case "blueBall": DColor.BackColor = Color.Blue;
                    break;

                case "yellowBall": DColor.BackColor = Color.Yellow;
                    break;

                case "greenBall": DColor.BackColor = Color.Lime;
                    break;
            }
        }

        private void contenedorcColisions(PictureBox x)
        {
            //Makes the player unable to move to a certain direction inside the cube.
            //                  | Defines the left perimeter |       Defines the top perimeter       |    Defines the down perimeter    | Defines the Right Perimeter |
            if ((x.Left - Player.Right) < 1 && (x.Top - Player.Top) < (Player.Height - 4) && (Player.Top - x.Top) < (x.Height - 4) && (Player.Left + 2) < x.Right)
            {
                moveRight = false;
            }
            if ((Player.Left - x.Right) < 1 && (x.Top - Player.Top) < (Player.Height - 4) && (Player.Top - x.Top) < (x.Height - 4) && (x.Left + 2) < Player.Right)
            {
                moveLeft = false;
            }
            if ((x.Top - Player.Top) < (Player.Height + 4) && (x.Left + 2) < Player.Right && (Player.Left + 2) < x.Right && (Player.Top - x.Top) < (x.Height - 2))
            {
                moveDown = false;
            }
            if ((Player.Top - x.Top) < (x.Height + 4) && (x.Left + 2) < Player.Right && (Player.Left + 2) < x.Right && (x.Top - Player.Top) < (Player.Height - 2))
            {
                moveUp = false;
            }
        }

        //------------------------------------------------------------------------------------------------------
        private void pauseConfig()
        {
            p.setVisible(false);
            p.setImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Menú Pausa.png");
            p.replayImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Botón Reiniciar.png");
            p.menuImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Botón Reiniciar.png");
            p.gamesImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Botón Reiniciar.png");
            p.useResume(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Pantalla de carga programa.png");
            p.useEscape();
            p.setLocation(15, ((lose.getHeight() / 2) - (lose.getBHeight() / 2)) - 20);
        }

        private void loseConfig()
        {
            lose.setVisible(false);
            lose.setImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Pantalla Perdiste broderrr.png");
            lose.replayImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Botón Reiniciar.png");
            lose.menuImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Botón Reiniciar.png");
            lose.gamesImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Botón Reiniciar.png");
            lose.setLocation(70, ((lose.getHeight() / 2) - (lose.getBHeight() / 2)) + 65);
        }

        private void winConfig()
        {
            win.setVisible(false);
            win.setImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Pantañña gg you win.png");
            win.replayImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Botón Reiniciar.png");
            win.menuImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Botón Reiniciar.png");
            win.gamesImage(@"C:\Users\47338591\Documents\GitHub\Bill-E-Proyecto-2022\Imagenes\Botón Reiniciar.png");
            win.setLocation(70, ((lose.getHeight() / 2) - (lose.getBHeight() / 2)) + 55);
            win.useTime(15);
        }
    }
}
