using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            richTextBox1.Text = "User: Unknown" + Environment.NewLine + Environment.NewLine + 
                "Normal High Score : 0" + Environment.NewLine + Environment.NewLine + 
                "Crazy High Score : 0";
        }

        Form2 f2 = new Form2();

        public static bool bclicked = false;
        public static int nscore = 0;
        public static int cscore = 0;
        public static string mode = "N";

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(mode);
            if (!button3.Enabled)
            {
                f2.Form = this;
                
                f2.Show();
                //f2.Show();
                this.Hide();
                bclicked = true;
               
             
            }
            else
                MessageBox.Show("Create user first");

            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a mini game made by Pete" + "\n"
                + "The goal of the game is to try to catch the little ghost" + "\n"
                + "There are 2 difficulties: normal and crazy!" + "\n"
                + "At the crazy mode the ghost is super fast and there are some surprises!" + "\n"
                + "Don't try to catch Mr Death because he is untouchable");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        

        void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mode = "N";
        }

        void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mode = "C";
        }
        
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
                MessageBox.Show("Please enter a name to create user");
            else if (maskedTextBox1.Text != "")
            {
                maskedTextBox1.Enabled = false;
                richTextBox1.Text = "User: "+ maskedTextBox1.Text + Environment.NewLine + Environment.NewLine +
                "Normal High Score : 0" + Environment.NewLine + Environment.NewLine +
                "Crazy High Score : 0";
                button3.Enabled = false;
            }
        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int clicks = Form2.clicks;
            if(mode == "N")
                if(clicks > nscore)
                {
                    nscore = clicks;
                    richTextBox1.Text = "User: " + maskedTextBox1.Text + Environment.NewLine + Environment.NewLine +
                    "Normal High Score : "+ nscore + Environment.NewLine + Environment.NewLine +
                    "Crazy High Score " + cscore;
                    
                }
            if (mode == "C")
                if (clicks > cscore)
                {
                    cscore = clicks;
                    richTextBox1.Text = "User: " + maskedTextBox1.Text + Environment.NewLine + Environment.NewLine +
                    "Normal High Score : " + nscore + Environment.NewLine + Environment.NewLine +
                    "Crazy High Score : " + cscore;
                    
                }
        }

       
    }
}
