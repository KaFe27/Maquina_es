using System;

namespace Ucu.Poo.Fsm
{
    public class Paused : State
    {
        public override void OnEnter()
        {
            Console.WriteLine("Reproducción en pausa");
        }
    }
}