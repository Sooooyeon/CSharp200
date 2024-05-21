namespace A134_CheckBox
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 40);
            label1.Name = "label1";
            label1.Size = new Size(225, 15);
            label1.TabIndex = 0;
            label1.Text = "질문 : 좋아하는 과일을 모두 선택하시오.";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(37, 82);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "사과";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(37, 107);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(38, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "배";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(37, 132);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(50, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "딸기";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(37, 157);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(62, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "바나나";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(37, 182);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(62, 19);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "오렌지";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(183, 174);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "제출";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 230);
            Controls.Add(button1);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button button1;
    }
}
