namespace A143_GradeCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.crd1 = new System.Windows.Forms.ComboBox();
            this.grd1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.crd2 = new System.Windows.Forms.ComboBox();
            this.crd3 = new System.Windows.Forms.ComboBox();
            this.crd4 = new System.Windows.Forms.ComboBox();
            this.crd5 = new System.Windows.Forms.ComboBox();
            this.crd6 = new System.Windows.Forms.ComboBox();
            this.crd7 = new System.Windows.Forms.ComboBox();
            this.grd2 = new System.Windows.Forms.ComboBox();
            this.grd3 = new System.Windows.Forms.ComboBox();
            this.grd4 = new System.Windows.Forms.ComboBox();
            this.grd5 = new System.Windows.Forms.ComboBox();
            this.grd6 = new System.Windows.Forms.ComboBox();
            this.grd7 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "과목명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "학점";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "성적";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(68, 83);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(85, 21);
            this.txt1.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(68, 121);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(85, 21);
            this.txt2.TabIndex = 4;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(68, 162);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(85, 21);
            this.txt3.TabIndex = 5;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(68, 206);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(85, 21);
            this.txt4.TabIndex = 6;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(68, 253);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(85, 21);
            this.txt5.TabIndex = 7;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(68, 305);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(85, 21);
            this.txt6.TabIndex = 8;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(68, 362);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(85, 21);
            this.txt7.TabIndex = 9;
            // 
            // crd1
            // 
            this.crd1.FormattingEnabled = true;
            this.crd1.Location = new System.Drawing.Point(274, 84);
            this.crd1.Name = "crd1";
            this.crd1.Size = new System.Drawing.Size(86, 20);
            this.crd1.TabIndex = 10;
            // 
            // grd1
            // 
            this.grd1.FormattingEnabled = true;
            this.grd1.Location = new System.Drawing.Point(450, 83);
            this.grd1.Name = "grd1";
            this.grd1.Size = new System.Drawing.Size(86, 20);
            this.grd1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "평균평점";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(450, 416);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(95, 21);
            this.txtGrade.TabIndex = 25;
            // 
            // crd2
            // 
            this.crd2.FormattingEnabled = true;
            this.crd2.Location = new System.Drawing.Point(274, 122);
            this.crd2.Name = "crd2";
            this.crd2.Size = new System.Drawing.Size(86, 20);
            this.crd2.TabIndex = 27;
            // 
            // crd3
            // 
            this.crd3.FormattingEnabled = true;
            this.crd3.Location = new System.Drawing.Point(273, 162);
            this.crd3.Name = "crd3";
            this.crd3.Size = new System.Drawing.Size(86, 20);
            this.crd3.TabIndex = 29;
            // 
            // crd4
            // 
            this.crd4.FormattingEnabled = true;
            this.crd4.Location = new System.Drawing.Point(273, 206);
            this.crd4.Name = "crd4";
            this.crd4.Size = new System.Drawing.Size(86, 20);
            this.crd4.TabIndex = 30;
            // 
            // crd5
            // 
            this.crd5.FormattingEnabled = true;
            this.crd5.Location = new System.Drawing.Point(273, 253);
            this.crd5.Name = "crd5";
            this.crd5.Size = new System.Drawing.Size(86, 20);
            this.crd5.TabIndex = 31;
            // 
            // crd6
            // 
            this.crd6.FormattingEnabled = true;
            this.crd6.Location = new System.Drawing.Point(273, 305);
            this.crd6.Name = "crd6";
            this.crd6.Size = new System.Drawing.Size(86, 20);
            this.crd6.TabIndex = 32;
            // 
            // crd7
            // 
            this.crd7.FormattingEnabled = true;
            this.crd7.Location = new System.Drawing.Point(273, 362);
            this.crd7.Name = "crd7";
            this.crd7.Size = new System.Drawing.Size(86, 20);
            this.crd7.TabIndex = 33;
            // 
            // grd2
            // 
            this.grd2.FormattingEnabled = true;
            this.grd2.Location = new System.Drawing.Point(450, 121);
            this.grd2.Name = "grd2";
            this.grd2.Size = new System.Drawing.Size(86, 20);
            this.grd2.TabIndex = 34;
            // 
            // grd3
            // 
            this.grd3.FormattingEnabled = true;
            this.grd3.Location = new System.Drawing.Point(450, 162);
            this.grd3.Name = "grd3";
            this.grd3.Size = new System.Drawing.Size(86, 20);
            this.grd3.TabIndex = 35;
            // 
            // grd4
            // 
            this.grd4.FormattingEnabled = true;
            this.grd4.Location = new System.Drawing.Point(450, 206);
            this.grd4.Name = "grd4";
            this.grd4.Size = new System.Drawing.Size(86, 20);
            this.grd4.TabIndex = 36;
            // 
            // grd5
            // 
            this.grd5.FormattingEnabled = true;
            this.grd5.Location = new System.Drawing.Point(450, 253);
            this.grd5.Name = "grd5";
            this.grd5.Size = new System.Drawing.Size(86, 20);
            this.grd5.TabIndex = 37;
            // 
            // grd6
            // 
            this.grd6.FormattingEnabled = true;
            this.grd6.Location = new System.Drawing.Point(450, 305);
            this.grd6.Name = "grd6";
            this.grd6.Size = new System.Drawing.Size(86, 20);
            this.grd6.TabIndex = 38;
            // 
            // grd7
            // 
            this.grd7.FormattingEnabled = true;
            this.grd7.Location = new System.Drawing.Point(450, 362);
            this.grd7.Name = "grd7";
            this.grd7.Size = new System.Drawing.Size(86, 20);
            this.grd7.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 455);
            this.Controls.Add(this.grd7);
            this.Controls.Add(this.grd6);
            this.Controls.Add(this.grd5);
            this.Controls.Add(this.grd4);
            this.Controls.Add(this.grd3);
            this.Controls.Add(this.grd2);
            this.Controls.Add(this.crd7);
            this.Controls.Add(this.crd6);
            this.Controls.Add(this.crd5);
            this.Controls.Add(this.crd4);
            this.Controls.Add(this.crd3);
            this.Controls.Add(this.crd2);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grd1);
            this.Controls.Add(this.crd1);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.ComboBox crd1;
        private System.Windows.Forms.ComboBox grd1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.ComboBox crd2;
        private System.Windows.Forms.ComboBox crd3;
        private System.Windows.Forms.ComboBox crd4;
        private System.Windows.Forms.ComboBox crd5;
        private System.Windows.Forms.ComboBox crd6;
        private System.Windows.Forms.ComboBox crd7;
        private System.Windows.Forms.ComboBox grd2;
        private System.Windows.Forms.ComboBox grd3;
        private System.Windows.Forms.ComboBox grd4;
        private System.Windows.Forms.ComboBox grd5;
        private System.Windows.Forms.ComboBox grd6;
        private System.Windows.Forms.ComboBox grd7;
    }
}

