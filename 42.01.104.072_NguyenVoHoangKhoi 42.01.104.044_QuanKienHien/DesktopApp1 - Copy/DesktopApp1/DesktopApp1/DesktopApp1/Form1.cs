using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[10];
        public string abcd1;
        private void soLuong_ValueChanged(object sender, EventArgs e)
        { 
            right = Convert.ToInt32(soLuong.Value)-1;
            if(soLuong.Value==1)
            {
                textBox1.Visible = true;
                label1.Visible = true;
            }
            if (soLuong.Value == 2)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                label2.Visible = true;
                label1.Visible = true;

            }
            if (soLuong.Value == 3)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                label3.Visible = true;

            }
            if (soLuong.Value == 4)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                label4.Visible = true;


            }
            if (soLuong.Value == 5)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                label5.Visible = true;

            }
            if (soLuong.Value == 6)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                label6.Visible = true;

            }
            if (soLuong.Value == 7)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                label7.Visible = true;

            }
            if (soLuong.Value == 8)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                label8.Visible = true;

            }
            if (soLuong.Value == 9)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                label9.Visible = true;

            }
            if (soLuong.Value == 10)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                label10.Visible = true;

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible=button4.Visible = false;
            button3.Visible = true;
            groupBoxTuantu.Visible = true;
            button4.Enabled = false;
            khoitao();
            richTextBox1.Text = "int LinearSearch(int a[], int N, int x)" + Environment.NewLine +
                                "{" + Environment.NewLine +
                                "   for (int i=0; i<N; i++);" + Environment.NewLine +
                                "   {" + Environment.NewLine +
                                "      if (a[i]==x) return i;" + Environment.NewLine +
                                "       " + Environment.NewLine +
                                "      else return -1;" + Environment.NewLine +
                                "   }" + Environment.NewLine +
                                "}";
            
            luuMang();
            pictureBox1.Location = new Point(600, -10);
            timer1.Enabled = true;
            textBoxi.Text = "0";

        }

        public void khoitao()
        {
            soLuong.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;

          /*  int k = textBox2.Height;
            textBox1.Height = int.Parse(textBox1.Text) * 10;
            textBox1.Location = new Point(textBox1.Location.X, textBox1.Location.Y - textBox1.Height + k);
            textBox2.Height = int.Parse(textBox2.Text) * 10;
            textBox2.Location = new Point(textBox2.Location.X, textBox2.Location.Y - textBox2.Height + k);
            textBox3.Height = int.Parse(textBox3.Text) * 10;
            textBox3.Location = new Point(textBox3.Location.X, textBox3.Location.Y - textBox3.Height + k);
            textBox4.Height = int.Parse(textBox4.Text) * 10;
            textBox4.Location = new Point(textBox4.Location.X, textBox4.Location.Y - textBox4.Height + k);
            textBox5.Height = int.Parse(textBox5.Text) * 10;
            textBox5.Location = new Point(textBox5.Location.X, textBox5.Location.Y - textBox5.Height + k); ;
            textBox6.Height = int.Parse(textBox6.Text) * 10;
            textBox6.Location = new Point(textBox6.Location.X, textBox6.Location.Y - textBox6.Height + k);
            textBox7.Height = int.Parse(textBox7.Text) * 10;
            textBox7.Location = new Point(textBox7.Location.X, textBox7.Location.Y - textBox7.Height + k);
            textBox8.Height = int.Parse(textBox8.Text) * 10;
            textBox8.Location = new Point(textBox8.Location.X, textBox8.Location.Y - textBox8.Height + k);
            textBox9.Height = int.Parse(textBox9.Text) * 10;
            textBox9.Location = new Point(textBox9.Location.X, textBox9.Location.Y - textBox9.Height + k);
            textBox10.Height = int.Parse(textBox10.Text) * 10;
            textBox10.Location = new Point(textBox10.Location.X, textBox10.Location.Y - textBox10.Height + k);
            */
            textBox1.BackColor = Color.AliceBlue;
            textBox2.BackColor = Color.AliceBlue;
            textBox3.BackColor = Color.AliceBlue;
            textBox4.BackColor = Color.AliceBlue;
            textBox5.BackColor = Color.AliceBlue;
            textBox6.BackColor = Color.AliceBlue;
            textBox7.BackColor = Color.AliceBlue;
            textBox8.BackColor = Color.AliceBlue;
            textBox9.BackColor = Color.AliceBlue;
            textBox10.BackColor = Color.AliceBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        public void luuMang()
        {
            a[0] = int.Parse(textBox1.Text);
            a[1] = int.Parse(textBox2.Text);
            a[2] = int.Parse(textBox3.Text);
            a[3] = int.Parse(textBox4.Text);
            a[4] = int.Parse(textBox5.Text);
            a[5] = int.Parse(textBox6.Text);
            a[6] = int.Parse(textBox7.Text);
            a[7] = int.Parse(textBox8.Text);
            a[8] = int.Parse(textBox9.Text);
            a[9] = int.Parse(textBox10.Text);
            
        }
        

        private void Form1_Load(object sender, fwefwqefasdEventArgs e)
        {
            if (abcd1 == "tuantu")
            {
                button4.Visible = false;
            }f
            else if (abcd1 == "nhiphan")  { buttosadfasdfasdfn1.Visible = false; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!button1.Enabled)
            {
                if (timer2.Enabled == true) timer2.Enabled = false; else timer2.Enabled = true;
                MessageBoxButtons
            }
            if (!button4.Enabled)
            {
                if (timer1.Enabled == true) timer1.Enabled = false; else timer1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible=button4.Visible = false;
            button3.Visible = true;
            groupBoxNhiPhan.Visible = true;
            khoitao();
            luuMang();
            richTextBox1.Text = "int BinarySearch(int a[],int N,int x )" + Environment.NewLine +
                               "{" + Environment.NewLine +
                               "   int  left =0, right = N-1, midle;" + Environment.NewLine +
                               "   while (left <= right)" + Environment.NewLine +
                               "   {" + Environment.NewLine +
                               "        midle = (left + right)/2;" + Environment.NewLine +
                               "        if (x == a[midle])  return midle;" + Environment.NewLine +
                               "            " + Environment.NewLine +
                               "        if (x<a[midle])right = midle -1;" + Environment.NewLine +
                               "        else           left  = midle +1;" + Environment.NewLine +
                               "   }" + Environment.NewLine +
                               "   return -1; // trong daõy khoâng coù x; " + Environment.NewLine +
                               "}";

            pictureBox1.Location = new Point(600, 40);
            DialogResult result = MessageBox.Show("Bạn có chắn dãy số bạn nhập là dãy tăng?", "Thông  báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) timer2.Enabled = true;
            else button4.Visible = true;
            textBoxleft.Text = "0";
            textBoxright.Text = (soLuong.Value - 1).ToString();

        }
        int kt = -2, repeat = 0;
        int left = 0;
        int right=0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            int mid = (left + right) / 2;
            string vitriText = "textBox" + (mid+1);
            TextBox qq = (TextBox)this.Controls.Find(vitriText, true).FirstOrDefault();
            if (kt == 0)
            {
                if (left > right)
                {
                    timer2.Enabled = false;
                    textBox11.Text = "khong tim thay";
                    pictureBox1.Location = new Point(600, 225);
                }

            }
            if (kt < 7)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 20);
                kt++;
            }
            
            if (kt == 2)
            {
                pictureBox2.Location = new Point(qq.Location.X, qq.Location.Y - 200);
                pictureBox2.Visible = true;
                textBoxmid.Text = mid.ToString();

            }
            if (kt == 3)
            {
                textBoxamid.Text = a[mid].ToString();
                if (int.Parse(test.Text) == a[mid])
                {
                    textBox11.Text = "Đã tìm thấy ở vị trí: " + (mid);
                    timer2.Enabled = false;
                }
                if (int.Parse(test.Text) < a[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
                
            }
            if (kt == 5)
            {
                textBoxright.Text = right.ToString();
            }
            if (kt == 6)
            {
                textBoxleft.Text = left.ToString();
            }
            if (kt == 7)
            {
                pictureBox1.Location = new Point(600, 80);
                kt = 0;
                repeat++;
            }
            
            if (repeat == 5)
            {
                timer2.Enabled = false;
                textBox11.Text = "chay het vong lap ma khong thay";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
        }


        int kt1 = -1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            {
                
                if (kt1 < 4 )
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 40);
                    kt1++;
                }
                if (kt1 == 2)
                {
                    textBoxai.Text = a[repeat].ToString();

                    if (int.Parse(test.Text) == a[repeat])
                    {
                        textBox11.Text = "Đã tìm thấy ở vị trí: " + (repeat);
                        timer1.Enabled = false;
                    }
                }
                if (kt1 == 4)
                {
                    textBoxi.Text = (repeat+1).ToString();
                    pictureBox1.Location = new Point(580, 60);
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 90, pictureBox2.Location.Y);
                    kt1 = 1;
                    repeat++;
                }
                if (repeat == soLuong.Value)
                {
                    textBox11.Text = "Không tìm thấy số cần tìm";
                    timer1.Enabled = false;
                }
            }
        }
    }
}
