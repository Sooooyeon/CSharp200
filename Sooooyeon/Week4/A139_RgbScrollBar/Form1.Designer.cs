﻿namespace A139_RgbScrollBar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.scrR = new System.Windows.Forms.HScrollBar();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.scrG = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.scrB = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(46, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 175);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // scrR
            // 
            this.scrR.Location = new System.Drawing.Point(125, 269);
            this.scrR.Name = "scrR";
            this.scrR.Size = new System.Drawing.Size(475, 21);
            this.scrR.TabIndex = 2;
            this.scrR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(629, 269);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 21);
            this.txtR.TabIndex = 3;
            this.txtR.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(629, 317);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 21);
            this.txtG.TabIndex = 6;
            this.txtG.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // scrG
            // 
            this.scrG.Location = new System.Drawing.Point(125, 317);
            this.scrG.Name = "scrG";
            this.scrG.Size = new System.Drawing.Size(475, 21);
            this.scrG.TabIndex = 5;
            this.scrG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Green";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(629, 365);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 21);
            this.txtB.TabIndex = 9;
            this.txtB.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // scrB
            // 
            this.scrB.Location = new System.Drawing.Point(125, 365);
            this.scrB.Name = "scrB";
            this.scrB.Size = new System.Drawing.Size(475, 21);
            this.scrB.TabIndex = 8;
            this.scrB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.scrB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.scrG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.scrR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar scrR;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.HScrollBar scrG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.HScrollBar scrB;
        private System.Windows.Forms.Label label3;
    }
}

