namespace Ucu.Poo.Fsm
{
    /// <summary>
    /// Representa un reproductor de música modelado como una máquina de estados.
    /// Tiene tres estados (stopped, playing y paused) y responde a los
    /// botones Play, Pause y Stop.
    /// </summary>
    public class MusicPlayer : StateMachine
    {
        public MusicPlayer()
        {
            this.Play = new PlaySymbol();
            this.Pause = new PauseSymbol();
            this.Stop = new StopSymbol();

            Stopped stopped = new Stopped();
            Playing playing = new Playing();
            Paused paused = new Paused();

            stopped.AddTransition(this.Play, playing);
            playing.AddTransition(this.Pause, paused);
            playing.AddTransition(this.Stop, stopped);
            paused.AddTransition(this.Play, playing);
            paused.AddTransition(this.Stop, stopped);

            this.AddToAlphabet(this.Play);
            this.AddToAlphabet(this.Pause);
            this.AddToAlphabet(this.Stop);

            this.AddState(stopped);
            this.AddState(playing);
            this.AddState(paused);
        }

        /// <summary>
        /// Obtiene el símbolo que representa el botón Play.
        /// </summary>
        public PlaySymbol Play { get; }

        /// <summary>
        /// Obtiene el símbolo que representa el botón Pause.
        /// </summary>
        public PauseSymbol Pause { get; }

        /// <summary>
        /// Obtiene el símbolo que representa el botón Stop.
        /// </summary>
        public StopSymbol Stop { get; }
    }
}