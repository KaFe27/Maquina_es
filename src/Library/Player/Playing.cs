using System;

namespace Ucu.Poo.Fsm
{
    /// <summary>
    /// Representa el estado en el que se está reproduciendo una canción.
    /// </summary>
    public class Playing : State
    {
        /// <summary>
        /// Muestra un mensaje al entrar en el estado de reproducción.
        /// </summary>
        public override void OnEnter()
        {
            Console.WriteLine("Reproduciendo canción");
        }
    }
}