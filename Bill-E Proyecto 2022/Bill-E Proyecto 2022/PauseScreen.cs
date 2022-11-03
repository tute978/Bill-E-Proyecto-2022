using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bill_E_Proyecto_2022
{
    class PauseScreen
    {
        Form form;
        Form backScreen = new Form();

        Button replay = new Button();
        Button menu = new Button();
        Button games = new Button();
        Button resume = new Button();

        Label time = new Label();

        GeneralButton r;
        GeneralButton m;
        GeneralButton g;
        GeneralButton res;

        public static bool stop = false;
        bool useEsc = false;

        public PauseScreen(Form form, int h, int w, int bSize)
        {
            this.form = form;
            backConfig();
            setHeight(h);
            setWidth(w);

            buttonSize(bSize);
            buttonConfig();

            addControls();
        }

        private void backConfig()
        {
            backScreen.BackColor = Color.Lime;
            backScreen.TransparencyKey = Color.Lime;

            backScreen.BackgroundImageLayout = ImageLayout.Stretch;
            backScreen.StartPosition = FormStartPosition.CenterScreen;
            backScreen.FormBorderStyle = FormBorderStyle.None;
            backScreen.KeyPreview = true;
            backScreen.TopMost = true;
            backScreen.KeyUp += KeyDown;

        }

        private void setWidth(int value)
        {
            backScreen.Width = value;
        }

        private void setHeight(int value)
        {
            backScreen.Height = value;
        }

        public void setLocation(int space, int y)
        {
            replay.Location = new Point(space, y);
            menu.Location = new Point((backScreen.ClientSize.Width / 2) - (menu.Width / 2), y);
            games.Location = new Point((backScreen.ClientSize.Width - games.Width) - space, y);

            r = new GeneralButton(replay);
            m = new GeneralButton(menu);
            g = new GeneralButton(games);
        }

        public void setImage(String file)
        {
            backScreen.BackgroundImage = Image.FromFile(file);
        }

        public void setVisible(bool b)
        {
            backScreen.Visible = b;

            replay.Visible = b;
            menu.Visible = b;
            games.Visible = b;
        }
//----------------------------------------------------------------------------------------------

        private void buttonSize(int value)
        {
            replay.Width = value;
            replay.Height = value;

            menu.Width = value;
            menu.Height = value;

            games.Width = value;
            games.Height = value;
        }

        private void buttonConfig()
        {
            replay.BackColor = Color.Transparent;
            menu.BackColor = Color.Transparent;
            games.BackColor = Color.Transparent;

            replay.FlatStyle = FlatStyle.Flat;
            menu.FlatStyle = FlatStyle.Flat;
            games.FlatStyle = FlatStyle.Flat;

            replay.FlatAppearance.BorderSize = 0;
            menu.FlatAppearance.BorderSize = 0;
            games.FlatAppearance.BorderSize = 0;

            replay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            menu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            games.FlatAppearance.MouseDownBackColor = Color.Transparent;

            replay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            menu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            games.FlatAppearance.MouseOverBackColor = Color.Transparent;

            replay.BackgroundImageLayout = ImageLayout.Stretch;
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            games.BackgroundImageLayout = ImageLayout.Stretch;

            replay.MouseEnter += MouseEnter;
            menu.MouseEnter += MouseEnter;
            games.MouseEnter += MouseEnter;

            replay.MouseLeave += MouseLeave;
            menu.MouseLeave += MouseLeave;
            games.MouseLeave += MouseLeave;

            replay.Click += ButtonClick;
            menu.Click += ButtonClick;
            games.Click += ButtonClick;
        }

        public void replayImage(String file)
        {
            replay.BackgroundImage = Image.FromFile(file);
        }

        public void menuImage(String file)
        {
            menu.BackgroundImage = Image.FromFile(file);
        }

        public void gamesImage(String file)
        {
            games.BackgroundImage = Image.FromFile(file);
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                if (stop && useEsc)
                {
                    backScreen.Visible = false;
                    stop = false;
                }
            }
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            if((Button)sender == replay)
            {
                r.setSize(4);
            }
            else if ((Button)sender == menu)
            {
                m.setSize(4);
            }
            else if ((Button)sender == games)
            {
                g.setSize(4);
            }
            else if ((Button)sender == resume)
            {
                res.setSize(4);
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            if ((Button)sender == replay)
            {
                r.setDefault();
            }
            else if ((Button)sender == menu)
            {
                m.setDefault();
            }
            else if ((Button)sender == games)
            {
                g.setDefault();
            }
            else if ((Button)sender == resume)
            {
                res.setDefault();
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if ((Button)sender == replay)
            {
                Form ventana = new Form8();
                ventana.Show();
                form.Close();
                stop = false;
                backScreen.Close();
            }
            else if ((Button)sender == menu)
            {
                Form ventana = new Form2();
                ventana.Show();
                form.Close();
                stop = false;
                backScreen.Close();
            }
            else if ((Button)sender == games)
            {
                Form ventana = new Form4();
                ventana.Show();
                form.Close();
                stop = false;
                backScreen.Close();
            }
            else if ((Button)sender == resume)
            {
                stop = false;
                backScreen.Visible = false;
            }
        }
//-----------------------------------------------------------------------------------------------
        public void useResume(String file)
        {
            resume.Width = (backScreen.Width / 3) * 2;
            resume.Height = resume.Width / 3;

            resume.BackColor = Color.Transparent;
            resume.FlatStyle = FlatStyle.Flat;
            resume.FlatAppearance.BorderSize = 0;
            resume.FlatAppearance.MouseDownBackColor = Color.Transparent;
            resume.FlatAppearance.MouseOverBackColor = Color.Transparent;
            resume.BackgroundImageLayout = ImageLayout.Stretch;
            resume.BackgroundImage = Image.FromFile(file);

            resume.MouseEnter += MouseEnter;
            resume.MouseLeave += MouseLeave;
            resume.Click += ButtonClick;

            resume.Location = new Point((backScreen.ClientSize.Width / 2) - (resume.Width / 2), (backScreen.ClientSize.Height - resume.Height) - 30);

            res = new GeneralButton(resume);
            backScreen.Controls.Add(resume);
        }

        public void useEscape()
        {
            useEsc = true;
        }

        public void useTime(int space)
        {
            time.BackColor = Color.Transparent;
            time.FlatStyle = FlatStyle.Flat;
            time.ForeColor = Color.White;
            time.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            time.Width = backScreen.Width / 3;
            time.Height = backScreen.Height / 10;

            time.Location = new Point(space * 2, (backScreen.ClientSize.Height - time.Height) - space / 2);
            time.Text = "Tu Tiempo: ";

            backScreen.Controls.Add(time);
        }

        public void setTime(int value)
        {
            time.Text = "Tu Tiempo: " + value;
        }
//-----------------------------------------------------------------------------------------

        public int getWidth()
        {
            return backScreen.ClientSize.Width;
        }

        public int getHeight()
        {
            return backScreen.ClientSize.Height;
        }

        public int getBWidth()
        {
            return replay.Width;
        }

        public int getBHeight()
        {
            return replay.Height;
        }
        //-----------------------------------------------------------------------------------------

        private void addControls()
        {
            backScreen.Show();

            backScreen.Controls.Add(replay);
            backScreen.Controls.Add(menu);
            backScreen.Controls.Add(games);
        }
    }
}
