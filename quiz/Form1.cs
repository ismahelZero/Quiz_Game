using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Xml;
using quiz.Properties;

namespace quiz
{

    


    public partial class Form1 : Form
    {
        public static int qt,s=0;
        Form2 f2 = new Form2();

        public static int[] bv = new int[10];



        public Form1()
        {
            InitializeComponent();

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (Form2.k == 3)
            {
                s = 0;
                Form2.k = 0;
                MessageBox.Show("زیاتر ناتوانی یاری کەیت");
                Array.Clear(bv,0,10);
                Array.Clear(Form2.arr,0,15);
                Form3 f3= new Form3();
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                f3.Show();
                this.Hide();

            }

            label2.Parent = pictureBox1;
          
            foreach (int i in bv)
            {
                if(i==1) button1.Visible= false; 
                if(i==2) button2.Visible= false;
                if(i==3) button3.Visible= false;
                if(i==4) button4.Visible= false;
                if(i==5) button5.Visible= false;
                if(i==6) button6.Visible= false;
                if(i==7) button7.Visible= false;
                if(i==8) button8.Visible= false;
                if(i==9) button9.Visible= false;
            }


        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           

            f2.Show();
            this.Hide();
            bv[s] = 1;
            s++;
            Form2.k++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            f2.Show();
            this.Hide();
            bv[s] = 2;
            s++;
            Form2.k++;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
            bv[s] = 3;
            s++;
            Form2.k++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
            bv[s] = 6;
            s++;
            Form2.k++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
            bv[s] = 7;
            s++;
            Form2.k++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
            bv[s] = 8;
            s++;
            Form2.k++;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
            bv[s] = 5;
            s++;
            Form2.k++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
            bv[s] = 9;
            s++;
            Form2.k++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
            bv[s] = 4;
            s++;
            Form2.k++;
        }
    }
}