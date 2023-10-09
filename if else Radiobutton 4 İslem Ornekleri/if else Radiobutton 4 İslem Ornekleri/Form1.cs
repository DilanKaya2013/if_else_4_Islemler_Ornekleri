using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_Radiobutton_4_İslem_Ornekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc=0;
            sayi1 = Convert.ToSingle(txtSayi1.Text);
            sayi2 = Convert.ToSingle(txtSayi2.Text);
            if (rbTopla.Checked)
            {
                sonuc=sayi1 + sayi2;
            }
            else if (rbCıkar.Checked)
            {
                sonuc=sayi1 - sayi2; 
            }
            else if (rbCarp.Checked)
            {
                sonuc=sayi1* sayi2;
            }
            else if (rbBol.Checked)
            {
                sonuc = sayi1 / sayi2;
            }

            lblSonuc.Text="Sonuç: "+sonuc.ToString();
    }
}
}
