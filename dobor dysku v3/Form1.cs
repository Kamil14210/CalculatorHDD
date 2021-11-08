using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace dobor_dysku_v3


{
    public partial class Kalkulator : MetroFramework.Forms.MetroForm
    {
        double bitrate = 4096;

        public Kalkulator()
        {
            InitializeComponent();
            mcbSelectResolution.SelectedIndex = 2;
            mrbH64.Checked = true;
            mtbHowCameras.Text = "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private double oblicz()

        {
            
                bitrate = Convert.ToDouble(mtbShowBitrate.Text);
                double a = Convert.ToDouble(mtbHowCameras.Text.Replace(".", ","));
                double b = Convert.ToDouble(mtbHowDay.Text.Replace(".", ","));

                double wynik = ((((bitrate / 8) * 86400) / 1048576) * a) * b;
                wynik = System.Math.Round(wynik, 2);
                return wynik;
                      
            }

        private void mb1_Click(object sender, EventArgs e)
        {
            try
            {

                if (mtbHowCameras.Text != "" && mtbHowDay.Text != "")
                {
                    double zmienna = oblicz();
                    double zmiennaTB = oblicz()/1024;
                    zmiennaTB = System.Math.Round(zmiennaTB, 2);
                    string zmiennajakotekst = zmienna.ToString();
                    
                    mtbDisplayResult1.Text = zmiennajakotekst + " GB";
                    mtbDisplayResult2.Text = zmiennaTB.ToString() + " TB";
                    
                }
                else
                {
                    MessageBox.Show("Brak wszystkich danych");
                }
            }
            catch
            {
                MessageBox.Show("Podaj wartości liczbowe");
            }
        }
        private void mcb1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (mcbSelectResolution.SelectedIndex == 0)
            {
                bitrate = 1700;
                mtbShowBitrate.Text = bitrate.ToString();
                mrbH64.Checked = true;
            }
            if (mcbSelectResolution.SelectedIndex == 1)
            {
                bitrate = 2048;
                mtbShowBitrate.Text = bitrate.ToString();
                mrbH64.Checked = true;
            }
            if (mcbSelectResolution.SelectedIndex == 2)
            {
                bitrate = 4096;
                mtbShowBitrate.Text = bitrate.ToString();
                mrbH64.Checked = true;
            }
            if (mcbSelectResolution.SelectedIndex == 3)
            {
                bitrate = 5120;
                mtbShowBitrate.Text = bitrate.ToString();
                mrbH64.Checked = true;
            }
            if (mcbSelectResolution.SelectedIndex == 4)
            {
                bitrate = 5120;
                mtbShowBitrate.Text = bitrate.ToString();
                mrbH64.Checked = true;
            }
            if (mcbSelectResolution.SelectedIndex == 5)
            {
                bitrate = 6144;
                mtbShowBitrate.Text = bitrate.ToString();
                mrbH64.Checked = true;
            }
            if (mcbSelectResolution.SelectedIndex == 6)
            {
                bitrate = 8192;
                mtbShowBitrate.Text = bitrate.ToString();
                mrbH64.Checked = true;

            }
            if (mcbSelectResolution.SelectedIndex == 7)
            {
                bitrate = 10240;
                mtbShowBitrate.Text = bitrate.ToString();
                mrbH64.Checked = true;
            }

        }
        private void mtbHowCameras_Click(object sender, EventArgs e)
        {
            
        }
        private void compression()
        {

            if (mcbSelectResolution.SelectedIndex == 0 && mrbH64.Checked)
            {
                bitrate = 1700;
                mtbShowBitrate.Text = bitrate.ToString();

            }
            if (mcbSelectResolution.SelectedIndex == 0 && mrbH265.Checked)
            {
                bitrate = 1700 / 2;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 0 && mrbH265plus.Checked)
            {
                bitrate = 1700 / 4;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            
            if (mcbSelectResolution.SelectedIndex == 1 && mrbH64.Checked)
            {
                bitrate = 2048;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 1 && mrbH265.Checked)
            {
                bitrate = 1024;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 1 && mrbH265plus.Checked)
            {
                bitrate = 512;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 2 && mrbH64.Checked)
            {
                bitrate = 4096;
                mtbShowBitrate.Text = bitrate.ToString();

            }
            if (mcbSelectResolution.SelectedIndex == 2 && mrbH265.Checked)
            {
                bitrate = 2048;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 2 && mrbH265plus.Checked)
            {
                bitrate = 1024;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 3 && mrbH64.Checked)
            {
                bitrate = 5120;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 3 && mrbH265.Checked)
            {
                bitrate = 5120 / 2;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 3 && mrbH265plus.Checked)
            {
                bitrate = 5120 / 4;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 4 && mrbH64.Checked)
            {
                bitrate = 5120;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 4 && mrbH265.Checked)
            {
                bitrate = 5120 / 2;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 4 && mrbH265plus.Checked)
            {
                bitrate = 5120 / 4;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 5 && mrbH64.Checked)
            {
                bitrate = 6144;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 5 && mrbH265.Checked)
            {
                bitrate = 6144 / 2;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 5 && mrbH265plus.Checked)
            {
                bitrate = 6144 / 4;
                mtbShowBitrate.Text = bitrate.ToString();
            }
            if (mcbSelectResolution.SelectedIndex == 6 && mrbH64.Checked)
            {
                bitrate = 8192;
                mtbShowBitrate.Text = bitrate.ToString();

            }
            if (mcbSelectResolution.SelectedIndex == 6 && mrbH265.Checked)
            {
                bitrate = 8192 / 2;
                mtbShowBitrate.Text = bitrate.ToString();

            }
            if (mcbSelectResolution.SelectedIndex == 6 && mrbH265plus.Checked)
            {
                bitrate = 8192 / 4;
                mtbShowBitrate.Text = bitrate.ToString();

            }
            if (mcbSelectResolution.SelectedIndex == 7 && mrbH64.Checked)
            {
                bitrate = 10240;
                mtbShowBitrate.Text = bitrate.ToString();

            }
            if (mcbSelectResolution.SelectedIndex == 7 && mrbH265.Checked)
            {
                bitrate = 10240 / 2;
                mtbShowBitrate.Text = bitrate.ToString();

            }
            if (mcbSelectResolution.SelectedIndex == 7 && mrbH265plus.Checked)
            {
                bitrate = 10240 / 4;
                mtbShowBitrate.Text = bitrate.ToString();

            
        }
            }

        private void mrb1_CheckedChanged(object sender, EventArgs e)
        {
            compression();          
        }


        private void mrb2_CheckedChanged(object sender, EventArgs e)
        {

            compression();
        }

        private void mrb3_CheckedChanged(object sender, EventArgs e)
        {
            compression();
        }

        private void mbClear_Click(object sender, EventArgs e)
        {
            mtbDisplayResult2.Clear();
            mtbDisplayResult1.Clear();
            mtbHowCameras.Text = "1";
            mtbHowDay.Clear();
        }

        private void mtbShowBitrate_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void mtbDisplayResult1_Click(object sender, EventArgs e)
        {

        }
        

        private void mtb1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mb1Do_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                oblicz();
            }
        }
        
        public void mtbHowCameras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(mtbHowCameras.Text);
                double y = Convert.ToDouble(mtbShowBitrate.Text);
                mtb1.Text = (x * y).ToString();
            }
            catch { }
        }

        public void mtbShowBitrate_TextChanged(object sender, EventArgs e)
        {
            double calkowitybitrate = Convert.ToDouble(mtbShowBitrate.Text);

            try
            {
                double x = Convert.ToDouble(mtbHowCameras.Text);
                double y = Convert.ToDouble(mtbShowBitrate.Text);
                mtb1.Text = (x * y).ToString();
            }
            catch { }
        }

        private void mb1Do_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://stackoverflow.com/");
            //pictureBox1.ImageLocation = "https://stackoverflow.com/";
        }
    }
    
    
}