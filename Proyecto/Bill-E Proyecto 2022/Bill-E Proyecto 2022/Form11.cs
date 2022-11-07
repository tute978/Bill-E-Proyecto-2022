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
    public partial class Form11 : Form
    {
        private SerialPort serialPort;

        public Form11()
        {
            InitializeComponent();
            init();
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
            try{
                serialPort = new SerialPort();
                serialPort.BaudRate = 9600;
                serialPort.PortName = "COM4";
                serialPort.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error con los puertos");
            }
            
        }
    }
}
