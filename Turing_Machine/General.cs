using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turing_Machine
{
    class General
    {
        public void LoadActions(Dictionary<(string, string), StateExecuter> customActions, string inputComandi)
        {
            // Prendo i comandi dati in input e, dopo averli formattati, li inserisco in una lista.
            bool istruzione = false;
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

        public void RunSimulator(DataGridView dgv_nastro, Dictionary<(string, string), StateExecuter> customActions)
        {
            // Creo una lista con tutte le celle attualmente usate.
            List<DataGridViewTextBoxCell> tape = new List<DataGridViewTextBoxCell>();
            tape = LoadTape(tape, dgv_nastro);

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

        // Aggiunge ogni cella del nastro a una lista di celle.
        public List<DataGridViewTextBoxCell> LoadTape(List<DataGridViewTextBoxCell> tape, DataGridView dgv_nastro)
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
    }
}
