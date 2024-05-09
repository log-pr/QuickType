namespace QuickType.Screens {
    
    class GameScreen : IScreen {

        private QuickType master;
        private bool gamemodeIsSelected;
        private bool playBookIsSelected;

        public GameScreen(QuickType master) {

            this.master = master;
            gamemodeIsSelected = false;
            playBookIsSelected = false;

        }

        public void Show() {

            if (!gamemodeIsSelected) {

                Console.WriteLine("Starting Game...");
                Console.WriteLine();
                Console.WriteLine("Select a Gamemode:");
                Console.WriteLine();
                Console.WriteLine("     s -- Standard");
                Console.WriteLine();

            } else if ({



            }
            

        }

        public void ProcessCommand(string input) {

        }
    }
}