namespace QuickType.Screens {
    
    class GameScreen : IScreen {

        QuickType master;

        public GameScreen(QuickType master) {
            this.input = "";
            this.master = master;
        }

        public void init() {

            Console.Clear();
            Console.WriteLine("Starting Game...");

        }

        public void processCommand(string input) {

        }
    }
}