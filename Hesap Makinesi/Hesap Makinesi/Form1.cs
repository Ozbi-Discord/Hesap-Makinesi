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
       char _islem;
       bool _ekranTemizlenecekmi;
        int _ilksayı;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi) { 
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";

        }

        private void sayı1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void sayı2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";

        }

        private void sayı3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";

        }

        private void sayı5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";

        }

        private void sayı6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";

        }

        private void sayı7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";

        }

        private void sayı8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";

        }

        private void sayı9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";

        }

        private void sayı0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";

        }

        private void buttonartı_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(ekranLabel.Text);
        }

        private void buttoneşittir_Click(object sender, EventArgs e)
        {
            int ikincisayı = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayı + ikincisayı;
                    break;
                case '-':
                    sonuc = _ilksayı - ikincisayı;
                    break;
                case '/':
                    sonuc = _ilksayı / ikincisayı;
                    break;

                case 'x':
                    sonuc = _ilksayı * ikincisayı;
                    break;
                default:
                    sonuc = 0;
                    break;


            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void buttoneksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(ekranLabel.Text);

        }

        private void butoncarpı_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _ekranTemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(ekranLabel.Text);

        }

        private void butonbölü_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(ekranLabel.Text);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
