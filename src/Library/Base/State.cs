using System.Collections.Generic;

namespace Ucu.Poo.Fsm
{
    /// <summary>
    /// Representa un estado de la máquina de estados. Conoce las transiciones
    /// que salen de él y puede ejecutar acciones al entrar y al salir.
    /// </summary>
    public class State
    {
        private List<Transition> transitions = new List<Transition>();

        /// <summary>
        /// Agrega una transición que sale de este estado.
        /// </summary>
        public void AddTransition(InputSymbol symbol, State nextState)
        {
            Transition transition = new Transition(symbol, nextState);
            this.transitions.Add(transition);
        }

         /// <summary>
        /// Obtiene el próximo estado según el símbolo recibido.
        /// </summary>
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

        /// <summary>
        /// Se ejecuta cuando la máquina entra en este estado.
        /// </summary>
        public virtual void OnEnter()
        {
        }

         /// <summary>
        /// Se ejecuta cuando la máquina sale de este estado.
        /// </summary>
        public virtual void OnExit()
        {
        }
    }
}