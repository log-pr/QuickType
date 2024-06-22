using QuickTypeGame.Screens;
using QuickTypeGame.PlaybookClass;
using System.ComponentModel;

namespace QuickTypeGame {
    
    class QuickType {

        public IScreen CurrScreen {get; set;}

        private string prsPath;
        public string PrsPath {get {return prsPath;}}

        public string message;
        
        private string input;
        public string Input {set {input = value;}}
        
        private string? username;
        public string? Username {
            get {return username;}
            set {
                if (value != null && value.Length > 12) {
                    username = value.Substring(0, 12);
                } else {
                    username = value;
                }
            }
        }

        private Playbook[]? playbooks;

        public QuickType() {

            CurrScreen = new MainMenuScreen(this);
            message = "";
            prsPath = "";
            input = "";
            InitPlaybooks();

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
                input = Console.ReadLine() ?? "";
                if (input == "q") {break;}
                CurrScreen.ProcessCommand(input);

            }
            
        }

        void InitPlaybooks() {
            //for each playbook txt file, create a Playbook instance for it
        }

        static void Main(string[] args){

            var master = new QuickType();
            master.Play();

        }
    }
}
