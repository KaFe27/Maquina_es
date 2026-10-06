using System.Collections.Generic;

namespace Ucu.Poo.Fsm
{

    /// <summary>
    /// Representa una máquina de estados finitos genérica. Conoce sus estados
    /// y el estado actual, y procesa símbolos de entrada.
    /// </summary>
    public class StateMachine
    {
        private List<State> states = new List<State>();

        private List<InputSymbol> alphabet = new List<InputSymbol>();

        /// <summary>
        /// Obtiene el estado actual de la máquina.
        /// </summary>
        public State CurrentState { get; private set; }

        /// <summary>
        /// Agrega un símbolo al alfabeto de la máquina.
        /// </summary>
        public void AddToAlphabet(InputSymbol symbol)
        {
            this.alphabet.Add(symbol);
        }

        /// <summary>
        /// Agrega un estado a la máquina. El primer estado agregado es el estado inicial.
        /// </summary>
        public void AddState(State state)
        {
            this.states.Add(state);

            if (this.CurrentState == null)
            {
                this.CurrentState = state;
            }
        }

        /// <summary>
        /// Procesa un símbolo de entrada y, si corresponde, cambia de estado.
        /// </summary>
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

        /// <summary>
        /// Procesa una secuencia de símbolos de entrada, uno a continuación del otro.
        /// </summary>
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