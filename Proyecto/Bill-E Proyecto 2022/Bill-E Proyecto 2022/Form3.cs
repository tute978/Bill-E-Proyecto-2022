using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Bill_E_Proyecto_2022
{
    public partial class Form3 : Form
    {
        GeneralButton volver;
        private SerialPort serialPort;

        public Form3()
        {
            InitializeComponent();
            init();
            volver = new GeneralButton(btnVolver);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Menu = new Form2();
            Menu.Show();
        }

        private void BtnVolver_MouseEnter(object sender, EventArgs e)
        {
            volver.setSize(4);
        }

        private void BtnVolver_MouseLeave(object sender, EventArgs e)
        {
            volver.setDefault();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                serialPort.WriteLine("a");
            }
            if (e.KeyCode == Keys.D)
            {
                serialPort.WriteLine("d");
            }
            if (e.KeyCode == Keys.W)
            {
                serialPort.WriteLine("w");
            }
            if (e.KeyCode == Keys.S)
            {
                serialPort.WriteLine("s");
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                serialPort.WriteLine("A");
            }
            if (e.KeyCode == Keys.D)
            {
                serialPort.WriteLine("D");
            }
            if (e.KeyCode == Keys.W)
            {
                serialPort.WriteLine("W");
            }
            if (e.KeyCode == Keys.S)
            {
                serialPort.WriteLine("S");
            }
        }

        private void init()
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.BaudRate = 9600;
                serialPort.PortName = "COM4";
                serialPort.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error con los puertos: "+ e);
            }

        }
    }
}
