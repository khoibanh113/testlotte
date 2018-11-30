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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[] a = new int[10];
        int[] luuVT = new int[10];
        int tocdo = 1000;
        public void khoitao()
        {
            soLuong.Enabled = false;
            textBox0.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox0.BackColor = Color.AliceBlue;
            textBox1.BackColor = Color.AliceBlue;
            textBox2.BackColor = Color.AliceBlue;
            textBox3.BackColor = Color.AliceBlue;
            textBox4.BackColor = Color.AliceBlue;
            textBox5.BackColor = Color.AliceBlue;
            textBox6.BackColor = Color.AliceBlue;
            textBox7.BackColor = Color.AliceBlue;
            textBox8.BackColor = Color.AliceBlue;
            textBox9.BackColor = Color.AliceBlue;

        }
        public void luumang()
        {
            a[0] = int.Parse(textBox0.Text);
            a[1] = int.Parse(textBox1.Text);
            a[2] = int.Parse(textBox2.Text);
            a[3] = int.Parse(textBox3.Text);
            a[4] = int.Parse(textBox4.Text);
            a[5] = int.Parse(textBox5.Text);
            a[6] = int.Parse(textBox6.Text);
            a[7] = int.Parse(textBox7.Text);
            a[8] = int.Parse(textBox8.Text);
            a[9] = int.Parse(textBox9.Text);
        }
        private void soLuong_ValueChanged(object sender, EventArgs e)
        {
            sleft = (Convert.ToInt32(soLuong.Value) - 1)/2;
            sl = (Convert.ToInt32(soLuong.Value) - 1);
            phai = sl;
            rr = sl;
            for (int i = 0; i <= sl; i++)
            {
                string tb = "textBox" + i;
                string lb = "label" + (i+1);
                //string pb = "pb" + i;
                TextBox tbb = (TextBox)this.Controls.Find(tb, true).FirstOrDefault();
                Label lbb = (Label)this.Controls.Find(lb, true).FirstOrDefault();
                //PictureBox pbb = (PictureBox)this.Controls.Find(pb, true).FirstOrDefault();
                tbb.Visible = lbb.Visible = true;
            }
            for (int i = sl+1; i <= 9; i++)
            {
                string tb = "textBox" + i;
                string lb = "label" + (i+1);
                TextBox tbb = (TextBox)this.Controls.Find(tb, true).FirstOrDefault();
                Label lbb = (Label)this.Controls.Find(lb, true).FirstOrDefault();
                tbb.Visible = lbb.Visible = false;
            }
           
        }
        private void numericUpDownk_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= Convert.ToInt32(numericUpDownk.Value); i++)
            {
                string tb = "numericUpDown" + i;
                NumericUpDown tbb = (NumericUpDown)this.Controls.Find(tb, true).FirstOrDefault();
                tbb.Visible  = true;
            }
            for (int i = Convert.ToInt32(numericUpDownk.Value) + 1; i <= 3; i++)
            {
                string tb = "numericUpDown" + i;
                NumericUpDown tbb = (NumericUpDown)this.Controls.Find(tb, true).FirstOrDefault();
                tbb.Visible = false;
            }
        }

        private void buttonSelectionSort_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            //Selection Sort
            if (comboBox1.SelectedIndex== 0)
            {
                richTextBox1.Text = "void SelectionSort(int a[], int N ){" + Environment.NewLine +
                                "   int min; " + Environment.NewLine +
                                "   for (int i = 0; i < N-1; i++)" + Environment.NewLine +
                                "   { " + Environment.NewLine +
                                "       min = i;  " + Environment.NewLine +
                                "       for(int j = i+1; j < N ; j++) " + Environment.NewLine +
                                "           if (a[j] < a[min]) min = j; " + Environment.NewLine +
                                "       if (min != i) Swap(a[min], a[i]);" + Environment.NewLine +
                                "   }" + Environment.NewLine +
                                "}";
                khoitao();
                luumang();
                timer1.Enabled = true;
                pictureBoxi.Visible = true;
            }
            //Interchange sort
            if (comboBox1.SelectedIndex == 1)
            {
                richTextBox1.Text = "void InterchangeSort(int a[], int N){ " + Environment.NewLine +
                                "   int i,j; " + Environment.NewLine +
                                "   for (int i = 0; i < N-1; i++)" + Environment.NewLine +
                                "       for(int j = i+1; j < N ; j++) " + Environment.NewLine +
                                "           if (a[j] < a[i])" + Environment.NewLine +
                                "               Swap(a[i], a[j]);" + Environment.NewLine +
                                "   }";
                khoitao();
                luumang();
                timer1.Enabled = true;
                buttonPause.Enabled = true;
                button1.Enabled = false;
                pictureBoxi.Visible = true;
            }
            //Insert Sort
            if (comboBox1.SelectedIndex == 2)
            {
                labelai.Text = "x = a[ i ]";
                labelaj.Text = "a[ pos - 1 ]";
                labelj.Text = "pos - 1";
                richTextBox1.Text = "void InsertionSort(int a[], int N ){ " + Environment.NewLine +
                                    "   int pos, i; " + Environment.NewLine +
                                    "   int x; " + Environment.NewLine +
                                    "   for (int i = 1; i < N; i++){" + Environment.NewLine +
                                    "       x = a[i]; " + Environment.NewLine +
                                    "       for(pos=i;(pos>0)&&(a[pos-1]>x);pos--) " + Environment.NewLine +
                                    "           a[pos] = a[pos-1];" + Environment.NewLine +
                                    "       a[pos] = x;" + Environment.NewLine +
                                    "   }" + Environment.NewLine +
                                    "}";
                khoitao();
                luumang();
                timer1.Enabled = true;
            }

            //Bubble Sort
            if(comboBox1.SelectedIndex==3)
            {
                labelj1.Visible = labelaj1.Visible = textBoxj1.Visible = textBoxaj1.Visible = true;
                richTextBox1.Text = "void BubbleSort(int a[], int N){ " + Environment.NewLine +
                                   "   int i, j; " + Environment.NewLine +
                                   "   for (i = 0 ; i<N-1 ; i++) " + Environment.NewLine +
                                   "       for (j =N-1; j>i ; j --) " + Environment.NewLine +
                                   "           if(a[j]< a[j-1]) " + Environment.NewLine +
                                   "                Swap(a[j], a[j-1]);" + Environment.NewLine +
                                   "}";
                khoitao();
                luumang();
                timer1.Enabled = true;
            }

            //Heap sort
            if (comboBox1.SelectedIndex==4)
            {
                buttonGD1_Click(sender,e);
                
            }

            //Shell sort
            if (comboBox1.SelectedIndex==5)
            {
                khoitao();
                luumang();
                pictureBoxi.Image = Properties.Resources.images2;
                if (numericUpDownk.Value != 0)
                {
                    timer1.Enabled = true;
                }
                else MessageBox.Show("Hãy nhập số lượng khác 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labeltam.Visible = textBoxtam.Visible = true;
                labeli.Text = "step";
                labelj.Text = "len = h[step]";
                labelai.Text = "i";
                labelaj.Text = "pos";
            }

            //Quick Sort
            if (comboBox1.SelectedIndex==6)
            {
                timer1.Enabled = true;
            }
        }
        int kt = -2, repeat = 0;
        public string abcd2;
        private void Form2_Load(object sender, EventArgs e)asdfasdfe qwfvsdagf
        {
            if (abcd2 == "select")
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (abcd2 == "interchange") comboBox1.SelectedIndex = 1;
            else if (abcd2 == "insert") comboBox1.SelectedIndex = 2;
            else if (abcd2 == "bubble") comboBox1.SelectedIndex = 3;
            else if (abcd2 == "heap") comboBox1.SelectedIndex = 4;
            else if (abcd2 == "shell") { comboBox1.SelectedIndex = 5; numericUpDownk.Visible = true; label13.Visible = true; }
            else if (abcd2 == "quick") comboBox1.SelectedIndex = 6;
            timer1.Interval = timerSwap.Interval = tocdo;
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false ) timer1.Enabled = false; else timer1.Enabled = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (timerSwap.Enabled == true) timerSwap.Enabled = false; else timerSwap.Enabled = true;
        }
        int min = 0;
        int k = 0;
        int kts = 0;
        int sort = -1;
        int tt = 0;
        int tt2 = 1;
        int sleft;
        bool ktjoint1 = false, doicho1 = false, doicho2 = false, lan1 = true;
        int curr;
        int sl;
        int heapsort = -2;
        int ht = 0;
        int ts = 0, kl;
        int ttnumeric = 1;
        int demslpb = 0;
        int ss = 0;
        int trai = 0, ll = 0;int rr,phai;int demk = 0; int xanh, ddo = 0;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void buttonCong_Click(object sender, EventArgs e)
        {
            if (tocdo>500)
            {
                tocdo -= 500;
            }
            timer1.Interval = tocdo;
            timerSwap.Interval = tocdo;
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            tocdo += 500;
            timer1.Interval = tocdo;
            timerSwap.Interval = tocdo;
        }

        

        private void buttonGD1_Click(object sender, EventArgs e)
        {
            //string st = @"C:\Users\ASUS\Desktop\images2.jpg";
            pictureBoxi.Image = Properties.Resources.images2;
            //string st1 = @"C:\Users\ASUS\Desktop\muiten.png";
            pictureBoxsosanh.Image = Properties.Resources.muiten;
            //string st2 = @"C:\Users\ASUS\Desktop\muiten2.png";
            pictureBoxsosanh1.Image = Properties.Resources.muiten;
            labeli.Text = "left";
            labelj.Text = "Curr";
            labelai.Text = "joint";
            labelaj.Text = "joint+1";
            for (int i = 0; i <= sleft; i++)
            {
                string ll = "textBox" + i;
                TextBox textBox = (TextBox)this.Controls.Find(ll, true).FirstOrDefault();
                textBox.BackColor = Color.LightBlue;
            }
            for (int i = sleft+1; i <= sl; i++)
            {
                string ll = "textBox" + i;
                TextBox textBox = (TextBox)this.Controls.Find(ll, true).FirstOrDefault();
                textBox.BackColor = Color.LightGreen;
            }
            timer1.Enabled = true;
            
        }

        private void buttonGD2_Click(object sender, EventArgs e)
        {
            timerSwap.Enabled = true;
            labeli.Text = "right";
            labelj.Text = "curr";
            labelai.Text = "joint";
            labelaj.Text = "joint + 1";
            //string st = @"C:\Users\ASUS\Desktop\images2.jpg";
            pictureBoxi.Image = Properties.Resources.images2;
            //string st1 = @"C:\Users\ASUS\Desktop\muiten.png";
            pictureBoxsosanh.Image = Properties.Resources.muiten;
            //string st2 = @"C:\Users\ASUS\Desktop\muiten2.png";
            pictureBoxsosanh1.Image = Properties.Resources.muiten2;
        }
        private void timerSwap_Tick(object sender, EventArgs e)
        {
            //InterchangeSort
            if (comboBox1.SelectedIndex == 1)
            {
                int t = repeat + 1;
                pbdoicho.Visible = false;
                
                if (kts == 0)
                {
                    pictureBox1.Location = new Point(460, 100);
                    textBoxkq.Text = "";
                    string vitrij = "textBox" + (t + k);
                    TextBox qq1 = (TextBox)this.Controls.Find(vitrij, true).FirstOrDefault();
                    pictureBoxsosanh.Location = new Point(qq1.Location.X, qq1.Location.Y - 150);
                    pictureBoxsosanh.Visible = true;
                    textBoxj.Text = (t + k).ToString();
                    textBoxaj.Text = a[t + k].ToString();
                }
                if (kts == 1)
                {
                    pictureBoxsosanh.Visible = true;
                    pictureBox1.Location = new Point(460, 120);
                }
                if (kts == 3)
                {
                    pictureBox1.Location = new Point(460, 140);
                    if (a[t + k] < a[repeat])
                    {
                        int dulieu;
                        int tem = a[repeat];
                        a[repeat] = a[t + k];
                        a[t + k] = tem;
                        string vitriamin = "textBox" + repeat;
                        string vitribandau = "textBox" + (t + k);
                        TextBox zz1 = (TextBox)this.Controls.Find(vitriamin, true).FirstOrDefault();
                        TextBox zz2 = (TextBox)this.Controls.Find(vitribandau, true).FirstOrDefault();
                        pbdoicho.Visible = true;
                        pbdoicho.Location = new Point(zz1.Location.X, zz1.Location.Y - 20);
                        pbdoicho.Width = Math.Abs(zz2.Location.X - zz1.Location.X + zz1.Width);
                        textBoxkq.Text = "Đổi chỗ " + a[repeat] + " và " + a[t + k];
                        dulieu = int.Parse(zz1.Text);
                        zz1.Text = zz2.Text;
                        zz2.Text = dulieu.ToString();
                        textBoxi.Text = repeat.ToString();
                        textBoxai.Text = a[repeat].ToString();
                        textBoxj.Text = (t + k).ToString();
                        textBoxaj.Text = a[t + k].ToString();
                        //pictureBox1.Location = new Point(460, 0);
                        kts = -1;

                    }
                    else
                    {
                        kts = -1;
                        pictureBox1.Location = new Point(460, 120);
                        textBoxkq.Text = "Không làm gì!";

                    }
                    k++;
                    if ((t + k) == (soLuong.Value))
                    {
                        string vitriamin = "textBox" + (repeat);
                        TextBox zz1 = (TextBox)this.Controls.Find(vitriamin, true).FirstOrDefault();
                        zz1.BackColor = Color.LightYellow;
                        button1.Enabled = false;
                        buttonPause.Enabled = true;
                        timerSwap.Enabled = false;
                        k = 0;
                        timer1.Enabled = true;
                    }
                }
                if (kts < 4)
                {
                    kts++;
                }


            }

            //Insertion sort
            int pos = repeat + 1;
            if (comboBox1.SelectedIndex == 2)
            {
                
                if (sort == 0 || sort == -1)
                {
                    string vitri = "textBox" + (pos - 1 - tt);
                    TextBox cc = (TextBox)this.Controls.Find(vitri, true).FirstOrDefault();
                    pictureBoxsosanh.Location = new Point(cc.Location.X, cc.Location.Y - 150);
                    pictureBoxsosanh.Visible = true;
                    textBoxj.Text = (pos - 1 - tt).ToString();
                    textBoxaj.Text = a[pos - 1 - tt].ToString();
                }
                if (sort < 4)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 20);
                    sort++;
                }
                if (sort == 1)
                {
                    if (pos > 0 && a[pos - 1 - tt] > a[pos - tt])
                    {
                        //pos-tt = pos
                        //pos -1 -tt = pos-1
                        textBoxkq.Text = "Đổi chỗ " + a[pos - 1 - tt] + " và " + a[pos - tt];
                        string vitripos = "textBox" + (pos - tt);
                        string vitripos1 = "textBox" + (pos - 1 - tt);
                        TextBox pp1 = (TextBox)this.Controls.Find(vitripos, true).FirstOrDefault();
                        TextBox pp2 = (TextBox)this.Controls.Find(vitripos1, true).FirstOrDefault();
                        int tem2 = int.Parse(pp1.Text);
                        pp1.Text = pp2.Text;
                        pp2.Text = tem2.ToString();

                        pbdoicho.Visible = true;
                        pbdoicho.Location = new Point(pp2.Location.X, pp2.Location.Y - 20);
                        pbdoicho.Width = Math.Abs(pp1.Location.X - pp2.Location.X + pp1.Width);
                        int tem = a[pos - tt];
                        a[pos - tt] = a[pos - 1 - tt];
                        a[pos - 1 - tt] = tem;

                        string sau = "textBox" + (pos - 1 - tt);
                        TextBox Sau1 = (TextBox)this.Controls.Find(sau, true).FirstOrDefault();
                        lbcur.Location = new Point(Sau1.Location.X, Sau1.Location.Y +40);

                        //textBoxi.Text = pos.ToString();

                        pos--;
                        if (pos - 1 >= 0)
                        {
                            //textBoxai.Text = a[pos - 1 -tt].ToString();
                        }

                    }
                    else
                    {
                        textBoxkq.Text = "Không làm gì";
                        pos--;
                        pos = -1;
                    }
                }

                if (sort == 2) pbdoicho.Visible = false;
                if (sort == 3)
                {
                    
                    sort = -1;
                    textBoxkq.Text = null;
                    pictureBox1.Location = new Point(460, 110);
                    tt++;
                    if (pos - 1 - tt < 0)
                    {
                        pos = -1;
                    }
                    else
                    {
                        string vitri = "textBox" + (pos - 1 - tt);
                        TextBox cc = (TextBox)this.Controls.Find(vitri, true).FirstOrDefault();
                        pictureBoxsosanh.Location = new Point(cc.Location.X, cc.Location.Y - 150);
                        pictureBoxsosanh.Visible = true;
                        //textBoxi.Text = (pos - 1- tt).ToString();
                        //textBoxai.Text = a[pos - 1 - tt].ToString();

                    }

                }
                if (pos <= 0)
                {
                    sort = -1;
                    tt = 0;
                    pictureBoxsosanh.Visible = false;
                    timerSwap.Enabled = false;
                    timer1.Enabled = true;
                    buttonPause.Enabled = true;
                    button1.Enabled = false;
                }

            }

            //Bubble Sort
            if (comboBox1.SelectedIndex == 3)
            {
                if (sort == -1)
                {
                    string vitrithuj = "textBox" + (soLuong.Value - 1 - tt);
                    TextBox cc = (TextBox)this.Controls.Find(vitrithuj, true).FirstOrDefault();
                    pictureBoxsosanh.Location = new Point(cc.Location.X, cc.Location.Y - 150);
                    pictureBoxsosanh.Visible = true;
                    textBoxj.Text = (soLuong.Value - 1 - tt).ToString();
                    textBoxaj.Text = a[Convert.ToInt32(soLuong.Value - 1 - tt)].ToString();
                    textBoxj1.Text = "";
                    textBoxaj1.Text = "";
                    textBoxkq.Text = "";
                    pictureBox1.Location = new Point(460, 100);
                }
                if (sort == 0)
                {
                    string vitrithuj1 = "textBox" + (soLuong.Value - 1 - tt2);
                    TextBox cc1 = (TextBox)this.Controls.Find(vitrithuj1, true).FirstOrDefault();
                    pictureBoxsosanh1.Location = new Point(cc1.Location.X, cc1.Location.Y - 150);
                    pictureBoxsosanh1.Visible = true;
                    textBoxj1.Text = (soLuong.Value - 1 - tt2).ToString();
                    textBoxaj1.Text = cc1.Text;
                    pictureBox1.Location = new Point(460, 120);
                }
                if (sort == 1)
                {
                    if (Convert.ToInt32(soLuong.Value - 1 - tt2) != repeat)
                    {
                        if (a[Convert.ToInt32(soLuong.Value - 1 - tt)] < a[Convert.ToInt32(soLuong.Value - 1 - tt2)])
                        {
                            string vitrithuj = "textBox" + (soLuong.Value - 1 - tt);
                            TextBox cc = (TextBox)this.Controls.Find(vitrithuj, true).FirstOrDefault();
                            string vitrithuj1 = "textBox" + (soLuong.Value - 1 - tt2);
                            TextBox cc1 = (TextBox)this.Controls.Find(vitrithuj1, true).FirstOrDefault();

                            textBoxkq.Text = "Đôi chỗ " + a[Convert.ToInt32(soLuong.Value - 1 - tt)] + " và " + a[Convert.ToInt32(soLuong.Value - 1 - tt2)];
                            pbdoicho.Visible = true;
                            pbdoicho.Location = new Point(cc1.Location.X, cc1.Location.Y - 25);
                            pbdoicho.Width = Math.Abs(cc.Location.X - cc1.Location.X + cc.Width);
                            int tem = a[Convert.ToInt32(soLuong.Value - 1 - tt)];
                            a[Convert.ToInt32(soLuong.Value - 1 - tt)] = a[Convert.ToInt32(soLuong.Value - 1 - tt2)];
                            a[Convert.ToInt32(soLuong.Value - 1 - tt2)] = tem;

                            int labeltem = int.Parse(cc.Text);
                            cc.Text = cc1.Text;
                            cc1.Text = labeltem.ToString();
                            pictureBox1.Location = new Point(460, 140);
                            tt++;
                            tt2++;

                        }
                        else
                        {
                            tt++;
                            tt2++;
                            textBoxkq.Text = "Không làm gì";

                        }
                    }
                    else
                    {
                        pictureBoxsosanh1.Visible = false;
                        if (a[Convert.ToInt32(soLuong.Value - 1 - tt)] < a[Convert.ToInt32(soLuong.Value - 1 - tt2)])
                        {
                            string vitrithuj = "textBox" + (soLuong.Value - 1 - tt);
                            TextBox cc = (TextBox)this.Controls.Find(vitrithuj, true).FirstOrDefault();
                            string vitrithuj1 = "textBox" + (soLuong.Value - 1 - tt2);
                            TextBox cc1 = (TextBox)this.Controls.Find(vitrithuj1, true).FirstOrDefault();


                            textBoxkq.Text = "Đôi chỗ " + a[Convert.ToInt32(soLuong.Value - 1 - tt)] + " và " + a[Convert.ToInt32(soLuong.Value - 1 - tt2)];
                            int tem = a[Convert.ToInt32(soLuong.Value - 1 - tt)];
                            a[Convert.ToInt32(soLuong.Value - 1 - tt)] = a[Convert.ToInt32(soLuong.Value - 1 - tt2)];
                            a[Convert.ToInt32(soLuong.Value - 1 - tt2)] = tem;
                            pictureBox1.Location = new Point(460, 140);
                            int labeltem = int.Parse(cc.Text);
                            cc.Text = cc1.Text;
                            cc1.Text = labeltem.ToString();
                            pbdoicho.Visible = true;
                            pbdoicho.Location = new Point(cc1.Location.X, cc1.Location.Y - 25);
                            pbdoicho.Width = Math.Abs(cc.Location.X - cc1.Location.X + cc.Width);
                            tt++;
                            tt2++;
                            timerSwap.Enabled = false;
                            timer1.Enabled = true;
                            tt = 0; tt2 = 1;
                            buttonPause.Enabled = true;
                            button1.Enabled = false;
                        }
                        else
                        {
                            tt++;
                            tt2++;
                            textBoxkq.Text = "Không làm gì";
                            timerSwap.Enabled = false;
                            timer1.Enabled = true;
                            tt = 0; tt2 = 1;
                            buttonPause.Enabled = true;
                            button1.Enabled = false;
                        }
                    }
                }
                if (soLuong.Value - tt2 - 1 < 0 || soLuong.Value - tt - 1 < 0)
                {
                    timerSwap.Enabled = false;
                    timer1.Enabled = true;
                    tt = 0; tt2 = 1;
                    buttonPause.Enabled = true;
                    button1.Enabled = false;
                }
                if (sort == 2)
                {
                    pbdoicho.Visible = false;
                    sort = -2;
                    textBoxkq.Text = null;

                    pictureBoxsosanh.Visible = pictureBoxsosanh1.Visible = false;
                }
                if (sort < 3)
                {
                    sort++;
                }
            }

            //Heap sort gd2
            if (comboBox1.SelectedIndex == 4)
            {
                pictureBox1.Visible = true;
                if (heapsort == -2)
                {
                    for (int i = 0; i <= sl; i++)
                    {
                        string po = "textBox" + i;
                        TextBox r = (TextBox)this.Controls.Find(po, true).FirstOrDefault();
                        r.BackColor = Color.LightGreen;
                    }
                    doicho1 = false; doicho2 = false;
                    ktjoint1 = false;
                    richTextBox1.Text =
                        "void	HeapSort (int a[], int N){ " + Environment.NewLine +
                        "   int   right = N - 1" + Environment.NewLine +
                        "   CreateHeap(a, N); " + Environment.NewLine +
                        "   while (right > 0){ " + Environment.NewLine +
                        "       Swap(a[0],a[right]);" + Environment.NewLine +
                        "       right--;" + Environment.NewLine +
                        "       Shift(a,0,right);" + Environment.NewLine +
                        "   }" + Environment.NewLine +
                        "}";
                    pictureBox1.Location = new Point(470, 60);
                }
                if (heapsort == -1) pictureBox1.Location = new Point(470, 80);
                if (heapsort == 0)//doi cho dau cuoi
                {
                    pictureBox1.Location = new Point(470, 100);
                    richTextBox1.Text =
                        "void	HeapSort (int a[], int N){ " + Environment.NewLine +
                        "   int   right = N - 1" + Environment.NewLine +
                        "   CreateHeap(a, N); " + Environment.NewLine +
                        "   while (right > 0){ " + Environment.NewLine +
                        "       Swap(a[0],a[right]);" + Environment.NewLine +
                        "       right--;" + Environment.NewLine +
                        "       Shift(a,0,right);" + Environment.NewLine +
                        "   }" + Environment.NewLine +
                        "}";
                    pictureBoxi.Visible = false;
                    string vtdau = "textBox" + 0;
                    TextBox qq = (TextBox)this.Controls.Find(vtdau, true).FirstOrDefault();
                    string vtcuoi = "textBox" + sl;
                    TextBox qq1 = (TextBox)this.Controls.Find(vtcuoi, true).FirstOrDefault();
                    pictureBoxRIGHT.Visible = true;
                    pictureBoxRIGHT.Location = new Point(qq1.Location.X, qq1.Location.Y + 50);
                    textBoxi.Text = sl.ToString();
                    textBoxkq.Text = "Đổi chỗ " + qq.Text + " và " + qq1.Text;
                    pbdoicho.Visible = true;
                    pbdoicho.Location = new Point(qq.Location.X, qq.Location.Y - 25);
                    pbdoicho.Width = Math.Abs(qq.Location.X - qq1.Location.X - qq1.Width);

                }
                if (heapsort == 1)
                {
                    pbdoicho.Visible = false;
                    pictureBox1.Location = new Point(470, 120);
                    string vtdau = "textBox" + 0;
                    TextBox qq = (TextBox)this.Controls.Find(vtdau, true).FirstOrDefault();
                    string vtcuoi = "textBox" + sl;
                    TextBox qq1 = (TextBox)this.Controls.Find(vtcuoi, true).FirstOrDefault();
                    string tem = qq.Text;
                    qq.Text = qq1.Text;
                    qq1.Text = tem;
                    qq1.BackColor = Color.OrangeRed;
                    qq.BackColor = Color.LightBlue;

                }
                if (heapsort == 2)
                {
                    pictureBox1.Location = new Point(470, 140);
                    sl--;
                    string vtcuoi = "textBox" + sl;
                    TextBox qq1 = (TextBox)this.Controls.Find(vtcuoi, true).FirstOrDefault();
                    pictureBoxRIGHT.Visible = true;
                    pictureBoxRIGHT.Location = new Point(qq1.Location.X, qq1.Location.Y + 50);
                    textBoxi.Text = sl.ToString();
                }
                if (heapsort == 3)
                {
                    richTextBox1.Text =
                        "void Shift (int a[], int left, int right){ " + Environment.NewLine +
                        "   int  x, curr = left, joint=2*curr+1,x = a[curr];" + Environment.NewLine +
                        "   while (joint <= right){" + Environment.NewLine +
                        "       if (joint < right)" + Environment.NewLine +
                        "           if (a[joint] < a[joint+1])" + Environment.NewLine +
                        "               joint = joint+1;" + Environment.NewLine +
                        "   if (a[joint]<x) break; " + Environment.NewLine +
                        "   a[curr] = a[joint]; " + Environment.NewLine +
                        "   curr = joint;    " + Environment.NewLine +
                        "   joint = 2*curr+1;   " + Environment.NewLine +
                        "   }" + Environment.NewLine +
                        "   a[curr] = x;" + Environment.NewLine +
                        "}";
                    pictureBox1.Location = new Point(470, 80);
                }
                //Shift
                if (heapsort == 4)
                {
                    doicho1 = false; doicho2 = false; ktjoint1 = false;
                    string vtht = "textBox" + ht;
                    TextBox vttbht = (TextBox)this.Controls.Find(vtht, true).FirstOrDefault();
                    pictureBoxi.Location = new Point(vttbht.Location.X, vttbht.Location.Y - 150);
                    pictureBoxRIGHT.Visible = pictureBoxi.Visible = true;
                    textBoxkq.Text = "";
                    pictureBox1.Location = new Point(470, 100);
                    textBoxj.Text = ht.ToString();
                }
                if (heapsort == 5)
                {
                    if (2 * ht + 1 <= sl)
                    {
                        string vitrijoint = "textBox" + (2 * ht + 1);
                        TextBox qq1 = (TextBox)this.Controls.Find(vitrijoint, true).FirstOrDefault();
                        pictureBoxsosanh.Location = new Point(qq1.Location.X, qq1.Location.Y - 150);
                        pictureBoxsosanh.Visible = true;
                        textBoxai.Text = (2 * ht + 1).ToString();
                    }
                    if ((2 * ht + 1 + 1) <= sl)
                    {
                        pictureBox1.Location = new Point(470, 120);
                        ktjoint1 = true;
                        string vitrijoint1 = "textBox" + (2 * ht + 1 + 1);
                        TextBox qq2 = (TextBox)this.Controls.Find(vitrijoint1, true).FirstOrDefault();
                        pictureBoxsosanh1.Location = new Point(qq2.Location.X, qq2.Location.Y - 150);
                        pictureBoxsosanh1.Visible = true;
                        textBoxaj.Text = (2 * ht + 1 + 1).ToString();
                    }
                    if (pictureBoxsosanh.Visible == false)
                    {

                        string vitricurr = "textBox" + ht;
                        TextBox cc = (TextBox)this.Controls.Find(vitricurr, true).FirstOrDefault();
                        cc.BackColor = Color.LightGreen;
                        heapsort = 7;
                    }
                }
                if (heapsort == 6)
                {
                    pictureBox1.Location = new Point(470, 160);
                    if (ktjoint1 == false)
                    {
                        string vitrisleft = "textBox" + ht;
                        TextBox qq = (TextBox)this.Controls.Find(vitrisleft, true).FirstOrDefault();
                        string vitrijoint = "textBox" + (2 * ht + 1);
                        TextBox qq1 = (TextBox)this.Controls.Find(vitrijoint, true).FirstOrDefault();

                        if (int.Parse(qq.Text) < int.Parse(qq1.Text))
                        {
                            textBoxkq.Text = "Đổi chỗ  " + qq.Text + " và " + qq1.Text;
                            doicho1 = true;
                            pbdoicho.Visible = true;
                            pbdoicho.Location = new Point(qq.Location.X, qq.Location.Y - 25);
                            pbdoicho.Width = Math.Abs(qq.Location.X - qq1.Location.X - qq1.Width);
                        }

                        else { textBoxkq.Text = "Không làm gì!"; qq.BackColor = Color.LightGreen; }
                    }
                    else
                    {
                        string vitrisleft = "textBox" + ht;
                        TextBox qq = (TextBox)this.Controls.Find(vitrisleft, true).FirstOrDefault();
                        string vitrijoint = "textBox" + (2 * ht + 1);
                        TextBox cc = (TextBox)this.Controls.Find(vitrijoint, true).FirstOrDefault();
                        string vitrijoint1 = "textBox" + (2 * ht + 1 + 1);
                        TextBox cc1 = (TextBox)this.Controls.Find(vitrijoint1, true).FirstOrDefault();

                        if (int.Parse(qq.Text) < int.Parse(cc.Text) && int.Parse(cc.Text) > int.Parse(cc1.Text))
                        {
                            textBoxkq.Text = "Đổi chỗ " + qq.Text + " và " + cc.Text;
                            doicho1 = true;
                            pbdoicho.Visible = true;
                            pbdoicho.Location = new Point(qq.Location.X, qq.Location.Y - 25);
                            pbdoicho.Width = Math.Abs(qq.Location.X - cc.Location.X - cc.Width);
                        }
                        else if (int.Parse(qq.Text) < int.Parse(cc1.Text))
                        {
                            textBoxkq.Text = "Đổi chỗ " + qq.Text + " và " + cc1.Text;
                            doicho2 = true;
                            pbdoicho.Visible = true;
                            pbdoicho.Location = new Point(qq.Location.X, qq.Location.Y - 25);
                            pbdoicho.Width = Math.Abs(qq.Location.X - cc1.Location.X - cc1.Width);
                        }
                        else { textBoxkq.Text = "Không làm gì!"; qq.BackColor = Color.LightGreen; }

                        }
                }
                if (heapsort == 7)
                {
                    pbdoicho.Visible = false;
                    string vitrisleft = "textBox" + ht;
                    TextBox qq = (TextBox)this.Controls.Find(vitrisleft, true).FirstOrDefault();
                    //qq.BackColor = Color.LightGreen;

                    if (doicho1)
                    {
                        string vitricurr = "textBox" + (2 * ht + 1);
                        TextBox cc = (TextBox)this.Controls.Find(vitricurr, true).FirstOrDefault();
                        qq.BackColor = Color.LightGreen;
                        cc.BackColor = Color.LightBlue;
                        string tem = qq.Text;
                        qq.Text = cc.Text;
                        cc.Text = tem;
                        ht = 2 * ht + 1;
                        heapsort = 3;
                    }
                    else if (doicho2)
                    {
                        string vitricurr = "textBox" + (2 * ht + 1 + 1);
                        TextBox cc = (TextBox)this.Controls.Find(vitricurr, true).FirstOrDefault();
                        qq.BackColor = Color.LightGreen;
                        cc.BackColor = Color.LightBlue;
                        string tem = qq.Text;
                        qq.Text = cc.Text;
                        cc.Text = tem;
                        ht = 2 * ht + 1 + 1;
                        heapsort = 3;
                    }

                    pictureBoxsosanh.Visible = pictureBoxsosanh1.Visible = false;
                    textBoxai.Text = textBoxaj.Text = "";
                }
                if (heapsort == 8)
                {

                    pictureBoxsosanh.Visible = pictureBoxsosanh1.Visible = pictureBoxi.Visible = false;
                    textBoxai.Text = textBoxaj.Text = "";
                    textBoxj.Text = textBoxaj.Text = textBoxai.Text = "";
                    heapsort = -1;
                    ht = 0;
                    if (sl < 1)
                    {
                        string vitricurr = "textBox" + 0;
                        TextBox cc = (TextBox)this.Controls.Find(vitricurr, true).FirstOrDefault();
                        cc.BackColor = Color.OrangeRed;
                        timerSwap.Enabled = false;
                        textBoxkq.Text = "Đã xong giai đoạn 2";
                        doicho1 = doicho2 = false;
                    }
                }

                if (heapsort < 9)
                {
                    heapsort++;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Selection sort
            if (comboBox1.SelectedIndex == 0)
            {
                button1.Visible = false;
                labeli.Text = "i = min";
                if (kt == 0||kt==1)
                {
                    pictureBox1.Location = new Point(460,60);
                    textBoxi.Text = repeat.ToString();
                    textBoxai.Text = a[repeat].ToString();
                    textBoxaj.Text = "";
                    textBoxj.Text = "";
                }
                if(kt==1) pictureBox1.Location = new Point(460, 80);
                if(kt==2) pictureBox1.Location = new Point(460, 120);
                
                if (kt == 3)
                {
                    pictureBox1.Location = new Point(460, 140);
                    min = repeat;
                    for (int j = repeat + 1; j < soLuong.Value; j++)
                    {
                        if (a[j] < a[min])
                        {
                            //min = j;
                            //string vitrisosanh = "textBox" + min;
                            //TextBox qq1 = (TextBox)this.Controls.Find(vitrisosanh, true).FirstOrDefault();
                            //pictureBoxsosanh.Location = new Point(qq1.Location.X, qq1.Location.Y - 150);
                            //pictureBoxsosanh.Visible = true;
                            
                        }

                    }
                }
                if (kt == 4)
                {
                    pictureBox1.Location = new Point(460, 160);
                    min = repeat;
                    for (int j = repeat + 1; j < soLuong.Value; j++)
                    {
                        if (a[j] < a[min])
                        {
                            textBoxj.Text = j.ToString();
                            textBoxaj.Text = a[j].ToString();
                            min = j;
                            string vitrisosanh = "textBox" + min;
                            TextBox qq1 = (TextBox)this.Controls.Find(vitrisosanh, true).FirstOrDefault();
                            pictureBoxsosanh.Location = new Point(qq1.Location.X, qq1.Location.Y - 150);
                            pictureBoxsosanh.Visible = true;
                            textBoxj.Text = j.ToString();
                            textBoxaj.Text = a[j].ToString();
                        }

                    }
                }
                if (kt == 5)
                {
                    pictureBox1.Location = new Point(460, 180);
                    string vitriamin = "textBox" + min;
                    string vitribandau = "textBox" + repeat;
                    TextBox qq1 = (TextBox)this.Controls.Find(vitriamin, true).FirstOrDefault();
                    TextBox qq2 = (TextBox)this.Controls.Find(vitribandau, true).FirstOrDefault();

                    if (min != repeat)
                    {
                        int tem = a[min], dulieu;
                        a[min] = a[repeat];
                        a[repeat] = tem;

                        textBoxkq.Text = "Đổi chỗ " + a[min] + " và " + a[repeat];
                        dulieu = int.Parse(qq1.Text);
                        qq1.Text = qq2.Text;
                        qq2.Text = dulieu.ToString();
                        //Point tmp = new Point(qq1.Location.X, qq1.Location.Y);
                        //qq1.Location = qq2.Location;
                        //qq2.Location = new Point(tmp.X, tmp.Y);
                        pbdoicho.Visible = true;
                        pbdoicho.Location = new Point(qq2.Location.X, qq2.Location.Y-20);
                        pbdoicho.Width = Math.Abs(qq2.Location.X - qq1.Location.X-qq1.Width);

                    }
                    else
                    {
                        textBoxkq.Text = "Không làm gì!";
                        textBoxj.Text = "";
                    }
                    qq2.BackColor = Color.LightYellow;

                }
                if (kt == 6)
                {
                    pictureBox1.Location = new Point(460, 200);
                    pictureBoxsosanh.Visible=pbdoicho.Visible = false;
                    //pictureBox1.Location = new Point(450, 40);
                    pictureBoxi.Location = new Point(pictureBoxi.Location.X + 90, pictureBoxi.Location.Y);
                    textBoxkq.Text = ""; 
                    kt = 0;
                    repeat++;
                }
                if (repeat == soLuong.Value-1)
                {
                    string vitribandau = "textBox" + repeat;
                    TextBox qq1 = (TextBox)this.Controls.Find(vitribandau, true).FirstOrDefault();
                    qq1.BackColor = Color.LightYellow;
                    textBoxkq.Text = "Đone";
                    timer1.Enabled = false;
                }
                if (kt < 6)
                {
                    kt++;
                }
            }


            //Interchange sort
            if (comboBox1.SelectedIndex == 1)
            {
                labeli.Text = "i";
                if (kt == -1||kt==0)
                {
                    pictureBox1.Location = new Point(460, 60);
                    pictureBoxsosanh.Visible = false;
                    textBoxi.Text = repeat.ToString();
                    textBoxai.Text = a[repeat].ToString();
                    textBoxaj.Text = "";
                    textBoxj.Text = "";
                    textBoxkq.Text = "";
                }
                if (kt == 0)
                {
                    pictureBox1.Location = new Point(460, 80);
                    button1.Enabled = true;
                    buttonPause.Enabled = false;

                    timer1.Enabled = false;
                    timerSwap.Enabled = true;
                    textBoxj.Text = (repeat + 1).ToString();
                    textBoxaj.Text = a[repeat + 1].ToString();
                    pictureBoxsosanh.Visible = true;
                    string vitriamin = "textBox" + (repeat+1);
                    TextBox zz1 = (TextBox)this.Controls.Find(vitriamin, true).FirstOrDefault();
                    pictureBoxsosanh.Location = new Point(zz1.Location.X, zz1.Location.Y -150);


                }
                if (kt == 2) kt = 4;

                if (kt < 4)
                {
                    pictureBoxsosanh.Visible = false;
                    kt++;
                }
                if (kt == 4)
                {
                    //pictureBox1.Location = new Point(470, 50);
                    pictureBoxi.Location = new Point(pictureBoxi.Location.X + 90, pictureBoxi.Location.Y);
                    kt = 0;
                    repeat++;
                }
                if (repeat == soLuong.Value-1)
                {
                    string vitriamin = "textBox" + (sl);
                    TextBox zz1 = (TextBox)this.Controls.Find(vitriamin, true).FirstOrDefault();
                    zz1.BackColor = Color.LightYellow;
                    pbdoicho.Visible = false;
                    pictureBoxsosanh.Visible = false;
                    textBoxi.Text = repeat.ToString();
                    textBoxai.Text = a[repeat].ToString();
                    textBoxaj.Text = "";
                    textBoxj.Text = "";
                    textBoxkq.Text = "Đone";
                    timer1.Enabled = false;
                }
            }

            //Insertion sort
            if(comboBox1.SelectedIndex==2)
            {
                
                if (kt==0)
                {
                    lbi.Visible = lbcur.Visible = true;
                    string vitri1 = "textBox" + (repeat + 1);
                    TextBox test = (TextBox)this.Controls.Find(vitri1, true).FirstOrDefault();
                    pictureBoxi.Location = new Point(test.Location.X, test.Location.Y-150);
                    pictureBoxi.Visible = true;
                    lbi.Location = new Point(pictureBoxi.Location.X + 10, pictureBoxi.Location.Y);
                    lbcur.Location = new Point(pictureBoxi.Location.X, pictureBoxi.Location.Y + 190);
                    
                    textBoxi.Text = (repeat+1).ToString();
                    textBoxai.Text = a[repeat+1].ToString();
                    textBoxaj.Text = "";
                    textBoxj.Text = "";
                    
                }
                if (kt ==1 )
                {
                    timerSwap.Enabled = true;
                    timer1.Enabled = false;
                    button1.Enabled = true;
                    buttonPause.Enabled = false;
                    string vitri2 = "textBox" + (repeat);
                    TextBox test2 = (TextBox)this.Controls.Find(vitri2, true).FirstOrDefault();
                    pictureBoxsosanh.Location = new Point(test2.Location.X, test2.Location.Y - 150);
                    pictureBoxsosanh.Visible = true;
                    textBoxj.Text = repeat.ToString();
                    textBoxaj.Text = a[repeat].ToString();
                }
                if (kt==2)
                {
                    textBoxkq.Text = "";
                    pbdoicho.Visible = false;
                    kt = -1;
                    repeat++;
                    pictureBox1.Location = new Point(470, 40);
                    
                }
                
                if (kt < 5)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 20);
                    kt++;
                }
                if (repeat == soLuong.Value -1)
                {
                    pictureBoxsosanh.Visible = false;
                    lbcur.Visible = false;
                    //textBoxi.Text = repeat.ToString();
                    //textBoxai.Text = a[repeat].ToString();
                    //textBoxaj.Text = "";
                    //textBoxj.Text = "";
                    textBoxkq.Text = "Đone";
                    timer1.Enabled = false;
                }
            }

            //Buble Sort
            if (comboBox1.SelectedIndex==3)
            {
                if (kt==-2)
                {
                    pictureBox1.Location = new Point(460, 60);
                }
                if (kt==-1)
                {
                    pictureBox1.Location = new Point(460, 80);
                    string vitrithui = "textBox" + (repeat);
                    TextBox cc = (TextBox)this.Controls.Find(vitrithui, true).FirstOrDefault();
                    pictureBoxi.Location = new Point(cc.Location.X, cc.Location.Y - 150);
                    pictureBoxi.Visible = true;
                    textBoxi.Text = repeat.ToString();
                    textBoxai.Text = a[repeat].ToString();
                    timerSwap.Enabled = true;
                    timer1.Enabled = false;
                    button1.Enabled = true;
                    buttonPause.Enabled = false;
                }
                if (kt==0)
                {
                    //timerSwap.Enabled = true;
                    //timer1.Enabled = false;
                    //button1.Enabled = true;
                    //buttonPause.Enabled = false;
                }
                if (kt == 1)
                {
                    pbdoicho.Visible = false;
                    textBoxkq.Text = "";

                    kt = -2;
                    repeat++;
                    //pictureBox1.Location = new Point(470, 80);

                }
                
                if(kt==2)
                {
                    kt = -1;
                    repeat++;
                    pictureBox1.Location = new Point(460, 80);
                    //pictureBoxi.Location = new Point(pictureBoxi.Location.X+20, pictureBoxi.Location.Y);
                }
                if (kt < 4)
                {
                    kt++;
                }
                if (repeat == soLuong.Value - 1)
                {
                    pictureBoxsosanh.Visible = false;
                    pictureBoxsosanh.Visible = false;
                    textBoxkq.Text = "Đone";
                    timer1.Enabled = false;
                    textBoxi.Text = (soLuong.Value - 1).ToString();
                    textBoxai.Text = (a[Convert.ToInt32(soLuong.Value-1)]).ToString();
                    pictureBox1.Location = new Point(460, 60);
                    pictureBoxi.Location = new Point(pictureBoxi.Location.X + 100, pictureBoxi.Location.Y);
                    textBoxj1.Text = textBoxaj1.Text = textBoxj.Text = textBoxaj.Text = textBoxkq.Text = "";
                }

            }

            //Heap sort
            if (comboBox1.SelectedIndex==4)
            {
                if (kt == -2)
                {
                    curr = sleft;
                    
                }
                if (kt == -1)
                {
                    richTextBox1.Text =
                        "void CreateHeap(int a[], int N){" + Environment.NewLine +
                        "int left;" + Environment.NewLine +
                        "for (left = (N - 1) / 2; left >= 0; left--)" + Environment.NewLine +
                        "    Shift(a, left, N - 1);" + Environment.NewLine +
                        "}";
                    pictureBox1.Location = new Point(470, 62);
                    
                    textBoxi.Text = sleft.ToString();
                }
                if (kt == 0)
                {
                    textBoxaj.Text =textBoxj.Text=textBoxj.Text= textBoxai.Text = "";
                    string vitrisleft = "textBox" + sleft;
                    TextBox qq = (TextBox)this.Controls.Find(vitrisleft, true).FirstOrDefault();
                    pictureBoxleft.Location = new Point(qq.Location.X, qq.Location.Y + 50);
                    pictureBoxleft.Visible = true;
                    pictureBox1.Location = new Point(470, 82);
                }
                
                if (kt==1)
                {
                    richTextBox1.Text =
                        "void Shift (int a[], int left, int right){ " + Environment.NewLine +
                        "   int  x, curr = left, joint=2*curr+1,x = a[curr];" + Environment.NewLine +
                        "   while (joint <= right){" + Environment.NewLine +
                        "       if (joint < right)" + Environment.NewLine +
                        "           if (a[joint] < a[joint+1])" + Environment.NewLine +
                        "               joint = joint+1;" + Environment.NewLine +
                        "   if (a[joint]<x) break; " + Environment.NewLine +
                        "   a[curr] = a[joint]; " + Environment.NewLine +
                        "   curr = joint;    " + Environment.NewLine +
                        "   joint = 2*curr+1;   " + Environment.NewLine +
                        "   }"+Environment.NewLine+
                        "   a[curr] = x;"+Environment.NewLine+
                        "}";
                    pictureBox1.Location = new Point(470, 80);
                    doicho1 = false;doicho2 = false;
                    ktjoint1 = false;
                    pictureBoxi.Visible= pictureBoxleft.Visible = true;
                    string vitrisleft = "textBox" + sleft;
                    TextBox qq = (TextBox)this.Controls.Find(vitrisleft, true).FirstOrDefault();
                    pictureBoxleft.Location = new Point(qq.Location.X, qq.Location.Y + 50);

                    string vitricurr = "textBox" + curr;
                    TextBox cc = (TextBox)this.Controls.Find(vitricurr, true).FirstOrDefault();
                    pictureBoxi.Location = new Point(cc.Location.X, cc.Location.Y - 150);
                    textBoxj.Text = curr.ToString();

                    
                }
                if (kt == 2)
                {
                    pictureBox1.Location = new Point(470, 100);
                    if (2 * curr + 1 <= Convert.ToInt32(soLuong.Value)) 
                    {
                        string vitrijoint = "textBox" + (2 * curr + 1);
                        TextBox qq1 = (TextBox)this.Controls.Find(vitrijoint, true).FirstOrDefault();
                        pictureBoxsosanh.Location = new Point(qq1.Location.X, qq1.Location.Y - 100);
                        pictureBoxsosanh.Visible = true;
                        pictureBox1.Location = new Point(470, 100);
                        textBoxai.Text = (2 * curr + 1).ToString();
                    }
                    if ((2 * curr + 1 + 1) < Convert.ToInt32(soLuong.Value))
                    {
                        ktjoint1 = true;
                        string vitrijoint1 = "textBox" + (2 * curr + 1 + 1);
                        TextBox qq2 = (TextBox)this.Controls.Find(vitrijoint1, true).FirstOrDefault();
                        pictureBoxsosanh1.Location = new Point(qq2.Location.X, qq2.Location.Y - 100);
                        pictureBoxsosanh1.Visible = true;
                        pictureBox1.Location = new Point(470, 120);
                        textBoxaj.Text = (2 * curr + 1 + 1).ToString();
                    }
                    if (pictureBoxsosanh.Visible == false)
                    {
                        string vitricurr = "textBox" + curr;
                        TextBox cc = (TextBox)this.Controls.Find(vitricurr, true).FirstOrDefault();
                        cc.BackColor = Color.LightGreen;
                        kt = 5;
                        
                    } 

                }
                if (kt == 3)
                {
                    if (ktjoint1 == false)
                    {
                        string vitrisleft = "textBox" + curr;
                        TextBox qq = (TextBox)this.Controls.Find(vitrisleft, true).FirstOrDefault();
                        string vitrijoint = "textBox" + (2 * curr + 1);
                        TextBox qq1 = (TextBox)this.Controls.Find(vitrijoint, true).FirstOrDefault();

                        if (int.Parse(qq.Text) < int.Parse(qq1.Text))
                        {
                            textBoxkq.Text = "Đổi chỗ " + qq.Text + " và " + qq1.Text;
                            doicho1 = true;
                        }
                        else textBoxkq.Text = "Không làm gì!";
                        pictureBox1.Location = new Point(470, 160);
                    }
                    else
                    {
                        string vitrisleft = "textBox" + curr;
                        TextBox qq = (TextBox)this.Controls.Find(vitrisleft, true).FirstOrDefault();
                        string vitrijoint = "textBox" + (2 * curr + 1);
                        TextBox cc = (TextBox)this.Controls.Find(vitrijoint, true).FirstOrDefault();
                        string vitrijoint1 = "textBox" + (2 * curr + 1+1);
                        TextBox cc1 = (TextBox)this.Controls.Find(vitrijoint1, true).FirstOrDefault();
                        
                        if (int.Parse(qq.Text) < int.Parse(cc.Text) && int.Parse(cc.Text)>int.Parse(cc1.Text))
                        {
                            textBoxkq.Text = "Đổi chỗ " + qq.Text + " và " + cc.Text;
                            doicho1 = true;
                        }
                        else if (int.Parse(qq.Text) < int.Parse(cc1.Text))
                        {
                            textBoxkq.Text = "Đỗi chỗ " + qq.Text + " và " + cc1.Text;
                            doicho2 = true;
                            
                        }
                        else textBoxkq.Text = "Không làm gì!";
                        pictureBox1.Location = new Point(470, 160);
                    }
                }
                if (kt==4)
                {
                    textBoxkq.Text = "";
                    string vitrisleft = "textBox" + curr;
                    TextBox qq = (TextBox)this.Controls.Find(vitrisleft, true).FirstOrDefault();
                    qq.BackColor = Color.LightGreen;

                    if (doicho1)
                    {
                        string vitricurr = "textBox" + (2 * curr + 1);
                        TextBox cc = (TextBox)this.Controls.Find(vitricurr, true).FirstOrDefault();
                        cc.BackColor = Color.LightBlue;
                        string tem = qq.Text;
                        qq.Text = cc.Text;
                        cc.Text = tem;
                        curr = 2 * curr + 1;
                        kt = -1;
                        pictureBox1.Location = new Point(470, 180);
                    }
                    else if(doicho2)
                    {
                        string vitricurr = "textBox" + (2 * curr + 1+1);
                        TextBox cc = (TextBox)this.Controls.Find(vitricurr, true).FirstOrDefault();
                        cc.BackColor = Color.LightBlue;
                        string tem = qq.Text;
                        qq.Text = cc.Text;
                        cc.Text = tem;
                        curr = 2 * curr + 1+1;
                        kt = -1;
                        pictureBox1.Location = new Point(470, 180);
                    }
                    
                    pictureBoxsosanh.Visible = pictureBoxsosanh1.Visible = false;
                }
                if(kt==5)
                {
                    pictureBoxsosanh.Visible = pictureBoxsosanh1.Visible = pictureBoxi.Visible = false;
                    kt = -2;
                    sleft = sleft - 1;
                    curr = sleft;
                    if (sleft<0)
                    {
                        timer1.Enabled = false;
                        textBoxkq.Text = "Đã xong giao đoạn 1";
                        doicho1 = doicho2 = false;
                        pictureBoxleft.Visible = false;
                        pictureBox1.Visible = false;
                        textBoxai.Text = textBoxaj.Text = textBoxj.Text = "";
                        DialogResult result = MessageBox.Show("Bạn có muốn bắt đầu giai đoạn 2 ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes) buttonGD2_Click(sender, e); else buttonGD2.Visible = true;
                    }
                }
                if (kt<6)
                {
                    kt++;
                }
            }

            //shell sort
            if (comboBox1.SelectedIndex == 5)
            {
                richTextBox1.Text =
                        "int h[MAXK], k; " + Environment.NewLine +
                        "void ShellSort(int a[], int N){" + Environment.NewLine +
                        "   int step, i, pos, x, len;" + Environment.NewLine +
                        "   for (step = 0 ; step <k; step ++){" + Environment.NewLine +
                        "   len = h[step]; " + Environment.NewLine +
                        "    for (i = len; i < N; i++){" + Environment.NewLine +
                        "      x = a[i];" + Environment.NewLine +
                        "      for(pos=i;(pos-len>=0)&&(x<a[pos-len]);pos-=len)" + Environment.NewLine +
                        "           a[pos] = a[pos-len];" + Environment.NewLine +
                        "      a[pos] = x;" + Environment.NewLine +
                        "    }" + Environment.NewLine +
                        "   }" + Environment.NewLine +
                        "}";
                int h1 = Convert.ToInt32(numericUpDown1.Value);
                int h2 = Convert.ToInt32(numericUpDown2.Value);
                int h3 = Convert.ToInt32(numericUpDown3.Value);
                PictureBox pb = new PictureBox();
                if (ttnumeric == 1) kl = h1;
                if (ttnumeric == 2) kl = h2;
                if (ttnumeric == 3) kl = h3;
                string lan1 = "textBox" + (kl + ts);
                TextBox tt = (TextBox)this.Controls.Find(lan1, true).FirstOrDefault();

                if (kt == -2) pictureBox1.Location = new Point(460,100); textBoxi.Text = (ttnumeric-1).ToString();
                if (kt == -1)  pictureBox1.Location = new Point(460, 120); textBoxj.Text = kl.ToString(); 
                if (kt==0)
                {
                    pictureBox1.Location = new Point(460, 140);
                    pictureBoxi.Location = new Point(tt.Location.X, tt.Location.Y - 150);
                    pictureBoxi.Visible = true;
                    textBoxai.Text = (kl + ts).ToString();
                }
                if (kt==1)
                {
                    pictureBox1.Location = new Point(460, 180);
                    for (int i =kl + ts - kl; i >= 0; i=i-kl)
                    {
                        string pb1 = "pb" + i;
                        PictureBox pbb = (PictureBox)this.Controls.Find(pb1, true).FirstOrDefault();
                        pbb.Visible = true;
                        demslpb++;
                    }
                    textBoxaj.Text = ts.ToString();
                }
                if (kt==2)
                {
                    pictureBox1.Location = new Point(460, 180);
                    textBoxtam.Text = tt.Text;
                    tt.Text = "";
                }
                if (kt==3)
                {
                    for (int i = 0; i <= sl; i++)
                    {
                        string tb = "textBox" + i;
                        TextBox tbb = (TextBox)this.Controls.Find(tb, true).FirstOrDefault();
                        tbb.BackColor = Color.AliceBlue;
                    }
                    if ((ts - ss * kl) >= 0)
                    {
                        string strdoicho = "textBox" + (ts - (ss) * kl);
                        TextBox textdoicho = (TextBox)this.Controls.Find(strdoicho, true).FirstOrDefault();
                        textdoicho.BackColor = Color.LightYellow;
                    }
                    textBoxkq.Text = "";
                }
                if (kt==4)
                {
                    textBoxaj.Text = (ts - (ss-1) * kl).ToString();
                    pictureBox1.Location = new Point(460, 220);
                    if ((ts-ss*kl)>=0)//neu ton tai vi tri joint 
                    {
                        string sosanh = "textBox" + (ts - ss * kl);
                        TextBox cansosanh = (TextBox)this.Controls.Find(sosanh, true).FirstOrDefault();
                        string strdoicho = "textBox" + (ts - (ss-1) * kl);
                        TextBox textdoicho = (TextBox)this.Controls.Find(strdoicho, true).FirstOrDefault();
                        if (int.Parse(textBoxtam.Text) < int.Parse(cansosanh.Text))//a[hientai]<a[joint1]
                        {
                            textBoxkq.Text = "Đổi chỗ " + cansosanh.Text + " và " + textBoxtam.Text;
                            textdoicho.Text = cansosanh.Text;
                            cansosanh.Text = "";
                            kt = 2;
                            doicho1 = true;
                        }
                        else
                        {
                            textdoicho.Text = textBoxtam.Text;
                            textBoxtam.Text = "";
                            ss = -1;
                            kt = 4;
                            doicho1 = false;
                            pictureBox1.Location = new Point(460, 240);
                            textBoxkq.Text = "Không làm gì!";
                        }

                    }
                    else
                    {
                        if (doicho1 == true)
                        {
                            string sosanh = "textBox" + (ts - (ss - 1) * kl);
                            TextBox cansosanh = (TextBox)this.Controls.Find(sosanh, true).FirstOrDefault();
                            cansosanh.Text = textBoxtam.Text;
                            textBoxtam.Text = "";
                            doicho1 = false;
                            ss = -1;
                            kt = 4;
                            pictureBox1.Location = new Point(460, 240);
                        }
                    }
                    
                    ss++;
                }
                if (kt == 5)
                {
                    for (int i = 0; i < sl; i ++)
                    {
                        string pb1 = "pb" + i;
                        PictureBox pbb = (PictureBox)this.Controls.Find(pb1, true).FirstOrDefault();
                        pbb.Visible = false;
                        string tb = "textBox" + i;
                        TextBox tbb = (TextBox)this.Controls.Find(tb, true).FirstOrDefault();
                        tbb.BackColor = Color.AliceBlue;
                    }

                    ts++;
                    kt = -1;
                    if (kl+ts-1-1==sl-1)
                    {
                        pictureBoxi.Visible = false;
                        ttnumeric++;
                        kt = -3;
                        if (ttnumeric > Convert.ToInt32(numericUpDownk.Value)) timer1.Enabled = false;ts = 0;
                    }
                }
                if (kt<8)
                {
                    kt++;
                    
                }
            }

            //Quick Sort
            
            if (comboBox1.SelectedIndex==6)
            {

                if (kt==-2)
                {
                    textBoxkq.Text = "";
                    pictureBoxi.Visible = pictureBoxsosanh.Visible = false;
                    textBoxi.Text = textBoxai.Text = textBoxj.Text = textBoxaj.Text = "";
                    richTextBox1.Text =
                        "void QuickSort(int a[], int left, int right){ " + Environment.NewLine +
                        "   int	i, j, x;" + Environment.NewLine +
                        "   if (left >= right)	return;" + Environment.NewLine +
                        "   x = a[left]; " + Environment.NewLine +
                        "   i = left; j = right; " + Environment.NewLine +
                        "   while(i < j) {" + Environment.NewLine +
                        "       while(a[i] < x) i++; " + Environment.NewLine +
                        "       while(a[j] > x) j--; " + Environment.NewLine +
                        "       if(i <= j) {  " + Environment.NewLine +
                        "           Swap(a[i], a[j]);  " + Environment.NewLine +
                        "           i++ ; j--;  " + Environment.NewLine +
                        "       }" + Environment.NewLine +
                        "   }" + Environment.NewLine +
                        "}";
                    pictureBox1.Location = new Point(460, 60);
                }
                if (kt == -1)
                {
                    pictureBox1.Location = new Point(460, 80);
                    for ( int i = 0; i < 10; i++)
                    {
                        string mm = "textBox" + i;
                        TextBox mau = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        mau.BackColor = Color.AliceBlue;
                    }
                    for (int i = 0; i < 10  && lan1 == false; i++) 
                    {
                        for (int j = 0; j < k; j++)
                        {
                            if (i==luuVT[j])
                            {
                                string mm = "textBox" + i;
                                TextBox mau = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                                mau.BackColor = Color.Red;
                            }
                        }
                    }
                    int traicu = trai;
                    for ( xanh = 0; xanh < sl; xanh++)//tim xanh dau tien
                    {
                        string mm = "textBox" + xanh;
                        TextBox mau = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        if (mau.BackColor == Color.AliceBlue)
                        {
                            ll = xanh; trai = ll;
                            break;
                        }
                    }
                    for (ddo = (xanh+1); ddo < sl && lan1==false; ddo++)//tim do dau tien
                    {
                        string mm = "textBox" + ddo;
                        TextBox mau = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                        if (mau.BackColor == Color.Red)
                        {
                            rr = ddo-1; phai = rr;
                            break;
                        }
                    }
                    if (/*trai !=rr &&*/ ddo == sl && lan1==false)
                    {
                        if (traicu > sl) sl--;
                        rr = sl; phai = sl;
                    }
                    if (trai>phai)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            string mm = "textBox" + i;
                            TextBox mau = (TextBox)this.Controls.Find(mm, true).FirstOrDefault();
                            mau.BackColor = Color.Red;
                        }
                        timer1.Enabled = false;
                    }
                    //if (rr - ll == 0)
                    //{
                    //    luuVT[k] = ll;
                    //    demk++;
                    //    if (ll != 0 && luuVT[demk] == 0)
                    //    {
                    //        textBoxkq.Text = "done do luuvt[demk]==0";
                    //    }
                    //    kt = -2;
                    //    k++;
                    //}

                }
                if (kt == 0)//hien ll rr
                {
                    textBoxkq.Text = "";
                    pictureBoxi.Visible = pictureBoxsosanh.Visible = false;
                    textBoxi.Text = textBoxai.Text = textBoxj.Text = textBoxaj.Text = "";
                    pictureBox1.Location = new Point(460, 120);
                    string tt = "textBox" + ll;
                    TextBox pbl = (TextBox)this.Controls.Find(tt, true).FirstOrDefault();
                    textBoxtam.Text = pbl.Text;
                    pbl.Text="";
                    string ll2 = "textBox" + rr;
                    TextBox pbr = (TextBox)this.Controls.Find(ll2, true).FirstOrDefault();
                    pictureBoxleft.Location = new Point(pbl.Location.X, pbl.Location.Y + 50);
                    pictureBoxRIGHT.Location = new Point(pbr.Location.X, pbr.Location.Y + 50);
                    pictureBoxleft.Visible=pictureBoxRIGHT.Visible = true;
                    trai++;
                    if (trai >= phai) pictureBoxi.Visible=false;
                    
                }
                if (kt==1)//hien pb trai
                {
                    //pictureBox1.Location = new Point(460, 140);
                    string tt = "textBox" + trai;
                    TextBox dau = (TextBox)this.Controls.Find(tt, true).FirstOrDefault();
                    pictureBoxi.Location = new Point(dau.Location.X, dau.Location.Y - 150);
                    pictureBoxi.Visible = pictureBoxsosanh.Visible = true;
                    string tt2 = "textBox" + phai;
                    TextBox cuoi = (TextBox)this.Controls.Find(tt2, true).FirstOrDefault();
                    pictureBoxsosanh.Location = new Point(cuoi.Location.X, cuoi.Location.Y - 150);

                    textBoxi.Text = trai.ToString();
                    
                    textBoxj.Text = phai.ToString();
                }
                if (kt==2)//tomau pb trai
                {
                    textBoxkq.Text = "";
                    pictureBox1.Location = new Point(460, 160);
                    //dieu kien dung
                    if (trai > phai)
                    {
                        kt = 8;
                        //doicho1 = true;
                    }
                    else
                    {
                        string qq = "textBox" + trai;
                        TextBox dau = (TextBox)this.Controls.Find(qq, true).FirstOrDefault();
                        string qq2 = "textBox" + phai;
                        TextBox cuoi = (TextBox)this.Controls.Find(qq2, true).FirstOrDefault();
                        textBoxaj.Text = cuoi.Text;
                        textBoxai.Text = dau.Text;
                        dau.BackColor = Color.LightYellow;
                    }
                }
                if (kt == 3)//kiem tra trai.text<tam.text?trai++:tới lượt phải
                {
                    textBoxkq.Text = "";
                    string tt = "textBox" + trai;
                    TextBox dau = (TextBox)this.Controls.Find(tt, true).FirstOrDefault();
                    if (int.Parse(dau.Text) < int.Parse(textBoxtam.Text)) 
                    {
                        trai++;
                        kt = 0;
                    }

                }
                if (kt == 4)//hien pb phai
                {
                    pictureBox1.Location = new Point(460, 180);
                    string tt2 = "textBox" + phai;
                    TextBox cuoi = (TextBox)this.Controls.Find(tt2, true).FirstOrDefault();
                    pictureBoxsosanh.Location = new Point(cuoi.Location.X, cuoi.Location.Y - 150);

                    textBoxj.Text = phai.ToString();
                    textBoxaj.Text = cuoi.Text;
                }
                if (kt==5)//to mau pb phai
                {
                    
                    if (trai > phai)
                    {
                        kt = 9;
                        //doicho2 = true;
                    }
                    else
                    {
                        string tt2 = "textBox" + phai;
                        TextBox cuoi = (TextBox)this.Controls.Find(tt2, true).FirstOrDefault();
                        cuoi.BackColor = Color.LightGreen;
                    }
                }
                if (kt==6)//kt phai.text<tam.text?doi trai&phai : phai ++
                {
                    pictureBox1.Location = new Point(460, 200);
                    string tt = "textBox" + trai;
                    TextBox dau = (TextBox)this.Controls.Find(tt, true).FirstOrDefault();
                    string tt2 = "textBox" + phai;
                    TextBox cuoi = (TextBox)this.Controls.Find(tt2, true).FirstOrDefault();
                    if (int.Parse(cuoi.Text) < int.Parse(textBoxtam.Text))
                    {
                        textBoxkq.Text = "Đổi chỗ " + dau.Text + " và " + cuoi.Text;
                        string tamp = cuoi.Text;
                        cuoi.Text = dau.Text;
                        dau.Text = tamp;
                        kt = 7;
                        //trai++;phai--; kt = 0;
                        
                    }
                    else
                    {
                        phai--;
                        if (phai < 0) { timer1.Enabled = false; textBoxkq.Text = "dung lai do phai = " + phai.ToString(); }
                        kt = 3;
                    }
                    
                }
                if (kt == 7)
                {
                    textBoxkq.Text = "";
                    trai++; phai--; kt = 0;
                    pictureBox1.Location = new Point(460, 220);
                }
                if (kt==8)//ben trai tiên qua rr;
                {
                    pictureBox1.Location = new Point(460, 200);

                    string tt = "textBox" + ll;
                    TextBox dau = (TextBox)this.Controls.Find(tt, true).FirstOrDefault();
                    string tt2 = "textBox" + phai;
                    TextBox cuoi = (TextBox)this.Controls.Find(tt2, true).FirstOrDefault();
                    string tem = dau.Text;
                    dau.Text = cuoi.Text;
                    cuoi.Text = textBoxtam.Text;
                    luuVT[k] = phai;
                    richTextBox1.Text += luuVT[k].ToString() + Environment.NewLine;
                    if(dau.Text!=cuoi.Text) textBoxkq.Text = "Đổi chỗ " + dau.Text + " và " + cuoi.Text;

                    //rr--;
                    //phai = rr;
                    //trai = ll;
                    kt = -2;
                    k++;
                    lan1 = false;
                }
                if (kt == 9)
                {
                    pictureBox1.Location = new Point(460, 200);
                    string tt = "textBox" + ll;
                    TextBox dau = (TextBox)this.Controls.Find(tt, true).FirstOrDefault();
                    string tt2 = "textBox" + phai;
                    TextBox doi = (TextBox)this.Controls.Find(tt2, true).FirstOrDefault();
                    string tt3 = "textBox" + trai;
                    TextBox ttrai = (TextBox)this.Controls.Find(tt3, true).FirstOrDefault();
                    dau.Text = doi.Text;
                    doi.Text = textBoxtam.Text;
                    textBoxtam.Text = "";
                    luuVT[k] = phai;
                    richTextBox1.Text += luuVT[k].ToString() + Environment.NewLine;
                    //phai--;
                    //trai = ll; rr = sl + 1;
                    kt = -2;
                    demk = k;
                    k++;
                    lan1 = false;
                   

                }
                if (kt<10)
                {
                    kt++;
                }
            }
        }

    }
}
