using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsLeague
{
    public partial class Form1 : Form
    {
        private const bool V = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void cPuanDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void sutunolusturma(ListView helper)
        {
            helper.Columns.Add("Takim");
            helper.Columns.Add("AGol");
            helper.Columns.Add("YGol");
            helper.Columns.Add("Averaj");
            helper.Columns.Add("Puan");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sutunolusturma(aPuanDurumu);
            sutunolusturma(bPuanDurumu);
            sutunolusturma(cPuanDurumu);
            sutunolusturma(dPuanDurumu);
            sutunolusturma(ePuanDurumu);
            sutunolusturma(fPuanDurumu);
            sutunolusturma(gPuanDurumu);
            sutunolusturma(hPuanDurumu);
        }
        public void sil(ListView tablo)
        {
            for (int i = 0; i < 20; i++)
            {
                if (tablo.Items.Count != 0)
                    tablo.Items[0].Remove();
                else break;
            }
        }
        public void ekle()
        {
            ListViewItem item = new ListViewItem("Barcelona");
            item.SubItems.Add("İspanya");
            ikinciTorba.Items.Add(item);
            item = new ListViewItem("Atletico Madrid");
            item.SubItems.Add("İspanya");
            ikinciTorba.Items.Add(item);
            item = new ListViewItem("Manchester City");
            item.SubItems.Add("İngiltere");
            ikinciTorba.Items.Add(item);
            item = new ListViewItem("Manchester United");
            item.SubItems.Add("İngiltere");
            ikinciTorba.Items.Add(item);
            item = new ListViewItem("Borussia Dortmund");
            item.SubItems.Add("Almanya");
            ikinciTorba.Items.Add(item);
            item = new ListViewItem("Shakhtar Donetsk");
            item.SubItems.Add("Ukrayna");
            ikinciTorba.Items.Add(item);
            item = new ListViewItem("Chelsea");
            item.SubItems.Add("İngiltere");
            ikinciTorba.Items.Add(item);
            item = new ListViewItem("Ajax");
            item.SubItems.Add("Hollanda");
            ikinciTorba.Items.Add(item);

            item = new ListViewItem("Bayern Munich");
            item.SubItems.Add("Almanya");
            birinciTorba.Items.Add(item);
            item = new ListViewItem("Sevilla");
            item.SubItems.Add("İspanya");
            birinciTorba.Items.Add(item);
            item = new ListViewItem("Real Madrid");
            item.SubItems.Add("İspanya");
            birinciTorba.Items.Add(item);
            item = new ListViewItem("Liverpool");
            item.SubItems.Add("İngiltere");
            birinciTorba.Items.Add(item);
            item = new ListViewItem("Juventus");
            item.SubItems.Add("İtalya");
            birinciTorba.Items.Add(item);
            item = new ListViewItem("Paris Saint -Germain");
            item.SubItems.Add("Fransa");
            birinciTorba.Items.Add(item);
            item = new ListViewItem("Zenit");
            item.SubItems.Add("Rusya");
            birinciTorba.Items.Add(item);
            item = new ListViewItem("Porto");
            item.SubItems.Add("Portekiz");
            birinciTorba.Items.Add(item);

            item = new ListViewItem("Dynamo Kiev");
            item.SubItems.Add("Ukrayna");
            ucuncuTorba.Items.Add(item);
            item = new ListViewItem("Red Bull Salzburg");
            item.SubItems.Add("Almanya");
            ucuncuTorba.Items.Add(item);
            item = new ListViewItem("RB Leipzig");
            item.SubItems.Add("Almanya");
            ucuncuTorba.Items.Add(item);
            item = new ListViewItem("Internazionale");
            item.SubItems.Add("İtalya");
            ucuncuTorba.Items.Add(item);
            item = new ListViewItem("Olympiacos");
            item.SubItems.Add("Yunanistan");
            ucuncuTorba.Items.Add(item);
            item = new ListViewItem("Lazio");
            item.SubItems.Add("İtalya");
            ucuncuTorba.Items.Add(item);
            item = new ListViewItem("Krasnodar");
            item.SubItems.Add("Rusya");
            ucuncuTorba.Items.Add(item);
            item = new ListViewItem("Atalanta");
            item.SubItems.Add("İtalya");
            ucuncuTorba.Items.Add(item);

            item = new ListViewItem("Lokomotiv Moskova");
            item.SubItems.Add("Rusya");
            dorduncuTorba.Items.Add(item);
            item = new ListViewItem("Marseille");
            item.SubItems.Add("Fransa");
            dorduncuTorba.Items.Add(item);
            item = new ListViewItem("Club Brugge");
            item.SubItems.Add("Belçika");
            dorduncuTorba.Items.Add(item);
            item = new ListViewItem("Bor.Mönchengladbach");
            item.SubItems.Add("Almanya");
            dorduncuTorba.Items.Add(item);
            item = new ListViewItem("Galatasaray");
            item.SubItems.Add("Türkiye");
            dorduncuTorba.Items.Add(item);
            item = new ListViewItem("Midtjylland");
            item.SubItems.Add("Danimarka");
            dorduncuTorba.Items.Add(item);
            item = new ListViewItem("Rennes");
            item.SubItems.Add("Fransa");
            dorduncuTorba.Items.Add(item);
            item = new ListViewItem("Ferencváros");
            item.SubItems.Add("Macaristan");
            dorduncuTorba.Items.Add(item);

            item = new ListViewItem("-");
            item.SubItems.Add("-");
            aGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            aGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            aGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            aGrubu.Items.Add(item);

            item = new ListViewItem("-");
            item.SubItems.Add("-");
            bGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            bGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            bGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            bGrubu.Items.Add(item);
            
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            cGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            cGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            cGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            cGrubu.Items.Add(item);


            item = new ListViewItem("-");
            item.SubItems.Add("-");
            dGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            dGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            dGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            dGrubu.Items.Add(item);

            item = new ListViewItem("-");
            item.SubItems.Add("-");
            eGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            eGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            eGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            eGrubu.Items.Add(item);

            item = new ListViewItem("-");
            item.SubItems.Add("-");
            fGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            fGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            fGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            fGrubu.Items.Add(item);

            item = new ListViewItem("-");
            item.SubItems.Add("-");
            gGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            gGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            gGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            gGrubu.Items.Add(item);

            item = new ListViewItem("-");
            item.SubItems.Add("-");
            hGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            hGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            hGrubu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            hGrubu.Items.Add(item);
        }
        public void TorbadanDagit(ListView torba, int torbano)
        {  
            Random rasgele = new Random();
            int a ,sayac;

            a = rasgele.Next(5);
            for (int i = 0; i < torba.Items.Count; i++)
            {
                if (torba.Items[a].SubItems[1].Text != aGrubu.Items[0].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != aGrubu.Items[1].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != aGrubu.Items[2].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != aGrubu.Items[3].SubItems[1].Text)
                {
                    aGrubu.Items[torbano].SubItems[0].Text = torba.Items[a].SubItems[0].Text;
                    aGrubu.Items[torbano].SubItems[1].Text = torba.Items[a].SubItems[1].Text;
                    torba.Items[a].Remove();
                    break;
                }
                else a = rasgele.Next(5);
            }

            a = rasgele.Next(4);
            for (int i = 0; i < torba.Items.Count; i++)
            {
                if (torba.Items[a].SubItems[1].Text != bGrubu.Items[0].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != bGrubu.Items[1].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != bGrubu.Items[2].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != bGrubu.Items[3].SubItems[1].Text)
                {
                    bGrubu.Items[torbano].SubItems[0].Text = torba.Items[a].SubItems[0].Text;
                    bGrubu.Items[torbano].SubItems[1].Text = torba.Items[a].SubItems[1].Text;
                    torba.Items[a].Remove();
                    break;
                }
                else a = rasgele.Next(4);
            }

            a = rasgele.Next(3);
            for (int i = 0; i < torba.Items.Count; i++)
            {
                if (torba.Items[a].SubItems[1].Text != cGrubu.Items[0].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != cGrubu.Items[1].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != cGrubu.Items[2].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != cGrubu.Items[3].SubItems[1].Text)
                {
                    cGrubu.Items[torbano].SubItems[0].Text = torba.Items[a].SubItems[0].Text;
                    cGrubu.Items[torbano].SubItems[1].Text = torba.Items[a].SubItems[1].Text;
                    torba.Items[a].Remove();
                    break;
                }
                else a = rasgele.Next(3);
            }

            a = rasgele.Next(5);
            sayac = 0;
            for (int i = 0; i < torba.Items.Count; i++)
            {
                if (torba.Items[a].SubItems[1].Text != dGrubu.Items[0].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != dGrubu.Items[1].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != dGrubu.Items[2].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != dGrubu.Items[3].SubItems[1].Text)
                {
                    dGrubu.Items[torbano].SubItems[0].Text = torba.Items[a].SubItems[0].Text;
                    dGrubu.Items[torbano].SubItems[1].Text = torba.Items[a].SubItems[1].Text;
                    torba.Items[a].Remove();
                    break;
                }
                else
                {
                    a--;
                    if (a >= 5) a = 0;
                    else if (a <= -1) a = 4;
                    sayac++;
                    if (sayac == 3)
                    {
                        sil(birinciTorba);
                        sil(ikinciTorba);
                        sil(ucuncuTorba);
                        sil(dorduncuTorba);
                        sil(aGrubu);
                        sil(bGrubu);
                        sil(cGrubu);
                        sil(dGrubu);
                        sil(eGrubu);
                        sil(fGrubu);
                        sil(gGrubu);
                        sil(hGrubu);
                        ekle();
                        TorbadanDagit(birinciTorba, 0);
                        TorbadanDagit(ikinciTorba, 1);
                        TorbadanDagit(ucuncuTorba, 2);
                        TorbadanDagit(dorduncuTorba, 3);
                    }
                }
            }

            a = rasgele.Next(4);
            sayac = 0;
            for (int i = 0; i < torba.Items.Count; i++)
            {
                if (torba.Items[a].SubItems[1].Text != eGrubu.Items[0].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != eGrubu.Items[1].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != eGrubu.Items[2].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != eGrubu.Items[3].SubItems[1].Text)
                {
                    eGrubu.Items[torbano].SubItems[0].Text = torba.Items[a].SubItems[0].Text;
                    eGrubu.Items[torbano].SubItems[1].Text = torba.Items[a].SubItems[1].Text;
                    torba.Items[a].Remove();
                    break;
                }
                else
                {
                    a--;
                    if (a >= 4) a = 0;
                    else if (a <= -1) a = 3;
                    sayac++;
                    if (sayac==3)
                    {
                        sil(birinciTorba);
                        sil(ikinciTorba);
                        sil(ucuncuTorba);
                        sil(dorduncuTorba);
                        sil(aGrubu);
                        sil(bGrubu);
                        sil(cGrubu);
                        sil(dGrubu);
                        sil(eGrubu);
                        sil(fGrubu);
                        sil(gGrubu);
                        sil(hGrubu);
                        ekle();
                        TorbadanDagit(torba, torbano);
                    }
                } 
            }

            a = rasgele.Next(3);
            sayac = 0;
            for (int i = 0; i < torba.Items.Count; i++)
            {
                if (torba.Items[a].SubItems[1].Text != fGrubu.Items[0].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != fGrubu.Items[1].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != fGrubu.Items[2].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != fGrubu.Items[3].SubItems[1].Text)
                {
                    fGrubu.Items[torbano].SubItems[0].Text = torba.Items[a].SubItems[0].Text;
                    fGrubu.Items[torbano].SubItems[1].Text = torba.Items[a].SubItems[1].Text;
                    torba.Items[a].Remove();
                    break;
                }
                else
                {
                    a--;
                    if (a >= 3) a = 0;
                    else if (a <= -1) a = 2;
                    sayac++;
                    if (sayac == 3)
                    {
                        sil(birinciTorba);
                        sil(ikinciTorba);
                        sil(ucuncuTorba);
                        sil(dorduncuTorba);
                        sil(aGrubu);
                        sil(bGrubu);
                        sil(cGrubu);
                        sil(dGrubu);
                        sil(eGrubu);
                        sil(fGrubu);
                        sil(gGrubu);
                        sil(hGrubu);
                        ekle();
                        TorbadanDagit(torba, torbano);
                    }
                }
            }

            a = rasgele.Next(2);
            sayac = 0;
            for (int i = 0; i < torba.Items.Count; i++)
            {
                if (torba.Items[a].SubItems[1].Text != gGrubu.Items[0].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != gGrubu.Items[1].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != gGrubu.Items[2].SubItems[1].Text &&
                    torba.Items[a].SubItems[1].Text != gGrubu.Items[3].SubItems[1].Text)
                {
                    gGrubu.Items[torbano].SubItems[0].Text = torba.Items[a].SubItems[0].Text;
                    gGrubu.Items[torbano].SubItems[1].Text = torba.Items[a].SubItems[1].Text;
                    torba.Items[a].Remove();
                    break;
                }
                else
                {
                    a--;
                    if (a >= 2) a = 0;
                    else if (a <= -1) a = 1;
                    if (sayac == 1)
                    {
                        gGrubu.Items[torbano].SubItems[0].Text = torba.Items[a].SubItems[0].Text;
                        gGrubu.Items[torbano].SubItems[1].Text = torba.Items[a].SubItems[1].Text;
                        torba.Items[a].Remove();
                        break;
                    }
                    sayac++;
                    if (sayac == 3)
                    {
                        sil(birinciTorba);
                        sil(ikinciTorba);
                        sil(ucuncuTorba);
                        sil(dorduncuTorba);
                        sil(aGrubu);
                        sil(bGrubu);
                        sil(cGrubu);
                        sil(dGrubu);
                        sil(eGrubu);
                        sil(fGrubu);
                        sil(gGrubu);
                        sil(hGrubu);
                        ekle();
                        TorbadanDagit(torba, torbano);
                    }
                }
            }

            hGrubu.Items[torbano].SubItems[0].Text = torba.Items[0].SubItems[0].Text;
            hGrubu.Items[torbano].SubItems[1].Text = torba.Items[0].SubItems[1].Text;
            torba.Items[0].Remove();  
        }
        public void Gorunum()
        {
            birinciTorba.Visible = false;
            ikinciTorba.Visible = false;
            ucuncuTorba.Visible = false;
            dorduncuTorba.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            aGrubu.Location = new Point(10,150);
            bGrubu.Location = new Point(220, 150);
            cGrubu.Location = new Point(430, 150);
            dGrubu.Location = new Point(640, 150);
            eGrubu.Location = new Point(10, 270);
            fGrubu.Location = new Point(220,270);
            gGrubu.Location = new Point(430,270);
            hGrubu.Location = new Point(640,270);
            label1.Location = new Point(80,135);
            label6.Location = new Point(290, 135);
            label7.Location = new Point(500, 135);
            label8.Location = new Point(710, 135);
            label9.Location = new Point(80, 255);
            label10.Location = new Point(290,255);
            label11.Location = new Point(500,255);
            label12.Location = new Point(710,255);
            GrupAtama.Visible = false;
            Fikstur.Visible = true;
            Fikstur.Location = new Point(5,100);
         
        }
        public void fiksturveSonucGorunum()
        {
            aGrubu.Visible = false;
            bGrubu.Visible = false;
            cGrubu.Visible = false;
            dGrubu.Visible = false;
            eGrubu.Visible = false;
            fGrubu.Visible = false;
            gGrubu.Visible = false;
            hGrubu.Visible = false;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
            label53.Location = new Point(680);
            label13.Location = new Point(620, 30);
            label14.Location = new Point(730, 30);
            label15.Location = new Point(750, 30);
            label16.Location = new Point(770, 30);
            label33.Location = new Point(620, 50);
            label34.Location = new Point(730, 50);
            label35.Location = new Point(750, 50);
            label36.Location = new Point(770, 50);
            label21.Location = new Point(770, 70);
            label22.Location = new Point(750, 70);
            label23.Location = new Point(730, 70);
            label24.Location = new Point(620, 70);
            label25.Location = new Point(620, 90);
            label26.Location = new Point(730, 90);
            label27.Location = new Point(750, 90);
            label28.Location = new Point(770, 90);
            label17.Location = new Point(620, 110);
            label18.Location = new Point(730, 110);
            label19.Location = new Point(750, 110);
            label20.Location = new Point(770, 110);
            label29.Location = new Point(620, 130);
            label30.Location = new Point(730, 130);
            label31.Location = new Point(750, 130);
            label32.Location = new Point(770, 130);
            aPuanDurumu.Location = new Point(10 ,20);
            bPuanDurumu.Location = new Point(320, 20);
            cPuanDurumu.Location = new Point(10, 150);
            dPuanDurumu.Location = new Point(320, 150);
            ePuanDurumu.Location = new Point(10, 280);
            fPuanDurumu.Location = new Point(320, 280);
            gPuanDurumu.Location = new Point(10, 410);
            hPuanDurumu.Location = new Point(320, 410);
            label1.Location = new Point(150, 5);
            label6.Location = new Point(450, 5);
            label7.Location = new Point(150, 135);
            label8.Location = new Point(450, 135);
            label9.Location = new Point(150, 265);
            label10.Location = new Point(450, 265);
            label11.Location = new Point(150, 395);
            label12.Location = new Point(450, 395);
            label53.Text="Son Grup Maçları";
            Fikstur.Visible = false;
            button1.Visible = true;
            button1.Location = new Point(650,150);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TorbadanDagit(birinciTorba,0);
            TorbadanDagit(ikinciTorba,1);
            TorbadanDagit(ucuncuTorba,2);
            TorbadanDagit(dorduncuTorba,3);
            Gorunum();
        }
        public void puanDurumuEkle() 
        {
            ListViewItem item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            aPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            aPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            aPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            aPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            bPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            bPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            bPuanDurumu.Items.Add(item);
            item = new ListViewItem("-"); 
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            bPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            cPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            cPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            cPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            cPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            dPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            dPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            dPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            dPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            ePuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            ePuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            ePuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            ePuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            fPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            fPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            fPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            fPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            gPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            gPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            gPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            gPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            hPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            hPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            hPuanDurumu.Items.Add(item);
            item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            hPuanDurumu.Items.Add(item);

        }
        public void aktarma()
        {
            puanDurumuEkle();
            for (int i = 0; i < aGrubu.Items.Count; i++)
            {
                aPuanDurumu.Items[i].SubItems[0].Text = aGrubu.Items[i].SubItems[0].Text;
                bPuanDurumu.Items[i].SubItems[0].Text = bGrubu.Items[i].SubItems[0].Text;
                cPuanDurumu.Items[i].SubItems[0].Text = cGrubu.Items[i].SubItems[0].Text;
                dPuanDurumu.Items[i].SubItems[0].Text = dGrubu.Items[i].SubItems[0].Text;
                ePuanDurumu.Items[i].SubItems[0].Text = eGrubu.Items[i].SubItems[0].Text;
                fPuanDurumu.Items[i].SubItems[0].Text = fGrubu.Items[i].SubItems[0].Text;
                gPuanDurumu.Items[i].SubItems[0].Text = gGrubu.Items[i].SubItems[0].Text;
                hPuanDurumu.Items[i].SubItems[0].Text = hGrubu.Items[i].SubItems[0].Text;
            }


        }

        public void hesaplama()
        {
            Random rasgele = new Random();

            int[] puan = { 0, 0, 0, 0 };
            int[] atılangol = { 0, 0, 0, 0 };
            int[] yenilengol = { 0, 0, 0, 0 };
            int[] averaj = { 0, 0, 0, 0 };
            int[] evsahibiTut = { 0, 0, 0, 0, 0, 0 };
            int[] deplasmanTut = { 0, 0, 0, 0, 0, 0 };
            
            int evsahibi = 0, deplasman = 0, sayac = 0;
            evsahibi = rasgele.Next(8);
            deplasman = rasgele.Next(8);
            for (int i = 0; i < 3; i++)
            {
                for (int j = i+1; j < 4; j++)
                {
                    evsahibi = rasgele.Next(8);
                    deplasman = rasgele.Next(8);
                    if (evsahibi > deplasman)
                    {
                        puan[i] = puan[i] + 3;
                        atılangol[i] = atılangol[i] + evsahibi;
                        yenilengol[i] = yenilengol[i] + deplasman;
                        atılangol[j] = atılangol[j] + deplasman;
                        yenilengol[j] = yenilengol[j] + evsahibi;
                        evsahibiTut[sayac] = evsahibi;
                        deplasmanTut[sayac] = deplasman;
                    }
                    else if (evsahibi < deplasman)
                    {
                        puan[j] = puan[j] + 3;
                        atılangol[i] = atılangol[i] + evsahibi;
                        yenilengol[i] = yenilengol[i] + deplasman;
                        atılangol[j] = atılangol[j] + deplasman;
                        yenilengol[j] = yenilengol[j] + evsahibi;
                        evsahibiTut[sayac] = evsahibi;
                        deplasmanTut[sayac] = deplasman;
                    }
                    else
                    {
                        puan[i] = puan[i] + 1;
                        puan[j] = puan[j] + 1;
                        atılangol[i] = atılangol[i] + evsahibi;
                        yenilengol[i] = yenilengol[i] + deplasman;
                        atılangol[j] = atılangol[j] + deplasman;
                        yenilengol[j] = yenilengol[j] + evsahibi;
                        evsahibiTut[sayac] = evsahibi;
                        deplasmanTut[sayac] = deplasman;
                    }
                    sayac++;
                }
            }
            for (int i = 0; i < averaj.Length; i++)
            {
                averaj[i] = atılangol[i] - yenilengol[i];
            }
            for (int i = 0; i < 4; i++)
            {
                yardimci_liste.Items[i].SubItems[0].Text = atılangol[i].ToString();
                yardimci_liste.Items[i].SubItems[1].Text = yenilengol[i].ToString();
                yardimci_liste.Items[i].SubItems[2].Text = averaj[i].ToString();
                yardimci_liste.Items[i].SubItems[3].Text = puan[i].ToString();
            }
            for (int i = 0; i < yardimci_liste.Items.Count; i++)
            {
                yardimci_liste.Items[i].SubItems[4].Text = evsahibiTut[i].ToString();
                yardimci_liste.Items[i].SubItems[5].Text = deplasmanTut[i].ToString();
            }
        }
        public void MacFiksturuveSonucu(ListView takim)
        {
            hesaplama();
            for (int i = 0; i < takim.Items.Count; i++)
            {
                takim.Items[i].SubItems[1].Text = yardimci_liste.Items[i].SubItems[0].Text;
                takim.Items[i].SubItems[2].Text = yardimci_liste.Items[i].SubItems[1].Text;
                takim.Items[i].SubItems[3].Text = yardimci_liste.Items[i].SubItems[2].Text;
                takim.Items[i].SubItems[4].Text = yardimci_liste.Items[i].SubItems[3].Text;
            }
            label13.Text = takim.Items[0].SubItems[0].Text;
            label14.Text = yardimci_liste.Items[0].SubItems[4].Text;
            label15.Text = yardimci_liste.Items[0].SubItems[5].Text;
            label16.Text = takim.Items[1].SubItems[0].Text;

            label17.Text = takim.Items[0].SubItems[0].Text;
            label18.Text = yardimci_liste.Items[1].SubItems[4].Text;
            label19.Text = yardimci_liste.Items[1].SubItems[5].Text;
            label20.Text = takim.Items[2].SubItems[0].Text;

            label21.Text = takim.Items[0].SubItems[0].Text;
            label22.Text = yardimci_liste.Items[2].SubItems[4].Text;
            label23.Text = yardimci_liste.Items[2].SubItems[5].Text;
            label24.Text = takim.Items[3].SubItems[0].Text;

            label25.Text = takim.Items[1].SubItems[0].Text;
            label26.Text = yardimci_liste.Items[3].SubItems[4].Text;
            label27.Text = yardimci_liste.Items[3].SubItems[5].Text;
            label28.Text = takim.Items[2].SubItems[0].Text;

            label29.Text = takim.Items[1].SubItems[0].Text;
            label30.Text = yardimci_liste.Items[4].SubItems[4].Text;
            label31.Text = yardimci_liste.Items[4].SubItems[5].Text;
            label32.Text = takim.Items[3].SubItems[0].Text;

            label33.Text = takim.Items[2].SubItems[0].Text;
            label34.Text = yardimci_liste.Items[5].SubItems[4].Text;
            label35.Text = yardimci_liste.Items[5].SubItems[5].Text;
            label36.Text = takim.Items[3].SubItems[0].Text;
        }
      
        private void Fikstur_Click(object sender, EventArgs e)
        {
            aktarma();
            
            MacFiksturuveSonucu(aPuanDurumu);
            
            MacFiksturuveSonucu(bPuanDurumu);
            
            MacFiksturuveSonucu(cPuanDurumu);
            
            MacFiksturuveSonucu(dPuanDurumu);
            
            MacFiksturuveSonucu(ePuanDurumu);
            
            MacFiksturuveSonucu(fPuanDurumu);
            
            MacFiksturuveSonucu(gPuanDurumu);

            MacFiksturuveSonucu(hPuanDurumu);
            
            fiksturveSonucGorunum();
            
        }

        public void kazananlar() 
        {
            aPuanDurumu.Visible = false;
            bPuanDurumu.Visible = false;
            cPuanDurumu.Visible = false;
            dPuanDurumu.Visible = false;
            ePuanDurumu.Visible = false;
            fPuanDurumu.Visible = false;
            gPuanDurumu.Visible = false;
            hPuanDurumu.Visible = false;
            label37.Visible = true;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;  
            label26.Visible = false;  
            label27.Visible = false;  
            label28.Visible = false;  
            label29.Visible = false;  
            label30.Visible = false;  
            label31.Visible = false;  
            label32.Visible = false;  
            label33.Visible = false;   
            label34.Visible = false;  
            label35.Visible = false;  
            label36.Visible = false;
            label53.Visible = false;
            label1.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false; 
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label37.Location = new Point(15, 5);
            label38.Location = new Point(15 , 25);
            label39.Location = new Point(15, 45);
            label40.Location = new Point(15, 65);
            label41.Location = new Point(15, 85);
            label42.Location = new Point(15, 105);
            label43.Location = new Point(15, 125);
            label44.Location = new Point(15, 145);
            label45.Location = new Point(15, 165);
            label46.Location = new Point(15, 185);
            label47.Location = new Point(15, 205);
            label48.Location = new Point(15, 225);
            label49.Location = new Point(15, 245);
            label50.Location = new Point(15, 265);
            label51.Location = new Point(15, 285);
            label52.Location = new Point(15, 305);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            //en iyileri label'A yansıtma
            label37.Text = aPuanDurumu.Items[0].SubItems[0].Text;
            label38.Text = aPuanDurumu.Items[1].SubItems[0].Text;
            label39.Text = bPuanDurumu.Items[0].SubItems[0].Text;
            label40.Text = bPuanDurumu.Items[1].SubItems[0].Text;
            label41.Text = cPuanDurumu.Items[0].SubItems[0].Text;
            label42.Text = cPuanDurumu.Items[1].SubItems[0].Text;
            label43.Text = dPuanDurumu.Items[0].SubItems[0].Text;
            label44.Text = dPuanDurumu.Items[1].SubItems[0].Text;
            label45.Text = ePuanDurumu.Items[0].SubItems[0].Text;
            label46.Text = ePuanDurumu.Items[1].SubItems[0].Text;
            label47.Text = fPuanDurumu.Items[0].SubItems[0].Text;
            label48.Text = fPuanDurumu.Items[1].SubItems[0].Text;
            label49.Text = gPuanDurumu.Items[0].SubItems[0].Text;
            label50.Text = gPuanDurumu.Items[1].SubItems[0].Text;
            label51.Text = hPuanDurumu.Items[0].SubItems[0].Text;
            label52.Text = hPuanDurumu.Items[1].SubItems[0].Text;
            kazananlar();
            
        }

        
    }
}
