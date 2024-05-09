namespace QuickType.Screens {
    
    interface IScreen {

        void show(); //method that displays the primary text output of the screen
        void processCommand(string input); //method that processes each command that the user inputs
        
    }

}
