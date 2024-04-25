namespace QuickType.Screens {
    
    class GameScreen : IScreen {

        QuickType master;

        public GameScreen(QuickType master) {
            this.master = master;
        }

        public void show() {

            Console.Clear();
            Console.WriteLine("Starting Game...");

        }

        public void processCommand(string input) {

        }
    }
}