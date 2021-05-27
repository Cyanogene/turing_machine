using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine
{
    class StateExecuter
    {
        public List<ICommand> actions = new List<ICommand>();
        public StateExecuter(string azioni)
        {
            string[] splitted = azioni.Split(',', '=');
            foreach (var item in splitted)
            {
                if (item == "<")
                    actions.Add(new MoveLeft());
                else if (item == ">")
                    actions.Add(new MoveRight());
                else if (item.ToUpper() == "STOP")
                    actions.Add(new Stop());
                else if (item.ToUpper().StartsWith("S"))
                    actions.Add(new ChangeState(item));
                else if (char.IsDigit(Convert.ToChar(item)))
                    actions.Add(new ChangeCell(item));
            }
        }

        public void execute(Manager man)
        {
            foreach (var item in actions)
            {
                item.Execute(man);
            }
        }
    }
}
