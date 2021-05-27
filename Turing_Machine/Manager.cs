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
        public int previousPosition;
        public int currentPosition;
        public string currentState;
        public List<DataGridViewTextBoxCell> listTape;
        public bool finito;
        public Manager(List<DataGridViewTextBoxCell> myListTape)
        {
            listTape = myListTape;
            finito = false;
            previousPosition = currentPosition;
        }
    }
}
