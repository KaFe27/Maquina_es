using System;

namespace Ucu.Poo.Fsm
{
    /// <summary>
    /// Representa el estado en el que no hay ninguna canción reproduciéndose.
    /// </summary>
    public class Stopped : State
    {
        /// <summary>
        /// Muestra un mensaje al entrar en el estado detenido.
        /// </summary>
        public override void OnEnter()
        {
            Console.WriteLine("Reproductor detenido");
        }
    }
}