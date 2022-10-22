using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Bolumler 
            string[] Dersler = {"Yazilim Muhndesligi","Bligissyar Muhndesligi" , "Saglik Yonitme"};
            comboBoxDersler.Items.AddRange(Dersler);


            //
            comboBoxdurumu.Items.Add("aktif ");
            comboBoxdurumu.Items.Add("pasif");
        }

        // Son Suresi -- Print
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBoxName.Text;
            string soyadi = textBoxSoyadi.Text;
            string dogum = textBoxDogum.Text;
            string ogrencino = textBoxOgrencino.Text;
            string kimlikno = textBoxkimlikno.Text;
            string email = textBoxEmail.Text;
            if(
                ad.Length > 3 &&
                soyadi.Length > 3 &&
                dogum.Length > 3 &&
                ogrencino.Length > 8 &&
                kimlikno.Length > 8 &&
                comboBoxdurumu.SelectedIndex != -1 &&
                comboBoxDersler.SelectedIndex != -1 && (radioButton1.Checked || radioButton2.Checked)
                )
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if(listBox1.Items[i].ToString().IndexOf("Ortalama") == -1)
                    {
                        MessageBox.Show("Dersler için ortalama notu hesapladığınızdan emin olun.");
                        break;
                    }
                    else
                    {
                        string sonuc = "";
                        string Cinsiyet = radioButton1.Checked  ? "ERKEK" : "KADIN";
                        printList.Items.Add("Öğrenci bilgileri");
                        printList.Items.Add("_________________");
                        printList.Items.Add("Ad:" + ad.ToString());
                        printList.Items.Add("Soyadı: " + soyadi);
                        printList.Items.Add("Doğum: " + dogum);
                        printList.Items.Add("Cinsiyet: " + Cinsiyet);
                        printList.Items.Add("Öğrenci Nomrası: " + ogrencino);
                        printList.Items.Add("Kimlik Nomrası: " + kimlikno);
                        printList.Items.Add("Bolüm:" + comboBoxDersler.SelectedItem.ToString());
                        printList.Items.Add("Sonuç:");
                        for (int j = 0; j < listBox1.Items.Count; j++)
                        {
                            printList.Items.Add(listBox1.Items[j].ToString());
                            sonuc = sonuc + "\n" + listBox1.Items[j].ToString();
                        }
                        MessageBox.Show(
                            "Öğrenci bilgileri \n _________________ \n Ad:"+ ad.ToString() +
                            "\n" + "Soyadı: " + soyadi +
                            "\n" + "Doğum: "  + dogum  +
                            "\n" + "Cinsiyet: " + Cinsiyet + 
                            "\n" + "Öğrenci Nomrası: " + ogrencino +
                            "\n" + "Kimlik Nomrası: " + kimlikno +
                            "\n" + "Bolüm:" + comboBoxDersler.SelectedItem.ToString() + 
                            "\n" + "Sonuç:" +
                            "\n" + sonuc
                            );


                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Gerekli tüm alanları doldurduğunuzdan emin olun");

            }
        }

        private void comboBoxDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dersName = comboBoxDersler.SelectedItem.ToString();

            // Bolumlerin Dersleri
            string[] Bligissyar = { "Matamatik1", "Fizik1", "Yazilim1" };
            string[] Saglik = { "Saglik Yontem", "Ayrik matamtik", "Fizik2" , "Matamatik2" };
            string[] Yazilim = { "Saglik Yontem", "Ayrik matamtik", "Fizik2", "Matamatik2" };

            if (dersName == "Yazilim Muhndesligi"){
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Yazilim);

            }else if (dersName == "Bligissyar Muhndesligi") {
             listBox1.Items.Clear();
             listBox1.Items.AddRange(Bligissyar);

            }else if (dersName == "Saglik Yonitme"){
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Saglik);
            }
        }
    



        private void Add_Click(object sender, EventArgs e)
        {
            string vizeText = textBoxVize.Text;
            string finalText = textBoxFinal.Text;


           
            if (vizeText.Length <= 0 || finalText.Length <= 0) {
                MessageBox.Show("dolup dolmadiginden emin ol");
                return;
            }
            if (vizeText.Length > 2 || finalText.Length > 2)
            {
                MessageBox.Show("Notu doğru girdiğinizden emin olun");
                return;
            }
            else if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("bölumu secip secmedeiginden emin ol");
                return;
            }else
            {
                if(listBox1.SelectedItem.ToString().IndexOf("Vize") == -1)
                {
                    textBoxVize.Text = "";
                    textBoxFinal.Text = "";
                    listBox1.Items[listBox1.SelectedIndex] = listBox1.SelectedItem.ToString() + " , Vize: " + vizeText + " - Final: " + finalText;
                }
                else
                {
                    MessageBox.Show("Puan Eklenmiştır ...");
                }
            }



        }



        // Ortalama hespalama
        private void OrtalamaHespala_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("dersi secip secmedeiginden emin ol");
                return;
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].ToString().IndexOf(",") == -1)
                    {
                        MessageBox.Show("Tüm puanların kaydedildiğinden emin olun");
                        break;
                    }
                    else
                    {
                        if (listBox1.Items[i].ToString().IndexOf("Ortalama") == -1)
                        {
                            string pouan = listBox1.Items[i].ToString();
                            int vizePuani = int.Parse(listBox1.Items[i].ToString().Substring(pouan.IndexOf("e:"), 5).Substring(2).TrimEnd());
                            int finalPuani = int.Parse(listBox1.Items[i].ToString().Substring(pouan.IndexOf("l:"), 5).Substring(2).TrimEnd());
                            double ortalama = vizePuani * 0.4 + finalPuani * 0.6;
                            if (ortalama >= 60 && ortalama <= 100)
                            {
                                listBox1.Items[i] = listBox1.Items[i] + " , Ortalama: " + Math.Round(ortalama, 4) + ", Ders Durumu: Geçti";
                            }
                            else if (ortalama >= 0 && ortalama < 60)
                            {
                                listBox1.Items[i] = listBox1.Items[i] + " , Ortalama: " + Math.Round(ortalama, 4) + ", Ders Durumu: Kaldı";
                            }
                        }
                    }

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}