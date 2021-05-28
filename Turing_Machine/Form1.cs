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
        private Turing turingClass;
        private Dictionary<(string, string), StateExecuter> customActions = new Dictionary<(string, string), StateExecuter>();

        public Form1()
        {
            InitializeComponent();
            dgv_nastro.BackgroundColor = SystemColors.Control;
            LoadColumns();
        }

        // Carico alcune celle appena eseguito il programma
        private void LoadColumns()
        {
            dgv_nastro.Columns.Add("", "");
            dgv_nastro.Rows.Add();
            for (int i = 0; i < 4; i++)
            {
                dgv_nastro.Columns.Add("", "");
            }
        }

        // Aggiunge ogni cella del nastro a una lista di celle.
        private List<DataGridViewTextBoxCell> LoadTape(List<DataGridViewTextBoxCell> tape)
        {
            DataGridViewCellCollection row = dgv_nastro.Rows[0].Cells;
            int pos = dgv_nastro.Columns.Count - 1;
            string s2 = row[pos].Value?.ToString() ?? "";

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
            // Dichiaro ed eseguo la classe che effettua l'addizione binaria tra due fattori
            List<DataGridViewTextBoxCell> tape = new List<DataGridViewTextBoxCell>();
            tape = LoadTape(tape);
            turingClass = new Turing();
            turingClass.BinaryAddition(tape, dgv_nastro);
        }

        private void btn_CompilaAlgoritmo_Click(object sender, EventArgs e)
        {
            // Prendo i comandi dati in input e, dopo averli formattati, li inserisco in una lista.
            bool istruzione = false;
            string inputComandi = textBox2.Text;
            List<string> listaComandi = inputComandi.Split(new char[] { '=', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] l = new string[1000];

            // Assegno le azioni di output ai comandi di input.
            foreach (var item in listaComandi)
            {
                // Se istruzione == TRUE, allora vuol dire che sto facendo il parsing di un azione di output
                if (istruzione)
                {
                    customActions.Add((l[0], l[1]), new StateExecuter(item));
                    istruzione = false;
                }

                // Separo i due valori per avere le due chiavi identificative di un comando.
                if (item.Contains("-"))
                {
                    l = item.Split('-');
                    istruzione = true;
                }
            }
        }

        private void btn_EseguiCustom_Click(object sender, EventArgs e)
        {
            // Creo una lista con tutte le celle attualmente usate.
            List<DataGridViewTextBoxCell> tape = new List<DataGridViewTextBoxCell>();
            tape = LoadTape(tape);

            // Creo la variabile che gestisce i vari paramentri del nastro.
            Manager man = new Manager(tape)
            {
                currentPosition = 0,
                currentState = "S0",
                dataGrid = dgv_nastro
            };

            // Finchè non ho il segnale di STOP, continuo a computare
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
            // Aggiunge una cella all'inizio del nastro.
            dgv_nastro.Columns.Insert(0, new DataGridViewColumn() { CellTemplate = new DataGridViewTextBoxCell() });
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Quando modifichiamo le celle più a destra, verranno create nuove celle per dare la sensazione di infinità del nastro.
            if (e.ColumnIndex >= dgv_nastro.Columns.Count - 2)
                dgv_nastro.Columns.Add("", "");
        }   
    }
}
