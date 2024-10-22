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
            button2 = new Button();
            button1 = new Button();
            btnExit = new Button();
            PnlHistory = new Panel();
            richTextBox1 = new RichTextBox();
            btnClearHistory = new Button();
            panel1 = new Panel();
            btnMenu = new Button();
            btnHistory = new Button();
            txtDisplayProvi = new TextBox();
            txtDisplay = new TextBox();
            PnlTitle.SuspendLayout();
            PnlHistory.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTitle
            // 
            PnlTitle.Controls.Add(button2);
            PnlTitle.Controls.Add(button1);
            PnlTitle.Controls.Add(btnExit);
            PnlTitle.Dock = DockStyle.Top;
            PnlTitle.Location = new Point(0, 0);
            PnlTitle.Margin = new Padding(0);
            PnlTitle.Name = "PnlTitle";
            PnlTitle.Size = new Size(350, 35);
            PnlTitle.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(54, 54, 54);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.minimize_minus;
            button2.Location = new Point(200, 0);
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
            button1.Location = new Point(250, 0);
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
            btnExit.Location = new Point(300, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 35);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // PnlHistory
            // 
            PnlHistory.Controls.Add(richTextBox1);
            PnlHistory.Controls.Add(btnClearHistory);
            PnlHistory.Dock = DockStyle.Bottom;
            PnlHistory.Location = new Point(0, 565);
            PnlHistory.Margin = new Padding(0);
            PnlHistory.Name = "PnlHistory";
            PnlHistory.Size = new Size(350, 5);
            PnlHistory.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(32, 32, 32);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.ForeColor = Color.Silver;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Horizontal;
            richTextBox1.Size = new Size(350, 0);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // btnClearHistory
            // 
            btnClearHistory.Dock = DockStyle.Bottom;
            btnClearHistory.FlatAppearance.BorderSize = 0;
            btnClearHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnClearHistory.FlatStyle = FlatStyle.Flat;
            btnClearHistory.Image = Properties.Resources.trashcan;
            btnClearHistory.Location = new Point(0, -35);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(350, 40);
            btnClearHistory.TabIndex = 3;
            btnClearHistory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnHistory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 35);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 40);
            panel1.TabIndex = 2;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Left;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(54, 54, 54);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Image = Properties.Resources.meun;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(50, 40);
            btnMenu.TabIndex = 2;
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            btnHistory.Dock = DockStyle.Right;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(54, 54, 54);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Image = Properties.Resources.historybig;
            btnHistory.Location = new Point(300, 0);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(50, 40);
            btnHistory.TabIndex = 0;
            btnHistory.UseVisualStyleBackColor = true;
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
            txtDisplayProvi.Size = new Size(350, 25);
            txtDisplayProvi.TabIndex = 3;
            txtDisplayProvi.Text = "testing";
            txtDisplayProvi.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.FromArgb(32, 32, 32);
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Dock = DockStyle.Top;
            txtDisplay.Font = new Font("Gadugi", 26F, FontStyle.Bold);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(0, 100);
            txtDisplay.Margin = new Padding(0);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(350, 40);
            txtDisplay.TabIndex = 4;
            txtDisplay.Text = "930213";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(350, 570);
            Controls.Add(txtDisplay);
            Controls.Add(txtDisplayProvi);
            Controls.Add(panel1);
            Controls.Add(PnlHistory);
            Controls.Add(PnlTitle);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
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
        private Button btnMenu;
        private Button btnHistory;
        private TextBox txtDisplayProvi;
        private TextBox txtDisplay;
        private Button btnClearHistory;
        private RichTextBox richTextBox1;
    }
}
