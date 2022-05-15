using System;
using System.Windows.Forms;

namespace SevenSegTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkDotShow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            this.Text = "~ Dijital Saat ~ " + DateTime.Now.ToLongTimeString() + " ~";

        }
        int sayac = 0;
        private void sevenSegmentArray1_Load(object sender, EventArgs e)
        {

        }
        /*int saniye=DateTime.Now.Second;
        int dakika = DateTime.Now.Minute;
        int hour = DateTime.Now.Hour;*/

        private void sevenSegmentLEDDigits1_Click(object sender, EventArgs e)
        {

        }

        DateTime saat = DateTime.Now;
        DateTime saatt = DateTime.Now;
        DateTime saattt = DateTime.Now;
        string format1 = "HH";//tarihe uygulanacak format.
        string format2 = "mm";//tarihe uygulanacak format.
        string format3 = "ss";


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "~ Dijital Saat ~ " + DateTime.Now.ToLongTimeString() + " ~";
            sevenSegmentArray1.Value = DateTime.Now.ToString(format1);
            sevenSegmentArray2.Value = DateTime.Now.ToString(format2);
            sevenSegmentArray3.Value = DateTime.Now.ToString(format3);

            sayac++;
            if (sayac % 2 == 0)
            {
                pictureBox1.BackColor = sevenSegmentArray1.ColorLight;
                pictureBox2.BackColor = sevenSegmentArray1.ColorLight;
            }
            else
            {
                pictureBox1.BackColor = Color.Black;
                pictureBox2.BackColor = Color.Black;
            }





            //Console.WriteLine(saat.ToString(format1));
            //Console.WriteLine(saatt.ToString(format2));
            //Console.WriteLine(saattt.ToString(format3));

            //sevenSegmentArray1.Value = DateTime.Now.ToString(format1);
            //sevenSegmentArray2.Value = DateTime.Now.ToString(format2);
            //sevenSegmentArray3.Value = DateTime.Now.ToString(format3);

            /* DateTime time = DateTime.Now;
             string format3 = "HH:mm";
             Console.WriteLine(time.ToString(format3));
             sevenSegmentArray3.Value = DateTime.Now.ToString(format3);*/ //koddd


        }

        private void sevenSegmentArray1_Load_1(object sender, EventArgs e)
        {
            sevenSegmentArray1.Value = DateTime.Now.ToString(format1);
        }
        private void sevenSegmentArray2_Load(object sender, EventArgs e)
        {
            sevenSegmentArray2.Value = DateTime.Now.ToString(format2);
        }

        private void sevenSegmentArray3_Load(object sender, EventArgs e)
        {

        }

        private void sevenSegmentArray3_Load_1(object sender, EventArgs e)
        {
            sevenSegmentArray3.Value = DateTime.Now.ToString(format3);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Red":
                    sevenSegmentArray1.ColorLight = Color.Red;
                    sevenSegmentArray2.ColorLight = Color.Red;
                    sevenSegmentArray3.ColorLight = Color.Red;
                    pictureBox1.BackColor = Color.Red;
                    pictureBox2.BackColor = Color.Red;
                    break;
                case "Blue":
                    sevenSegmentArray1.ColorLight = Color.Blue;
                    sevenSegmentArray2.ColorLight = Color.Blue;
                    sevenSegmentArray3.ColorLight = Color.Blue;
                    pictureBox1.BackColor = Color.Blue;
                    pictureBox2.BackColor = Color.Blue;
                    break;
                case "Green":
                    sevenSegmentArray1.ColorLight = Color.Lime;
                    sevenSegmentArray2.ColorLight = Color.Lime;
                    sevenSegmentArray3.ColorLight = Color.Lime;
                    pictureBox1.BackColor = Color.Lime;
                    pictureBox2.BackColor = Color.Lime;
                    break;
            }
        }
    }
}
