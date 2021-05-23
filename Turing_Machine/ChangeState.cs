using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine
{
    class ChangeState : ICommand
    {
        public string stato;

        public ChangeState(string newStato)
        {
            stato = newStato;
        }
        void ICommand.execute(Manager man)
        {
            man.currentState = stato;
        }
    }
}
