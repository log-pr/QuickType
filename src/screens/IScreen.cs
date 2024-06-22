namespace QuickTypeGame.Screens {
    
    interface IScreen {

        void Show(); //method that displays the primary text output of the screen
        void ProcessCommand(string input); //method that processes each command that the user inputs

    }

}
