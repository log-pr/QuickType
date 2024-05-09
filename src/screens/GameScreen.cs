namespace QuickType.Screens {
    
    class GameScreen : IScreen {

        private QuickType master;
        private bool gamemodeIsSelected;

        public GameScreen(QuickType master) {

            this.master = master;
            gamemodeIsSelected = false;

        }

        public void Show() {

            Console.WriteLine("Starting Game...");

        }

        private ShowStart() 

        public void ProcessCommand(string input) {

        }
    }
}