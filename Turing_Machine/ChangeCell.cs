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
        void ICommand.Execute(Manager man)
        {
            man.listTape[man.currentPosition].Value = contenuto;
        }
    }
}
