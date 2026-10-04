namespace Ucu.Poo.Fsm
{
    public class TransitionFunction
    {
        public TransitionFunction(InputSymbol triggerSymbol, State nextState)
        {
            this.TriggerSymbol = triggerSymbol;
            this.NextState = nextState; 
        }      

        public InputSymbol TriggerSymbol { get; }

        public State NextState { get; }

        public bool IsTriggeredBy(InputSymbol symbol)
        {
            return this.TriggerSymbol == symbol;
        }
    }
}