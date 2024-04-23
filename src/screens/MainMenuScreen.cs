namespace QuickType.Screens {

    class MainMenuScreen : IScreen {

        string input;
        QuickType master;

        public MainMenuScreen(QuickType master) {
            this.input = "";
            this.master = master;
        }

        public void init() {
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
            Console.WriteLine();
            Console.WriteLine();

            this.input = Console.ReadLine();
            this.processCommand();
        }

        private void processCommand() {
            if (input == "s") {
                master.setScreen(new GameScreen(master));
            } else if (input == "prs") {
                master.message = "The PR sheet has been opened in your default text viewer application.";
                //System.Diagnostics.Process.Start(master.getPRSPath());
            } else if (input.Substring(0,3) == "un ") {
                master.setUsername(input.Substring(3));
                master.message = "Username has been set to: " + master.getUsername();
            }
        }
    }
}