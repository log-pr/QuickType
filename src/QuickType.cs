using QuickType.Screens;

namespace QuickType {
    
    class QuickType {

        IScreen currScreen;
        string username;
        string prsPath;
        public string message;

        public QuickType() {

            currScreen = new MainMenuScreen(this);
            message = "";
            prsPath = "";

        }

        public void show() {

            while (true) {
                Console.Clear();
                Console.WriteLine(message);
                message = "";
                Console.WriteLine();
                currScreen.init();
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
            master.show();

        }
    }
}
