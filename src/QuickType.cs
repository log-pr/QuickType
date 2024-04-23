using QuickType.Screens;

namespace QuickType {
    
    class QuickType {

        IScreen currScreen;
        string username;

        public QuickType() {

            currScreen = new MainMenuScreen(this);

        }

        public void show() {

            currScreen.init();

        }

        public void setScreen(IScreen screen) {

            currScreen = screen;

        }

        public void setUsername(string name) {

            if (name.Length > 12) {
                this.username = name.Substring(0, 12);
            } else {
                this.username = name;
            }
            
        }

        public string getUsername() {

            return this.username;

        }

        static void Main(string[] args){

            var master = new QuickType();
            master.show();

        }
    }
}
