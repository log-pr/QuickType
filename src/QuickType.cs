using QuickType.Screens;

namespace QuickType {
    
    class QuickType {

        IScreen currScreen;
        string username;
        string prsPath;
        public string message;
        string input;

        public QuickType() {

            currScreen = new MainMenuScreen(this);
            message = "";
            prsPath = "";
            input = "";

        }

        public void play() {

            while (true) {
                Console.Clear();
                Console.WriteLine(message);
                message = "";
                Console.WriteLine();
                currScreen.show();
                input = Console.ReadLine();
                currScreen.processCommand(input);
            }
            
        }

        public void setScreen(IScreen screen) {

            currScreen = screen;

        }

        public void setUsername(string name) {

            if (name.Length > 12) {
                username = name.Substring(0, 12);
            } else {
                username = name;
            }
            
        }

        public string getUsername() {

            return username;

        }

        public string getPRSPath() {

            return prsPath;

        }

        static void Main(string[] args){

            var master = new QuickType();
            master.play();

        }
    }
}
