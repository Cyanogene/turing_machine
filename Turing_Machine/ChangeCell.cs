using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine
{
    class ChangeCell : ICommand
    {
        public string contenuto;
        public ChangeCell(string newContenuto)
        {
            contenuto = newContenuto;
        }
        void ICommand.execute(Manager man)
        {
            man.listTape[man.currentPosition] = contenuto;
        }
    }
}
