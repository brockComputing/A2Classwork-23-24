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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucTest1
            // 
            this.ucTest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ucTest1.Location = new System.Drawing.Point(205, 110);
            this.ucTest1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ucTest1.Name = "ucTest1";
            this.ucTest1.numberofLates = 0;
            this.ucTest1.Size = new System.Drawing.Size(150, 150);
            this.ucTest1.TabIndex = 0;
            // 
            // ucTest2
            // 
            this.ucTest2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ucTest2.Location = new System.Drawing.Point(513, 127);
            this.ucTest2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ucTest2.Name = "ucTest2";
            this.ucTest2.numberofLates = 0;
            this.ucTest2.Size = new System.Drawing.Size(150, 150);
            this.ucTest2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucTest2);
            this.Controls.Add(this.ucTest1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UCTest ucTest1;
        private UCTest ucTest2;
        private System.Windows.Forms.Button button1;
    }
}

