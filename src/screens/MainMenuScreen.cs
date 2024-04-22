namespace QuickType.Screens {

    class MainMenuScreen : IScreen {

        public void init() {
            Console.Clear();
            Console.WriteLine("Welcome to QuickType!");
            Console.WriteLine();
            Console.WriteLine("Choose a command:");
            Console.WriteLine("s -- Start Game");
            Console.WriteLine("prs -- View the PR Sheet");
            Console.WriteLine("un <username> -- Set Username");
            Console.WriteLine();
            string input = Console.ReadLine();
        }
    }
}