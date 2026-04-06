namespace ExpressionEvaluator.UI.Win
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
            button9 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnParenthesisOpen = new Button();
            btncloseParenthesis = new Button();
            btnPow = new Button();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button6 = new Button();
            button13 = new Button();
            button12 = new Button();
            button10 = new Button();
            button11 = new Button();
            button17 = new Button();
            button15 = new Button();
            button16 = new Button();
            button18 = new Button();
            button20 = new Button();
            button19 = new Button();
            button2 = new Button();
            button21 = new Button();
            DisplayTexto = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button9.BackColor = Color.FromArgb(51, 65, 85);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button9.ForeColor = Color.FromArgb(56, 189, 248);
            button9.Location = new Point(281, 218);
            button9.Margin = new Padding(10, 11, 10, 11);
            button9.Name = "button9";
            button9.Padding = new Padding(1);
            button9.Size = new Size(67, 76);
            button9.TabIndex = 8;
            button9.Text = "-";
            button9.TextAlign = ContentAlignment.TopCenter;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(51, 64, 71);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 250, 252);
            button1.Location = new Point(281, 414);
            button1.Margin = new Padding(10, 11, 10, 11);
            button1.Name = "button1";
            button1.Padding = new Padding(1);
            button1.Size = new Size(67, 75);
            button1.TabIndex = 0;
            button1.Text = "DEL";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(24, 28, 34);
            flowLayoutPanel1.Controls.Add(btnParenthesisOpen);
            flowLayoutPanel1.Controls.Add(btncloseParenthesis);
            flowLayoutPanel1.Controls.Add(btnPow);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button13);
            flowLayoutPanel1.Controls.Add(button12);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.Controls.Add(button11);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button17);
            flowLayoutPanel1.Controls.Add(button15);
            flowLayoutPanel1.Controls.Add(button16);
            flowLayoutPanel1.Controls.Add(button18);
            flowLayoutPanel1.Controls.Add(button20);
            flowLayoutPanel1.Controls.Add(button19);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button21);
            flowLayoutPanel1.Location = new Point(26, 115);
            flowLayoutPanel1.Margin = new Padding(10, 11, 10, 11);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel1.Size = new Size(368, 595);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnParenthesisOpen
            // 
            btnParenthesisOpen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnParenthesisOpen.BackColor = Color.FromArgb(51, 65, 85);
            btnParenthesisOpen.FlatAppearance.BorderSize = 0;
            btnParenthesisOpen.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            btnParenthesisOpen.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            btnParenthesisOpen.FlatStyle = FlatStyle.Flat;
            btnParenthesisOpen.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            btnParenthesisOpen.ForeColor = Color.FromArgb(56, 189, 248);
            btnParenthesisOpen.Location = new Point(20, 22);
            btnParenthesisOpen.Margin = new Padding(10, 11, 10, 11);
            btnParenthesisOpen.Name = "btnParenthesisOpen";
            btnParenthesisOpen.Padding = new Padding(1);
            btnParenthesisOpen.Size = new Size(67, 76);
            btnParenthesisOpen.TabIndex = 31;
            btnParenthesisOpen.Text = "(";
            btnParenthesisOpen.UseVisualStyleBackColor = false;
            btnParenthesisOpen.Click += btnParenthesisOpen_Click;
            // 
            // btncloseParenthesis
            // 
            btncloseParenthesis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btncloseParenthesis.BackColor = Color.FromArgb(51, 65, 85);
            btncloseParenthesis.FlatAppearance.BorderSize = 0;
            btncloseParenthesis.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            btncloseParenthesis.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            btncloseParenthesis.FlatStyle = FlatStyle.Flat;
            btncloseParenthesis.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            btncloseParenthesis.ForeColor = Color.FromArgb(56, 189, 248);
            btncloseParenthesis.Location = new Point(107, 22);
            btncloseParenthesis.Margin = new Padding(10, 11, 10, 11);
            btncloseParenthesis.Name = "btncloseParenthesis";
            btncloseParenthesis.Padding = new Padding(1);
            btncloseParenthesis.Size = new Size(67, 76);
            btncloseParenthesis.TabIndex = 17;
            btncloseParenthesis.Text = ")";
            btncloseParenthesis.UseVisualStyleBackColor = false;
            btncloseParenthesis.Click += btncloseParenthesis_Click;
            // 
            // btnPow
            // 
            btnPow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPow.BackColor = Color.FromArgb(51, 65, 85);
            btnPow.FlatAppearance.BorderSize = 0;
            btnPow.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            btnPow.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            btnPow.FlatStyle = FlatStyle.Flat;
            btnPow.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            btnPow.ForeColor = Color.FromArgb(56, 189, 248);
            btnPow.Location = new Point(194, 22);
            btnPow.Margin = new Padding(10, 11, 10, 11);
            btnPow.Name = "btnPow";
            btnPow.Padding = new Padding(1);
            btnPow.Size = new Size(67, 76);
            btnPow.TabIndex = 34;
            btnPow.Text = "^";
            btnPow.TextAlign = ContentAlignment.MiddleRight;
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button8.BackColor = Color.FromArgb(51, 65, 85);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button8.ForeColor = Color.FromArgb(56, 189, 248);
            button8.Location = new Point(281, 22);
            button8.Margin = new Padding(10, 11, 10, 11);
            button8.Name = "button8";
            button8.Padding = new Padding(1);
            button8.Size = new Size(67, 76);
            button8.TabIndex = 21;
            button8.Text = "/";
            button8.TextAlign = ContentAlignment.TopCenter;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(51, 64, 71);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button7.ForeColor = Color.FromArgb(255, 250, 252);
            button7.Location = new Point(20, 120);
            button7.Margin = new Padding(10, 11, 10, 11);
            button7.Name = "button7";
            button7.Padding = new Padding(1);
            button7.Size = new Size(67, 76);
            button7.TabIndex = 20;
            button7.Text = "7";
            button7.TextAlign = ContentAlignment.TopCenter;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(51, 64, 71);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button5.ForeColor = Color.FromArgb(255, 250, 252);
            button5.Location = new Point(107, 120);
            button5.Margin = new Padding(10, 11, 10, 11);
            button5.Name = "button5";
            button5.Padding = new Padding(1);
            button5.Size = new Size(67, 76);
            button5.TabIndex = 18;
            button5.Text = "8";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(51, 64, 71);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button6.ForeColor = Color.FromArgb(255, 250, 252);
            button6.Location = new Point(194, 120);
            button6.Margin = new Padding(10, 11, 10, 11);
            button6.Name = "button6";
            button6.Padding = new Padding(1);
            button6.Size = new Size(67, 76);
            button6.TabIndex = 19;
            button6.Text = "9";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button13.BackColor = Color.FromArgb(51, 65, 85);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button13.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button13.ForeColor = Color.FromArgb(56, 189, 248);
            button13.Location = new Point(281, 120);
            button13.Margin = new Padding(10, 11, 10, 11);
            button13.Name = "button13";
            button13.Padding = new Padding(1);
            button13.Size = new Size(67, 76);
            button13.TabIndex = 25;
            button13.Text = "*";
            button13.TextAlign = ContentAlignment.BottomCenter;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button12.BackColor = Color.FromArgb(51, 64, 71);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button12.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button12.ForeColor = Color.FromArgb(255, 250, 252);
            button12.Location = new Point(20, 218);
            button12.Margin = new Padding(10, 11, 10, 11);
            button12.Name = "button12";
            button12.Padding = new Padding(1);
            button12.Size = new Size(67, 76);
            button12.TabIndex = 23;
            button12.Text = "4";
            button12.TextAlign = ContentAlignment.TopCenter;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button10.BackColor = Color.FromArgb(51, 64, 71);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button10.ForeColor = Color.FromArgb(255, 250, 252);
            button10.Location = new Point(107, 218);
            button10.Margin = new Padding(10, 11, 10, 11);
            button10.Name = "button10";
            button10.Padding = new Padding(1);
            button10.Size = new Size(67, 76);
            button10.TabIndex = 24;
            button10.Text = "5";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button11.BackColor = Color.FromArgb(51, 64, 71);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button11.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button11.ForeColor = Color.FromArgb(255, 250, 252);
            button11.Location = new Point(194, 218);
            button11.Margin = new Padding(10, 11, 10, 11);
            button11.Name = "button11";
            button11.Padding = new Padding(1);
            button11.Size = new Size(67, 76);
            button11.TabIndex = 22;
            button11.Text = "6";
            button11.TextAlign = ContentAlignment.TopCenter;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button17
            // 
            button17.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button17.BackColor = Color.FromArgb(51, 64, 71);
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button17.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button17.ForeColor = Color.FromArgb(255, 250, 252);
            button17.Location = new Point(20, 316);
            button17.Margin = new Padding(10, 11, 10, 11);
            button17.Name = "button17";
            button17.Padding = new Padding(1);
            button17.Size = new Size(67, 76);
            button17.TabIndex = 27;
            button17.Text = "1";
            button17.TextAlign = ContentAlignment.TopCenter;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button15
            // 
            button15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button15.BackColor = Color.FromArgb(51, 64, 71);
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button15.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button15.ForeColor = Color.FromArgb(255, 250, 252);
            button15.Location = new Point(107, 316);
            button15.Margin = new Padding(10, 11, 10, 11);
            button15.Name = "button15";
            button15.Padding = new Padding(1);
            button15.Size = new Size(67, 76);
            button15.TabIndex = 28;
            button15.Text = "2";
            button15.TextAlign = ContentAlignment.TopCenter;
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button16.BackColor = Color.FromArgb(51, 64, 71);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button16.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button16.ForeColor = Color.FromArgb(255, 250, 252);
            button16.Location = new Point(194, 316);
            button16.Margin = new Padding(10, 11, 10, 11);
            button16.Name = "button16";
            button16.Padding = new Padding(1);
            button16.Size = new Size(67, 76);
            button16.TabIndex = 26;
            button16.Text = "3";
            button16.TextAlign = ContentAlignment.TopCenter;
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button18
            // 
            button18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button18.BackColor = Color.FromArgb(51, 65, 85);
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button18.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button18.ForeColor = Color.FromArgb(56, 189, 248);
            button18.Location = new Point(281, 316);
            button18.Margin = new Padding(10, 11, 10, 11);
            button18.Name = "button18";
            button18.Padding = new Padding(1);
            button18.Size = new Size(67, 76);
            button18.TabIndex = 29;
            button18.Text = "+";
            button18.TextAlign = ContentAlignment.TopRight;
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button20
            // 
            button20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button20.BackColor = Color.FromArgb(51, 64, 71);
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button20.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button20.ForeColor = Color.FromArgb(255, 250, 252);
            button20.Location = new Point(20, 414);
            button20.Margin = new Padding(10, 11, 10, 11);
            button20.Name = "button20";
            button20.Padding = new Padding(1);
            button20.Size = new Size(67, 76);
            button20.TabIndex = 32;
            button20.Text = ".";
            button20.TextAlign = ContentAlignment.TopCenter;
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button19
            // 
            button19.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button19.BackColor = Color.FromArgb(51, 64, 71);
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button19.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button19.ForeColor = Color.FromArgb(255, 250, 252);
            button19.Location = new Point(107, 414);
            button19.Margin = new Padding(10, 11, 10, 11);
            button19.Name = "button19";
            button19.Padding = new Padding(1);
            button19.Size = new Size(67, 76);
            button19.TabIndex = 30;
            button19.Text = "0";
            button19.TextAlign = ContentAlignment.TopCenter;
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(51, 64, 71);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button2.ForeColor = Color.FromArgb(255, 250, 252);
            button2.Location = new Point(194, 414);
            button2.Margin = new Padding(10, 11, 10, 11);
            button2.Name = "button2";
            button2.Padding = new Padding(1);
            button2.Size = new Size(67, 76);
            button2.TabIndex = 15;
            button2.Text = "C";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button21
            // 
            button21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button21.BackColor = Color.Cyan;
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 255, 226);
            button21.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 71, 79);
            button21.FlatStyle = FlatStyle.Flat;
            button21.Font = new Font("Segoe UI Variable Display", 25.8000011F);
            button21.ForeColor = Color.FromArgb(15, 23, 42);
            button21.Location = new Point(20, 512);
            button21.Margin = new Padding(10, 11, 10, 11);
            button21.Name = "button21";
            button21.Padding = new Padding(1);
            button21.Size = new Size(328, 76);
            button21.TabIndex = 33;
            button21.Text = "=";
            button21.TextAlign = ContentAlignment.TopCenter;
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click;
            // 
            // DisplayTexto
            // 
            DisplayTexto.BackColor = Color.FromArgb(9, 14, 20);
            DisplayTexto.ForeColor = SystemColors.Window;
            DisplayTexto.Location = new Point(26, 35);
            DisplayTexto.Multiline = true;
            DisplayTexto.Name = "DisplayTexto";
            DisplayTexto.Size = new Size(372, 85);
            DisplayTexto.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 20, 25);
            ClientSize = new Size(420, 727);
            Controls.Add(DisplayTexto);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Padding = new Padding(5, 6, 5, 6);
            Text = "FuntionsEvaluator";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text = DisplayTexto.Text.Substring(0,DisplayTexto.Text.Length-1) ;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DisplayTexto.Text += "/";
        }
        #endregion

        private TextBox textBox1;

        public TextBox txtDisplay { get; private set; }

        private Button button9;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button btncloseParenthesis;
        private Button button7;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button12;
        private Button button10;
        private Button button11;
        private Button button13;
        private Button button17;
        private Button button15;
        private Button button16;
        private Button button18;
        private Button button19;
        private Button btnParenthesisOpen;
        private Button button20;
        private Button btnPow;
        private Button button21;
        private TextBox DisplayTexto;
    }
}
