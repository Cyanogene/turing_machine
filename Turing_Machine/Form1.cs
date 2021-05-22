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

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool scatto = false;
            string s = textBox2.Text;
            List<string> a = s.Split('=', '\r', '\n').ToList();
            a = a.Where(x => x != "").ToList();
            Dictionary<(string, string), StateExecuter> c = new Dictionary<(string, string), StateExecuter>();
            string v = a.First(x => x.Contains("-"));
            Manager man = new Manager(label1, label2)
            {
                currentPosition = 0,
                currentState = 0
            };
            string[] l = new string[1000];
            foreach (var item in a)
            {
                
                if (scatto)
                {
                    c.Add((l[0], l[1]), new StateExecuter(item, man));
                    scatto = false;
                }
                if (item.Contains("-"))
                {
                    l = item.Split('-');
                    scatto = true;
                    
                }
                
            }
          //  c.Add((asd[0], asd[1]), new StateExecuter("", man));

        }
    }
}
