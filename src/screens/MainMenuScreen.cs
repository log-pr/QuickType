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
            Console.Clear();
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
            if (this.input == "s") {
                master.setScreen(new GameScreen());
                master.start();
            } else if (this.input == "prs") {
                Console.WriteLine("PR Sheet");
            } else if (this.input == "un") {
                Console.WriteLine("Username");
            }
        }
    }
}