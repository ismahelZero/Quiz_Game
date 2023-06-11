using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using Microsoft.Win32.SafeHandles;

namespace quiz
{

    public partial class Form3 : Form
    {
        public static string name = "";
        Form1 f1 = new Form1();
        SqlConnection coon = new SqlConnection(@"Data Source=LAPTOP-2J7D7T6H\SQLEXPRESS;Initial Catalog=QA;Integrated Security=True");
        DataTable table= new DataTable();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            label3.ForeColor= Color.White;
            button1.ForeColor= Color.White;
            button2.ForeColor= Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            coon.Open();
            button1.Visible = false; 
            button2.Visible = false;
            button3.Visible = false;
            label2.Text = "";
            dataGridView1.Visible = false;
            SqlDataAdapter sq;
            sq = new SqlDataAdapter(@"select Name ناو ,q_type  جۆری_پرسیار, answer وەڵام from [table] ", coon);
            DataTable dt;
            dt = new DataTable();
            sq.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
            Form1.qt = 1;
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
            Form1.qt = 2;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
            Form1.qt = 3;
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.Text = "جۆری پرسیارەکان چیبێت؟";
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            name = textBox1.Text;
            button4.Visible = false;
            textBox1.Visible= false;
            label3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible==true || button1.Visible==true) {
                button4.Visible = false;
                textBox1.Visible = false;
                label3.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                label1.Visible = false;
                label2.Visible = true;
                label2.Text = "ئەو کەسانەی یارییان کردوە";
                button5.Text = "گەرانەوە";
                dataGridView1.Visible= true;
                
            }
            else
            {
                button4.Visible = true;
                textBox1.Visible = true;
                label3.Visible = true;
                dataGridView1.Visible = false;
                label1.Visible= true;
                label2.Visible = false;
                label1.Text = "بەخێربێن";
                button5.Text = "بینینی ئەو کەسانەی یارییان کردوە";
                

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
