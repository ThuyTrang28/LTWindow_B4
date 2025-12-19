namespace Article05
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
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(84, 90);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += bt_OK_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(282, 253);
            Controls.Add(button1);
            KeyPreview = true;
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Form1";
            Load += Form1_Load_1;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
        }
        // ...
        #endregion

        private Button button1;
    }
}
