using System.Windows.Forms;
using System.Drawing;

namespace Bill_E_Proyecto_2022
{
    class GeneralButton
    {
        //ReadOnly = final in java
        readonly int X;
        readonly int Y;

        readonly int locX;
        readonly int locY;

        Button b;

        public GeneralButton(Button b)
        {
            X = b.Size.Width;
            Y = b.Size.Height;

            locX = b.Location.X;
            locY = b.Location.Y;

            this.b = b;
        }

        public void setSize(int ns)
        {
            b.Size = new Size(X + ns, Y + ns);
            b.Location = new Point(locX - (ns / 2), locY - (ns / 2));
        }

        public void setDefault()
        {
            b.Size = new Size(X, Y);
            b.Location = new Point(locX, locY);
        }

        public Button GetButton()
        {
            return b;
        }

        public int getX()
        {
            return X;
        }

        public int getY()
        {
            return Y;
        }
    }
}
