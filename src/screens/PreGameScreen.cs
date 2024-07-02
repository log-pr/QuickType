using QuickTypeGame.PlaybookClass;

namespace QuickTypeGame.Screens {
    
    class PreGameScreen : IScreen {

        private QuickType master;
        private bool gamemodeIsSelected;
        private bool playbookIsSelected;

        public PreGameScreen(QuickType master) {

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

                int input_int;

                //checks the input to make sure that it is a number, if it is not then nothing happens
                try {
                    input_int = Int32.Parse(input);
                } catch {
                    input_int = 0;
                }

                if (input_int <= master.Playbooks.Count && input_int >= 1) {
                    master.activePlaybook = master.Playbooks[input_int-1];
                    master.message = "Playbook \""+master.activePlaybook.Title+"\" has been selected.";
                }

                

            }

        }
    }
}