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
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Security.Cryptography.X509Certificates;

namespace quiz
{
    

    public partial class Form2 : Form
    {


        public static int[] arr = new int[15];
        public static string qt2 = "";
        public static int j = 0, k = 0;

        Random rn = new Random();
        int q;

        public  class p1
        {

           

            public p1(string v1, string v2, string v3, string v4, string v5)
            {
                V1 = v1;
                V2 = v2;
                V3 = v3;
                V4 = v4;
                V5 = v5;
            }

            public string V1 { get; }
            public string V2 { get; }
            public string V3 { get; }
            public string V4 { get; }
            public string V5 { get; }
        }
        p1[] psha = new p1[9];
        p1[] pshoka = new p1[11]; 
        p1[] pshakam = new p1[9];



        string[] answers = { "pshay jwan", "iso razagran" , "جگەر", "44", "620", "22", "بۆنکردن", "مێشک", "پەمەی", "گوێچکە", "32","John Mauchly" ,"css","10","James Gosling","CPU","tennis game","Google","Hedy Lammer","NAV 1000","Youtube","World Wide Web","1937","1914","سکۆتلەندا","موبارەک بن احمد","1920","70","4","1889","لەندەن"};
        bool flag = false;
        SqlConnection coon = new SqlConnection(@"Data Source=LAPTOP-2J7D7T6H\SQLEXPRESS;Initial Catalog=QA;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
            

        }


