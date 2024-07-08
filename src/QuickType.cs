using QuickTypeGame.Screens;
using QuickTypeGame.PlaybookClass;
using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography;

namespace QuickTypeGame {
    
    class QuickType {

        public IScreen CurrScreen {get; set;}

        private string prsText;
        public string PrsText {get {return prsText;}}

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

        private List<Playbook> playbooks;
        public List<Playbook> Playbooks {get {return playbooks ?? [];}}

        public Playbook activePlaybook;

        private string currentDirectory;

        public QuickType() {

            CurrScreen = new MainMenuScreen(this);
            message = "";
            input = "";
            currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ""; //possibly needs to be .GetEntryAssembly() or GetCallingAssembly() instead	    

	    //init PRS file, read if exists or create if it does not
	    string prsPath = Path.Combine(currentDirectory, "../../../prs");
	    if (File.Exists(prsPath)) {
		prsText = File.ReadAllText(prsPath);
	    } else {
	    	File.WriteAllText(prsPath, "");
		prsText = "";
	    }

            playbooks = [];
            activePlaybook = new("", "");
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
            playbooks = [];

            string playbookFolder = Path.Combine(currentDirectory, "../../../playbooks/");
            DirectoryInfo d = new(playbookFolder);

            foreach (var file in d.GetFiles()) {

                string text = File.ReadAllText(file.FullName);
                string title = file.Name;
                playbooks.Add(new Playbook(text, title));
                
            }
        }

        static void Main(string[] args){

            var master = new QuickType();
            master.Play();

        }
    }
}
