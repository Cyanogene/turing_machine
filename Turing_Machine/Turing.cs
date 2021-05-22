using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turing_Machine
{
    /// <summary>
    /// DA AGGIUNGERE VARIE FORMATTAZIONI (SISTEMARE POSIZIONE PUNTATORE, AGGIORNARE DI PIU'
    /// </summary>

    class Turing
    {
        Label tape;
        Label pointer;
        // Inventare sintassi
        public Turing(Label myTape, Label myPointer)
        {
            tape = myTape;
            pointer = myPointer;
        }
        public void BinaryAddition(List<string> listTape)
        {
            tape.Refresh();
            int stato = 0;
            int pos = 1;
            bool finito = false;

            Thread.Sleep(100);
            while (!finito)
            {
                switch (stato)
                {
                    case 0:
                        if (listTape[pos] == " ")
                        {
                            stato = 1;
                        }
                        pos++;
                        pointer.Left += 13;
                        break;

                    case 1:
                        if (listTape[pos] == " ")
                        {
                            stato = 2;
                            pos--;
                            pointer.Left -= 13;
                        }

                        else
                        {
                            pos++;
                            pointer.Left += 13;
                        }

                        tape.Text = "";
                        listTape.ForEach(Print);
                        tape.Refresh();
                        break;

                    case 2:
                        if (listTape[pos] == "1")
                        {
                            stato = 3;
                            listTape[pos] = "0";
                            pos--;
                            pointer.Left -= 13;
                        }

                        else if (listTape[pos] == "0")
                        {
                            listTape[pos] = "1";
                            pos--;
                            pointer.Left -= 13;
                        }

                        else
                        {
                            stato = 5;
                            pos++;
                            pointer.Left += 13;
                        }

                        tape.Text = "";
                        listTape.ForEach(Print);
                        tape.Refresh();
                        break;

                    case 3:
                        if (listTape[pos] == " ")
                        {
                            stato = 4;
                        }

                        pos--;
                        pointer.Left -= 13;
                        break;

                    case 4:
                        if (listTape[pos] == "1")
                        {
                            listTape[pos] = "0";
                            pos--;
                            pointer.Left -= 13;
                        }

                        else if (listTape[pos] == "0")
                        {
                            stato = 0;
                            listTape[pos] = "1";
                            pos++;
                            pointer.Left += 13;
                        }

                        else
                        {
                            stato = 0;
                            listTape[pos] = "1";
                            pos += 2;
                            listTape.Insert(0, " ");
                            pointer.Left += 13;
                        }

                        tape.Text = "";
                        listTape.ForEach(Print);
                        tape.Refresh();
                        break;

                    case 5:
                        if (listTape[pos] == "1")
                        {
                            listTape[pos] = "";
                            pos++;
                            pointer.Left += 13;
                        }
                        else
                        {
                            finito = true;
                        }

                        tape.Text = "";
                        listTape.ForEach(Print);
                        tape.Refresh();
                        break;
                }

                Thread.Sleep(600);
            }
            pointer.Left = tape.Left+1;
        }

        public void Print(string s)
        {
            tape.Text += s;
        }
        //tape.Text = "";
        //                listTape.ForEach(Print);
        //                pos--;
        //                tape.Refresh();
        //                pointer.Left -= 14;


    }
}
