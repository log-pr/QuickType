using QuickType.Screens;

namespace QuickType {
    
    class QuickType {

        IScreen currScreen;

        public QuickType() {

            currScreen = new MainMenuScreen(this);

        }

        public void start() {

            currScreen.init();

        }

        public void setScreen(IScreen screen) {

            currScreen = screen;

        }

        static void Main(string[] args){

            var master = new QuickType();
            master.start();

        }
    }
}
