namespace Article17
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các Controls (Từ Slide117)
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btDeselectAll;
        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;


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
            btSelect = new Button();
            btDeselect = new Button();
            btSelectAll = new Button();
            btDeselectAll = new Button();
            lbSong = new ListBox();
            lbFavorite = new ListBox();
            SuspendLayout();
            // 
            // btSelect
            // 
            btSelect.Location = new Point(350, 100);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(75, 34);
            btSelect.TabIndex = 0;
            btSelect.Text = ">";
            btSelect.Click += btSelect_Click;
            // 
            // btDeselect
            // 
            btDeselect.Location = new Point(350, 150);
            btDeselect.Name = "btDeselect";
            btDeselect.Size = new Size(75, 32);
            btDeselect.TabIndex = 1;
            btDeselect.Text = "<";
            btDeselect.Click += btDeselect_Click;
            // 
            // btSelectAll
            // 
            btSelectAll.Location = new Point(350, 200);
            btSelectAll.Name = "btSelectAll";
            btSelectAll.Size = new Size(75, 34);
            btSelectAll.TabIndex = 2;
            btSelectAll.Text = ">>";
            btSelectAll.Click += btSelectAll_Click;
            // 
            // btDeselectAll
            // 
            btDeselectAll.Location = new Point(350, 250);
            btDeselectAll.Name = "btDeselectAll";
            btDeselectAll.Size = new Size(75, 37);
            btDeselectAll.TabIndex = 3;
            btDeselectAll.Text = "<<";
            btDeselectAll.Click += btDeselectAll_Click;
            // 
            // lbSong
            // 
            lbSong.Location = new Point(50, 50);
            lbSong.Name = "lbSong";
            lbSong.Size = new Size(235, 324);
            lbSong.TabIndex = 4;
            lbSong.MouseDoubleClick += lbSong_MouseDoubleClick;
            // 
            // lbFavorite
            // 
            lbFavorite.Location = new Point(500, 50);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(226, 324);
            lbFavorite.TabIndex = 5;
            lbFavorite.MouseDoubleClick += lbFavorite_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btSelect);
            Controls.Add(btDeselect);
            Controls.Add(btSelectAll);
            Controls.Add(btDeselectAll);
            Controls.Add(lbSong);
            Controls.Add(lbFavorite);
            Name = "Form1";
            Text = "Article 17 - ListBox Demo";
            Load += Form1_Load;
            ResumeLayout(false);

        }

        #endregion
    }
}