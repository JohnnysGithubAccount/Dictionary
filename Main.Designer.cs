namespace Dictionary
{
    partial class Main
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
            this.submenu = new System.Windows.Forms.Button();
            this.Thesaurus = new System.Windows.Forms.Label();
            this.translate_model = new System.Windows.Forms.Label();
            this.dictionary_mode = new System.Windows.Forms.Label();
            this.wordSearcherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wordSearcherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryInterface1 = new Dictionary.DictionaryInterface();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordSearcherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordSearcherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.submenu);
            this.panel1.Controls.Add(this.Thesaurus);
            this.panel1.Controls.Add(this.translate_model);
            this.panel1.Controls.Add(this.dictionary_mode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 46);
            this.panel1.TabIndex = 0;
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
            // Thesaurus
            // 
            this.Thesaurus.AutoSize = true;
            this.Thesaurus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thesaurus.Location = new System.Drawing.Point(435, 9);
            this.Thesaurus.Name = "Thesaurus";
            this.Thesaurus.Size = new System.Drawing.Size(127, 29);
            this.Thesaurus.TabIndex = 2;
            this.Thesaurus.Text = "Thesaurus";
            // 
            // translate_model
            // 
            this.translate_model.AutoSize = true;
            this.translate_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translate_model.Location = new System.Drawing.Point(287, 9);
            this.translate_model.Name = "translate_model";
            this.translate_model.Size = new System.Drawing.Size(114, 29);
            this.translate_model.TabIndex = 1;
            this.translate_model.Text = "Translate";
            this.translate_model.Click += new System.EventHandler(this.translate_model_Click);
            // 
            // dictionary_mode
            // 
            this.dictionary_mode.AutoSize = true;
            this.dictionary_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dictionary_mode.Location = new System.Drawing.Point(117, 9);
            this.dictionary_mode.Name = "dictionary_mode";
            this.dictionary_mode.Size = new System.Drawing.Size(119, 29);
            this.dictionary_mode.TabIndex = 0;
            this.dictionary_mode.Text = "Dictionary";
            this.dictionary_mode.Click += new System.EventHandler(this.dictionary_mode_Click);
            // 
            // wordSearcherBindingSource1
            // 
            this.wordSearcherBindingSource1.DataSource = typeof(Dictionary.WordSearcher);
            // 
            // wordSearcherBindingSource
            // 
            this.wordSearcherBindingSource.DataSource = typeof(Dictionary.WordSearcher);
            // 
            // dictionaryInterface1
            // 
            this.dictionaryInterface1.Location = new System.Drawing.Point(0, 43);
            this.dictionaryInterface1.Name = "dictionaryInterface1";
            this.dictionaryInterface1.Size = new System.Drawing.Size(1230, 687);
            this.dictionaryInterface1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 730);
            this.Controls.Add(this.dictionaryInterface1);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordSearcherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordSearcherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Thesaurus;
        private System.Windows.Forms.Label translate_model;
        private System.Windows.Forms.Label dictionary_mode;
        private System.Windows.Forms.Button submenu;
        private System.Windows.Forms.BindingSource wordSearcherBindingSource;
        private System.Windows.Forms.BindingSource wordSearcherBindingSource1;
        private DictionaryInterface dictionaryInterface1;
    }
}