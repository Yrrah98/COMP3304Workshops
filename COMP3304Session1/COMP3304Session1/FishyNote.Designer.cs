namespace COMP3304Session1
{
    partial class FishyNote
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MinimiseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(780, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(769, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(24, 26);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "X";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MinimiseButton
            // 
            this.MinimiseButton.BackColor = System.Drawing.Color.Blue;
            this.MinimiseButton.Location = new System.Drawing.Point(13, 12);
            this.MinimiseButton.Name = "MinimiseButton";
            this.MinimiseButton.Size = new System.Drawing.Size(115, 43);
            this.MinimiseButton.TabIndex = 2;
            this.MinimiseButton.Text = "Minimise";
            this.MinimiseButton.UseVisualStyleBackColor = false;
            this.MinimiseButton.Click += new System.EventHandler(this.MinimiseButton_Click);
            // 
            // FishyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.MinimiseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FishyNote";
            this.Text = "FishyNote";
            this.Load += new System.EventHandler(this.FishyNote_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button MinimiseButton;
    }
}