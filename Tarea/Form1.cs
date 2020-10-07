using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e) => Close();

        public void ColorTexto(Color x, String y) {
            if (Texto.ForeColor != x) {
                Texto.ForeColor = x;
                Texto.Text = y;
                if (x == Color.Yellow)
                {
                    Texto.BackColor = Color.Black;
                }
                else if (Texto.BackColor != Color.White) {
                    Texto.BackColor = Color.White;
                }
            }
        }

        private void Hola_Click(object sender, EventArgs e)
        {
            ColorTexto(Color.Black, "Hola");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorTexto(Color.Red, "Rojo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorTexto(Color.Blue, "Azul");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorTexto(Color.Green, "Verde");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorTexto(Color.Yellow, "Amarillo");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorTexto(Color.Purple, "Morado");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorTexto(Color.Orange, "Anaranjado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorTexto(Color.Pink, "Rosado");
        }
    }
}
