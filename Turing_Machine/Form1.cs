using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turing_Machine
{
    public partial class Form1 : Form
    {
        private Turing t;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            List<string> tape = new List<string>();
            tape.Add(" ");
            // X label1 = 14 per ogni numero
            label1.Text = textBox1.Text;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == ' ')
                    tape.Add(" ");
                else
                    tape.Add(textBox1.Text[i].ToString());

            }
            tape.Add(" ");
            t = new Turing(label1, label2);
            t.BinaryAddition(tape);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
