namespace utility
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label3 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button4 = new Button();
            richTextBox1 = new RichTextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(148, 10);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.Size = new Size(151, 19);
            label1.TabIndex = 0;
            label1.Text = "Support me ♡ ︎";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 41);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "BTC";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(29, 81, 69);
            button2.BackgroundImage = shutty_utility.Properties.Resources.back_button;
            button2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(191, 295);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Size = new Size(56, 50);
            button2.TabIndex = 4;
            toolTip1.SetToolTip(button2, "Back");
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(54, 39);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(381, 19);
            textBox1.TabIndex = 7;
            textBox1.TabStop = false;
            textBox1.Text = "bc1qnucsgcu8pamdplsetx99strq5l94y7dr3t90s930ezctcjakgk4q9dxe2g";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(10, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 8;
            label2.Text = "ETH";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(54, 115);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(381, 19);
            textBox2.TabIndex = 9;
            textBox2.TabStop = false;
            textBox2.Text = "0xd2ecde18e31874abab52b47d655bc4ecd715fabf";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(171, 91, 61);
            button1.FlatAppearance.BorderColor = Color.FromArgb(171, 91, 61);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(158, 70);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(131, 35);
            button1.TabIndex = 2;
            button1.Text = "Copy";
            toolTip1.SetToolTip(button1, "Copy  BTC adress");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.FromArgb(171, 91, 61);
            button4.FlatAppearance.BorderColor = Color.FromArgb(171, 91, 61);
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(158, 146);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(131, 35);
            button4.TabIndex = 3;
            button4.Text = "Copy";
            toolTip1.SetToolTip(button4, "Copy ETH adress");
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(12, 16, 32);
            richTextBox1.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.ForeColor = Color.FromArgb(62, 174, 92);
            richTextBox1.Location = new Point(14, 192);
            richTextBox1.Margin = new Padding(5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(418, 92);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "My contacts\n\nGitHub github.com/jeanofkeep\n\nEmail movadim07@gmail.com";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(29, 41, 81);
            ClientSize = new Size(448, 359);
            Controls.Add(richTextBox1);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SHUTTY UTILITY v1.2.0 by vadii";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ToolTip toolTip1;
    }
}