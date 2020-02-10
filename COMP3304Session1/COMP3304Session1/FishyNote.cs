using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static COMP3304Session1.Delegates;

namespace COMP3304Session1
{
    public partial class FishyNote : Form
    {
        // DECLARE bool, _collapsed to store a boolean to say whether the note has been minimised or not 
        private bool _collapsed;
        // DECLARE delegate called _rmvNote, will contain a reference to remove note delegate
        private RemoveNote _rmvNote;

        private ReplaceNote _rplcNote;

        private RetrieveNote _rtrvNote;

        private int _uid;

        public FishyNote(RemoveNote rmvNote, ReplaceNote rplcNote, RetrieveNote rtrvNote, int pUID)
        {
            // INITALISE
            _collapsed = true;

            InitializeComponent();

            // SET _rmvNote as rmvNote paramater
            _rmvNote = rmvNote;
            // SET _rplcNote as rplcNote paramater
            _rplcNote = rplcNote;
            // SET _rtrvNote as rtrvNote paramater
            _rtrvNote = rtrvNote;
            // SET _uid as pUID paramater
            _uid = pUID;
            // CALL _rplcNote and insert "enter text here", sending the _uid of this note
            _rplcNote("enter text here", _uid);

            this.textBox1.Text = _rtrvNote(_uid);


        }

        /// <summary>
        /// METHOD: Closes the note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {

            _rmvNote(this, _uid);
        }

        /// <summary>
        /// METHOD: This method will expand the FishNote, keeping the expand button and delete button on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimiseButton_Click(object sender, EventArgs e)
        {

            // DECLARE local variable: int, _minHeight stores a height based on a percentage of expanded window height
            int _minHeight = this.Height/8;

            // DECLARE local variable: int, _normHeight stores the normal height of the window.
            int _normHeight = 450;



            // IF _collapsed is true
            if (_collapsed)
            {
                // SET text box visibility to false (make it not visible)
                // SET Height to _minHeight variable
                // SET _collapsed to false
                this.textBox1.Visible = false;
                this.Height = _minHeight;
                _collapsed = false;
            }
            else
            {
                // SET text box visibility to true
                // SET Height to _normHeight variable
                // SET _collapsed to true
                this.textBox1.Visible = true;
                this.Height = _normHeight;
                _collapsed = true;
            }
        }

        /// <summary>
        /// METHOD: textBox1_Click when the text box is clicked in, the auto text "disappears" - should have renamed class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Click(object sender, EventArgs e)
        {
            // CALL delegate to replace the note text, send the text in the texbox and this forms _uid
            _rplcNote(this.textBox1.Text, this._uid);
        }

        private void FishyNote_Load(object sender, EventArgs e)
        {

        }

        #region Code Snippet: makes this borderless window movable
        // Modified from https://stackoverflow.com/a/24561946 and attributed to user jay_t55

        // DECLARE a boolean that is set to true when a mouse down event is detected, call it _mouseDown:
        private bool _mouseDown = false;

        // DECLARE a Point object to store the last location of the window origin (ie memory), call it _lastLocation:
        private Point _lastLocation;

        // Mouse down event handler
        private void FishyNote_MouseDown(object sender, MouseEventArgs e)
        {
            // SET _mouseDown true:
            _mouseDown = true;

            // STORE current location to _lastLocation:
            _lastLocation = e.Location;
        }

        // Mouse move event handler
        private void FishyNote_MouseMove(object sender, MouseEventArgs e)
        {
            // Only act if mouse button is down...
            if (_mouseDown)
            {
                // SET new location according to mouse movement from _lastLocation:
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                // UPDATE this window:
                this.Update();
            }
        }

        // Mouse up event handler
        private void FishyNote_MouseUp(object sender, MouseEventArgs e)
        {
            // RESET _mouseDown to false:
            _mouseDown = false;
        }
        #endregion
    }
}
