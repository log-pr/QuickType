namespace QuickType.Screens {
    
    class GameScreen : IScreen {

        QuickType master;

        public GameScreen(QuickType master) {

            this.master = master;

        }

        public void Show() {

            Console.WriteLine("Starting Game...");

        }



        public void ProcessCommand(string input) {

        }
    }
}