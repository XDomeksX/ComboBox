namespace ComboBox
{
    partial class Form1
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
            this.CB1 = new System.Windows.Forms.ComboBox();
            this.L1 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CB1
            // 
            this.CB1.FormattingEnabled = true;
            this.CB1.Items.AddRange(new object[] {
            "IT managment",
            "aplikativno programiranje",
            "internet programiranje",
            "informacijski sistemi"});
            this.CB1.Location = new System.Drawing.Point(294, 188);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(231, 21);
            this.CB1.TabIndex = 0;
            this.CB1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(294, 146);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(231, 13);
            this.L1.TabIndex = 1;
            this.L1.Text = "Odaberite jedan od ponuđenih ovrzovnih profila";
            this.L1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(294, 237);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(231, 24);
            this.TB1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.CB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB1;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox TB1;
    }
}

