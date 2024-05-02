using QuickType.Screens;

namespace QuickType {
    
    class QuickType {

        private IScreen currScreen;
        public IScreen CurrScreen {
            set {currScreen = value;}
        }
        private string username;
        public string Username {
            get {return username;}
            set {
                if (value.Length > 12) {
                    username = value.Substring(0, 12);
                } else {
                    username = value;
                }
            }
        }
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

            //The main loop of the game that runs for its entire duration after being initialized
            while (true) {

                Console.Clear();
                Console.WriteLine(message);
                message = "";
                Console.WriteLine();
                currScreen.show();
                Console.Write(":");
                input = Console.ReadLine();
                currScreen.processCommand(input);

            }
            
        }

        public void setScreen(IScreen screen) {

            currScreen = screen;

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
