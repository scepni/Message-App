using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace messageapp
{
    public partial class mesaj : Form
    {
        public mesaj()
        {
            InitializeComponent();

        }
        int pointX = 15;
        int pointY = 15;
        //Mesajların Yanlarındaki Tarihin Yazdırıldığı Metod
        public void Tarih(int xKoord, int yKoord, Control Object)
        {

            Label l1 = new Label
            {
                Width = 50,
                Height = 30,
                Text = DateTime.Now.ToString("HH:mm:ss")
            };
            Point pt = new Point(xKoord, yKoord);
            l1.Location = pt;

            //    l1.Location = new Point(xKoord, yKoord);
            Object.Controls.Add(l1);
            Object.Show();


        }

        public void SagClick(PictureBox GonderilenResim, PictureBox yildizli)
        {
            //Context Menu kullanılarak sağ click üzerinde İndir seçeneği oluşturuldu.
            ContextMenu sagclick = new ContextMenu();
            this.ContextMenu = sagclick;
            MenuItem menuItem1 = new MenuItem
            {
                Text = "İndir"
            };
            sagclick.MenuItems.Add(menuItem1);
            MenuItem menuItem2 = new MenuItem
            {
                Text = "Yıldızla"
            };
            sagclick.MenuItems.Add(menuItem2);
            //menuItem1_Click fonksiyonunda ise indir butonuna tıklanıldığında ne olacağı tanımlandı.
            menuItem1.Click += (sender, EventArgs) => { MenuItem1_Click(sender, EventArgs, GonderilenResim); };
            menuItem2.Click += (sender, EventArgs) => { MenuItem2_Click(sender, EventArgs, yildizli); };
        }
        //Resim Saveleme Fonksiyonu
        private void MenuItem1_Click(object sender, EventArgs e, PictureBox GonderilenResim)
        {
            //Bir save file dialog sayesinde seçilen resim ,seçilen adrese kopyalandı.
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GonderilenResim.Image.Save(saveFileDialog.FileName);
                }
            }
        }
        //Mesaj Yıldızlama Fonksiyonu
        private void MenuItem2_Click(object sender, EventArgs e, PictureBox YildizliMesaj)
        {
            if (YildizliMesaj.Visible == true)
            {
                YildizliMesaj.Visible = false;
            }
            else
            {
                YildizliMesaj.Visible = true;
            }

        }
        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void CHAT_Click(object sender, EventArgs e)
        {

        }
        private void Gonderbut_Click(object sender, EventArgs e)
        {
            if (mesajbox.Text == "")
            {
                MessageBox.Show("Boş Mesaj Gönderilemez!");
            }


            mespanel.VerticalScroll.Value = 0;

            if (mesajbox.Text != "")
            {


                MesajBallon();

            }
            mesajbox.Text = "";
        }
        private void Mesajbox_TextChanged(object sender, EventArgs e)
        {

        }
        public void MesajBallon()
        {
            //Panel üzerindeki mesajları gösteren textboxları oluşturan fonksiyon

            TextBox mesaj = new TextBox
            {
                Text = mesajbox.Text,
                Multiline = true,
                WordWrap = true,
                ReadOnly = true,
                Width = 100,
            
                Location = new Point(pointX, pointY),
                BackColor = Color.White
            };
            Tarih(120, pointY+3, mespanel);
            mespanel.Controls.Add(mesaj);
            mespanel.Show();

            mespanel.ScrollControlIntoView(mesaj); //Mesaj isimli textboxa göre scrollu ayarlayan metod


            pointY += 30;

        }
        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Mespanel_Paint_2(object sender, PaintEventArgs e)
        {

        }
        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        //Tüm Mesajları Silme Butonu Ve Fonksiyonu
        private void Button3_Click_1(object sender, EventArgs e)
        {
            string MessageBoxTitle = "Temizle";
            string MessageBoxContent = "Tüm mesajları Silmek İstediğine Emin misiniz?";
            //Bir dialog kutucuğu oluşturulup kullanıcıdan yes ya da no cevabı alındı.
            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            //Cevabın yes olması durumunda mespanel üzerindeki tüm mesajlar silindi.
            if (dialogResult == DialogResult.Yes)
            {
                mespanel.VerticalScroll.Value = 0;
                pointY = 15;
                mespanel.Controls.Clear(); //to remove all controls
            }
           
        }
        //Dosya Gönderme Fonksiyonu,Tamamlanmadı!!!!!!!!
        private void Button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog filegonder = new OpenFileDialog
            {
                Filter = "(*.pdf, *.txt, *.docx, *.mp3, *.mp4) | *.pdf; *.txt; *.docx; *.mp3; *.mp4"
            };
            filegonder.ShowDialog();
            //Dosya Tipi Öğrenildi.
            string datatype = System.IO.Path.GetExtension(filegonder.FileName);
            if (datatype == ".pdf")
            {
                PictureBox p2 = new PictureBox();

            }
        }
        public void Yildizla()
        {
            PictureBox YildizResim = new PictureBox
            {
                //------Fotoğraflardaki Yıldız Sembolünün Eklenmesi Durumu//
                Image = messageapp.Properties.Resources.star_icon,
                Visible = false,
                Height = 20,
                BackColor = Color.Transparent,
                Width = 20,
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            };
            Point pt = new Point(0, 128);
            YildizResim.Location = pt;

            // GonderilenResim.Controls.Add(YildizResim);
            //  GonderilenResim.Show();
            //--------------------------------------------------------//
        }

        //Galeriden Resim Alıp Panele Gönderme Butonu 
        private void Button1_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog imagegonder = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };


            //Open File Dialog Üzerinde En az bir adet görselin seçilmesini kontrol eden if
            if (imagegonder.ShowDialog() == DialogResult.OK)
            {
                //OPD üzerinde birden fazla görselin seçilmesi durumunda çoklu object oluşumu ve bu objectlere atama yapılarak mesaj paneline eklenmesi.
                if (imagegonder.FileNames.Length > 1)
                {
                    PictureBox[] CokluResim = new PictureBox[imagegonder.FileNames.Length];

                    int counterobject = 0;
                    foreach (var item in imagegonder.FileNames)
                    {
                        mespanel.VerticalScroll.Value = 0;
                        CokluResim[counterobject] = new PictureBox
                        {
                            ImageLocation = item,
                            Location = new Point(pointX - 8, pointY),
                            Height = 150,
                            Width = 150,
                            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                        };
                        mespanel.Controls.Add(CokluResim[counterobject]);
                        mespanel.Show();
                        mespanel.ScrollControlIntoView(CokluResim[counterobject]);
                        pointY += 165;
                        Tarih(100, 135, CokluResim[counterobject]);
                        counterobject++;
                    }
                }
                //OPD üzerinden yalnızca bir adet görsel seçilmesi durumu
                else
                {
                    mespanel.VerticalScroll.Value = 0;
                    PictureBox GonderilenResim = new PictureBox
                    {
                        Location = new Point(pointX - 8, pointY),
                        Height = 150,
                        Width = 150,
                        ImageLocation = imagegonder.FileName,
                        SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                    };
                    //   SagClick(GonderilenResim, YildizResim);
                    mespanel.Controls.Add(GonderilenResim);
                    mespanel.Show();
                    mespanel.ScrollControlIntoView(GonderilenResim);
                    Tarih(100, 135, GonderilenResim);
                    pointY += 165;
                }

            }


        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Yildizli y1 = new Yildizli();
            y1.Show();
        }

        private void Mesaj_Load(object sender, EventArgs e)
        {

        }
    }
}
