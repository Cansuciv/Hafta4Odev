using System.Security.AccessControl;

namespace Hafta4Odev
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

        List<string> Liste_KitapAdi = new List<string>();
        List<string> Liste_KitapYazari = new List<string>();
        List<string> Liste_Yayinevi = new List<string>();
        List<string> Liste_YayinTarihi = new List<string>();
        List<string> Liste_KitapTuru = new List<string>();
        List<string> Liste_SayfaSayisi = new List<string>();
        List<string> Liste_Dil = new List<string>();
        List<string> Liste_RaflandigiYer = new List<string>();
        List<string> Liste_Durum = new List<string>();
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Liste_KitapAdi.Add(KitapAdi.Text);
            Liste_KitapYazari.Add(KitapYazari.Text);
            Liste_Yayinevi.Add(Yayinevi.Text);
            Liste_YayinTarihi.Add(YayinTarihi.Text);
            Liste_KitapTuru.Add(KitapTuru.Text);
            Liste_SayfaSayisi.Add(SayfaSayisi.Text);
            Liste_Dil.Add(Dil.Text);
            Liste_RaflandigiYer.Add(RaflandigiYer.Text);
            Liste_Durum.Add(Durum.Text);

            sayac++;
            listBox1.Items.Clear();
            comboBox1.Items.Clear();

            for (int i = 0; i < sayac; i++)
            {
                string deger = Liste_KitapAdi[i] + " " + Liste_KitapYazari[i] + " " + Liste_Durum[i];
                listBox1.Items.Add(deger);
                comboBox1.Items.Add(deger);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sayac2 = listBox1.SelectedIndex;
            if (sayac2 >= 0 && sayac2 < Liste_KitapAdi.Count)
            {
                string KitapBilgileri = "Kitap Adý: " + Liste_KitapAdi[sayac2] + Environment.NewLine +
                                        "Kitap Yazarý: " + Liste_KitapYazari[sayac2] + Environment.NewLine +
                                        "Yayýnevi: " + Liste_Yayinevi[sayac2] + Environment.NewLine +
                                        "Yayýn Tarihi: " + Liste_YayinTarihi[sayac2] + Environment.NewLine +
                                        "Kitap Türü: " + Liste_KitapTuru[sayac2] + Environment.NewLine +
                                        "Sayfa Sayýsý: " + Liste_SayfaSayisi[sayac2] + Environment.NewLine +
                                        "Dil: " + Liste_Dil[sayac2] + Environment.NewLine +
                                        "Raflandýðý Yer: " + Liste_RaflandigiYer[sayac2] + Environment.NewLine +
                                        "Durum: " + Liste_Durum[sayac2];

                MessageBox.Show(KitapBilgileri, "Kitap Bilgileri");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < listBox1.Items.Count)
            {
                object selectedItem = listBox1.Items[selectedIndex];
                listBox1.Items.RemoveAt(selectedIndex);
                listBox1.Items.Insert(0, selectedItem);
                listBox1.SelectedIndex = 0;
            }
        }
    }
}