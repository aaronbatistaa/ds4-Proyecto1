namespace Proyecto_1
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
            PnlTitle = new Panel();
            btnUtp = new Button();
            button2 = new Button();
            button1 = new Button();
            btnExit = new Button();
            PnlHistory = new Panel();
            rtBoxHistory = new RichTextBox();
            btnClearHistory = new Button();
            panel1 = new Panel();
            btnShowResults = new Button();
            btnHistory = new Button();
            txtDisplayProvi = new TextBox();
            txtDisplay = new TextBox();
            btnErase = new Button();
            btnClear = new Button();
            btnClearAll = new Button();
            button6 = new Button();
            button7 = new Button();
            btnSquare = new Button();
            btnRoot = new Button();
            btnDivide = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSubs = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMulti = new Button();
            btnNegative = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnEqual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            PnlTitle.SuspendLayout();
            PnlHistory.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTitle
            // 
            PnlTitle.Controls.Add(btnUtp);
            PnlTitle.Controls.Add(button2);
            PnlTitle.Controls.Add(button1);
            PnlTitle.Controls.Add(btnExit);
            PnlTitle.Dock = DockStyle.Top;
            PnlTitle.Location = new Point(0, 0);
            PnlTitle.Margin = new Padding(0);
            PnlTitle.Name = "PnlTitle";
            PnlTitle.Size = new Size(325, 35);
            PnlTitle.TabIndex = 0;
            PnlTitle.MouseDown += PnlTitle_MouseDown;
            // 
            // btnUtp
            // 
            btnUtp.FlatAppearance.BorderSize = 0;
            btnUtp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUtp.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnUtp.FlatStyle = FlatStyle.Flat;
            btnUtp.ForeColor = Color.Transparent;
            btnUtp.Image = Properties.Resources._6_logo_utp___rgb_oficial__1_;
            btnUtp.Location = new Point(3, 1);
            btnUtp.Name = "btnUtp";
            btnUtp.Size = new Size(43, 32);
            btnUtp.TabIndex = 3;
            btnUtp.UseVisualStyleBackColor = true;
            btnUtp.Click += btnUtp_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(54, 54, 54);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.minimize_minus;
            button2.Location = new Point(175, 0);
            button2.Name = "button2";
            button2.Size = new Size(50, 35);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(54, 54, 54);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.maximize;
            button1.Location = new Point(225, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 35);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = Properties.Resources.icons8_close_15;
            btnExit.Location = new Point(275, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 35);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // PnlHistory
            // 
            PnlHistory.Controls.Add(rtBoxHistory);
            PnlHistory.Controls.Add(btnClearHistory);
            PnlHistory.Dock = DockStyle.Bottom;
            PnlHistory.Location = new Point(0, 565);
            PnlHistory.Margin = new Padding(0);
            PnlHistory.Name = "PnlHistory";
            PnlHistory.Size = new Size(325, 5);
            PnlHistory.TabIndex = 1;
            // 
            // rtBoxHistory
            // 
            rtBoxHistory.BackColor = Color.FromArgb(32, 32, 32);
            rtBoxHistory.BorderStyle = BorderStyle.None;
            rtBoxHistory.Dock = DockStyle.Fill;
            rtBoxHistory.ForeColor = Color.Silver;
            rtBoxHistory.Location = new Point(0, 0);
            rtBoxHistory.Margin = new Padding(0);
            rtBoxHistory.Name = "rtBoxHistory";
            rtBoxHistory.ReadOnly = true;
            rtBoxHistory.ScrollBars = RichTextBoxScrollBars.Horizontal;
            rtBoxHistory.Size = new Size(325, 0);
            rtBoxHistory.TabIndex = 4;
            rtBoxHistory.Text = "";
            // 
            // btnClearHistory
            // 
            btnClearHistory.Dock = DockStyle.Bottom;
            btnClearHistory.FlatAppearance.BorderSize = 0;
            btnClearHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnClearHistory.FlatStyle = FlatStyle.Flat;
            btnClearHistory.Image = Properties.Resources.trashcan;
            btnClearHistory.Location = new Point(0, -35);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(325, 40);
            btnClearHistory.TabIndex = 3;
            btnClearHistory.UseVisualStyleBackColor = true;
            btnClearHistory.Click += btnClearHistory_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnShowResults);
            panel1.Controls.Add(btnHistory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 35);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 40);
            panel1.TabIndex = 2;
            // 
            // btnShowResults
            // 
            btnShowResults.Dock = DockStyle.Left;
            btnShowResults.FlatAppearance.BorderSize = 0;
            btnShowResults.FlatAppearance.MouseOverBackColor = Color.FromArgb(54, 54, 54);
            btnShowResults.FlatStyle = FlatStyle.Flat;
            btnShowResults.Location = new Point(0, 0);
            btnShowResults.Name = "btnShowResults";
            btnShowResults.Size = new Size(169, 40);
            btnShowResults.TabIndex = 2;
            btnShowResults.Text = "Mostrar Resultados";
            btnShowResults.UseVisualStyleBackColor = true;
            btnShowResults.Click += btnShowResults_Click;
            // 
            // btnHistory
            // 
            btnHistory.Dock = DockStyle.Right;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(54, 54, 54);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Image = Properties.Resources.historybig;
            btnHistory.Location = new Point(275, 0);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(50, 40);
            btnHistory.TabIndex = 0;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // txtDisplayProvi
            // 
            txtDisplayProvi.BackColor = Color.FromArgb(32, 32, 32);
            txtDisplayProvi.BorderStyle = BorderStyle.None;
            txtDisplayProvi.Dock = DockStyle.Top;
            txtDisplayProvi.Font = new Font("Gadugi", 12F);
            txtDisplayProvi.ForeColor = Color.DarkGray;
            txtDisplayProvi.Location = new Point(0, 75);
            txtDisplayProvi.Margin = new Padding(0);
            txtDisplayProvi.Multiline = true;
            txtDisplayProvi.Name = "txtDisplayProvi";
            txtDisplayProvi.ReadOnly = true;
            txtDisplayProvi.Size = new Size(325, 35);
            txtDisplayProvi.TabIndex = 3;
            txtDisplayProvi.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.FromArgb(32, 32, 32);
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Dock = DockStyle.Top;
            txtDisplay.Font = new Font("Gadugi", 26F, FontStyle.Bold);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(0, 110);
            txtDisplay.Margin = new Padding(0);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(325, 40);
            txtDisplay.TabIndex = 4;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnErase
            // 
            btnErase.BackColor = Color.FromArgb(50, 50, 50);
            btnErase.FlatAppearance.BorderSize = 0;
            btnErase.FlatStyle = FlatStyle.Flat;
            btnErase.Image = Properties.Resources.icons8_clear_symbol_15;
            btnErase.Location = new Point(245, 165);
            btnErase.Margin = new Padding(0);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(75, 60);
            btnErase.TabIndex = 5;
            btnErase.UseVisualStyleBackColor = false;
            btnErase.Click += btnErase_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(50, 50, 50);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(165, 165);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 60);
            btnClear.TabIndex = 5;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.FromArgb(50, 50, 50);
            btnClearAll.FlatAppearance.BorderSize = 0;
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.Location = new Point(85, 165);
            btnClearAll.Margin = new Padding(0);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(75, 60);
            btnClearAll.TabIndex = 5;
            btnClearAll.Text = "CE";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(50, 50, 50);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(5, 165);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(75, 60);
            button6.TabIndex = 5;
            button6.Text = "sin";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnOtherOps_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(50, 50, 50);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(5, 232);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(75, 60);
            button7.TabIndex = 6;
            button7.Text = "cos";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnOtherOps_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = Color.FromArgb(50, 50, 50);
            btnSquare.FlatAppearance.BorderSize = 0;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.Font = new Font("Gadugi", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSquare.Location = new Point(85, 232);
            btnSquare.Margin = new Padding(0);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(75, 60);
            btnSquare.TabIndex = 7;
            btnSquare.Text = "x²";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnOtherOps_Click;
            // 
            // btnRoot
            // 
            btnRoot.BackColor = Color.FromArgb(50, 50, 50);
            btnRoot.FlatAppearance.BorderSize = 0;
            btnRoot.FlatStyle = FlatStyle.Flat;
            btnRoot.Font = new Font("Gadugi", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRoot.Location = new Point(165, 232);
            btnRoot.Margin = new Padding(0);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(75, 60);
            btnRoot.TabIndex = 8;
            btnRoot.Text = "√x";
            btnRoot.UseVisualStyleBackColor = false;
            btnRoot.Click += btnOtherOps_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(50, 50, 50);
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Gadugi", 16F);
            btnDivide.Location = new Point(245, 232);
            btnDivide.Margin = new Padding(0);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 60);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnBasicMathOp_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(59, 59, 59);
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Gadugi", 14.25F, FontStyle.Bold);
            btn4.Location = new Point(5, 366);
            btn4.Margin = new Padding(0);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 60);
            btn4.TabIndex = 14;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(59, 59, 59);
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Gadugi", 14.25F, FontStyle.Bold);
            btn5.Location = new Point(85, 366);
            btn5.Margin = new Padding(0);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 60);
            btn5.TabIndex = 15;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNum_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(59, 59, 59);
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Gadugi", 14.25F, FontStyle.Bold);
            btn6.Location = new Point(165, 366);
            btn6.Margin = new Padding(0);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 60);
            btn6.TabIndex = 16;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNum_Click;
            // 
            // btnSubs
            // 
            btnSubs.BackColor = Color.FromArgb(50, 50, 50);
            btnSubs.FlatAppearance.BorderSize = 0;
            btnSubs.FlatStyle = FlatStyle.Flat;
            btnSubs.Font = new Font("Gadugi", 16F);
            btnSubs.Location = new Point(245, 366);
            btnSubs.Margin = new Padding(0);
            btnSubs.Name = "btnSubs";
            btnSubs.Size = new Size(75, 60);
            btnSubs.TabIndex = 17;
            btnSubs.Text = "-";
            btnSubs.UseVisualStyleBackColor = false;
            btnSubs.Click += btnBasicMathOp_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(59, 59, 59);
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Gadugi", 14.25F, FontStyle.Bold);
            btn7.Location = new Point(5, 299);
            btn7.Margin = new Padding(0);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 60);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(59, 59, 59);
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Gadugi", 14.25F, FontStyle.Bold);
            btn8.Location = new Point(85, 299);
            btn8.Margin = new Padding(0);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 60);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNum_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(59, 59, 59);
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Gadugi", 14.25F, FontStyle.Bold);
            btn9.Location = new Point(165, 299);
            btn9.Margin = new Padding(0);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 60);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNum_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.FromArgb(50, 50, 50);
            btnMulti.FlatAppearance.BorderSize = 0;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.ForeColor = Color.FromArgb(50, 50, 50);
            btnMulti.Image = Properties.Resources.icons8_close_151;
            btnMulti.Location = new Point(245, 299);
            btnMulti.Margin = new Padding(0);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(75, 60);
            btnMulti.TabIndex = 13;
            btnMulti.Text = "x";
            btnMulti.TextAlign = ContentAlignment.BottomCenter;
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnBasicMathOp_Click;
            // 
            // btnNegative
            // 
            btnNegative.BackColor = Color.FromArgb(59, 59, 59);
            btnNegative.FlatAppearance.BorderSize = 0;
            btnNegative.FlatStyle = FlatStyle.Flat;
            btnNegative.ForeColor = Color.FromArgb(59, 59, 59);
            btnNegative.Image = Properties.Resources.icons8_plus_slash_minus_18;
            btnNegative.Location = new Point(5, 500);
            btnNegative.Margin = new Padding(0);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(75, 60);
            btnNegative.TabIndex = 22;
            btnNegative.Text = "neg";
            btnNegative.TextAlign = ContentAlignment.BottomCenter;
            btnNegative.UseVisualStyleBackColor = false;
            btnNegative.Click += btnOtherOps_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(59, 59, 59);
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Gadugi", 14.25F, FontStyle.Bold);
            btn0.Location = new Point(85, 500);
            btn0.Margin = new Padding(0);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 60);
            btn0.TabIndex = 23;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNum_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.FromArgb(59, 59, 59);
            btnDecimal.FlatAppearance.BorderSize = 0;
            btnDecimal.FlatStyle = FlatStyle.Flat;
            btnDecimal.Font = new Font("Gadugi", 16F);
            btnDecimal.Location = new Point(165, 500);
            btnDecimal.Margin = new Padding(0);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(75, 60);
            btnDecimal.TabIndex = 24;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnNum_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(129, 57, 242);
            btnEqual.FlatAppearance.BorderSize = 0;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Gadugi", 16F);
            btnEqual.Location = new Point(245, 500);
            btnEqual.Margin = new Padding(0);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(75, 60);
            btnEqual.TabIndex = 25;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(59, 59, 59);
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Gadugi", 14.25F, FontStyle.Bold);
            btn1.Location = new Point(5, 433);
            btn1.Margin = new Padding(0);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 60);
            btn1.TabIndex = 18;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(59, 59, 59);
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Gadugi", 14.25F, FontStyle.Bold);
            btn2.Location = new Point(85, 433);
            btn2.Margin = new Padding(0);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 60);
            btn2.TabIndex = 19;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNum_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(59, 59, 59);
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Gadugi", 14.25F, FontStyle.Bold);
            btn3.Location = new Point(165, 433);
            btn3.Margin = new Padding(0);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 60);
            btn3.TabIndex = 20;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNum_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(50, 50, 50);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Gadugi", 16F);
            btnAdd.Location = new Point(245, 433);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 60);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnBasicMathOp_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(325, 570);
            Controls.Add(PnlHistory);
            Controls.Add(btnNegative);
            Controls.Add(btn0);
            Controls.Add(btnDecimal);
            Controls.Add(btnEqual);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnAdd);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnSubs);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnMulti);
            Controls.Add(button7);
            Controls.Add(btnSquare);
            Controls.Add(btnRoot);
            Controls.Add(btnDivide);
            Controls.Add(button6);
            Controls.Add(btnClearAll);
            Controls.Add(btnClear);
            Controls.Add(btnErase);
            Controls.Add(txtDisplay);
            Controls.Add(txtDisplayProvi);
            Controls.Add(panel1);
            Controls.Add(PnlTitle);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            PnlTitle.ResumeLayout(false);
            PnlHistory.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlTitle;
        private Panel PnlHistory;
        private Button btnExit;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Button btnShowResults;
        private Button btnHistory;
        private TextBox txtDisplayProvi;
        private TextBox txtDisplay;
        private Button btnClearHistory;
        private RichTextBox rtBoxHistory;
        private Button btnErase;
        private Button btnClear;
        private Button btnClearAll;
        private Button button6;
        private Button button7;
        private Button btnSquare;
        private Button btnRoot;
        private Button btnDivide;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubs;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMulti;
        private Button btnNegative;
        private Button btn0;
        private Button btnDecimal;
        private Button btnEqual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btnUtp;
    }
}
