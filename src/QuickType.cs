using QuickType.Screens;

namespace QuickType {
    
    class QuickType {

        IScreen currScreen;
        string username;

        public QuickType() {

            currScreen = new MainMenuScreen(this);

        }

        public void start() {

            currScreen.init();

        }

        public void setScreen(IScreen screen) {

            currScreen = screen;

        }

        public void setUsername(string name) {

            this.username = name.Substring(0, 12);

        }

        static void Main(string[] args){

            var master = new QuickType();
            master.start();

        }
    }
}
