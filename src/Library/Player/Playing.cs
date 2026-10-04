using System;

namespace Ucu.Poo.Fsm
{
    public class Playing : State
    {
        public override void OnEnter()
        {
            Console.WriteLine("Reproduciendo canción");
        }
    }
}