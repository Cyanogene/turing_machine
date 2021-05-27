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

    class Turing
    {
        public void BinaryAddition(List<DataGridViewTextBoxCell> listTape, DataGridView dataGrid)
        {
            int stato = 0;
            int pos = 1;
            bool finito = false;
            int tempPos = pos;
            Thread.Sleep(100);
            while (!finito)
            {
                if (tempPos >= 0 && tempPos <= listTape.Count - 1)
                    listTape[tempPos].Style.BackColor = Color.Empty;

                string s = listTape[pos].Value?.ToString() ?? "";
                listTape[pos].Style.BackColor = Color.Cyan;
                tempPos = pos;
                switch (stato)
                {
                    case 0:
                        if (s == "")
                        {
                            stato = 1;
                        }
                        pos++;
                        break;

                    case 1:
                        if (s == "")
                        {
                            stato = 2;
                            pos--;
                        }

                        else
                        {
                            pos++;
                        }
                        break;

                    case 2:
                        if (s == "1")
                        {
                            stato = 3;
                            listTape[pos].Value = "0";
                            pos--;
                        }

                        else if (s == "0")
                        {
                            listTape[pos].Value = "1";
                            pos--;
                        }

                        else
                        {
                            stato = 5;
                            pos++;
                        }
                        break;

                    case 3:
                        if (s == "")
                        {
                            stato = 4;
                        }
                        pos--;
                        break;

                    case 4:
                        if (s == "1")
                        {
                            listTape[pos].Value = "0";
                            pos--;
                        }

                        else if (s == "0")
                        {
                            stato = 0;
                            listTape[pos].Value = "1";
                            pos++;
                        }

                        else
                        {
                            stato = 0;
                            listTape[pos].Value = "1";
                            pos += 2;
                            tempPos += 1;
                            dataGrid.Columns.Insert(0, new DataGridViewColumn() { CellTemplate = new DataGridViewTextBoxCell() });
                            listTape.Insert(0, new DataGridViewTextBoxCell());
                        }
                        break;

                    case 5:
                        if (s == "1")
                        {
                            listTape[pos].Value = "";
                            pos++;
                        }
                        else
                        {
                            finito = true;
                        }
                        break;
                }
                dataGrid.ClearSelection();
                dataGrid.Refresh();
                Thread.Sleep(600);
            }
            listTape[pos].Style.BackColor = Color.Empty;
        }
    }
}
