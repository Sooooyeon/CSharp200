﻿namespace A140_ListBox
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.txtIn1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIt1 = new System.Windows.Forms.TextBox();
            this.txtIt2 = new System.Windows.Forms.TextBox();
            this.txtIn2 = new System.Windows.Forms.TextBox();
            this.txtIn3 = new System.Windows.Forms.TextBox();
            this.txtIt3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "미국",
            "러시아",
            "중국",
            "영국",
            "독일",
            "프랑스",
            "일본",
            "이스라엘",
            "사우디아라비아",
            "UAE",
            "한국"});
            this.listBox1.Location = new System.Drawing.Point(184, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(349, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 88);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(515, 31);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 88);
            this.listBox3.TabIndex = 2;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // txtIn1
            // 
            this.txtIn1.Location = new System.Drawing.Point(184, 149);
            this.txtIn1.Name = "txtIn1";
            this.txtIn1.Size = new System.Drawing.Size(120, 21);
            this.txtIn1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "SelectedIndex:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "SelectedItem";
            // 
            // txtIt1
            // 
            this.txtIt1.Location = new System.Drawing.Point(184, 189);
            this.txtIt1.Name = "txtIt1";
            this.txtIt1.Size = new System.Drawing.Size(120, 21);
            this.txtIt1.TabIndex = 6;
            // 
            // txtIt2
            // 
            this.txtIt2.Location = new System.Drawing.Point(349, 189);
            this.txtIt2.Name = "txtIt2";
            this.txtIt2.Size = new System.Drawing.Size(120, 21);
            this.txtIt2.TabIndex = 7;
            // 
            // txtIn2
            // 
            this.txtIn2.Location = new System.Drawing.Point(349, 149);
            this.txtIn2.Name = "txtIn2";
            this.txtIn2.Size = new System.Drawing.Size(120, 21);
            this.txtIn2.TabIndex = 8;
            // 
            // txtIn3
            // 
            this.txtIn3.Location = new System.Drawing.Point(515, 149);
            this.txtIn3.Name = "txtIn3";
            this.txtIn3.Size = new System.Drawing.Size(120, 21);
            this.txtIn3.TabIndex = 10;
            // 
            // txtIt3
            // 
            this.txtIt3.Location = new System.Drawing.Point(515, 189);
            this.txtIt3.Name = "txtIt3";
            this.txtIt3.Size = new System.Drawing.Size(120, 21);
            this.txtIt3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "GDP 순위";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "살기좋은 도시";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "행복한 나라";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIn3);
            this.Controls.Add(this.txtIt3);
            this.Controls.Add(this.txtIn2);
            this.Controls.Add(this.txtIt2);
            this.Controls.Add(this.txtIt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIn1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox txtIn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIt1;
        private System.Windows.Forms.TextBox txtIt2;
        private System.Windows.Forms.TextBox txtIn2;
        private System.Windows.Forms.TextBox txtIn3;
        private System.Windows.Forms.TextBox txtIt3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

