using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turing_Machine
{
    public partial class Form1 : Form
    {
        private Turing t;
        Dictionary<(string, string), StateExecuter> c = new Dictionary<(string, string), StateExecuter>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DataGridViewTextBoxCell> tape = new List<DataGridViewTextBoxCell>();
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns.Insert(0, new DataGridViewColumn() { CellTemplate = new DataGridViewTextBoxCell() });
            foreach (DataGridViewTextBoxCell item in dataGridView1.Rows[0].Cells)
            {
                item.Selected = false;
                tape.Add(item);
            }
            //for (int i = 0; i < textBox1.Text.Length; i++)
            //{
            //    if (textBox1.Text[i] == ' ')
            //        tape.Add(" ");
            //    else
            //        tape.Add(textBox1.Text[i].ToString());

            //}
            ////tape.Add(" ");
            t = new Turing();
            t.BinaryAddition(tape, dataGridView1);
        }

        private void btn_CompilaAlgoritmo_Click(object sender, EventArgs e)
        {
            bool scatto = false;
            string s = textBox2.Text;
            List<string> tape = new List<string>();

            List<string> a = s.Split(new char[] { '=', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] l = new string[1000];
            foreach (var item in a)
            {
                if (scatto)
                {
                    c.Add((l[0], l[1]), new StateExecuter(item));
                    scatto = false;
                }
                if (item.Contains("-"))
                {
                    l = item.Split('-');
                    scatto = true;
                }
            }
        }

        private void btn_EseguiCustom_Click(object sender, EventArgs e)
        {
            List<string> tape = new List<string>();
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == ' ')
                    tape.Add(" ");
                else
                    tape.Add(textBox1.Text[i].ToString());

            }

            Manager man = new Manager(new Label(), tape) //lbl_puntatore
            {
                currentPosition = 0,
                currentState = "S0"
            };

            while (!man.finito)
            {
                if (c.TryGetValue((man.currentState, tape[man.currentPosition]), out StateExecuter executer))
                {
                    executer.execute(man);
                    //lbl_input.Text = "";
                    tape.ForEach(Print);
                    //lbl_input.Refresh();
                    Thread.Sleep(600);
                }
            }
            //lbl_puntatore.Left = 370;

        }
        public void Print(string s)
        {
            //lbl_input.Text += s;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //lbl_input.Text = textBox1.Text;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "");
            dataGridView1.Rows.Add();
        }

        private void DataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.Width = 20;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns.Insert(0, new DataGridViewColumn() { CellTemplate = new DataGridViewTextBoxCell() });
        }
    }
}
