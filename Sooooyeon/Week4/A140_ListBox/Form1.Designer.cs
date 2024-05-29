namespace A140_ListBox
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
            this.txtSIndex1 = new System.Windows.Forms.TextBox();
            this.txtSitem1 = new System.Windows.Forms.TextBox();
            this.txtSitem2 = new System.Windows.Forms.TextBox();
            this.txtSIndex2 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtSitem3 = new System.Windows.Forms.TextBox();
            this.txtSIndex3 = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.listBox1.Location = new System.Drawing.Point(141, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 172);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtSIndex1
            // 
            this.txtSIndex1.Location = new System.Drawing.Point(141, 248);
            this.txtSIndex1.Name = "txtSIndex1";
            this.txtSIndex1.Size = new System.Drawing.Size(182, 21);
            this.txtSIndex1.TabIndex = 1;
            // 
            // txtSitem1
            // 
            this.txtSitem1.Location = new System.Drawing.Point(141, 286);
            this.txtSitem1.Name = "txtSitem1";
            this.txtSitem1.Size = new System.Drawing.Size(182, 21);
            this.txtSitem1.TabIndex = 2;
            // 
            // txtSitem2
            // 
            this.txtSitem2.Location = new System.Drawing.Point(364, 286);
            this.txtSitem2.Name = "txtSitem2";
            this.txtSitem2.Size = new System.Drawing.Size(182, 21);
            this.txtSitem2.TabIndex = 5;
            // 
            // txtSIndex2
            // 
            this.txtSIndex2.Location = new System.Drawing.Point(364, 248);
            this.txtSIndex2.Name = "txtSIndex2";
            this.txtSIndex2.Size = new System.Drawing.Size(182, 21);
            this.txtSIndex2.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(364, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(182, 172);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // txtSitem3
            // 
            this.txtSitem3.Location = new System.Drawing.Point(584, 286);
            this.txtSitem3.Name = "txtSitem3";
            this.txtSitem3.Size = new System.Drawing.Size(182, 21);
            this.txtSitem3.TabIndex = 8;
            // 
            // txtSIndex3
            // 
            this.txtSIndex3.Location = new System.Drawing.Point(584, 248);
            this.txtSIndex3.Name = "txtSIndex3";
            this.txtSIndex3.Size = new System.Drawing.Size(182, 21);
            this.txtSIndex3.TabIndex = 7;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(584, 59);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(182, 172);
            this.listBox3.TabIndex = 6;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "GDP 순위";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "살기좋은 도시";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "행복한 나라";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "SelectedIndex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "SelectedItem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSitem3);
            this.Controls.Add(this.txtSIndex3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.txtSitem2);
            this.Controls.Add(this.txtSIndex2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.txtSitem1);
            this.Controls.Add(this.txtSIndex1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtSIndex1;
        private System.Windows.Forms.TextBox txtSitem1;
        private System.Windows.Forms.TextBox txtSitem2;
        private System.Windows.Forms.TextBox txtSIndex2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtSitem3;
        private System.Windows.Forms.TextBox txtSIndex3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

