namespace Article18
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;


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
            lbSong = new ListBox();
            lbFavorite = new ListBox();
            btSelect = new Button();
            btRemove = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbSong
            // 
            lbSong.FormattingEnabled = true;
            lbSong.Location = new Point(12, 32);
            lbSong.Name = "lbSong";
            lbSong.Size = new Size(250, 304);
            lbSong.TabIndex = 0;
            // 
            // lbFavorite
            // 
            lbFavorite.FormattingEnabled = true;
            lbFavorite.Location = new Point(379, 32);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(250, 304);
            lbFavorite.TabIndex = 3;
            // 
            // btSelect
            // 
            btSelect.Location = new Point(270, 100);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(94, 29);
            btSelect.TabIndex = 1;
            btSelect.Text = ">";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // btRemove
            // 
            btRemove.Location = new Point(270, 150);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(94, 29);
            btRemove.TabIndex = 2;
            btRemove.Text = "<";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 4;
            label1.Text = "Danh sách bài hát";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 9);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 5;
            label2.Text = "Danh sách bài hát ưa thích";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 350);
            Controls.Add(lbFavorite);
            Controls.Add(btRemove);
            Controls.Add(btSelect);
            Controls.Add(lbSong);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Music";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // Khai báo các control ở đây (đã được thêm ở đầu file)
    }
}