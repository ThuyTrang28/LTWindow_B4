// File: Form1.Designer.cs (Hoàn chỉnh và đã gán sự kiện btClear)

using System.Drawing;
using System.Windows.Forms;

namespace Article12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các Controls
        private ComboBox cb_Faculty;
        private TextBox tbDisplay;
        private Button btOK;
        private Button btClear;


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
            this.btOK = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            // Dựa trên Slide95.JPG - String Collection Editor
            this.cb_Faculty.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Ngoại ngữ",
            "Quản trị kinh doanh",
            "Cơ khí",
            "Điện",
            "Cơ khí động lực"});
            this.cb_Faculty.Location = new System.Drawing.Point(12, 12);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(200, 28);
            this.cb_Faculty.TabIndex = 0;
            this.cb_Faculty.Text = "Công nghệ thông tin";
            this.cb_Faculty.SelectedIndexChanged += new System.EventHandler(this.cb_Faculty_SelectedIndexChanged);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(12, 50);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(95, 29);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(117, 50);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(95, 29);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            // Dòng này đã được thêm/chỉnh sửa để gán sự kiện cho btClear_Click
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(12, 90);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.Size = new System.Drawing.Size(300, 27);
            this.tbDisplay.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 150);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "Form1";
            this.Text = "ComboBox Article";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}