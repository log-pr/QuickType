namespace QuickTypeGame.Screens {
    
    class EndScreen : IScreen {

        public void Show() {

            Console.WriteLine("Game Over. Press 'q' to quit.");
            Console.WriteLine();

        }

        public void ProcessCommand(string input) {

        }        
    }
}