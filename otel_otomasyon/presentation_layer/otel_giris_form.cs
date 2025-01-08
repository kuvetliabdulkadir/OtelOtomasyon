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
    public partial class otel_giris_form : Form
    {
        public otel_giris_form()
        {
            InitializeComponent();
        }
        private void form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yoneticigirisform yoneticigirisform = new yoneticigirisform();
            yoneticigirisform.Show();
            this.Hide();
        }

        private void otel_giris_form_Load(object sender, EventArgs e)
        {

        }
    }
}
