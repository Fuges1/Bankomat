namespace Bankomat
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
            textBoxAmount = new TextBox();
            labelBalance = new Label();
            buttonDeposit = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(42, 129);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(217, 23);
            textBoxAmount.TabIndex = 0;
            textBoxAmount.Visible = false;
            textBoxAmount.TextChanged += textBoxAmount_TextChanged;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.ForeColor = SystemColors.ButtonHighlight;
            labelBalance.Location = new Point(203, 16);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(120, 15);
            labelBalance.TabIndex = 1;
            labelBalance.Text = "Выберете операцию";
            labelBalance.Visible = false;
            // 
            // buttonDeposit
            // 
            buttonDeposit.Location = new Point(366, 46);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new Size(119, 208);
            buttonDeposit.TabIndex = 2;
            buttonDeposit.Text = "Внести";
            buttonDeposit.UseVisualStyleBackColor = true;
            buttonDeposit.Visible = false;
            buttonDeposit.Click += buttonDeposit_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(209, 46);
            button1.Name = "button1";
            button1.Size = new Size(119, 208);
            button1.TabIndex = 3;
            button1.Text = "Узнать баланс";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(56, 46);
            button2.Name = "button2";
            button2.Size = new Size(119, 208);
            button2.TabIndex = 4;
            button2.Text = "Снять";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(181, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 210);
            panel1.TabIndex = 5;
            panel1.Click += panel1_Click;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 80F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(66, 178);
            label1.Name = "label1";
            label1.Size = new Size(431, 142);
            label1.TabIndex = 11;
            label1.Text = "НЕСБЕР";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(147, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 100);
            panel2.TabIndex = 6;
            panel2.Visible = false;
            panel2.Click += panel2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 80F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(56, -31);
            label3.Name = "label3";
            label3.Size = new Size(431, 142);
            label3.TabIndex = 12;
            label3.Text = "НЕСБЕР";
            label3.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(42, 158);
            button3.Name = "button3";
            button3.Size = new Size(99, 23);
            button3.TabIndex = 7;
            button3.Text = "Снять";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(42, 111);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 8;
            label2.Text = "Введите сумму";
            label2.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(42, 158);
            button4.Name = "button4";
            button4.Size = new Size(99, 23);
            button4.TabIndex = 9;
            button4.Text = "Внести";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 288);
            button5.Name = "button5";
            button5.Size = new Size(50, 23);
            button5.TabIndex = 10;
            button5.Text = "<---";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bankomat;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(537, 323);
            Controls.Add(buttonDeposit);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBoxAmount);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(labelBalance);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label3);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAmount;
        private Label labelBalance;
        private Button buttonDeposit;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Label label2;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label3;
    }
}