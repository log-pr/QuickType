namespace QuickType.Screens {

    class MainMenuScreen : IScreen {

        QuickType master;

        public MainMenuScreen(QuickType master) {

            this.master = master;

        }

        public void Show() {

            const int LeftSpacing = 15;
            const int RightSpacing = 20;

            Console.WriteLine(string.Format("{0}", "Welcome to QuickType!".PadLeft(LeftSpacing)));
            Console.WriteLine();
            Console.WriteLine("Choose a command:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(string.Format("{0} -- {1}", "s".PadLeft(LeftSpacing), "Start Game".PadRight(RightSpacing)));
            Console.WriteLine(string.Format("{0} -- {1}", "prs".PadLeft(LeftSpacing), "View the PR Sheet".PadRight(RightSpacing)));
            Console.WriteLine(string.Format("{0} -- {1}", "un <username>".PadLeft(LeftSpacing), "Set Username".PadRight(RightSpacing)));
            Console.WriteLine(string.Format("{0} -- {1}", "q".PadLeft(LeftSpacing), "Quit (Any Screen)".PadRight(RightSpacing)));
            Console.WriteLine();
            Console.WriteLine();

        }

        public void ProcessCommand(string input) {

            if (input == "s") {

                master.CurrScreen = new GameScreen(master);

            } else if (input == "prs") {

                master.message = "The PR sheet has been opened in your default text viewer application.";
                //System.Diagnostics.Process.Start(master.PrsPath());

            } else if (input.Substring(0,3) == "un ") {

                master.Username = input.Substring(3); //skips the first 3 characters so "un " is skipped
                master.message = "Username has been set to: " + master.Username;

            }
        }
    }
}