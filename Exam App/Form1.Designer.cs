namespace exam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quesNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.corNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wroNum = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.Button();
            this.trueans = new System.Windows.Forms.Label();
            this.userans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(534, 229);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(591, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question Number:";
            // 
            // quesNum
            // 
            this.quesNum.AutoSize = true;
            this.quesNum.Location = new System.Drawing.Point(780, 48);
            this.quesNum.Name = "quesNum";
            this.quesNum.Size = new System.Drawing.Size(21, 23);
            this.quesNum.TabIndex = 2;
            this.quesNum.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(611, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correct Answer:";
            // 
            // corNum
            // 
            this.corNum.AutoSize = true;
            this.corNum.Location = new System.Drawing.Point(780, 98);
            this.corNum.Name = "corNum";
            this.corNum.Size = new System.Drawing.Size(21, 23);
            this.corNum.TabIndex = 4;
            this.corNum.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(619, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wrong Answer:";
            // 
            // wroNum
            // 
            this.wroNum.AutoSize = true;
            this.wroNum.Location = new System.Drawing.Point(780, 151);
            this.wroNum.Name = "wroNum";
            this.wroNum.Size = new System.Drawing.Size(21, 23);
            this.wroNum.TabIndex = 6;
            this.wroNum.Text = "0";
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnA.Location = new System.Drawing.Point(12, 261);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(236, 63);
            this.btnA.TabIndex = 7;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnB.Location = new System.Drawing.Point(310, 261);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(236, 63);
            this.btnB.TabIndex = 8;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC.Location = new System.Drawing.Point(12, 345);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(236, 63);
            this.btnC.TabIndex = 9;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnD.Location = new System.Drawing.Point(310, 345);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(236, 63);
            this.btnD.TabIndex = 10;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(724, 316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(611, 196);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(218, 45);
            this.next.TabIndex = 13;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.button5_Click);
            // 
            // trueans
            // 
            this.trueans.AutoSize = true;
            this.trueans.Location = new System.Drawing.Point(340, 442);
            this.trueans.Name = "trueans";
            this.trueans.Size = new System.Drawing.Size(62, 23);
            this.trueans.TabIndex = 14;
            this.trueans.Text = "label2";
            this.trueans.Visible = false;
            // 
            // userans
            // 
            this.userans.AutoSize = true;
            this.userans.Location = new System.Drawing.Point(425, 442);
            this.userans.Name = "userans";
            this.userans.Size = new System.Drawing.Size(62, 23);
            this.userans.TabIndex = 15;
            this.userans.Text = "label2";
            this.userans.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 415);
            this.Controls.Add(this.userans);
            this.Controls.Add(this.trueans);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.wroNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.corNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quesNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Label quesNum;
        private Label label3;
        private Label corNum;
        private Label label5;
        private Label wroNum;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button next;
        private Label trueans;
        private Label userans;
    }
}