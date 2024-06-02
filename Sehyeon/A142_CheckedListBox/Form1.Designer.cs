namespace A142_CheckedListBox
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
            this.cLstBox = new System.Windows.Forms.CheckedListBox();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnTo = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cLstBox
            // 
            this.cLstBox.FormattingEnabled = true;
            this.cLstBox.Location = new System.Drawing.Point(96, 60);
            this.cLstBox.Name = "cLstBox";
            this.cLstBox.Size = new System.Drawing.Size(217, 244);
            this.cLstBox.TabIndex = 0;
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(600, 370);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(120, 32);
            this.btnDelAll.TabIndex = 1;
            this.btnDelAll.Text = "모두 삭제";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 15;
            this.lstBox.Location = new System.Drawing.Point(465, 60);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(255, 244);
            this.lstBox.TabIndex = 2;
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(347, 113);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(83, 32);
            this.btnTo.TabIndex = 3;
            this.btnTo.Text = ">";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(347, 164);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(83, 32);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = ">>";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(347, 223);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 32);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.cLstBox);
            this.Name = "Form1";
            this.Text = "Traver Wish List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cLstBox;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnBack;
    }
}

