using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomaliAskerProblemi
{
    public partial class frmRomaliAsker : Form
    {
        public frmRomaliAsker()
        {
            InitializeComponent();
        }

        private void btnKalanAsker_Click(object sender, EventArgs e)
        {
            if (txtAskerSayisi.Text == "" || txtAdimSayisi.Text == "")
                MessageBox.Show("Gerekli alanları doldurun.");
            else
            {
                string textAskerSayisi = txtAskerSayisi.Text, textAdimSayisi = txtAdimSayisi.Text;
                int kontrolas = 1, kontrolad = 1;

                foreach (char askerIndis in textAskerSayisi)
                {
                    if (askerIndis >= 48 && askerIndis <= 57)
                        continue;
                    else
                        kontrolas = 0;
                }

                foreach (char adimIndis in textAdimSayisi)
                {
                    if (adimIndis >= 48 && adimIndis <= 57)
                        continue;
                    else
                        kontrolad = 0;
                }

                if (kontrolas == 0)
                    MessageBox.Show("Asker sayısını numeric bir değer girin!");
                else if (kontrolad == 0)
                    MessageBox.Show("Adım sayısını numeric bir değer girin!");
                else
                {
                    int askerSayisi = Convert.ToInt32(txtAskerSayisi.Text);
                    int adimSayisi = Convert.ToInt32(txtAdimSayisi.Text);

                    if (askerSayisi <= 2)
                        MessageBox.Show("Asker sayısı 2 ve 2'den küçük olamaz.");
                    else if (adimSayisi == 0)
                        MessageBox.Show("Adım sayısı 0 olamaz.");
                    else
                    {
                        int askerKont = askerSayisi;
                        int[] askerler = new int[askerSayisi];

                        for (int j = 0; j < askerSayisi; j++)
                        {
                            askerler[j] = 1; //Tüm askerler başta yaşıyorlar yani değerleri 1
                        }

                        int askerKontrol = 0, adimKont = 1;
                        while (askerKont != 2) //Son 2 asker kalmadığı sürece dön
                        {
                            if (askerKontrol == askerSayisi) //son indisli askere geldiysen 0. indise geri dön
                                askerKontrol = 0;
                            if (askerler[askerKontrol] == 1) //Asker yaşıyorsa
                            {
                                if (adimKont % adimSayisi == 0) //askerler üzerinde adım sayısı kadar ilerlendiyse yani ölecek asker bulundu.
                                {
                                    askerler[askerKontrol] = 0;
                                    askerKont--;
                                    adimKont = 1; //adım sayısı 1'e geri dönsün ki diğer ölecek asker için tekrar adım hesaplansın
                                }
                                else
                                    adimKont++; //Asker ölmedi daha gidilecek adım var ilerle
                                askerKontrol++;
                            }
                            else
                                askerKontrol++; //bir sonra ki askere bakmak için ilerle
                        }
                        string mesaj = "";
                        //kalan askerleri göster
                        for (int k = 0; k < askerSayisi; k++)
                        {
                            if (askerler[k] == 1)
                                mesaj += (k + 1).ToString() + Environment.NewLine;
                        }
                        MessageBox.Show(mesaj);
                    }
                }
            }
        }
    }
}
