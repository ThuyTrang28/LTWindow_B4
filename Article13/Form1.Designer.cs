namespace Article13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các Controls
        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btOK;


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
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Location = new System.Drawing.Point(25, 25);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(350, 28);
            this.cb_Faculty.TabIndex = 0;
            // Gán sự kiện SelectedValueChanged
            this.cb_Faculty.SelectedValueChanged += new System.EventHandler(this.cb_Faculty_SelectedValueChanged);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(25, 65);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.Size = new System.Drawing.Size(350, 150);
            this.tbDisplay.TabIndex = 1;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(195, 230);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(90, 35);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            // Gán sự kiện Click cho nút Clear
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(285, 230);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(90, 35);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // Gán sự kiện Click cho nút OK
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 290);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "Form1";
            this.Text = "ComboBox Article";
            // Gán sự kiện Load cho Form
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}