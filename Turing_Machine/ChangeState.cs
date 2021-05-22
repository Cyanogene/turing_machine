using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine
{
    class ChangeState : ICommand
    {
        public int stato;

        public ChangeState(int newStato)
        {
            stato = newStato;
        }
        void ICommand.execute(Manager man)
        {
            man.currentState = stato;
        }
    }
}
