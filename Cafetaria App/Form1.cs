using System.Security.Policy;

namespace LESSONS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total=0.0,mcoast;//mcoast to save coast im memory
        
        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, cola, glass, cookie;
            if (textBox1.Text=="") popcorn= 0;
            else popcorn = Convert.ToInt16(textBox1.Text);
            if (textBox2.Text=="") cola =0;
            else cola = Convert.ToInt16(textBox2.Text);
            if (textBox3.Text=="") glass = 0;
            else glass = Convert.ToInt16(textBox3.Text);
            if (textBox4.Text=="") cookie = 0;
            else cookie = Convert.ToInt16(textBox4.Text);   
            double coast = (popcorn * 3.99) + (cola * 2.49) + (glass * 7.85) + (cookie * 1.49);
            mcoast= coast;
            label11.Text=coast.ToString("0.00") + " $";
            total += coast;
            label10.Text=total.ToString("0.00") + " $";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "") MessageBox.Show("Please give the amount of \ncash money to calculate change");
            else
            {
                double money = Convert.ToInt16(textBox5.Text);
                double change = money - mcoast;
                label14.Text = change.ToString("0.00") + " $";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label11.Text = "00 $";
        }

       
        
    }
}