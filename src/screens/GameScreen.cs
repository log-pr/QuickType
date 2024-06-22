using QuickTypeGame.PlaybookClass;

namespace QuickTypeGame.Screens {
    
    class GameScreen : IScreen {

        private QuickType master;
        private bool gamemodeIsSelected;
        private bool playbookIsSelected;

        public GameScreen(QuickType master) {

            this.master = master;
            gamemodeIsSelected = false;
            playbookIsSelected = false;

        }

        public void Show() {

            if (!gamemodeIsSelected) {

                Console.WriteLine("Starting Game...");
                Console.WriteLine();
                Console.WriteLine("Select a Gamemode:");
                Console.WriteLine();
                Console.WriteLine("     s -- Standard");
                Console.WriteLine();

            } else if (!playbookIsSelected) {

                Console.WriteLine("Starting Game...");
                Console.WriteLine();
                Console.WriteLine("Select a Playbook:");
                Console.WriteLine();
                //displaying all playbooks is somewhat hard to implement so I will do that later
                int i = 1;
                foreach (Playbook p in master.Playbooks) {
                    Console.WriteLine(i++.ToString()+" "+p.Title);
                }
                Console.WriteLine();

            }
            

        }

        public void ProcessCommand(string input) {

            if (!gamemodeIsSelected) {

                if (input == "s") {gamemodeIsSelected = true;}

            } else if (!playbookIsSelected) {



            }

        }
    }
}