using QuickType.Screens;

namespace QuickType {
    
    class QuickType {

        static void Main(string[] args){

            var master = new QuickType();
            master.start();

        }

        void start(){

            IScreen currScreen = new MainMenuScreen(this);
            currScreen.init();
            
        }
    }
}
