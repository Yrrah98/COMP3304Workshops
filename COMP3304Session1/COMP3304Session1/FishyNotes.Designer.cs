namespace COMP3304Session1
{
    partial class FishyNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNote
            // 
            this.AddNote.Location = new System.Drawing.Point(35, 48);
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(145, 49);
            this.AddNote.TabIndex = 0;
            this.AddNote.Text = "More Fish!";
            this.AddNote.UseVisualStyleBackColor = true;
            this.AddNote.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // FishyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNote);
            this.Name = "FishyNotes";
            this.Text = "Fishy Notes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNote;
    }
}

