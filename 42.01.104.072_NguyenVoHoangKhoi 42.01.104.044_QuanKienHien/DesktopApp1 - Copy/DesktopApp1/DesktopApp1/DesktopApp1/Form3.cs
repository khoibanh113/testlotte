using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int tocdo = 500;
        int sl;
        int kt = 0;
        int k = 1, z = 0;
        int dem = 0, demcu = -2;
        int[] a = new int[10];
        int[] b = new int[10];
        bool danhdau2 = true, danhdau4 = true, doicho1 = false, batflag = false;
        string doimau = "vang";
        int demmauvang = 0;
        

        private void soLuong_ValueChanged(object sender, EventArgs e)
        {
            sl = (Convert.ToInt32(soLuong.Value) - 1);
            for (int i = 0; i <= sl; i++)
            {
                string tb = "textBox" + i;
                string lb = "label" + (i + 1);
                TextBox tbb = (TextBox)this.Controls.Find(tb, true).FirstOrDefault();
                Label lbb = (Label)this.Controls.Find(lb, true).FirstOrDefault();
                tbb.Visible = lbb.Visible = true;
            }
            for (int i = sl + 1; i <= 9; i++)
            {
                string tb = "textBox" + i;
                string lb = "label" + (i + 1);
                TextBox tbb = (TextBox)this.Controls.Find(tb, true).FirstOrDefault();
                Label lbb = (Label)this.Controls.Find(lb, true).FirstOrDefault();
                tbb.Visible = lbb.Visible = false;
            }
        }

        private void textBox0_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncong_Click(object sender, EventArgs e)
        {
            if (tocdo > 500)
            {
                tocdo -= 500;
            }
            timer1.Interval = tocdo;
        }

        private void buttontru_Click(object sender, EventArgs e)
        {
            tocdo += 500;
            timer1.Interval = tocdo;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Interval = tocdo;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= sl; i++)
            {
                string tb = "textBox" + (i+10);
                TextBox tbb = (TextBox)this.Controls.Find(tb, true).FirstOrDefault();
                tbb.Visible = true;
            }
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                buttonStart.Text = "Continue";
            }
            else { timer1.Enabled = true; buttonStart.Text = "Pause"; }
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kt == 0) pictureBox1.Height = 15; pictureBox1.Location = new Point(690, 40);
            if (kt==1) pictureBox1.Height = 15; pictureBox1.Location = new Point(690, 80);
            if (kt==2)
            {
                pictureBox1.Location = new Point(690, 180);
                pictureBox1.Height = 20;
                labelK.Text = "K = " + k;
                labelstatus.Text = "Phân phối đều luân phiên";
                if (k==8)
                {
                    timer1.Enabled = false;
                    labelstatus.Text = "Đã dừng";
                }
                for (int i = dem; i < dem+k; i++)
                {
                    string mm = "textBox" + i;
                    TextBox mau = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                    a[i] =int.Parse(mau.Text);
                    if (doimau == "xanh")
                    {
                        mau.BackColor = Color.LightGreen;
                    }
                    else if (doimau == "vang") 
                    {
                        mau.BackColor = Color.LightYellow;
                    }
                }
                if (doimau == "xanh")
                {
                    doimau = "vang";
                }
                else if (doimau == "vang")
                {
                    doimau = "xanh";
                }
            }
            if (kt == 3)
            {
                pictureBox1.Location = new Point(690, 200);
                pictureBox1.Height = 50;
                if (k == 2 && danhdau2)//doiten khi k = 2
                {//10 11/12 13
                    string tmp = textBox12.Name;
                    textBox12.Name = textBox11.Name;
                    textBox11.Name = tmp;
                    //14 15/ 16 17
                    string tmp2 = textBox16.Name;
                    textBox16.Name = textBox15.Name;
                    textBox15.Name = tmp2;
                    danhdau2 = false;
                }
                if (k == 4 && danhdau4)
                {
                    //10 11 12 13
                    //14 15 16 17
                    string tmp1 = textBox11.Name;
                    string tmp2 = textBox12.Name;
                    string tmp3 = textBox13.Name;
                    string tmp4 = textBox14.Name;
                    string tmp5 = textBox15.Name;
                    string tmp6 = textBox16.Name;
                    string tmp7 = textBox17.Name;

                    textBox11.Name = tmp4;
                    textBox12.Name = tmp1;
                    textBox13.Name = tmp5;
                    textBox14.Name = tmp2;
                    textBox15.Name = tmp6;
                    textBox16.Name = tmp3;
                    
                    danhdau4 = false;
                }
                for (int i = dem; i < dem + k; i++)
                {
                    string qq = "textBox" + i;
                    TextBox tbb = (TextBox)this.Controls.Find(qq, true).FirstOrDefault();
                    string mm = "textBox" + (i + 10);
                    TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                    tbb2.Text = a[i].ToString();

                    tbb2.BackColor = tbb.BackColor;
                    tbb.Text = "";tbb.BackColor = Color.WhiteSmoke;
                }
                kt = 1; dem += k;
                if (dem>sl)
                {
                    kt = 4;
                    dem = 0;
                }
                
            }
            if (kt == 4)
            {
                pictureBox1.Location = new Point(690, 80);
                pictureBox1.Height = 15;
                if (!danhdau2 && k == 2) 
                {
                    string tmp = textBox12.Name;
                    textBox12.Name = textBox11.Name;
                    textBox11.Name = tmp;
                    //14 15/ 16 17
                    string tmp2 = textBox16.Name;
                    textBox16.Name = textBox15.Name;
                    textBox15.Name = tmp2;
                    for (int i = dem; i < sl / 2 + 1; i++)
                    {
                        string mm = "textBox" + (i + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        tbb2.BackColor = Color.LightPink;
                    }
                    for (int i = sl / 2 + 1; i < sl; i++)
                    {
                        string mm = "textBox" + (i + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        tbb2.BackColor = Color.LightGreen;
                    }
                    danhdau2 = true;
                }
                if (!danhdau4 && k == 4) 
                {
                    string tmp1 = textBox11.Name;
                    string tmp2 = textBox12.Name;
                    string tmp3 = textBox13.Name;
                    string tmp4 = textBox14.Name;
                    string tmp5 = textBox15.Name;
                    string tmp6 = textBox16.Name;

                    textBox11.Name = tmp2;
                    textBox12.Name = tmp4;
                    textBox13.Name = tmp6;
                    textBox14.Name = tmp1;
                    textBox15.Name = tmp3;
                    textBox16.Name = tmp5;
                    for (int i = 0; i <= sl; i++)
                    {
                        string mm = "textBox" + (i + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        b[i] = int.Parse(tbb2.Text);
                    }
                }
            }
            if (kt==5)// to mau tb10 11
            {
                //dang lam
                pictureBox1.Location = new Point(690, 320);
                pictureBox1.Height = 50;
                labelstatus.Text = "Trộn từng cặp đường chạy";
                if (k==1)
                {
                    for (int i = dem; i < dem + 2; i++)
                    {
                        string mm = "textBox" + (i + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        tbb2.BackColor = Color.Yellow;
                        b[i] = int.Parse(tbb2.Text);
                    }
                }
                else if (k==2)
                {
                    for (int i = 0; i < sl / 2 + 1; i++)//luu 4 hong
                    {
                        string mm = "textBox" + (i + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        if(tbb2.BackColor == Color.LightPink)
                        {
                            b[i] =int.Parse(tbb2.Text);
                        }
                    }
                    if (batflag) // luu 4 xanh la
                    {
                        for (int i = sl/2+1; i <= sl; i++)
                        {
                            string mm = "textBox" + (i + 10);
                            TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                            if (tbb2.BackColor == Color.LightGreen)
                            {
                                b[i] = int.Parse(tbb2.Text);
                            }
                        }
                    }
                    for (int i = dem; i < dem + 2 /*&& i < sl / 2 + 1*/; i++)   
                    {
                        if (i == dem + z || i==dem+z-1 && i != 0) i = i + z;
                        string mm = "textBox" + (i + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        if (tbb2.Text != "") 
                        {
                            tbb2.BackColor = Color.Yellow;
                        }
                        
                    }
                    demmauvang = 0;
                    for (int i = 0; i < sl+1 ; i++)
                    {
                        string mm = "textBox" + (i + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        if (tbb2.BackColor==Color.Yellow)
                        {
                            demmauvang++;
                        }
                    }

                    if (batflag && demmauvang == 1) 
                    {
                        string mm = "textBox" + (dem + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        string mm1 = "textBox" + (dem + z);
                        TextBox tbb1 = (TextBox)this.Controls.Find(mm1, true).FirstOrDefault();
                        tbb1.Text = tbb2.Text;
                        tbb2.Text = ""; tbb2.BackColor = Color.WhiteSmoke;
                        k = k * 2;
                        kt = 0;
                        dem = 0;
                        demcu = -2;
                        z = 0;
                    }
                    if (demmauvang == 1 && !batflag) //con 1 o vang duy nhat
                    {
                        if (batflag) labelstatus.Text = "E";
                        string mm = "textBox" + (dem + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        string mm1 = "textBox" + (dem+z);
                        TextBox tbb1 = (TextBox)this.Controls.Find(mm1, true).FirstOrDefault();
                        tbb1.Text = tbb2.Text;
                        tbb2.Text = ""; tbb2.BackColor = Color.WhiteSmoke;
                        kt = 4;
                        dem = sl / 2 + 1;
                        z = 0;
                        batflag = true;
                    }
                }
                else if (k == 4)
                {
                    for (int i = dem; i < dem + 2+z; i++)
                    {
                        if (i == dem + z || i == dem + z - 1 && i != 0) i = i + z;
                        string mm = "textBox" + (i + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        if(tbb2.Text!="") tbb2.BackColor = Color.Yellow;
                    }
                    demmauvang = 0;
                    for (int i = 0; i < sl + 1; i++)
                    {
                        string mm = "textBox" + (i + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        if (tbb2.BackColor == Color.Yellow)
                        {
                            demmauvang++;
                        }
                    }
                    if ( demmauvang == 1)
                    {
                        string mm = "textBox" + (dem + 10);
                        TextBox tbb2 = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        string mm1 = "textBox" + (dem + z);
                        TextBox tbb1 = (TextBox)this.Controls.Find(mm1, true).FirstOrDefault();
                        tbb1.Text = tbb2.Text;
                        tbb2.Text = ""; tbb2.BackColor = Color.WhiteSmoke;
                        k = k * 2;
                        kt = 0;
                        dem = 0;
                        demcu = -2;
                        z = 0;
                    }
                }
            }
            if (kt==6)
            {
                pictureBox1.Location = new Point(690, 480);
                pictureBox1.Height = 100;
                if (k==1)
                {
                    string mm = "textBox" + (dem);
                    TextBox tbb = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                    string mm2 = "textBox" + (dem + 10);
                    TextBox tbb2 = (TextBox)this.Controls.Find(mm2, true).FirstOrDefault();
                    string mm3 = "textBox" + (dem + 10 + 1);
                    TextBox tbb3 = (TextBox)this.Controls.Find(mm3, true).FirstOrDefault();
                    string mm4 = "textBox" + (dem + 10 - 1);
                    TextBox tbb4 = (TextBox)this.Controls.Find(mm4, true).FirstOrDefault();
                    if (dem == demcu + k)
                    {
                        kt = 4;//to mau 2 thang tiep theo
                        if (doicho1) { tbb.Text = b[dem].ToString(); tbb2.Text = ""; tbb2.BackColor = Color.WhiteSmoke; }
                        else { tbb.Text = b[dem - 1].ToString(); tbb4.Text = ""; tbb4.BackColor = Color.WhiteSmoke; }

                        dem++;
                        demcu = dem;
                        doicho1 = false;
                    }
                    else if (b[dem] < b[dem + 1])
                    {
                        tbb.Text = b[dem].ToString();
                        doicho1 = true;
                        kt = 5; demcu = dem;
                        dem++;
                        tbb2.Text = "";
                        tbb2.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        tbb.Text = b[dem + 1].ToString();
                        kt = 5; demcu = dem;
                        dem++;
                        tbb3.Text = "";
                        tbb3.BackColor = Color.WhiteSmoke;
                    }

                }

                if (k==2)
                {
                    string mm = "textBox" + (dem+z);
                    TextBox tbb = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                    string mm10 = "textBox" + (dem+10-z);
                    TextBox tbb10 = (TextBox)this.Controls.Find(mm10, true).FirstOrDefault();
                    string mm1 = "textBox" + (dem+1+z);
                    TextBox tbb1 = (TextBox)this.Controls.Find(mm1, true).FirstOrDefault();
                    string mm110 = "textBox" + (dem+1+10+z);
                    TextBox tbb110 = (TextBox)this.Controls.Find(mm110, true).FirstOrDefault();

                    if (b[dem] < b[dem + 1 + z]) 
                    {
                        tbb.Text = b[dem].ToString();
                        string mm10tru = "textBox" + (dem + 10);
                        TextBox tbb10tru = (TextBox)this.Controls.Find(mm10tru, true).FirstOrDefault();
                        tbb10tru.Text = "";tbb10tru.BackColor = Color.WhiteSmoke;
                        dem = dem + 1 + z;
                        kt = 4;
                        z = 0;
                    }
                    else //b[dem] > b[dem+1+z]
                    {
                        tbb.Text = b[dem + 1+z].ToString();
                        tbb110.Text = "";tbb110.BackColor = Color.WhiteSmoke;
                        z++;kt = 4;
                    }
                }
                if (k==4)
                {
                    string mm = "textBox" + (dem + z);
                    TextBox tbb = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                    string mm10 = "textBox" + (dem + 10 - z);
                    TextBox tbb10 = (TextBox)this.Controls.Find(mm10, true).FirstOrDefault();
                    string mm1 = "textBox" + (dem + 1 + z);
                    TextBox tbb1 = (TextBox)this.Controls.Find(mm1, true).FirstOrDefault();
                    string mm110 = "textBox" + (dem + 1 + 10 + z);
                    TextBox tbb110 = (TextBox)this.Controls.Find(mm110, true).FirstOrDefault();
                    if (b[dem] < b[dem + 1 + z])
                    {
                        tbb.Text = b[dem].ToString();
                        string mm10tru = "textBox" + (dem + 10);
                        TextBox tbb10tru = (TextBox)this.Controls.Find(mm10tru, true).FirstOrDefault();
                        tbb10tru.Text = ""; tbb10tru.BackColor = Color.WhiteSmoke;
                        dem = dem + 1 + z;
                        kt = 4;
                        z = 0;
                    }
                    else //b[dem] > b[dem+1+z]
                    {
                        tbb.Text = b[dem + 1 + z].ToString();
                        tbb110.Text = ""; tbb110.BackColor = Color.WhiteSmoke;
                        z++; kt = 4;
                    }
                }
                if (dem==sl+1)
                {
                    k = k * 2;
                    kt = 0;
                    dem = 0;
                    demcu = -2;
                    z = 0;
                }

            }

            if (kt < 10) kt++;
        }

        
    }
}
