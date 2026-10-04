using System.Collections.Generic;

namespace Ucu.Poo.Fsm
{
    public class StateMachine
    {
        private List<State> states = new List<State>();

        private List<InputSymbol> alphabet = new List<InputSymbol>();

        public State CurrentState { get; private set; }

        public void AddToAlphabet(InputSymbol symbol)
        {
            this.alphabet.Add(symbol);
        }

        public void AddState(State state)
        {
            this.states.Add(state);

            if (this.CurrentState == null)
            {
                this.CurrentState = state;
            }
        }

        public bool ProcessInput(InputSymbol symbol)
        {
            if (!this.alphabet.Contains(symbol))
            {
                return false;
            }

            State nextState = this.CurrentState.GetNextState(symbol);

            if (nextState == null)
            {
                return false;
            }

            this.CurrentState.OnExit();
            this.CurrentState = nextState;
            this.CurrentState.OnEnter();

            return true;
        }

        public bool ProcessInputs(InputSymbol[] symbols)
        {
            bool allAccepted = true;

            foreach (InputSymbol symbol in symbols)
            {
                if (!this.ProcessInput(symbol))
                {
                    allAccepted = false;
                }
            }

            return allAccepted;
        }
    }
}