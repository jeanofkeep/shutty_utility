using System.Drawing;

namespace utility
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown1.ForeColor = SystemColors.InfoText;
            numericUpDown1.Location = new Point(18, 50);
            numericUpDown1.Margin = new Padding(10);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(412, 20);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(-4, 7);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Padding = new Padding(6);
            label1.Size = new Size(285, 31);
            label1.TabIndex = 0;
            label1.Text = " Enter the time(minutes)";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(55, 55, 55);
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(278, 93);
            button5.Margin = new Padding(10);
            button5.Name = "button5";
            button5.Size = new Size(65, 58);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(132, 55, 16);
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(364, 93);
            button4.Margin = new Padding(10);
            button4.Name = "button4";
            button4.Size = new Size(65, 58);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(105, 93);
            button3.Margin = new Padding(10);
            button3.Name = "button3";
            button3.Size = new Size(65, 58);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 179, 0);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(191, 93);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Size = new Size(65, 58);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0, true);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 93);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Size = new Size(56, 50);
            button1.TabIndex = 2;
            toolTip1.SetToolTip(button1, "Shutdown");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(76, 330);
            label2.Margin = new Padding(9);
            label2.Name = "label2";
            label2.Size = new Size(287, 13);
            label2.TabIndex = 7;
            label2.Text = "© 2025 Shutty Utility – Open Source";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(12, 16, 32);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.ForeColor = Color.FromArgb(62, 174, 92);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 13;
            listBox1.Location = new Point(16, 167);
            listBox1.Margin = new Padding(6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(412, 143);
            listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(29, 41, 81);
            ClientSize = new Size(448, 359);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            ForeColor = SystemColors.ButtonFace;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SHUTTY UTILITY v1.0 by vadii";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

