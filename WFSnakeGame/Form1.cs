using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSnakeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<KareInfo> listKare = new List<KareInfo>();
        List<KareInfo> listUzuv = new List<KareInfo>();
        YilanInfo yilanInfo = null;

        int yon = 2;
        int toplamKareSayisi = 900;
        bool gameOver = false;
        bool yemVar = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            int kareKenarUzunluk = 12;
            int kareX = 1;
            int kareY = 1;
            int margin = 2;

            for (int i = 0; i < toplamKareSayisi; i++)
            {
                KareInfo kareInfo = new KareInfo(this.panel, new Point(kareX, kareY), new Size(kareKenarUzunluk, kareKenarUzunluk), i);
                listKare.Add(kareInfo);
                kareX += kareKenarUzunluk + margin;

                if ((i + 1) % 30 == 0)
                {
                    kareX = 1;
                    kareY += kareKenarUzunluk + margin;
                }
            }
            sinirEkle();
            yilanInfo = new YilanInfo(listKare, listUzuv);
        }

        void yemEkle()
        {
            if (yemVar)
            {
                return;
            }

            Random random = new Random();
            int indis = 0;
            bool durum = false;

            while (durum == false)
            {
                indis = random.Next(0, toplamKareSayisi);
                durum = true;

                if (this.listKare[indis].uzuv || this.listKare[indis].sinir)
                {
                    durum = false;
                }
            }

            if (durum)
            {
                this.listKare[indis].yemYap();
                this.yemVar = true;
            }
        }

        void sinirEkle()
        {
            for (int i = 0; i <= 29; i += 1)
            {
                listKare[i].sinirYap();
            }
            for (int i = 0; i <= 870; i += 30)
            {
                listKare[i].sinirYap();
            }
            for (int i = 870; i <= 899; i += 1)
            {
                listKare[i].sinirYap();
            }
            for (int i = 29; i <= 899; i += 30)
            {
                listKare[i].sinirYap();
            }
        }

        void newGame()
        {
            timer.Stop();

            foreach (KareInfo item in listKare)
            {
                if (!item.sinir)
                {
                    item.uzuvYapma();
                    item.yemYapma();
                }
            }

            gameOver = false;
            yon = 2;
            yemVar = false;
            lblSkor.Text = "0";
            listUzuv.Clear();
            yilanInfo = new YilanInfo(listKare, listUzuv);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            yemEkle();
            int sonuc = yilanInfo.yurut(yon);

            switch (sonuc)
            {
                case 0:
                    timer.Stop();
                    gameOver = true;
                    MessageBox.Show("Oyun Bitti :(");
                    break;

                case 1:
                    break;

                case 2:
                    yemVar = false;
                    lblSkor.Text = Convert.ToString(Convert.ToInt32(lblSkor.Text) + 1);
                    break;

                default:
                    break;
            }
        }

        private void pictureUp_Click(object sender, EventArgs e)
        {
            if (yilanInfo.yon != 3)
            {
                yon = 1;
            }
        }

        private void pictureRgt_Click(object sender, EventArgs e)
        {
            if (yilanInfo.yon != 4)
            {
                yon = 2;
            }
        }

        private void pictureLft_Click(object sender, EventArgs e)
        {
            if (yilanInfo.yon != 2)
            {
                yon = 4;
            }
        }

        private void pictureDown_Click(object sender, EventArgs e)
        {
            if (yilanInfo.yon != 1)
            {
                yon = 3;
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                timer.Start();
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                timer.Stop();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                if (yilanInfo.yon != 3)
                {
                    yon = 1;
                }
            }

            if (keyData == Keys.Right)
            {
                if (yilanInfo.yon != 4)
                {
                    yon = 2;
                }
            }

            if (keyData == Keys.Left)
            {
                if (yilanInfo.yon != 2)
                {
                    yon = 4;
                }
            }

            if (keyData == Keys.Down)
            {
                if (yilanInfo.yon != 1)
                {
                    yon = 3;
                }
            }

            return base.ProcessDialogKey(keyData);
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            newGame();
        }
    }

    class KareInfo
    {
        public Point location { get; set; }
        public Size size { get; set; }
        public Color backColor { get; set; }
        public PictureBox pictureBox { get; set; }

        public int indis { get; set; }
        public bool uzuv { get; set; }
        public bool yem { get; set; }
        public bool sinir { get; set; }

        public Panel panel { get; set; }

        public KareInfo(Panel panel, Point location, Size size, int indis)
        {
            this.panel = panel;
            this.location = location;
            this.size = size;
            this.indis = indis;
            this.backColor = Color.Black;
            this.uzuv = false;
            this.yem = false;
            this.sinir = false;
            pictureBoxAdd();
        }

        void pictureBoxAdd()
        {
            pictureBox = new PictureBox();
            pictureBox.Location = this.location;
            pictureBox.Size = this.size;
            pictureBox.BackColor = this.backColor;
            this.panel.Controls.Add(pictureBox);
        }

        public void uzuvYap()
        {
            this.pictureBox.BackColor = Color.Green;
            this.uzuv = true;
        }

        public void uzuvYapma()
        {
            this.pictureBox.BackColor = this.backColor;
            this.uzuv = false;
        }

        public void yemYap()
        {
            this.pictureBox.BackColor = Color.Red;
            this.yem = true;
        }

        public void yemYapma()
        {
            this.pictureBox.BackColor = this.backColor;
            this.yem = false;
        }

        public void sinirYap()
        {
            this.pictureBox.BackColor = Color.Gray;
            this.sinir = true;
        }
    }

    class YilanInfo
    {
        public int startPosition = 33;
        public int yon { get; set; }
        public List<KareInfo> listkare { get; set; }
        public List<KareInfo> listUzuv { get; set; }

        public YilanInfo(List<KareInfo> listkare, List<KareInfo> listUzuv)
        {
            this.listkare = listkare;
            this.listUzuv = listUzuv;

            this.listkare[31].uzuvYap();
            this.listkare[32].uzuvYap();
            this.listkare[33].uzuvYap();

            this.listUzuv.Add(this.listkare[31]);
            this.listUzuv.Add(this.listkare[32]);
            this.listUzuv.Add(this.listkare[33]);
        }

        public int yurut(int yon)
        {
            this.yon = yon;

            switch (yon)
            {
                case 1:
                    startPosition = startPosition - 30;
                    break;
                case 2:
                    startPosition = startPosition + 1;
                    break;
                case 3:
                    startPosition = startPosition + 30;
                    break;
                case 4:
                    startPosition = startPosition - 1;
                    break;
                default:
                    break;
            }

            if (this.listkare[startPosition].uzuv || this.listkare[startPosition].sinir)
            {
                return 0; // Game Over
            }
            else
            {
                this.listkare[startPosition].uzuvYap();
                this.listUzuv.Add(this.listkare[startPosition]);

                if (this.listkare[startPosition].yem)
                {
                    this.listkare[startPosition].yem = false;

                    return 2; // Yem yenmiş ise
                }
                else
                {
                    this.listkare[this.listUzuv[0].indis].uzuvYapma();
                    this.listUzuv.RemoveAt(0);

                    return 1; // Kuyruk silinmiş ise
                }
            }
        }
    }
}
