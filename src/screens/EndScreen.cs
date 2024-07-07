namespace QuickTypeGame.Screens {
    
    class EndScreen : IScreen {

	private QuickType master;

	public EndScreen(QuickType master) {

		this.master = master;

	}

        public void Show() {

            Console.WriteLine("Game Over.");
            Console.WriteLine();
	    Console.WriteLine("Enter 'q' to quit.");
	    Console.WriteLine("Enter 'r' to restart the playbook.");
	    Console.WriteLine("Enter 'n' to start a new game.");
            Console.WriteLine();
        }

        public void ProcessCommand(string input) {
	
	    if (input == "r") {master.CurrScreen = new GameScreen(master);}

	    if (input == "n") {master.CurrScreen = new PreGameScreen(master);}

        }        
    }
}
