using System.Collections.Generic;

namespace Ucu.Poo.Fsm
{
    public class State
    {
        private List<Transition> transitions = new List<Transition>();

        public void AddTransition(InputSymbol symbol, State nextState)
        {
            Transition transition = new Transition(symbol, nextState);
            this.transitions.Add(transition);
        }

        public State GetNextState(InputSymbol symbol)
        {
            foreach (Transition transition in this.transitions)
            {
                if (transition.IsTriggeredBy(symbol))
                {
                    return transition.NextState;
                }
            }

            return null;
        }

        public virtual void OnEnter()
        {
        }

        public virtual void OnExit()
        {
        }
    }
}