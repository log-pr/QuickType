namespace QuickType.Screens {
    
    class EndScreen : IScreen {

        public void show() {
            Console.Clear();
            Console.WriteLine("Game Over.");
        }

        public void processCommand(string input) {

        }        
    }
}