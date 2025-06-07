using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KargoTakipSistemi
{
    public partial class Form1 : Form
    {
        string dosyaYolu = "veriler.txt";
        List<Gonderi> gonderiler = new List<Gonderi>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTip.Items.AddRange(new string[] { "Yurtici", "Yurtdisi" });
            cmbDurum.DataSource = Enum.GetValues(typeof(Durum));

            if (!File.Exists(dosyaYolu))
            {
                File.WriteAllLines(dosyaYolu, new string[]
                {
                    "Yurtici,387526FC,Bekliyor",
                    "Yurtdisi,235260031,Yolda"
                });
            }

            DosyadanYukle();
            ListeyiGuncelle();

        }

        void DosyadanYukle()
        {
            gonderiler.Clear();
            var satirlar = File.ReadAllLines(dosyaYolu);
            foreach (var satir in satirlar)
            {
                var parca = satir.Split(',');
                string tip = parca[0];
                string takipNo = parca[1];
                Durum durum = (Durum)Enum.Parse(typeof(Durum), parca[2]);

                Gonderi g;
                if (tip == "Yurtici")
                    g = new Yurtici(takipNo);
                else
                    g = new Yurtdisi(takipNo);
                g.DurumGuncelle(durum);
                gonderiler.Add(g);
            }
        }

        void ListeyiGuncelle()
        {

            dgvGonderiler.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvGonderiler.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvGonderiler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvGonderiler.EnableHeadersVisualStyles = false;
            dgvGonderiler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 123, 255);
            dgvGonderiler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGonderiler.DataSource = null;
            dgvGonderiler.DataSource = gonderiler.Select(g => new
            {
                Tip = g is Yurtici ? "Yurtici" : "Yurtdisi",
                g.TakipNo,
                Durum = g.GonderiDurumu.ToString()
            }).ToList();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            string takipNo = txtTakipNo.Text.Trim();
            string tip = cmbTip.SelectedItem?.ToString();
            Durum durum = (Durum)cmbDurum.SelectedItem;

            if (string.IsNullOrEmpty(takipNo) || string.IsNullOrEmpty(tip))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            Gonderi yeni;
            if (tip == "Yurtici") yeni = new Yurtici(takipNo);
            else yeni = new Yurtdisi(takipNo);

            yeni.DurumGuncelle(durum);
            gonderiler.Add(yeni);

            DosyayaKaydet();
            ListeyiGuncelle();

            MessageBox.Show("Gönderi eklendi.");
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string aranan = txtTakipNo.Text.Trim();
            var g = gonderiler.FirstOrDefault(x => x.TakipNo == aranan);

            if (g != null)
            {
                lblSonuc.Text = g.GonderiBilgisi();
            }
            else
            {
                lblSonuc.Text = "Gönderi bulunamadı.";
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string takipNo = txtTakipNo.Text.Trim();
            string yeniDurum = cmbDurum.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(takipNo) || string.IsNullOrEmpty(yeniDurum))
            {
                MessageBox.Show("Takip numarası ve yeni durumu girin.");
                return;
            }

            var gonderi = gonderiler.FirstOrDefault(g => g.TakipNo == takipNo);

            if (gonderi != null)
            {
                Durum yeniDurumEnum;
                bool donustuMu = Enum.TryParse<Durum>(yeniDurum, out yeniDurumEnum);
                if (!donustuMu)
                {
                    MessageBox.Show("Geçersiz durum değeri.");
                    return;
                }

                gonderi.DurumGuncelle(yeniDurumEnum);
                MessageBox.Show("Durum başarıyla güncellendi.");

                DosyayaKaydet();
                ListeyiGuncelle();
            }
            else
            {
                MessageBox.Show("Bu takip numarasına ait gönderi bulunamadı.");
            }
        }
        
        void DosyayaKaydet()
        {
            List<string> cikti = new List<string>();
            foreach (var g in gonderiler)
            {
                string tip = g is Yurtici ? "Yurtici" : "Yurtdisi";
                cikti.Add($"{tip},{g.TakipNo},{g.GonderiDurumu}");
            }
            File.WriteAllLines(dosyaYolu, cikti);
        }

       
        public enum Durum
        {
            Bekliyor,
            Yolda,
            TeslimEdildi
        }

        public interface ITakipEdilebilir
        {
            string TakipNo { get; }
            Durum GonderiDurumu { get; set; }
            void DurumGuncelle(Durum yeniDurum);
        }

        public abstract class Gonderi : ITakipEdilebilir
        {
            public string TakipNo { get; set; }
            public Durum GonderiDurumu { get; set; }

            public Gonderi(string takipNo)
            {
                TakipNo = takipNo;
                GonderiDurumu = Durum.Bekliyor;
            }

            public void DurumGuncelle(Durum yeniDurum)
            {
                GonderiDurumu = yeniDurum;
            }

            public abstract string GonderiBilgisi();
        }

        public class Yurtici : Gonderi
        {
            public Yurtici(string takipNo) : base(takipNo) { }

            public override string GonderiBilgisi()
            {
                return $"[Yurtici] TakipNo: {TakipNo}, Durum: {GonderiDurumu}";
            }
        }

        public class Yurtdisi : Gonderi
        {
            public Yurtdisi(string takipNo) : base(takipNo) { }

            public override string GonderiBilgisi()
            {
                return $"[Yurtdisi] TakipNo: {TakipNo}, Durum: {GonderiDurumu}";
            }
        }
    }
}

