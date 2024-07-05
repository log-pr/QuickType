using System;
using System.Collections;

namespace QuickTypeGame.PlaybookClass {
    
    class Playbook : IEnumerable {

        private string text;
        private string title;
        public string Title {
            get {return title;}
        }
        public Playbook(string text, string title) {
            
            this.text = text;
            this.title = title;

        }

        public IEnumerator GetEnumerator() {

            string line = "";
            for (int i = 0; i < text.Length; i++){
                if (text[i] != '\n') {
                    line = line + text[i];
                } else {
                    yield return line;
                    line = "";   
                }
            
            }
            yield return line;
        }

    }
}