namespace Dictionary
{
    partial class DictionaryInterface
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
            this.components = new System.ComponentModel.Container();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.word = new System.Windows.Forms.Label();
            this.definitionsDisplayer = new System.Windows.Forms.TextBox();
            this.redo = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(885, 16);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(215, 56);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(74, 16);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(783, 56);
            this.searchBar.TabIndex = 5;
            this.searchBar.TextChanged += new System.EventHandler(this.search_bar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultContainer);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.searchBar);
            this.panel2.Controls.Add(this.word);
            this.panel2.Controls.Add(this.definitionsDisplayer);
            this.panel2.Location = new System.Drawing.Point(47, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 603);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // resultContainer
            // 
            this.resultContainer.BackColor = System.Drawing.SystemColors.Control;
            this.resultContainer.Location = new System.Drawing.Point(74, 78);
            this.resultContainer.Name = "resultContainer";
            this.resultContainer.Size = new System.Drawing.Size(783, 19);
            this.resultContainer.TabIndex = 0;
            this.resultContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.result_container_Paint);
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word.Location = new System.Drawing.Point(30, 94);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(159, 69);
            this.word.TabIndex = 1;
            this.word.Text = "word";
            this.word.Click += new System.EventHandler(this.word_Click);
            // 
            // definitionsDisplayer
            // 
            this.definitionsDisplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.definitionsDisplayer.Location = new System.Drawing.Point(42, 166);
            this.definitionsDisplayer.Multiline = true;
            this.definitionsDisplayer.Name = "definitionsDisplayer";
            this.definitionsDisplayer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.definitionsDisplayer.Size = new System.Drawing.Size(1058, 418);
            this.definitionsDisplayer.TabIndex = 7;
            // 
            // redo
            // 
            this.redo.Location = new System.Drawing.Point(89, 4);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(80, 36);
            this.redo.TabIndex = 9;
            this.redo.Text = "Redo";
            this.redo.UseVisualStyleBackColor = true;
            this.redo.Click += new System.EventHandler(this.button1_Click);
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(3, 4);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(80, 36);
            this.undo.TabIndex = 10;
            this.undo.Text = "Undo";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DictionaryInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.undo);
            this.Controls.Add(this.redo);
            this.Controls.Add(this.panel2);
            this.Name = "DictionaryInterface";
            this.Size = new System.Drawing.Size(1230, 687);
            this.Load += new System.EventHandler(this.DictionaryInterface_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel resultContainer;
        private System.Windows.Forms.Button redo;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.TextBox definitionsDisplayer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
    }
}
