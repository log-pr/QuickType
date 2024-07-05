using System.Collections;
using QuickTypeGame.PlaybookClass;

namespace QuickTypeGame.Screens {

    class GameScreen : IScreen {

        QuickType master;
        IEnumerator PBIter;
        bool isNotDone;

        public GameScreen(QuickType master) {

            this.master = master;

            //should always find a playbook in activePlaybook, but otherwise will just display no info then exit
            PBIter = master.activePlaybook.GetEnumerator() ?? new Playbook("", "").GetEnumerator();
            isNotDone = PBIter.MoveNext(); //MoveNext returns false when it reaches the end of the collection, isNotDone is tracking this for us so we know when to stop

        }

        public void Show() {

            Console.WriteLine(PBIter.Current);
            Console.WriteLine();

        }

        public void ProcessCommand(string input) {

            if (input == PBIter.Current as string) {

                isNotDone = PBIter.MoveNext(); //MoveNext returns False when itering is done so we know when to stop
                if (!isNotDone) {master.CurrScreen = new EndScreen();}

            } else {

                master.message = "Try again.";

            }
            
            

        }
    }
}