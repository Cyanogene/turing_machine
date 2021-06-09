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
        private General generalClass;

        public Form1()
        {
            InitializeComponent();
            dgv_nastro.BackgroundColor = SystemColors.Control;
            LoadColumns();
            generalClass = new General();
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

        private void btn_AddizioneBinaria_Click(object sender, EventArgs e)
        {
            // Dichiaro ed eseguo la classe che effettua l'addizione binaria tra due fattori
            List<DataGridViewTextBoxCell> tape = new List<DataGridViewTextBoxCell>();
            tape = generalClass.LoadTape(tape, dgv_nastro);
            turingClass = new Turing();
            turingClass.BinaryAddition(tape, dgv_nastro);
        }

        private void btn_CompilaAlgoritmo_Click(object sender, EventArgs e)
        {
            generalClass.LoadActions(customActions, txt_ScriviAlgoritmo.Text);
        }

        private void btn_EseguiCustom_Click(object sender, EventArgs e)
        {
            generalClass.RunSimulator(dgv_nastro, customActions, true);
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

        private void Btn_Help_Click(object sender, EventArgs e)
        {
            string testo = $"Sei sicuro di voler aprire il manuale online?";
            DialogResult dialogResult = MessageBox.Show(testo, "Macchina di Turing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
                System.Diagnostics.Process.Start("https://github.com/Cyanogene/turing_machine/blob/main/README.md");
        }

        private void btn_divisibile3_Click(object sender, EventArgs e)
        {
            string input = "S0-0=S0,0,>\nS0-1=S1,1,>\nS1-0=S2,0,>\nS1-1=S0,1,>\nS2-0=S1,0,>\nS2-1=S2,1,>\nS0-_=STOP";
            generalClass.LoadActions(customActions, input);

            if (generalClass.RunSimulator(dgv_nastro, customActions, false))
                MessageBox.Show("Il numero non è divisibile per 3.", "Macchina di Turing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Il numero è divisibile per 3.", "Macchina di Turing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_numPari_Click(object sender, EventArgs e)
        {
            string input = "S0-0=S1,0,>\nS1-0=S0,0,>\nS0-1=S0,1,>\nS1-1=S1,1,>\nS0-_=STOP";
            generalClass.LoadActions(customActions, input);

            if (generalClass.RunSimulator(dgv_nastro, customActions, false))
                MessageBox.Show("Il numero di \"0\" di questo numero binario è dispari.", "Macchina di Turing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Il numero di \"0\" di questo numero binario è pari.", "Macchina di Turing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
