using QuickTypeGame.PlaybookClass;

namespace QuickTypeGame.Screens {

    class GameScreen : IScreen {

        QuickType master;

        public GameScreen(QuickType master) {

            this.master = master;

        }

        public void Show() {}

        public void ProcessCommand(string input) {}
    }
}