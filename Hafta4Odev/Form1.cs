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
        List<string> Liste_RafladigiYer = new List<string>();
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
            Liste_RafladigiYer.Add(RafladigiYer.Text);
            Liste_Durum.Add(Durum.Text);


            for (int i = 0; i < sayac; i++)
            {
                string deger = Liste_KitapAdi[i] + " " + Liste_KitapYazari[i] + " " + Liste_Durum[i];
                listBox1.Items.Clear();
                comboBox1.Items.Clear();
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
    }
}