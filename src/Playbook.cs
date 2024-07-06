using System;
using System.Collections;

namespace QuickTypeGame.PlaybookClass {
    
    class Playbook : IEnumerable {

        private string text;
        private string title;
        public string Title {get {return title;}}
	private int lineLength;
	public int LineLength {get {return lineLength;}}
	public int CharLength {get {return text.Length;}}

        public Playbook(string text, string title) {
            
            this.text = text;
            this.title = title;
	    this.lineLength = 0;
	    foreach (var i in this) {
		    lineLength++;
	    }

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
