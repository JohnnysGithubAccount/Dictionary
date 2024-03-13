namespace Dictionary
{
    partial class MainManagingForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reset_database = new System.Windows.Forms.Button();
            this.submenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wordInfosDisplayer = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordInfosDisplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reset_database);
            this.panel1.Controls.Add(this.submenu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 46);
            this.panel1.TabIndex = 4;
            // 
            // reset_database
            // 
            this.reset_database.Location = new System.Drawing.Point(1123, 0);
            this.reset_database.Name = "reset_database";
            this.reset_database.Size = new System.Drawing.Size(95, 46);
            this.reset_database.TabIndex = 4;
            this.reset_database.Text = "Reset Database";
            this.reset_database.UseVisualStyleBackColor = true;
            this.reset_database.Click += new System.EventHandler(this.button1_Click);
            // 
            // submenu
            // 
            this.submenu.Location = new System.Drawing.Point(0, 0);
            this.submenu.Name = "submenu";
            this.submenu.Size = new System.Drawing.Size(87, 46);
            this.submenu.TabIndex = 3;
            this.submenu.Text = "Submenu";
            this.submenu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delete";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Update";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wordInfosDisplayer);
            this.panel2.Location = new System.Drawing.Point(87, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 513);
            this.panel2.TabIndex = 7;
            // 
            // wordInfosDisplayer
            // 
            this.wordInfosDisplayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordInfosDisplayer.Location = new System.Drawing.Point(22, 17);
            this.wordInfosDisplayer.Name = "wordInfosDisplayer";
            this.wordInfosDisplayer.RowHeadersWidth = 51;
            this.wordInfosDisplayer.RowTemplate.Height = 24;
            this.wordInfosDisplayer.Size = new System.Drawing.Size(998, 474);
            this.wordInfosDisplayer.TabIndex = 0;
            this.wordInfosDisplayer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wordInfosDisplayer_CellClick);
            this.wordInfosDisplayer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wordInfosDisplayer_CellContentClick);
            this.wordInfosDisplayer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.wordInfosDisplayer_CellMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(835, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Display";
            // 
            // filter
            // 
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.FormattingEnabled = true;
            this.filter.Location = new System.Drawing.Point(958, 96);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(178, 39);
            this.filter.TabIndex = 9;
            this.filter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.filter.SelectionChangeCommitted += new System.EventHandler(this.filter_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Word display";
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(87, 97);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(360, 38);
            this.searchBar.TabIndex = 11;
            this.searchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainManagingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 730);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainManagingForm";
            this.Text = "Dictionary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordInfosDisplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button submenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView wordInfosDisplayer;
        private System.Windows.Forms.Button reset_database;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Timer timer1;
    }
}