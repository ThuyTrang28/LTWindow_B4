namespace Article11
{
    partial class Form1
    {
        // Khai báo Controls (giữ nguyên)
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button btDot;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btBackspace;
        private System.Windows.Forms.Button btPlusMinus;
        private System.Windows.Forms.Button btSqrt;
        private System.Windows.Forms.Button btPercent;
        private System.Windows.Forms.Button btInverse; // 1/x
        private System.Windows.Forms.Button btMC;
        private System.Windows.Forms.Button btMR;
        private System.Windows.Forms.Button btMS;
        private System.Windows.Forms.Button btMPlus;
        private System.Windows.Forms.Button btMMinus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // Định nghĩa kích thước và khoảng cách
            int buttonWidth = 50;
            int buttonHeight = 40;
            int buttonSpacing = 5;
            int startX = 5;
            int startY = 85; // Bắt đầu sau TextBox và hàng Memory

            // Khởi tạo các Controls
            txtDisplay = new System.Windows.Forms.TextBox();
            bt0 = new System.Windows.Forms.Button();
            bt1 = new System.Windows.Forms.Button();
            bt2 = new System.Windows.Forms.Button();
            bt3 = new System.Windows.Forms.Button();
            bt4 = new System.Windows.Forms.Button();
            bt5 = new System.Windows.Forms.Button();
            bt6 = new System.Windows.Forms.Button();
            bt7 = new System.Windows.Forms.Button();
            bt8 = new System.Windows.Forms.Button();
            bt9 = new System.Windows.Forms.Button();
            btPlus = new System.Windows.Forms.Button();
            btMinus = new System.Windows.Forms.Button();
            btMultiply = new System.Windows.Forms.Button();
            btDivide = new System.Windows.Forms.Button();
            btEquals = new System.Windows.Forms.Button();
            btDot = new System.Windows.Forms.Button();
            btC = new System.Windows.Forms.Button();
            btCE = new System.Windows.Forms.Button();
            btBackspace = new System.Windows.Forms.Button();
            btPlusMinus = new System.Windows.Forms.Button();
            btSqrt = new System.Windows.Forms.Button();
            btPercent = new System.Windows.Forms.Button();
            btInverse = new System.Windows.Forms.Button();
            btMC = new System.Windows.Forms.Button();
            btMR = new System.Windows.Forms.Button();
            btMS = new System.Windows.Forms.Button();
            btMPlus = new System.Windows.Forms.Button();
            btMMinus = new System.Windows.Forms.Button();

            SuspendLayout();

            // 
            // txtDisplay
            // 
            txtDisplay.Location = new System.Drawing.Point(startX, 10);
            txtDisplay.Size = new System.Drawing.Size(280, 30);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtDisplay.ReadOnly = true;

            // --- Hàng Memory (Row 1) ---
            int row1Y = 45;

            // MC
            btMC.Location = new System.Drawing.Point(startX + (0 * (buttonWidth + buttonSpacing)), row1Y);
            btMC.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btMC.Text = "MC";

            // MR
            btMR.Location = new System.Drawing.Point(startX + (1 * (buttonWidth + buttonSpacing)), row1Y);
            btMR.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btMR.Text = "MR";

            // MS
            btMS.Location = new System.Drawing.Point(startX + (2 * (buttonWidth + buttonSpacing)), row1Y);
            btMS.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btMS.Text = "MS";

            // M+
            btMPlus.Location = new System.Drawing.Point(startX + (3 * (buttonWidth + buttonSpacing)), row1Y);
            btMPlus.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btMPlus.Text = "M+";

            // M-
            btMMinus.Location = new System.Drawing.Point(startX + (4 * (buttonWidth + buttonSpacing)), row1Y);
            btMMinus.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btMMinus.Text = "M-";

            // --- Hàng Clear/Edit (Row 2) ---
            int row2Y = row1Y + buttonHeight + buttonSpacing; // startY = 85

            // Backspace (←)
            btBackspace.Location = new System.Drawing.Point(startX + (0 * (buttonWidth + buttonSpacing)), row2Y);
            btBackspace.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btBackspace.Text = "←";

            // CE
            btCE.Location = new System.Drawing.Point(startX + (1 * (buttonWidth + buttonSpacing)), row2Y);
            btCE.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btCE.Text = "CE";

            // C
            btC.Location = new System.Drawing.Point(startX + (2 * (buttonWidth + buttonSpacing)), row2Y);
            btC.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btC.Text = "C";

            // Plus/Minus (±)
            btPlusMinus.Location = new System.Drawing.Point(startX + (3 * (buttonWidth + buttonSpacing)), row2Y);
            btPlusMinus.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btPlusMinus.Text = "±";

            // Sqrt (√)
            btSqrt.Location = new System.Drawing.Point(startX + (4 * (buttonWidth + buttonSpacing)), row2Y);
            btSqrt.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btSqrt.Text = "√";

            // --- Hàng 7-9 (Row 3) ---
            int row3Y = row2Y + buttonHeight + buttonSpacing;

            // 7
            bt7.Location = new System.Drawing.Point(startX + (0 * (buttonWidth + buttonSpacing)), row3Y);
            bt7.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            bt7.Text = "7";

            // 8
            bt8.Location = new System.Drawing.Point(startX + (1 * (buttonWidth + buttonSpacing)), row3Y);
            bt8.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            bt8.Text = "8";

            // 9
            bt9.Location = new System.Drawing.Point(startX + (2 * (buttonWidth + buttonSpacing)), row3Y);
            bt9.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            bt9.Text = "9";

            // Divide (/)
            btDivide.Location = new System.Drawing.Point(startX + (3 * (buttonWidth + buttonSpacing)), row3Y);
            btDivide.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btDivide.Text = "/";

            // Percent (%)
            btPercent.Location = new System.Drawing.Point(startX + (4 * (buttonWidth + buttonSpacing)), row3Y);
            btPercent.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btPercent.Text = "%";

            // --- Hàng 4-6 (Row 4) ---
            int row4Y = row3Y + buttonHeight + buttonSpacing;

            // 4
            bt4.Location = new System.Drawing.Point(startX + (0 * (buttonWidth + buttonSpacing)), row4Y);
            bt4.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            bt4.Text = "4";

            // 5
            bt5.Location = new System.Drawing.Point(startX + (1 * (buttonWidth + buttonSpacing)), row4Y);
            bt5.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            bt5.Text = "5";

            // 6
            bt6.Location = new System.Drawing.Point(startX + (2 * (buttonWidth + buttonSpacing)), row4Y);
            bt6.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            bt6.Text = "6";

            // Multiply (*)
            btMultiply.Location = new System.Drawing.Point(startX + (3 * (buttonWidth + buttonSpacing)), row4Y);
            btMultiply.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btMultiply.Text = "*";

            // 1/x (Inverse)
            btInverse.Location = new System.Drawing.Point(startX + (4 * (buttonWidth + buttonSpacing)), row4Y);
            btInverse.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btInverse.Text = "1/x";

            // --- Hàng 1-3 (Row 5) ---
            int row5Y = row4Y + buttonHeight + buttonSpacing;

            // 1
            bt1.Location = new System.Drawing.Point(startX + (0 * (buttonWidth + buttonSpacing)), row5Y);
            bt1.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            bt1.Text = "1";

            // 2
            bt2.Location = new System.Drawing.Point(startX + (1 * (buttonWidth + buttonSpacing)), row5Y);
            bt2.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            bt2.Text = "2";

            // 3
            bt3.Location = new System.Drawing.Point(startX + (2 * (buttonWidth + buttonSpacing)), row5Y);
            bt3.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            bt3.Text = "3";

            // Minus (-)
            btMinus.Location = new System.Drawing.Point(startX + (3 * (buttonWidth + buttonSpacing)), row5Y);
            btMinus.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btMinus.Text = "-";

            // Equals (=) - Kéo dài 2 hàng
            btEquals.Location = new System.Drawing.Point(startX + (4 * (buttonWidth + buttonSpacing)), row5Y);
            btEquals.Size = new System.Drawing.Size(buttonWidth, (buttonHeight * 2) + buttonSpacing);
            btEquals.Text = "=";

            // --- Hàng 0 (Row 6) ---
            int row6Y = row5Y + buttonHeight + buttonSpacing;

            // 0 - Kéo dài 2 cột
            bt0.Location = new System.Drawing.Point(startX + (0 * (buttonWidth + buttonSpacing)), row6Y);
            bt0.Size = new System.Drawing.Size((buttonWidth * 2) + buttonSpacing, buttonHeight);
            bt0.Text = "0";

            // Dot (.)
            btDot.Location = new System.Drawing.Point(startX + (2 * (buttonWidth + buttonSpacing)), row6Y);
            btDot.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btDot.Text = ".";

            // Plus (+)
            btPlus.Location = new System.Drawing.Point(startX + (3 * (buttonWidth + buttonSpacing)), row6Y);
            btPlus.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btPlus.Text = "+";


            // Thêm tất cả Controls vào Form
            Controls.Add(txtDisplay);
            Controls.Add(bt0);
            Controls.Add(bt1);
            Controls.Add(bt2);
            Controls.Add(bt3);
            Controls.Add(bt4);
            Controls.Add(bt5);
            Controls.Add(bt6);
            Controls.Add(bt7);
            Controls.Add(bt8);
            Controls.Add(bt9);
            Controls.Add(btPlus);
            Controls.Add(btMinus);
            Controls.Add(btMultiply);
            Controls.Add(btDivide);
            Controls.Add(btEquals);
            Controls.Add(btDot);
            Controls.Add(btC);
            Controls.Add(btCE);
            Controls.Add(btBackspace);
            Controls.Add(btPlusMinus);
            Controls.Add(btSqrt);
            Controls.Add(btPercent);
            Controls.Add(btInverse);
            Controls.Add(btMC);
            Controls.Add(btMR);
            Controls.Add(btMS);
            Controls.Add(btMPlus);
            Controls.Add(btMMinus);

            // Gán Event Handler Button_Click cho TẤT CẢ các nút
            bt0.Click += new System.EventHandler(Button_Click);
            bt1.Click += new System.EventHandler(Button_Click);
            bt2.Click += new System.EventHandler(Button_Click);
            bt3.Click += new System.EventHandler(Button_Click);
            bt4.Click += new System.EventHandler(Button_Click);
            bt5.Click += new System.EventHandler(Button_Click);
            bt6.Click += new System.EventHandler(Button_Click);
            bt7.Click += new System.EventHandler(Button_Click);
            bt8.Click += new System.EventHandler(Button_Click);
            bt9.Click += new System.EventHandler(Button_Click);

            btDot.Click += new System.EventHandler(Button_Click);

            btPlus.Click += new System.EventHandler(Button_Click);
            btMinus.Click += new System.EventHandler(Button_Click);
            btMultiply.Click += new System.EventHandler(Button_Click);
            btDivide.Click += new System.EventHandler(Button_Click);
            btEquals.Click += new System.EventHandler(Button_Click);

            btC.Click += new System.EventHandler(Button_Click);
            btCE.Click += new System.EventHandler(Button_Click);
            btBackspace.Click += new System.EventHandler(Button_Click);

            btPlusMinus.Click += new System.EventHandler(Button_Click);
            btSqrt.Click += new System.EventHandler(Button_Click);
            btPercent.Click += new System.EventHandler(Button_Click);
            btInverse.Click += new System.EventHandler(Button_Click);

            btMC.Click += new System.EventHandler(Button_Click);
            btMR.Click += new System.EventHandler(Button_Click);
            btMS.Click += new System.EventHandler(Button_Click);
            btMPlus.Click += new System.EventHandler(Button_Click);
            btMMinus.Click += new System.EventHandler(Button_Click);

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 450); // Tăng chiều cao để chứa tất cả các nút
            Name = "Form1";
            Text = "My Calculator";
            Load += Form1_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Đảm bảo rằng KHÔNG có định nghĩa Button_Click nào ở đây để tránh lỗi 'ambiguous'.
    }
}