using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    class NoteData : INoteData, ITextData
    {

        private IDictionary<int, String> _noteText;

        public NoteData()
        {

            _noteText = new Dictionary<int, String>();

        }

        public void AddNote(int key, String txt)
        {
            _noteText[key] = txt;

        }

        public void RemoveNote(int key)
        {
            _noteText.Remove(key);
        }

        public String Retrieve(int key)
        {

            // IF the dictionary contains the key passed in
            if (_noteText.ContainsKey(key))
                // THEN return the value found at the specified element 
                return _noteText[key];
            else
                // THEN return a message stating the lack of existing element
                return null;

        }

        public void Replace(int key, String replacementTxt)
        {
            _noteText[key] = replacementTxt;
        }
    }
}
