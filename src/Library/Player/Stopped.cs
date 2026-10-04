using System;

namespace Ucu.Poo.Fsm
{
    public class Stopped : State
    {
        public override void OnEnter()
        {
            Console.WriteLine("Reproductor detenido");
        }
    }
}