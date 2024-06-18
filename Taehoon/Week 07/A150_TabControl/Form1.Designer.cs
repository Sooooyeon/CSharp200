namespace A150_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAlarmSet = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnSet);
            this.tabPage1.Controls.Add(this.timePicker);
            this.tabPage1.Controls.Add(this.datePicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "알람 설정";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTime);
            this.tabPage2.Controls.Add(this.lblDate);
            this.tabPage2.Controls.Add(this.lblAlarm);
            this.tabPage2.Controls.Add(this.lblAlarmSet);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "디지털 시계";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(24, 20);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(344, 28);
            this.datePicker.TabIndex = 0;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(24, 222);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(343, 28);
            this.timePicker.TabIndex = 1;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(91, 291);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(91, 46);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "설정";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(212, 291);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 46);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "해제";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblAlarmSet
            // 
            this.lblAlarmSet.AutoSize = true;
            this.lblAlarmSet.Location = new System.Drawing.Point(41, 29);
            this.lblAlarmSet.Name = "lblAlarmSet";
            this.lblAlarmSet.Size = new System.Drawing.Size(86, 18);
            this.lblAlarmSet.TabIndex = 0;
            this.lblAlarmSet.Text = "알람 설정";
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(41, 94);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(54, 18);
            this.lblAlarm.TabIndex = 1;
            this.lblAlarm.Text = "Alarm";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(41, 181);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(41, 273);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 18);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblAlarmSet;
    }
}

