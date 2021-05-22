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
        public int currentState;
        public List<string> listTape;
        public Label tape;
        public Label pointer;
        public Manager(Label myTape, Label myPointer)
        {
            tape = myTape;
            pointer = myPointer;
        }
    }
}
