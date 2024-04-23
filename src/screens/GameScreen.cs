namespace QuickType.Screens {
    
    class GameScreen : IScreen {

        string input;
        QuickType master;

        public GameScreen(QuickType master) {
            this.input = "";
            this.master = master;
        }

        public void init() {
            Console.Clear();
            Console.WriteLine("Starting Game...");

            input = Console.ReadLine();
        }
    }
}