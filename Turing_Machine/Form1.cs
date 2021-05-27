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
        Dictionary<(string, string), StateExecuter> customActions = new Dictionary<(string, string), StateExecuter>();

        public Form1()
        {
            InitializeComponent();
            dgv_nastro.BackgroundColor = SystemColors.Control;
            LoadColumns();
        }

        private void LoadColumns()
        {
            dgv_nastro.Columns.Add("", "");
            dgv_nastro.Rows.Add();
            for (int i = 0; i < 4; i++)
            {
                dgv_nastro.Columns.Add("", "");
            }
        }

        private List<DataGridViewTextBoxCell> LoadTape(List<DataGridViewTextBoxCell> tape)
        {
            DataGridViewCellCollection row = dgv_nastro.Rows[0].Cells;
            int pos = dgv_nastro.Columns.Count - 1;
            string s1 = row[0].Value?.ToString() ?? "";
            string s2 = row[pos].Value?.ToString() ?? "";

            //if (!string.IsNullOrEmpty(s1))
            //    dgv_nastro.Columns.Insert(0, new DataGridViewColumn() { CellTemplate = new DataGridViewTextBoxCell() });

            if (!string.IsNullOrEmpty(s2))
                dgv_nastro.Columns.Add("", "");

            foreach (DataGridViewTextBoxCell item in dgv_nastro.Rows[0].Cells)
            {
                string s3 = item.Value?.ToString() ?? "";
                if (s3 == "")
                    item.Value = "";
                item.Selected = false;
                tape.Add(item);
            }
            return tape;
        }

        private void btn_AddizioneBinaria_Click(object sender, EventArgs e)
        {
            List<DataGridViewTextBoxCell> tape = new List<DataGridViewTextBoxCell>();
            tape = LoadTape(tape);
            t = new Turing();
            t.BinaryAddition(tape, dgv_nastro);
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
                    customActions.Add((l[0], l[1]), new StateExecuter(item));
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

            List<DataGridViewTextBoxCell> tape = new List<DataGridViewTextBoxCell>();
            tape = LoadTape(tape);

            // creo il manager che parte alla pos 0, stato 0

            Manager man = new Manager(tape) //lbl_puntatore
            {
                currentPosition = 0,
                currentState = "S0"
            };

            // finchè non ho il segnale di STOP, continuo a computare

            while (!man.finito)
            {
                if (customActions.TryGetValue((man.currentState, tape[man.currentPosition].Value.ToString()), out StateExecuter executer))
                {
                    executer.execute(man);
                    dgv_nastro.ClearSelection();
                    dgv_nastro.Refresh();
                    Thread.Sleep(600);
                }
            }

        }

        private void btn_AggiungiCellaInizio_Click(object sender, EventArgs e)
        {
            dgv_nastro.Columns.Insert(0, new DataGridViewColumn() { CellTemplate = new DataGridViewTextBoxCell() });
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= dgv_nastro.Columns.Count - 2)
                dgv_nastro.Columns.Add("", "");
        }

        
    }
}
