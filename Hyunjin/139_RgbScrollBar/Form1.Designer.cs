namespace _139_RgbScrollBar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.scrR = new System.Windows.Forms.HScrollBar();
            this.scrG = new System.Windows.Forms.HScrollBar();
            this.scrB = new System.Windows.Forms.HScrollBar();
            this.labe1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(72, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 214);
            this.panel1.TabIndex = 0;
            // 
            // scrR
            // 
            this.scrR.Location = new System.Drawing.Point(174, 287);
            this.scrR.Name = "scrR";
            this.scrR.Size = new System.Drawing.Size(478, 39);
            this.scrR.TabIndex = 1;
            this.scrR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // scrG
            // 
            this.scrG.Location = new System.Drawing.Point(174, 391);
            this.scrG.Name = "scrG";
            this.scrG.Size = new System.Drawing.Size(478, 39);
            this.scrG.TabIndex = 2;
            this.scrG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // scrB
            // 
            this.scrB.Location = new System.Drawing.Point(174, 494);
            this.scrB.Name = "scrB";
            this.scrB.Size = new System.Drawing.Size(478, 39);
            this.scrB.TabIndex = 3;
            this.scrB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(84, 299);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(39, 18);
            this.labe1.TabIndex = 4;
            this.labe1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blue";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(721, 287);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 28);
            this.txtR.TabIndex = 8;
            this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtR.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(721, 391);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 28);
            this.txtG.TabIndex = 9;
            this.txtG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtG.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(721, 494);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 28);
            this.txtB.TabIndex = 10;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 598);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.scrB);
            this.Controls.Add(this.scrG);
            this.Controls.Add(this.scrR);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar scrR;
        private System.Windows.Forms.HScrollBar scrG;
        private System.Windows.Forms.HScrollBar scrB;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
    }
}

