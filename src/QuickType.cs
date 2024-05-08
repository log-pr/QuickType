using QuickType.Screens;

namespace QuickType {
    
    class QuickType {

        public IScreen CurrScreen {get; set;}

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

        private string prsPath;
        public string PrsPath {get;}
        public string Message {get; set;}
        
        private string input;
        public string Input {
            set {input = value;}
        }

        public QuickType() {

            CurrScreen = new MainMenuScreen(this);
            Message = "";
            prsPath = "";
            input = "";

        }

        public void play() {

            //The main loop of the game that runs for its entire duration after being initialized
            while (true) {

                Console.Clear();
                Console.WriteLine(Message);
                Message = "";
                Console.WriteLine();
                CurrScreen.show();
                Console.Write(":");
                Input = Console.ReadLine();
                CurrScreen.processCommand(input);

            }
            
        }

        static void Main(string[] args){

            var master = new QuickType();
            master.play();

        }
    }
}
