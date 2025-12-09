namespace LAB04_NT106
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBai1 = new Button();
            btnBai4 = new Button();
            btnBai5 = new Button();
            SuspendLayout();
            // 
            // btnBai1
            // 
            btnBai1.Location = new Point(42, 33);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(94, 29);
            btnBai1.TabIndex = 0;
            btnBai1.Text = "Bài 1";
            btnBai1.UseVisualStyleBackColor = true;
            btnBai1.Click += button1_Click;
            // 
            // btnBai4
            // 
            btnBai4.Location = new Point(563, 33);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(94, 29);
            btnBai4.TabIndex = 1;
            btnBai4.Text = "Bài 4";
            btnBai4.UseVisualStyleBackColor = true;
            btnBai4.Click += btnBai4_Click;
            // 
            // btnBai5
            // 
            btnBai5.Location = new Point(563, 231);
            btnBai5.Name = "btnBai5";
            btnBai5.Size = new Size(94, 29);
            btnBai5.TabIndex = 2;
            btnBai5.Text = "Bài 5";
            btnBai5.UseVisualStyleBackColor = true;
            btnBai5.Click += btnBai5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBai5);
            Controls.Add(btnBai4);
            Controls.Add(btnBai1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBai1;
        private Button btnBai4;
        private Button btnBai5;
    }
}
