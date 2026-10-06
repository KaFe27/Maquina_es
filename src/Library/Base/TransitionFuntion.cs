namespace Ucu.Poo.Fsm
{
    /// <summary>
    /// Representa una transición entre estados: indica qué símbolo la dispara
    /// y a qué estado lleva.
    /// </summary>
    public class TransitionFunction
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Transition"/>.
        /// </summary>
        public TransitionFunction(InputSymbol triggerSymbol, State nextState)
        {
            this.TriggerSymbol = triggerSymbol;
            this.NextState = nextState; 
        }
        /// <summary>
        /// Obtiene el símbolo que dispara la transición.
        /// </summary>     

        public InputSymbol TriggerSymbol { get; }

        /// <summary>
        /// Obtiene el estado al que lleva la transición.
        /// </summary>
        public State NextState { get; }
        
        /// <summary>
        /// Indica si el símbolo recibido dispara esta transición.
        /// </summary>
        public bool IsTriggeredBy(InputSymbol symbol)
        {
            return this.TriggerSymbol == symbol;
        }
    }
}