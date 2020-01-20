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

        private Form _newNote;

        public FishyNotes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// METHOD: AddNote_Click, a method which will add a new fishyNote to the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote_Click(object sender, EventArgs e)
        {
            // INSTANTIATE _newNote as a new type of FishyNote
            _newNote = new FishyNote();

            // IF _newNote is null OR _newNote has been disposed
            if(_newNote != null || _newNote.IsDisposed)
                // show the new note
                _newNote.Show();
        }
    }
}
