using System;
using System.Collections.Generic;
using System.Drawing;
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
            customActions.Clear();
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
                    if (l[1] == "_")
                        l[1] = "";
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
            Manager man = new Manager()
            {
                currentPosition = 0,
                currentState = "S0",
                dataGrid = dgv_nastro,
                previousPosition = 0,
                finito = false,
                listTape = tape,
            };

            man.listTape[man.currentPosition].Style.BackColor = Color.Cyan;
            dgv_nastro.Refresh();
            Thread.Sleep(600);
            // Finchè non ho il segnale di STOP, continuo a computare
            while (!man.finito)
            {
                string value = tape[man.currentPosition].Value?.ToString() ?? "";
                if (customActions.TryGetValue((man.currentState, value), out StateExecuter executer))
                {
                    executer.execute(man);
                    dgv_nastro.ClearSelection();
                    dgv_nastro.Refresh();
                    Thread.Sleep(600);
                }
                else
                {
                    man.finito = true;
                    MessageBox.Show("Non è stata trovata nessuna istruzione per andare avanti.\n L'esecuzione è stata fermata.", "Macchina di Turing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            man.listTape[man.currentPosition].Style.BackColor = Color.Empty;
            dgv_nastro.Refresh();
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
