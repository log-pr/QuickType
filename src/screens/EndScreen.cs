namespace QuickType.Screens {
    
    class EndScreen : IScreen {

        public void init() {
            Console.Clear();
            Console.WriteLine("Game Over.");
        }

        public void processCommand(string input) {

        }        
    }
}