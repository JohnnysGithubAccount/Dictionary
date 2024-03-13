namespace Dictionary
{
    partial class searchResult
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wordDisplayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordDisplayer
            // 
            this.wordDisplayer.AutoSize = true;
            this.wordDisplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDisplayer.Location = new System.Drawing.Point(3, 9);
            this.wordDisplayer.Name = "wordDisplayer";
            this.wordDisplayer.Size = new System.Drawing.Size(116, 46);
            this.wordDisplayer.TabIndex = 0;
            this.wordDisplayer.Text = "Word";
            this.wordDisplayer.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.wordDisplayer);
            this.Name = "searchResult";
            this.Size = new System.Drawing.Size(783, 70);
            this.Load += new System.EventHandler(this.searchResult_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchResult_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.searchResult_MouseDoubleClick);
            this.MouseLeave += new System.EventHandler(this.searchResult_MouseLeave);
            this.MouseHover += new System.EventHandler(this.searchResult_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordDisplayer;
    }
}
