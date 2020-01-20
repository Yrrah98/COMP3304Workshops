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
    public partial class FishyNote : Form
    {

        public FishyNote()
        {
            InitializeComponent();
        }

        /// <summary>
        /// METHOD: Closes the note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
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


            if (this.textBox1.Visible)
            {
                this.textBox1.Visible = false;
                this.Height = _minHeight;
            }
            else
            {
                this.textBox1.Visible = true;
                this.Height = _normHeight;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }
    }
}
