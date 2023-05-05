namespace WindowsFormsApp1
{
    partial class Calculator
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
            this.numOne = new System.Windows.Forms.Button();
            this.numTwo = new System.Windows.Forms.Button();
            this.numFour = new System.Windows.Forms.Button();
            this.numThree = new System.Windows.Forms.Button();
            this.numFive = new System.Windows.Forms.Button();
            this.numSix = new System.Windows.Forms.Button();
            this.numSeven = new System.Windows.Forms.Button();
            this.numEight = new System.Windows.Forms.Button();
            this.numNine = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.numZero = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblhistory = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayOrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numOne
            // 
            this.numOne.BackColor = System.Drawing.Color.Transparent;
            this.numOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numOne.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numOne.Location = new System.Drawing.Point(27, 307);
            this.numOne.Name = "numOne";
            this.numOne.Size = new System.Drawing.Size(82, 62);
            this.numOne.TabIndex = 0;
            this.numOne.Tag = "number";
            this.numOne.Text = "1";
            this.numOne.UseVisualStyleBackColor = false;
            this.numOne.Click += new System.EventHandler(this.number);
            // 
            // numTwo
            // 
            this.numTwo.BackColor = System.Drawing.Color.Transparent;
            this.numTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numTwo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numTwo.Location = new System.Drawing.Point(117, 307);
            this.numTwo.Name = "numTwo";
            this.numTwo.Size = new System.Drawing.Size(82, 62);
            this.numTwo.TabIndex = 1;
            this.numTwo.Tag = "number";
            this.numTwo.Text = "2";
            this.numTwo.UseVisualStyleBackColor = false;
            this.numTwo.Click += new System.EventHandler(this.number);
            // 
            // numFour
            // 
            this.numFour.BackColor = System.Drawing.Color.Transparent;
            this.numFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numFour.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numFour.Location = new System.Drawing.Point(27, 239);
            this.numFour.Name = "numFour";
            this.numFour.Size = new System.Drawing.Size(82, 62);
            this.numFour.TabIndex = 2;
            this.numFour.Tag = "number";
            this.numFour.Text = "4";
            this.numFour.UseVisualStyleBackColor = false;
            this.numFour.Click += new System.EventHandler(this.number);
            // 
            // numThree
            // 
            this.numThree.BackColor = System.Drawing.Color.Transparent;
            this.numThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numThree.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numThree.Location = new System.Drawing.Point(205, 307);
            this.numThree.Name = "numThree";
            this.numThree.Size = new System.Drawing.Size(82, 62);
            this.numThree.TabIndex = 3;
            this.numThree.Tag = "number";
            this.numThree.Text = "3";
            this.numThree.UseVisualStyleBackColor = false;
            this.numThree.Click += new System.EventHandler(this.number);
            // 
            // numFive
            // 
            this.numFive.BackColor = System.Drawing.Color.Transparent;
            this.numFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numFive.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numFive.Location = new System.Drawing.Point(117, 240);
            this.numFive.Name = "numFive";
            this.numFive.Size = new System.Drawing.Size(82, 62);
            this.numFive.TabIndex = 4;
            this.numFive.Tag = "number";
            this.numFive.Text = "5";
            this.numFive.UseVisualStyleBackColor = false;
            this.numFive.Click += new System.EventHandler(this.number);
            // 
            // numSix
            // 
            this.numSix.BackColor = System.Drawing.Color.Transparent;
            this.numSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numSix.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numSix.Location = new System.Drawing.Point(205, 239);
            this.numSix.Name = "numSix";
            this.numSix.Size = new System.Drawing.Size(82, 62);
            this.numSix.TabIndex = 5;
            this.numSix.Tag = "number";
            this.numSix.Text = "6";
            this.numSix.UseVisualStyleBackColor = false;
            this.numSix.Click += new System.EventHandler(this.number);
            // 
            // numSeven
            // 
            this.numSeven.BackColor = System.Drawing.Color.Transparent;
            this.numSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numSeven.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numSeven.Location = new System.Drawing.Point(27, 171);
            this.numSeven.Name = "numSeven";
            this.numSeven.Size = new System.Drawing.Size(82, 62);
            this.numSeven.TabIndex = 6;
            this.numSeven.Tag = "number";
            this.numSeven.Text = "7";
            this.numSeven.UseVisualStyleBackColor = false;
            this.numSeven.Click += new System.EventHandler(this.number);
            // 
            // numEight
            // 
            this.numEight.BackColor = System.Drawing.Color.Transparent;
            this.numEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numEight.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numEight.Location = new System.Drawing.Point(117, 172);
            this.numEight.Name = "numEight";
            this.numEight.Size = new System.Drawing.Size(82, 62);
            this.numEight.TabIndex = 7;
            this.numEight.Tag = "number";
            this.numEight.Text = "8";
            this.numEight.UseVisualStyleBackColor = false;
            this.numEight.Click += new System.EventHandler(this.number);
            // 
            // numNine
            // 
            this.numNine.BackColor = System.Drawing.Color.Transparent;
            this.numNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numNine.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numNine.Location = new System.Drawing.Point(205, 171);
            this.numNine.Name = "numNine";
            this.numNine.Size = new System.Drawing.Size(82, 62);
            this.numNine.TabIndex = 8;
            this.numNine.Tag = "number";
            this.numNine.Text = "9";
            this.numNine.UseVisualStyleBackColor = false;
            this.numNine.Click += new System.EventHandler(this.number);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Location = new System.Drawing.Point(27, 105);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(42, 62);
            this.clear.TabIndex = 9;
            this.clear.Tag = "clear";
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.Transparent;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divide.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.divide.Location = new System.Drawing.Point(205, 104);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(82, 62);
            this.divide.TabIndex = 10;
            this.divide.Tag = "mathope";
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.math);
            // 
            // numZero
            // 
            this.numZero.BackColor = System.Drawing.Color.Transparent;
            this.numZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numZero.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numZero.Location = new System.Drawing.Point(27, 375);
            this.numZero.Name = "numZero";
            this.numZero.Size = new System.Drawing.Size(170, 62);
            this.numZero.TabIndex = 11;
            this.numZero.Tag = "number";
            this.numZero.Text = "0";
            this.numZero.UseVisualStyleBackColor = false;
            this.numZero.Click += new System.EventHandler(this.number);
            // 
            // times
            // 
            this.times.BackColor = System.Drawing.Color.Transparent;
            this.times.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.times.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.times.Location = new System.Drawing.Point(117, 104);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(82, 62);
            this.times.TabIndex = 12;
            this.times.Tag = "mathope";
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = false;
            this.times.Click += new System.EventHandler(this.math);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Transparent;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.del.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.del.Location = new System.Drawing.Point(205, 375);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(82, 62);
            this.del.TabIndex = 13;
            this.del.Tag = "number";
            this.del.Text = ",";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.Transparent;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equals.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.equals.Location = new System.Drawing.Point(293, 239);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(82, 198);
            this.equals.TabIndex = 14;
            this.equals.Tag = "mathope";
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Transparent;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCE.Location = new System.Drawing.Point(66, 105);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(43, 62);
            this.btnCE.TabIndex = 15;
            this.btnCE.Tag = "clear";
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Transparent;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minus.Location = new System.Drawing.Point(293, 104);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(82, 62);
            this.minus.TabIndex = 16;
            this.minus.Tag = "mathope";
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.math);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Transparent;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plus.Location = new System.Drawing.Point(293, 172);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(82, 62);
            this.plus.TabIndex = 17;
            this.plus.Tag = "mathope";
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.math);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(27, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 43);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblhistory
            // 
            this.lblhistory.AutoSize = true;
            this.lblhistory.Location = new System.Drawing.Point(30, 36);
            this.lblhistory.Name = "lblhistory";
            this.lblhistory.Size = new System.Drawing.Size(0, 17);
            this.lblhistory.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.grayOrangeToolStripMenuItem,
            this.neonToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 30);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // grayOrangeToolStripMenuItem
            // 
            this.grayOrangeToolStripMenuItem.Name = "grayOrangeToolStripMenuItem";
            this.grayOrangeToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.grayOrangeToolStripMenuItem.Text = "Gray-Orange";
            this.grayOrangeToolStripMenuItem.Click += new System.EventHandler(this.grayOrangeToolStripMenuItem_Click);
            // 
            // neonToolStripMenuItem
            // 
            this.neonToolStripMenuItem.Name = "neonToolStripMenuItem";
            this.neonToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.neonToolStripMenuItem.Text = "Neon";
            this.neonToolStripMenuItem.Click += new System.EventHandler(this.neonToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 24);
            this.toolStripMenuItem1.Text = "Vintage";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(61, 24);
            this.toolStripMenuItem2.Text = "Pastel";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(68, 24);
            this.toolStripMenuItem3.Text = "Nature";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(54, 24);
            this.toolStripMenuItem4.Text = "Dark";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(403, 461);
            this.Controls.Add(this.lblhistory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.del);
            this.Controls.Add(this.times);
            this.Controls.Add(this.numZero);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.numNine);
            this.Controls.Add(this.numEight);
            this.Controls.Add(this.numSeven);
            this.Controls.Add(this.numSix);
            this.Controls.Add(this.numFive);
            this.Controls.Add(this.numThree);
            this.Controls.Add(this.numFour);
            this.Controls.Add(this.numTwo);
            this.Controls.Add(this.numOne);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculator";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numOne;
        private System.Windows.Forms.Button numTwo;
        private System.Windows.Forms.Button numFour;
        private System.Windows.Forms.Button numThree;
        private System.Windows.Forms.Button numFive;
        private System.Windows.Forms.Button numSix;
        private System.Windows.Forms.Button numSeven;
        private System.Windows.Forms.Button numEight;
        private System.Windows.Forms.Button numNine;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button numZero;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblhistory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayOrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

