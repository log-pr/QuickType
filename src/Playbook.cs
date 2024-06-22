using System;
using System.Collections;

namespace QuickTypeGame.PlaybookClass {
    
    class Playbook : IEnumerable {

        private string text;
        public Playbook(string text) {
            
            this.text = text;

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

        }

    }
}