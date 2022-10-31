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

        PictureBox backScreen = new PictureBox();
        Button replay = new Button();
        Button menu = new Button();
        Button games = new Button();

        GeneralButton r;
        GeneralButton m;
        GeneralButton g;

        public PauseScreen(Form form, int h, int w, int bSize)
        {
            this.form = form;
            r = new GeneralButton(replay);
            m = new GeneralButton(menu);
            g = new GeneralButton(games);

            backConfig();
            setHeight(h);
            setWidth(w);

            buttonSize(bSize);
            buttonConfig();

            setLocation();
            addControls();
        }

        private void backConfig()
        {
            backScreen.BackColor = Color.Transparent;
            backScreen.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void setWidth(int value)
        {
            backScreen.Width = value;
        }

        private void setHeight(int value)
        {
            backScreen.Height = value;
        }

        public void setLocation()
        {
            int x = (form.Width / 2) - (backScreen.Width / 2);
            int y = (form.Height / 2) - (backScreen.Height / 2);

            backScreen.Location = new Point(x, y);

            int bx = backScreen.Left;
            int by = (form.Height / 2) - (replay.Height / 2);

            replay.Location = new Point(bx - (replay.Width), 0);
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

        private void MouseEnter(object sender, EventArgs e)
        {
            r.setSize(4);
            m.setSize(4);
            g.setSize(4);
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            r.setDefault();
            m.setDefault();
            g.setDefault();
        }
//-----------------------------------------------------------------------------------------
        private void addControls()
        {
            form.Controls.Add(backScreen);

            form.Controls.Add(replay);
            form.Controls.Add(menu);
            form.Controls.Add(games);
        }
    }
}
