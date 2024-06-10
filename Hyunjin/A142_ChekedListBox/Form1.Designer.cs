namespace A142_ChekedListBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cLstBox = new System.Windows.Forms.CheckedListBox();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnTo = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cLstBox
            // 
            this.cLstBox.FormattingEnabled = true;
            this.cLstBox.Location = new System.Drawing.Point(26, 39);
            this.cLstBox.Name = "cLstBox";
            this.cLstBox.Size = new System.Drawing.Size(260, 329);
            this.cLstBox.TabIndex = 0;
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 18;
            this.lstBox.Location = new System.Drawing.Point(415, 39);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(249, 328);
            this.lstBox.TabIndex = 1;
            // 
            // btnTo
            // 
            this.btnTo.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTo.Location = new System.Drawing.Point(309, 93);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(82, 25);
            this.btnTo.TabIndex = 2;
            this.btnTo.Text = ">";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAll.Location = new System.Drawing.Point(309, 199);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(82, 25);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = ">>";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.Location = new System.Drawing.Point(309, 299);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 25);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 415);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.cLstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cLstBox;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnBack;
    }
}

