using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace exam
{
    public partial class Form1 : Form
    {
        private SoundPlayer truesound;
        private SoundPlayer falsesound;
        public Form1()
        {
            InitializeComponent();
            truesound= new SoundPlayer("Correct.wav");
            falsesound = new SoundPlayer("Wrong.wav");
        }

        int questno=0 , corno=0 , wrono=0 ;
       

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            next.Enabled = true;
            userans.Text = btnB.Text;
            if (trueans.Text == userans.Text)
            {
                corno++;
                corNum.Text = corno.ToString();
                pictureBox1.Visible = true;
                btnB.BackColor = Color.Green;
                truesound.Play();
            }
            else
            {
                wrono++;
                wroNum.Text = wrono.ToString();
                pictureBox2.Visible = true;
                btnB.BackColor = Color.Red;
                falsesound.Play();
                
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            next.Enabled = true;
            userans.Text = btnC.Text;
            if (trueans.Text == userans.Text)
            {
                corno++;
                corNum.Text = corno.ToString();
                pictureBox1.Visible = true;
                btnC.BackColor = Color.Green;
                truesound.Play();

            }
            else
            {
                wrono++;
                wroNum.Text = wrono.ToString();
                pictureBox2.Visible = true;
                btnC.BackColor = Color.Red;
                falsesound.Play();
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            next.Enabled = true;
            userans.Text = btnD.Text;
            if (trueans.Text == userans.Text)
            {
                corno++;
                corNum.Text = corno.ToString();
                pictureBox1.Visible = true;
                btnD.BackColor = Color.Green;
                truesound.Play();
            }
            else
            {
                wrono++;
                wroNum.Text = wrono.ToString();
                pictureBox2.Visible = true;
                btnD.BackColor = Color.Red;
                falsesound.Play();
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            next.Enabled = true;
            userans.Text=btnA.Text;
            if (trueans.Text==userans.Text )
            {
                corno++;
                corNum.Text=corno.ToString();
                pictureBox1.Visible = true;
                btnA.BackColor = Color.Green;
                truesound.Play();
            }
            else
            {
                wrono++;
                wroNum.Text=wrono.ToString();
                pictureBox2.Visible = true;
                btnA.BackColor= Color.Red;
                falsesound.Play();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            next.Enabled = false;
            pictureBox1.Visible = false; 
            pictureBox2.Visible = false;
            btnA.BackColor = Color.White;
            btnB.BackColor = Color.White;
            btnC.BackColor = Color.White;
            btnD.BackColor = Color.White;
            truesound.Stop();
            falsesound.Stop();


            questno++;
            quesNum.Text = questno.ToString();
            if (questno== 1 ) {
                richTextBox1.Text = "What is the most popular regligion in the turkish people before islam?";
                btnA.Text = "Judaism";
                btnB.Text = "Atheism";
                btnC.Text = "Christianity";
                btnD.Text = "Tengrism";
                trueans.Text = "Tengrism";
             }
            if (questno== 2 )
            {
                richTextBox1.Text = "What is the capital city of Turkey?";
                btnA.Text = "Ýstanbul";
                btnB.Text = "Ankara";
                btnC.Text = "Ýzmir";
                btnD.Text = "Antalya";
                trueans.Text = "Ankara";
            }
            if (questno == 2)
            {
                richTextBox1.Text = "What city is famous for kebab?";
                btnA.Text = "Van";
                btnB.Text = "Çorum";
                btnC.Text = "Adana";
                btnD.Text = "Sivas";
                trueans.Text = "Adana";
            }
            if (questno == 3)
            {
                richTextBox1.Text = "What country Turkey is not a neighbor? ";
                btnA.Text = "Germany";
                btnB.Text = "Greece";
                btnC.Text = "Syria";
                btnD.Text = "Iraq";
                trueans.Text = "Germany";
            }
            if (questno == 4) {
                richTextBox1.Text = "What car brand is belong to Turkey?";
                btnA.Text = "BMW";
                btnB.Text = "FIAT";
                btnC.Text = "TOGG";
                btnD.Text = "NISSAN";
                trueans.Text = "TOGG";
            }
            if (questno == 5)
            {
                richTextBox1.Text = "What is the age of consent in Turkey?";
                btnA.Text = "16";
                btnB.Text = "17";
                btnC.Text = "18";
                btnD.Text = "19";
                trueans.Text = "18";
                next.Text = "Finish";
            }
            if (questno == 6)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("You Finish The Exam \nTrue Number: " + corno + "\nFalse Number" + wrono);
            }


        }
    }
}