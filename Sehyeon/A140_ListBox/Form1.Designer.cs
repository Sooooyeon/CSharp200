﻿namespace A140_ListBox
{
    partial class ListBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectedIndex = new System.Windows.Forms.Label();
            this.SelectedItem = new System.Windows.Forms.Label();
            this.txtSIndex1 = new System.Windows.Forms.TextBox();
            this.txtSItem1 = new System.Windows.Forms.TextBox();
            this.txtSItem2 = new System.Windows.Forms.TextBox();
            this.txtSIndex2 = new System.Windows.Forms.TextBox();
            this.txtSItem13 = new System.Windows.Forms.TextBox();
            this.txtSIndex3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(127, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(96, 88);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "GDP 순위";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(247, 91);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(96, 88);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(366, 91);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(96, 88);
            this.listBox3.TabIndex = 3;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "살기좋은 도시";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "행복한 나라";
            // 
            // SelectedIndex
            // 
            this.SelectedIndex.AutoSize = true;
            this.SelectedIndex.Location = new System.Drawing.Point(22, 225);
            this.SelectedIndex.Name = "SelectedIndex";
            this.SelectedIndex.Size = new System.Drawing.Size(85, 12);
            this.SelectedIndex.TabIndex = 6;
            this.SelectedIndex.Text = "SelectedIndex";
            // 
            // SelectedItem
            // 
            this.SelectedItem.AutoSize = true;
            this.SelectedItem.Location = new System.Drawing.Point(22, 257);
            this.SelectedItem.Name = "SelectedItem";
            this.SelectedItem.Size = new System.Drawing.Size(82, 12);
            this.SelectedItem.TabIndex = 7;
            this.SelectedItem.Text = "SelectedItem:";
            // 
            // txtSIndex1
            // 
            this.txtSIndex1.Location = new System.Drawing.Point(127, 222);
            this.txtSIndex1.Name = "txtSIndex1";
            this.txtSIndex1.Size = new System.Drawing.Size(100, 21);
            this.txtSIndex1.TabIndex = 8;
            this.txtSIndex1.Text = "txtSIndex1";
            // 
            // txtSItem1
            // 
            this.txtSItem1.Location = new System.Drawing.Point(127, 254);
            this.txtSItem1.Name = "txtSItem1";
            this.txtSItem1.Size = new System.Drawing.Size(100, 21);
            this.txtSItem1.TabIndex = 9;
            // 
            // txtSItem2
            // 
            this.txtSItem2.Location = new System.Drawing.Point(247, 254);
            this.txtSItem2.Name = "txtSItem2";
            this.txtSItem2.Size = new System.Drawing.Size(100, 21);
            this.txtSItem2.TabIndex = 11;
            // 
            // txtSIndex2
            // 
            this.txtSIndex2.Location = new System.Drawing.Point(247, 222);
            this.txtSIndex2.Name = "txtSIndex2";
            this.txtSIndex2.Size = new System.Drawing.Size(100, 21);
            this.txtSIndex2.TabIndex = 10;
            // 
            // txtSItem13
            // 
            this.txtSItem13.Location = new System.Drawing.Point(366, 254);
            this.txtSItem13.Name = "txtSItem13";
            this.txtSItem13.Size = new System.Drawing.Size(100, 21);
            this.txtSItem13.TabIndex = 13;
            // 
            // txtSIndex3
            // 
            this.txtSIndex3.Location = new System.Drawing.Point(366, 222);
            this.txtSIndex3.Name = "txtSIndex3";
            this.txtSIndex3.Size = new System.Drawing.Size(100, 21);
            this.txtSIndex3.TabIndex = 12;
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 324);
            this.Controls.Add(this.txtSItem13);
            this.Controls.Add(this.txtSIndex3);
            this.Controls.Add(this.txtSItem2);
            this.Controls.Add(this.txtSIndex2);
            this.Controls.Add(this.txtSItem1);
            this.Controls.Add(this.txtSIndex1);
            this.Controls.Add(this.SelectedItem);
            this.Controls.Add(this.SelectedIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SelectedIndex;
        private System.Windows.Forms.Label SelectedItem;
        private System.Windows.Forms.TextBox txtSIndex1;
        private System.Windows.Forms.TextBox txtSItem1;
        private System.Windows.Forms.TextBox txtSItem2;
        private System.Windows.Forms.TextBox txtSIndex2;
        private System.Windows.Forms.TextBox txtSItem13;
        private System.Windows.Forms.TextBox txtSIndex3;
    }
}

