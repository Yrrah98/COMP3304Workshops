using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    public partial class FishyNotes : Form
    {
        // DECLARE Form called _newNote - Stores form which will be a new note
        private Form _newNote;
        // DECLARE IList<Form> called _notes - stores a list of forms, allowing multiple notes
        private IList<Form> _notes;

        

        private int uidIncrementer;

        private INoteData _noteData;

        public FishyNotes()
        {
            InitializeComponent();

            _notes = new List<Form>();

            _noteData = new NoteData();

            //_noteText = new Dictionary<int, String>();
        }

        /// <summary>
        /// METHOD: AddNote_Click, a method which will add a new fishyNote to the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote_Click(object sender, EventArgs e)
        {
            uidIncrementer++;
            // INSTANTIATE _newNote as a new type of FishyNote
            _newNote = new FishyNote(this.DeleteNote, this.ReplaceNote, this.RetrieveNote, uidIncrementer);

            _noteData.AddNote(uidIncrementer, "");
            

            // show the new note
            _newNote.Show();

            _notes.Add(_newNote);

            _newNote = null;
            
        }

        /// <summary>
        /// METHOD: ReplaceNote - to replace the text of the note in the dictionary
        /// </summary>
        /// <param name="txt"> the text which is to be stored in the dictionaries value</param>
        /// <param name="key"> the key/index of the form in the dictionary</param>
        private void ReplaceNote(String txt, int key)
        {
            // SET the text at the key value to the text passed in via parameter 
            ((ITextData)_noteData).Replace(key, txt);
        }

        /// <summary>
        /// METHOD: RetrieveNote, returns the value from an element in the dictionary
        /// </summary>
        /// <param name="key"> the key at which data will be found</param>
        /// <returns></returns>
        private String RetrieveNote(int key)
        {

            return ((ITextData)_noteData).Retrieve(key);

        }


        /// <summary>
        ///  METHOD: DeleteNote, delete the note from the list of notes
        /// </summary>
        /// <param name="args"> this will be the form which needs deleting</param>
        private void DeleteNote(Form args, int key)
        {
            _noteData.RemoveNote(key);

            // FOREACH note in the list
            foreach(Form f in _notes)
            {
                // IF the form is the form sent in 
                if (f == args)
                    // THEN dispose of that note
                    f.Dispose(); 
            }
            // REMOVE the note from the list
            _notes.Remove(args);
        }
    }
}
