using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        Double result = 0;
        bool mathope = false;
        string ope = "";//to memorize old operation
       
        public Calculator()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }
        
        private void number(object sender, EventArgs e)
        {
            if(textBox1.Text == "0"||mathope)
                textBox1.Clear();
            
            mathope= false;
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void math(object sender, EventArgs e)
        {
            mathope= true;
            Button btn = (Button)sender;
            string newope = btn.Text;
            lblhistory.Text = lblhistory.Text + " " + textBox1.Text + " " +" "+ newope;
            switch (ope) 
            {
                case "+": textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();break;
                case "-": textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString(); break;
                case "*": textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString(); break;
                default:break;
            }
            result=Double.Parse(textBox1.Text);
            textBox1.Text=result.ToString();
            ope= newope;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblhistory.Text= "";
            ope = "";
            result = 0;
            mathope = false;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            lblhistory.Text = "";
            switch (ope)
            {
                case "+": textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString(); break;
                case "*": textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString(); break;
                default: break;
            }
            result=Double.Parse((textBox1.Text));
            textBox1.Text=(result.ToString());
            ope = "";
        }

        private void del_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Text= "0";
            }
            else if (mathope)
            {
                textBox1.Text = "0";
            }
            if(!textBox1.Text.Contains(",")) {
                textBox1.Text += ",";            
            }
            mathope=false;

        }
        public void forecolorblack(Button button)
        {
            button.ForeColor = Color.Black;
            lblhistory.ForeColor = Color.Black;
        }
        public void forecolorwite(Button button)
        {
            button.ForeColor = Color.White;
            lblhistory.ForeColor = Color.White;
        }
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "number")
                {
                    button.BackColor = Color.White;
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "mathope")
                {
                    button.BackColor = Color.White;
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "clear")
                {
                    button.BackColor = Color.White;
                    forecolorblack(button);
                }
            }
        }

        private void grayOrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "number")
                {
                    button.BackColor = ColorTranslator.FromHtml("#FFA559");
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "mathope")
                {
                    button.BackColor = ColorTranslator.FromHtml("#454545");
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "clear")
                {
                    button.BackColor = ColorTranslator.FromHtml("#FFE6C7");
                    forecolorblack(button);
                }
            }
        }

        private void neonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E3F6FF");
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "number")
                {
                    button.BackColor = ColorTranslator.FromHtml("#8DCBE6");
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "mathope")
                {
                    button.BackColor = ColorTranslator.FromHtml("#9DF1DF");
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "clear")
                {
                    button.BackColor = ColorTranslator.FromHtml("#FFEA20");
                    forecolorblack(button);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)//vintage
        {
            this.BackColor = ColorTranslator.FromHtml("#9E6F21");
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "number")
                {
                    button.BackColor = ColorTranslator.FromHtml("#ABC4AA");
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "mathope")
                {
                    button.BackColor = ColorTranslator.FromHtml("#F3DEBA");
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "clear")
                {
                    button.BackColor = ColorTranslator.FromHtml("#E7B10A");
                    forecolorblack(button);
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)//pastel
        {
            this.BackColor = ColorTranslator.FromHtml("#B7B7B7");
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "number")
                {
                    button.BackColor = ColorTranslator.FromHtml("#7C96AB");
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "mathope")
                {
                    button.BackColor = ColorTranslator.FromHtml("#BFCCB5");
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "clear")
                {
                    button.BackColor = ColorTranslator.FromHtml("#EDC6B1");
                    forecolorblack(button);
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)//nature
        {
            this.BackColor = ColorTranslator.FromHtml("#E6E2C3");
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "number")
                {
                    button.BackColor = ColorTranslator.FromHtml("#88A47C");
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "mathope")
                {
                    button.BackColor = ColorTranslator.FromHtml("#227C70");
                    forecolorblack(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "clear")
                {
                    button.BackColor = ColorTranslator.FromHtml("#344D67");
                    forecolorblack(button);
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)//dark
        {
            this.BackColor = ColorTranslator.FromHtml("#11150d");
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "number")
                {
                    button.BackColor = ColorTranslator.FromHtml("#33322e");
                    forecolorwite(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "mathope")
                {
                    button.BackColor = ColorTranslator.FromHtml("#33322e");
                    forecolorwite(button);
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag?.ToString() == "clear")
                {
                    button.BackColor = ColorTranslator.FromHtml("#33322e");
                    forecolorwite(button);
                }
            }
        }
    }
}
