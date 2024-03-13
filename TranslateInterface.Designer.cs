namespace Dictionary
{
    partial class TranslateInterface
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.switching = new System.Windows.Forms.Button();
            this.language_in = new System.Windows.Forms.ComboBox();
            this.language_out = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(997, 201);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.language_out);
            this.panel2.Controls.Add(this.language_in);
            this.panel2.Controls.Add(this.switching);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(51, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 596);
            this.panel2.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 324);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(997, 232);
            this.textBox2.TabIndex = 1;
            // 
            // switching
            // 
            this.switching.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switching.Location = new System.Drawing.Point(232, 20);
            this.switching.Name = "switching";
            this.switching.Size = new System.Drawing.Size(106, 39);
            this.switching.TabIndex = 4;
            this.switching.Text = "button1";
            this.switching.UseVisualStyleBackColor = true;
            // 
            // language_in
            // 
            this.language_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language_in.FormattingEnabled = true;
            this.language_in.Items.AddRange(new object[] {
            "English",
            "Vietnamese",
            "Spanish",
            "Chinese",
            "Japanese"});
            this.language_in.Location = new System.Drawing.Point(60, 20);
            this.language_in.Name = "language_in";
            this.language_in.Size = new System.Drawing.Size(121, 39);
            this.language_in.TabIndex = 5;
            this.language_in.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // language_out
            // 
            this.language_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language_out.FormattingEnabled = true;
            this.language_out.Items.AddRange(new object[] {
            "English",
            "Vietnamese",
            "Spanish",
            "Chinese",
            "Japanese"});
            this.language_out.Location = new System.Drawing.Point(384, 20);
            this.language_out.Name = "language_out";
            this.language_out.Size = new System.Drawing.Size(121, 39);
            this.language_out.TabIndex = 6;
            this.language_out.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Translated";
            // 
            // TranslateInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "TranslateInterface";
            this.Size = new System.Drawing.Size(1230, 687);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox language_in;
        private System.Windows.Forms.Button switching;
        private System.Windows.Forms.ComboBox language_out;
        private System.Windows.Forms.Label label1;
    }
}
