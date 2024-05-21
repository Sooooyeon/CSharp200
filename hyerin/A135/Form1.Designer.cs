namespace A135
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
            this.rbKorea = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbChina = new System.Windows.Forms.RadioButton();
            this.rbJapan = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMaie = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbKorea
            // 
            this.rbKorea.AutoSize = true;
            this.rbKorea.Location = new System.Drawing.Point(33, 20);
            this.rbKorea.Name = "rbKorea";
            this.rbKorea.Size = new System.Drawing.Size(56, 16);
            this.rbKorea.TabIndex = 0;
            this.rbKorea.TabStop = true;
            this.rbKorea.Text = "Korea";
            this.rbKorea.UseVisualStyleBackColor = true;
            this.rbKorea.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.rbChina);
            this.groupBox1.Controls.Add(this.rbJapan);
            this.groupBox1.Controls.Add(this.rbKorea);
            this.groupBox1.Location = new System.Drawing.Point(49, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Japan";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(33, 147);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(53, 16);
            this.rbOther.TabIndex = 6;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbChina
            // 
            this.rbChina.AutoSize = true;
            this.rbChina.Location = new System.Drawing.Point(33, 64);
            this.rbChina.Name = "rbChina";
            this.rbChina.Size = new System.Drawing.Size(56, 16);
            this.rbChina.TabIndex = 3;
            this.rbChina.TabStop = true;
            this.rbChina.Text = "China";
            this.rbChina.UseVisualStyleBackColor = true;
            // 
            // rbJapan
            // 
            this.rbJapan.AutoSize = true;
            this.rbJapan.Location = new System.Drawing.Point(33, 104);
            this.rbJapan.Name = "rbJapan";
            this.rbJapan.Size = new System.Drawing.Size(57, 16);
            this.rbJapan.TabIndex = 1;
            this.rbJapan.TabStop = true;
            this.rbJapan.Text = "Japan";
            this.rbJapan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.rbMaie);
            this.groupBox2.Location = new System.Drawing.Point(394, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(159, 53);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(65, 16);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMaie
            // 
            this.rbMaie.AutoSize = true;
            this.rbMaie.Location = new System.Drawing.Point(33, 53);
            this.rbMaie.Name = "rbMaie";
            this.rbMaie.Size = new System.Drawing.Size(51, 16);
            this.rbMaie.TabIndex = 5;
            this.rbMaie.TabStop = true;
            this.rbMaie.Text = "Male";
            this.rbMaie.UseVisualStyleBackColor = true;
            this.rbMaie.CheckedChanged += new System.EventHandler(this.rbMaie_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbKorea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbChina;
        private System.Windows.Forms.RadioButton rbJapan;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMaie;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.Button button1;
    }
}