        private void Form2_Load(object sender, EventArgs e)
        {



           


            int temp;

            button5.Visible = false;
            Form1 f1 = new Form1();

            coon.Open();

            if (Form1.qt == 1)
            {

                temp = rn.Next(11);
                for (int i = 0; i < arr.Length; i++)
                {

                    foreach (var item in arr)
                    {
                        if (item == temp)
                        {
                            temp = rn.Next(11);
                            goto l1;
                        }

                    }

                    arr[j] = temp;
                    j++;
                    q = temp;
                    goto end;

                l1:;
                }
            end:

                qt2 = "IT";
                this.BackgroundImage = Properties.Resources.photo_2023_02_15_13_06_38;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                pshoka[0] = new p1("یەکەم کۆمپیوتەر لەلایەن کێ درووستکرا", "John Mauchly", "Steve Russell", "Ralph H.Bear", "Whilliam Higinbotham");
                pshoka[1] = new p1("کام لەمانە زمانی پرۆگرامینگ نیە", "c#", "c++", "c", "css");
                pshoka[2] = new p1("  چەند بوو Bluetooth لە سەرەتادا  مەودای", "20", "10", "30", "5");
                pshoka[3] = new p1("java کئ ناسراوە بە باوکی ", "James Clerk", "Ericsson Gromson", "James Gosling", "Jaap Hartsen");
                pshoka[4] = new p1("کام بەشی کۆمپیوتەر بە مێشکی کۆمپیوتەر ناسراوە", "CPU", "GPU", "Motherbord", "RAM");
                pshoka[5] = new p1("چی بوو video game یەکەم", "tennis game", "chest game", "tetris game", "pong game");
                pshoka[6] = new p1("دروستدەکا android  کام کۆمپانیا سیستەمی", "Huawei", "Microsoft", "Samsung", "Google");
                pshoka[7] = new p1("دروستکرد WIFI کێ بوو   ", "Vic Hayes", "Graham Danial", "Hedy Lammer", "Micheal Marcus");
                pshoka[8] = new p1("ناوی چیبوو GPS یەکەم  ", "NAV 1000", "Sputnik", "Reagan", "FAA");
                pshoka[9] = new p1("زۆرترین بەکار هێنەری هەبێ کامەیە Google دوای social media دووم پلات فۆرمی       ", "Gmail", "Youtube", "Facebook", "Twitter");
                pshoka[10] = new p1("  کورتکراوەی چییە WWW", "World Web Windows", "World Web Wide", "World Wide Web", " Wide Web World");


                label1.Text = pshoka[q].V1;
                button1.Text = pshoka[q].V2;
                button2.Text = pshoka[q].V3;
                button3.Text = pshoka[q].V4;
                button4.Text = pshoka[q].V5;



            }
            else if (Form1.qt == 2)
            {
                temp = rn.Next(9);
                for (int i = 0; i < arr.Length; i++)
                {
                
                    foreach (var item in arr)
                    {
                        if (item == temp)
                        {
                            temp = rn.Next(9);
                            goto l1;
                        }
                        
                    }
                    
                        arr[j] = temp;
                        j++;
                        q = temp;
                        goto end;
                    
                l1:;
                }


            end:

                qt2 = "Health";
                this.BackgroundImage = Properties.Resources.health3;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                psha[0] = new p1("کام ئەندامی لەشی مرۆڤ بەشێکی لێ لابەیت دروست ئەبێتەوە", "گورچیلە", "جگەر", "سیەکان", "پەنکریاس");
                psha[1] = new p1("ژمارەی ئەو ماسوولکانەی جەستە لە کاتی قسەکردندا بەکاری ئەهێنی", "44", "43", "34", "33");
                psha[2] = new p1("ژمارەی ماسوولکەکانی لەشی مرۆڤ چەندە", "650", "602", "620", "600");
                psha[3] = new p1("ژمارەی ئسقانەکانی کەلەی سەر چەندە", "22", "34", "12", "20");
                psha[4] = new p1("کام هەستەوەرە کەمترین چالاکی هەیە", "بیستن", "بەرکەوتن", "تامکردن", "بۆنکردن");
                psha[5] = new p1("ئەو ئەندامەی ٪٤٠ ی ئۆکسجینی خوێن بەکاردەهێنیت", "گەدە", "دڵ", "مێشک", "سیەکان");
                psha[6] = new p1("رەنگی سیەکانی مرۆڤێکی ساغ چۆنە", "زەرد", "رەش", "پەمەی", "سوور");
                psha[7] = new p1("بجووکترین ئسقان لە جەستەی مرۆڤدا لە کوێیە", "کەلەی سەر", "دەست", "لووت", "گوێچکە");
                psha[8] = new p1("رووخسار لە چەند ئێسک پێکهاتووە", "32", "34", "30", "38");


                label1.Text = psha[q].V1;
                button1.Text = psha[q].V2;
                button2.Text = psha[q].V3;
                button3.Text = psha[q].V4;
                button4.Text = psha[q].V5;

            }
            else
            {

                temp = rn.Next(9);
                for (int i = 0; i < arr.Length; i++)
                {

                    foreach (var item in arr)
                    {
                        if (item == temp)
                        {
                            temp = rn.Next(9);
                            goto l1;
                        }

                    }

                    arr[j] = temp;
                    j++;
                    q = temp;
                    goto end;

                l1:;
                }
            end:


                qt2 = "History";
                this.BackgroundImage = Properties.Resources.history;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                pshakam[0] = new p1("کام ئاڵا یەکەم ئاڵا بوو کە دامەزرا", "سکۆتلەندا", "ئیسپانیا", "بەریتانیا", "ئیتالیا");
                pshakam[1] = new p1("جەنگی جیهانی دووەم سالی جەند بوو", "1937", "1930", "1940", "1941");
                pshakam[2] = new p1("ئاڵای کوردستان لە سالی چەندهەڵکرا ", "1920", "1927", "1914", "1916");
                pshakam[3] = new p1("پەیکەری مێژوو نووسی بەردەم قەڵا کێیە", "حوسێن حوزنی موکریانی", "میر شەرەفخانی بەدلیسی", "موبارەک بن احمد", "گیوی موکریانی");
                pshakam[4] = new p1("قەڵای هەولێر مێژووەکەی دەگەرێتەوە چەند سەدە پێش ئێستا", "40", "50", "70", "90");
                pshakam[5] = new p1("جەنگی جیهانی یەکەم سالی جەند بوو", "1910", "1914", "1909", "1922");
                pshakam[6] = new p1("جەنگی جیهانی یەکەم چەند سالی خایاند", "2", "3", "5", "4");
                pshakam[7] = new p1(" بورجی ئیفڵ لە سالی چەد نبنیادنراوە", "1889", "1890", "1899", "1880");
                pshakam[8] = new p1("کام لە مانە پایتەختی بەریتانیایە", "بێرلین", "کێیڤ", "بێرەن", "لەندەن");

                label1.Text = pshakam[q].V1;
                button1.Text = pshakam[q].V2;
                button2.Text = pshakam[q].V3;
                button3.Text = pshakam[q].V4;
                button4.Text = pshakam[q].V5;

            }
           
           
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string x in answers)
            {
                if (x == button1.Text)
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                    
                }
                if (x == button2.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                    flag= true;
                }
                if (x == button3.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Green;
                    button4.BackColor = Color.Red;
                }
                if (x == button4.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Green;
                }
            };
            button5.Visible = true;
            if (flag == true)
            {
                SqlCommand cmd = new SqlCommand("insert into [table] values('"+Form3.name+"','" + qt2 + "','right')", coon);
               
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into [table] values('"+Form3.name+"','" + qt2 + "','wrong')", coon);
                
                cmd.ExecuteNonQuery();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string x in answers)
            {
                if (x == button1.Text)
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (x == button2.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (x == button3.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Green;
                    button4.BackColor = Color.Red;
                    flag= true;
                }
                if (x == button4.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Green;
                }
            };
            button5.Visible = true;
            if (flag == true)
            {
                SqlCommand cmd = new SqlCommand("insert into [table] values('"+Form3.name+"','" + qt2 + "','right')", coon);
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into [table] values('"+Form3.name+"','" + qt2 + "','wrong')", coon);
                cmd.ExecuteNonQuery();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string x in answers)
            {
                if (x == button1.Text)
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (x == button2.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (x == button3.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Green;
                    button4.BackColor = Color.Red;
                }
                if (x == button4.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Green;
                    flag= true;
                }
            };
            button5.Visible = true;
            if (flag == true)
            {
                SqlCommand cmd = new SqlCommand("insert into [table] values('"+Form3.name+"','" + qt2 + "','right')", coon);
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into [table] values('"+Form3.name+"','" + qt2 + "','wrong')", coon);
                cmd.ExecuteNonQuery();
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (string x in answers)
            {
                if (x == button1.Text)
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;

                    flag = true;
                }
                if (x == button2.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;

                }
                if (x == button3.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Green;
                    button4.BackColor = Color.Red;

                }
                if (x == button4.Text)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Green;

                }
            };

            button5.Visible = true;
            if (flag == true)
            {
                SqlCommand cmd = new SqlCommand("insert into [table] values('" + Form3.name + "','" + qt2 + "','right')", coon);
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into [table] values('" + Form3.name + "','" + qt2 + "','wrong')", coon);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
