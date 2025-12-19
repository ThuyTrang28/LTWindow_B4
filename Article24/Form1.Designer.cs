namespace Article24
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
            components = new System.ComponentModel.Container();
            lblDisplay = new Label();
            btStart = new Button();
            btStop = new Button();
            tmStopwatch = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 48F);
            lblDisplay.Location = new Point(265, 111);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(234, 106);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "00:00";
            lblDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btStart
            // 
            btStart.Location = new Point(230, 250);
            btStart.Name = "btStart";
            btStart.Size = new Size(120, 50);
            btStart.TabIndex = 1;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.Location = new Point(410, 250);
            btStop.Name = "btStop";
            btStop.Size = new Size(120, 50);
            btStop.TabIndex = 2;
            btStop.Text = "Stop";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // tmStopwatch
            // 
            tmStopwatch.Interval = 1000;
            tmStopwatch.Tick += tmStopwatch_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btStop);
            Controls.Add(btStart);
            Controls.Add(lblDisplay);
            Name = "Form1";
            Text = "Timer Article";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // Các biến được khai báo ở đây để Form1.cs có thể gọi được
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer tmStopwatch;
    }
}