using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turing_Machine
{
    class Manager
    {
        public int currentPosition;
        public string currentState;
        public List<string> listTape;
        public Label pointer;
        public bool finito;
        public Manager(Label myPointer, List<string> myListTape)
        {
            pointer = myPointer;
            listTape = myListTape;
            finito = false;
        }
    }
}
