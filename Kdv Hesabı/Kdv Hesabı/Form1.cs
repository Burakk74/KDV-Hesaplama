using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kdv_Hesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double tutar = Convert.ToDouble(tutar_al_txt.Text);
                double yedekle = tutar;                    
                
                if(temel_gıda_chck.Checked)
                {
 

                    tutar += yedekle / 100;
                    kdv_tutar_lbl.Text = Convert.ToString(yedekle / 100) + " ₺";
                    uygulanan_kdv_yuzdesi_lbl.Text = "%1";
                    toplam_fiyat_lbl.Text = Convert.ToString(tutar) + " ₺";

                }

                else if(tekstil_urun_chck.Checked  )
                {
                    

                    tutar += (yedekle * 10) / 100;
                    kdv_tutar_lbl.Text = Convert.ToString((yedekle * 10) / 100) +" ₺";
                    uygulanan_kdv_yuzdesi_lbl .Text = "%10";
                    toplam_fiyat_lbl.Text = Convert.ToString(tutar) + " ₺";

                }
                else if(beyaz_esya_chck.Checked) {
                
                 

                    tutar += (yedekle * 20) / 100;
                    kdv_tutar_lbl.Text = Convert.ToString((yedekle * 20) / 100) + " ₺";
                    uygulanan_kdv_yuzdesi_lbl.Text = "%20";
                    toplam_fiyat_lbl.Text = Convert.ToString(tutar) + " ₺";
                }
                else
                {
                    MessageBox.Show("Lütfen ürünün türünü seçiniz !");
                }



            }
            catch {

                MessageBox.Show("Lütfen girdiğiniz değeri kontrol ediniz !");
                tutar_al_txt.Clear();

            }
        }
    }
}
