using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_otomasyon.presentation_layer
{
    public partial class yonetici_islemleri_form : Form
    {
        public yonetici_islemleri_form()
        {
            InitializeComponent();
        }
        private void form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        private void geribtn_Click(object sender, EventArgs e)
        {
            yoneticigirisform yoneticigirisform = new yoneticigirisform();
            yoneticigirisform.Show();
            this.Hide();
        }

        private void odayonetimibtn_Click(object sender, EventArgs e)
        {
            oda_yonetimi_form oda_yonetimi_form = new oda_yonetimi_form();
            oda_yonetimi_form.Show();
            this.Hide();
        }

        private void yonetici_islemleri_form_Load(object sender, EventArgs e)
        {

        }

        private void mstryonetimibtn_Click(object sender, EventArgs e)
        {
            musteri_yonetimi_form musteri_Yonetimi_Form = new musteri_yonetimi_form();
            musteri_Yonetimi_Form.Show();
            this.Hide();
        }


        private void yntkayityonlendirmebtn_Click(object sender, EventArgs e)
        {
            yonetici_kayıt_form yonetici_kayit = new yonetici_kayıt_form();
            yonetici_kayit.Show();
            this.Hide();
        }

        private void rzvyonetimibtn_Click(object sender, EventArgs e)
        {
         rezervasyon_islemleri_form  rezervasyon_islemleri = new rezervasyon_islemleri_form();
         rezervasyon_islemleri.Show();
         this.Hide();
        }

        private void faturagoruntulebtn_Click(object sender, EventArgs e)
        {
            fatura_yonetimi_form fatura_Yonetimi_Form = new fatura_yonetimi_form();
            fatura_Yonetimi_Form.Show(this);
            this.Hide();
        }
    }
}
