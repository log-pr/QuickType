using QuickTypeGame.Screens;
using QuickTypeGame.PlaybookClass;
using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography;

namespace QuickTypeGame {
    
    class QuickType {

        public IScreen CurrScreen {get; set;}

        private string prsPath;

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

        private long time;
        public long Time {
            get {return time;}
            set {time = value;}
        }

        public QuickType() {

            CurrScreen = new MainMenuScreen(this);
            message = "";
            input = "";
            currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ""; //possibly needs to be .GetEntryAssembly() or GetCallingAssembly() instead	    

	        //init PRS file, read if exists or create if it does not
            //may change this later to not pull the prsText until the prs command is called
            //this would prevent a possible needless file read and then the prsText variable could be local instad of global
	        prsPath = Path.Combine(currentDirectory, "../../../prs.csv");
	        if (File.Exists(prsPath)) {
		        prsText = File.ReadAllText(prsPath);
	        } else {
	    	    File.WriteAllText(prsPath, "");
		        prsText = "";
	        }

	        //inits each playbook file in the playbook folder and creates a playbook object for each of them
            playbooks = [];
            activePlaybook = new("", "");
            string playbookFolder = Path.Combine(currentDirectory, "../../../playbooks/");
            DirectoryInfo d = new(playbookFolder);
            foreach (var file in d.GetFiles()) {
                string text = File.ReadAllText(file.FullName);
                string title = file.Name;
                playbooks.Add(new Playbook(text, title)); 
            }
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

        public void WriteScore() {

            string scoreString = activePlaybook.Title + "," + username + "," + time + "\n";
            prsText += scoreString;
            File.AppendAllText(prsPath, scoreString);

        }

        static void Main(string[] args){

            var master = new QuickType {message = "Welcome to QuickType!"};
            master.Play();

        }
    }
}
