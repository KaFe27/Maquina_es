using System;

namespace Ucu.Poo.Fsm
{
    /// <summary>
    /// Representa el estado en el que la reproducción está detenida temporalmente.
    /// </summary>
    public class Paused : State
    {
        /// <summary>
        /// Muestra un mensaje al entrar en el estado de pausa.
        /// </summary>
        public override void OnEnter()
        {
            Console.WriteLine("Reproducción en pausa");
        }
    }
}