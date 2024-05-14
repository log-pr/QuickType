using QuickType.Screens;

namespace QuickType {
    
    class QuickType {

        public IScreen CurrScreen {get; set;}

        private string prsPath;
        public string PrsPath {get {return prsPath;}}

        public string message;
        
        private string input;
        public string Input {set {input = value;}}
        
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

        public QuickType() {

            CurrScreen = new MainMenuScreen(this);
            message = "";
            prsPath = "";
            input = "";

        }

        public void Play() {

            //The main loop of the game that runs for its entire duration after being initialized
            while (true) {

                Console.Clear();
                Console.WriteLine(message);
                message = "";
                Console.WriteLine();
                CurrScreen.Show();
                Console.Write(":");
                input = Console.ReadLine();
                if (input == "q") {break;}
                CurrScreen.ProcessCommand(input);

            }
            
        }

        static void Main(string[] args){

            var master = new QuickType();
            master.Play();

        }
    }
}
