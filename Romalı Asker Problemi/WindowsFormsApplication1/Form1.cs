using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            lbx_Askerler.Items.Clear();
            lbx_Olenler.Items.Clear();
            lbx_Kalanlar.Items.Clear();

            if (txt_AskerSayisi.Text == "" || txt_AdimSayisi.Text == "")
            {
                MessageBox.Show("Lütfen değerleri boş bırakmayınız");  
          
            }

            else
            {
  
                List<int> askerler = new List<int>();
                if (Int64.Parse(txt_AskerSayisi.Text) > Int32.MaxValue)
                {
                    MessageBox.Show("Maximum girebileceğiniz asker sayısını geçtiniz!! ");
                    this.Hide();
                }
                int aralik = Convert.ToInt32(txt_AdimSayisi.Text);
                if (Convert.ToInt32(txt_AdimSayisi.Text) > Convert.ToInt32(txt_AskerSayisi.Text) ||
                    Convert.ToInt32(txt_AdimSayisi.Text) == Convert.ToInt32(txt_AskerSayisi.Text) )
                {
                    MessageBox.Show("Adım Sayısı asker sayısından büyük ya da eşit olamaz !" );
                    this.Hide();
                }

                int sonOlen = 0;
                int sil = 0;
                stopwatch.Start();
                for (int a = 1; a <= Convert.ToInt32(txt_AskerSayisi.Text); a++)
                {
                    askerler.Add(a);
                    lbx_Askerler.Items.Add(a);
                }
                do
                {
                    sil = sonOlen + aralik - 1;
                    if (sil >= askerler.Count)
                    {
                        sil = sil % askerler.Count;
                    }

                    lbx_Olenler.Items.Add(askerler[sil]);
                    askerler.RemoveAt(sil);
                    sonOlen = sil;

                    if (sonOlen >= askerler.Count)
                    {

                        sonOlen = 0;
                    }
                } while (askerler.Count > 2);

                if (Convert.ToInt32(txt_AskerSayisi.Text) > 2)
                {
                    lbx_Kalanlar.Items.Add(askerler[0]);
                    lbx_Kalanlar.Items.Add(askerler[1]);
                }
                else
                {
                    MessageBox.Show("Girilen asker sayısı 2'den büyük olmalıdır");
                }
            }
            stopwatch.Stop();
            label7.Text = stopwatch.ElapsedMilliseconds.ToString();
            
           
        }

        private void txt_AskerSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_AdimSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

  
  
    }
}


