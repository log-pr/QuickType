using QuickTypeGame.PlaybookClass;

namespace QuickTypeGame.Screens {
    
    class PreGameScreen : IScreen {

        private QuickType master;
        private bool gamemodeIsSelected;
        private bool playbookIsSelected;

        public PreGameScreen(QuickType master) {

            this.master = master;
            gamemodeIsSelected = true; //will need to be changed to 'false' once more gamemodes are added, but right now gamemode selection is not needed
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
                int i = 1;
                foreach (Playbook p in master.Playbooks) {
                    Console.WriteLine(i++.ToString()+") "+p.Title);
		    Console.WriteLine("\t("+p.LineLength.ToString()+" lines, "+p.CharLength+" characters)");
                }
                Console.WriteLine();

            } else if (gamemodeIsSelected && playbookIsSelected) {

                Console.WriteLine("Press Enter to begin or type 'b' to go back.");
                Console.WriteLine();

            } else {
                //this should theoretically never occur
                Console.WriteLine("Something went wrong. Please restart the program.");
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
                    playbookIsSelected = true;
                    
                }

            } else if (gamemodeIsSelected && playbookIsSelected) {

                if (input == "b") {

                    gamemodeIsSelected = false;
                    master.activePlaybook = new("","");
                    playbookIsSelected = false;

                } else if (input == "") {

                    master.CurrScreen = new GameScreen(master);

                }

            } else {
                
                //theoretically should never occur but may need to add a failsafe of some sort here

            }

        }
    }
}
