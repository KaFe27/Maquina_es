namespace Ucu.Poo.Fsm
{
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

        public PlaySymbol Play { get; }

        public PauseSymbol Pause { get; }

        public StopSymbol Stop { get; }
    }
}