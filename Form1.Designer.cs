namespace AutoKey
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(12, 156);
            button1.Name = "button1";
            button1.Size = new Size(239, 35);
            button1.TabIndex = 0;
            button1.Text = "Start hotkey";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 53);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Текст для спама";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 82);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Кол-во циклов";
            textBox2.Size = new Size(239, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 111);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Зедержка ";
            textBox3.Size = new Size(239, 23);
            textBox3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20F);
            label2.Location = new Point(27, 9);
            label2.Name = "label2";
            label2.Size = new Size(215, 37);
            label2.TabIndex = 5;
            label2.Text = "AUTO HOTKEY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(263, 203);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Auto HotKey";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
    }
}
