using System.Windows.Forms;
using System.Threading;


namespace Bill_E_Proyecto_2022
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();
            this.Hide();
            timer1.Enabled = false;

        }
    }
}
