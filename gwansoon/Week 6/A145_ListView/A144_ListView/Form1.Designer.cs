namespace A144_ListView
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
            this.rbDetail = new System.Windows.Forms.RadioButton();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.myListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbDetail
            // 
            this.rbDetail.AutoSize = true;
            this.rbDetail.Location = new System.Drawing.Point(91, 41);
            this.rbDetail.Name = "rbDetail";
            this.rbDetail.Size = new System.Drawing.Size(87, 22);
            this.rbDetail.TabIndex = 0;
            this.rbDetail.TabStop = true;
            this.rbDetail.Text = "자세히";
            this.rbDetail.UseVisualStyleBackColor = true;
            this.rbDetail.CheckedChanged += new System.EventHandler(this.rbDetail_CheckedChanged);
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(227, 41);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(87, 22);
            this.rbList.TabIndex = 1;
            this.rbList.TabStop = true;
            this.rbList.Text = "리스트";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.rbList_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(368, 41);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(129, 22);
            this.rbSmall.TabIndex = 2;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "작은 아이콘";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(546, 41);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(111, 22);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "큰 아이콘";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // myListView
            // 
            this.myListView.HideSelection = false;
            this.myListView.Location = new System.Drawing.Point(48, 84);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(664, 309);
            this.myListView.TabIndex = 4;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.SelectedIndexChanged += new System.EventHandler(this.myListView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected";
            // 
            // txtSelected
            // 
            this.txtSelected.Location = new System.Drawing.Point(309, 419);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(403, 28);
            this.txtSelected.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 485);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myListView);
            this.Controls.Add(this.rbLarge);
            this.Controls.Add(this.rbSmall);
            this.Controls.Add(this.rbList);
            this.Controls.Add(this.rbDetail);
            this.Name = "Form1";
            this.Text = "ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
       
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDetail;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.ListView myListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelected;
    }
}

