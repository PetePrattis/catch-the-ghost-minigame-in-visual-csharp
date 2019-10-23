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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            InitializeComponent();
            tm.Interval = 1000;
            tm.Tick += new EventHandler(tm_Tick);
            tm2.Interval = 500;
            tm2.Tick += new EventHandler(tm2_Tick);
            tm3.Interval = 500;
            tm3.Tick += new EventHandler(tm3_Tick);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            

            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            //Form2 f2 = new Form2();
            //if (Form1.bclicked)
            //{
            MessageBox.Show(Form1.mode);
               
           // }
            //Form1.bclicked = false;
        }

        //string gmode = Form1.mode;
        private void Form2_Shown(object sender, EventArgs e)
        {
            if (Form1.mode == "N")
            {
                tm.Start();
                pictureBox1.Visible = true;
            }
            else if (Form1.mode == "C")
            {
                tm2.Start();
                tm3.Start();
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            //MessageBox.Show(Form1.mode);
        }



        public Form Form { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            
            tm.Stop();
            tm2.Stop();
            tm3.Stop();
            this.Hide();
            Form.Show();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

       

        
        

        Timer tm = new Timer();
        int X = 0;
        int Y = 0;
        Timer tm2 = new Timer();
        Timer tm3 = new Timer();

        void tm_Tick(object sender, EventArgs e)
        {
            X = ((int)(new Random().Next(0, 1025)));
            Y = ((int)(new Random().Next(0, 545)));
            if (X > 1025 - pictureBox1.Width)
            {
                X = 1025 - pictureBox1.Width;
            }
            if (Y > 545 - pictureBox1.Height)
            {
                Y = 545 - pictureBox1.Height;
            }
            pictureBox1.Location = new Point(X, Y);
        }
        void tm2_Tick(object sender, EventArgs e)
        {
            X = ((int)(new Random().Next(0, 1025)));
            Y = ((int)(new Random().Next(0, 545)));
            if (X > 1025 - pictureBox1.Width)
            {
                X = 1025 - pictureBox1.Width;
            }
            if (Y > 545 - pictureBox1.Height)
            {
                Y = 545 - pictureBox1.Height;
            }
            pictureBox1.Location = new Point(X, Y);
        }
        void tm3_Tick(object sender, EventArgs e)
        {
            X = ((int)(new Random().Next(0, 1025)));
            Y = ((int)(new Random().Next(0, 545)));
            if (X > 1025 - pictureBox2.Width)
            {
                X = 1025 - pictureBox2.Width;
            }
            if (Y > 545 - pictureBox2.Height)
            {
                Y = 545 - pictureBox2.Height;
            }
            pictureBox2.Location = new Point(X, Y);
        }


        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public static int clicks = 0;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 f1 = new Form1();
            clicks += 1;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 f1 = new Form1();
            Form.Show();
            tm.Stop();
            tm2.Stop();
            tm3.Stop();
            this.Hide();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


        }

      
    }
}
