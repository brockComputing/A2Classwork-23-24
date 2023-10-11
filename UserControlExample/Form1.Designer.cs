namespace UserControlExample
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
            this.ucTest1 = new UserControlExample.UCTest();
            this.ucTest2 = new UserControlExample.UCTest();
            this.SuspendLayout();
            // 
            // ucTest1
            // 
            this.ucTest1.Location = new System.Drawing.Point(205, 110);
            this.ucTest1.Name = "ucTest1";
            this.ucTest1.Size = new System.Drawing.Size(150, 150);
            this.ucTest1.TabIndex = 0;
            // 
            // ucTest2
            // 
            this.ucTest2.Location = new System.Drawing.Point(513, 127);
            this.ucTest2.Name = "ucTest2";
            this.ucTest2.Size = new System.Drawing.Size(150, 150);
            this.ucTest2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucTest2);
            this.Controls.Add(this.ucTest1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UCTest ucTest1;
        private UCTest ucTest2;
    }
}

