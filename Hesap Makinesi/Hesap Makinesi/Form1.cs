using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {

        private char _islem;
        private bool _EkranTemizlenecekMi;
        private int _ilkSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakan1button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "0";
        }

        private void ToplamaButon_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _EkranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel.Text);
        }

        private void EşittirButon_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(EkranLabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case 'X':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;

                default:
                    sonuc = 0;
                    break;
            }

            EkranLabel.Text = Convert.ToString(sonuc);

        }

        private void ÇıkarmaButon_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _EkranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel.Text);
        }

        private void ÇarpmaButon_Click(object sender, EventArgs e)
        {
            _islem = 'X';
            _EkranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel.Text);
        }

        private void BölmeButon_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _EkranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel.Text);
        }

        private void temizleButon_Click(object sender, EventArgs e)
        {
            EkranLabel.Text = "0";
        }
    }
}
