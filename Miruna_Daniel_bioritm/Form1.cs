    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miruna_Daniel_bioritm
{
    public partial class Form1 : Form
    {
        Bitmap b;
        int lx, ly;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lx = pictureBox1.Width; ly = pictureBox1.Height;
            b = new Bitmap(lx, ly);
            pictureBox1.Image = b;
            dateTimePickerB.Value = DateTime.Now;
        }

        private void dateTimePickerN_ValueChanged(object sender, EventArgs e)
        {
            button_generare_Click(sender, e);
        }

        private void dateTimePickerB_ValueChanged(object sender, EventArgs e)
        {
            button_generare_Click(sender, e);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_nrzile.Text = trackBar1.Value.ToString();
            button_generare_Click(sender, e);
        }



        private void button_generare_Click(object sender, EventArgs e)
        {
            if (b == null) return;
            Graphics g = Graphics.FromImage(b);/// incepem sa desenam sistemul de axe cu variabila g din clasa Graphics
            g.Clear(Color.LightYellow);/// dam culoare fontului 
            g.DrawLine(new Pen(Color.Black, 2), 0, ly / 2, lx, ly / 2);/// desenam axa ox
            g.DrawLine(new Pen(Color.Black, 2), lx / 2, 0, lx / 2, ly);/// desenam axa oy
            string ziua;
            int nr_zile = trackBar1.Value;/// luam numarul de zile din track bar - calc bioritm pe cate zile vrem
            double dx = lx / (2.0 * nr_zile);/// diferenta dintre 2 linii verticale , intr-un numar real
            // Desenare Cadrane
            for (int i = 0; i <= 2 * nr_zile; i++)
            {
                ziua = dateTimePickerB.Value.Date.AddDays(i - nr_zile).ToShortDateString();///incepem de la minus mergem n poziti stanaga si n poziti dreapta de aceea si forul pana la 2*n
                g.DrawLine(new Pen(Color.Black, 1), (int)(i * dx), 0, (int)(i * dx), ly); /// desenam linia 
                g.DrawString(ziua, new Font("Arial", 10),
                new SolidBrush(Color.Blue), (int)(i * dx), ly - 80, new StringFormat(StringFormatFlags.DirectionVertical));/// dam font datei , ii dam coordonatele si cum este asezata
            }
            // Desenare 
            DateTime zi1 = dateTimePickerB.Value.Date.AddDays(-nr_zile);/// ziua din partea stanga 
            DateTime zi2 = dateTimePickerB.Value.Date.AddDays(nr_zile);/// ziua din partea dreapta
            //
            int nrz1 = (zi1 - dateTimePickerN.Value.Date).Days;/// diferenta de zile dintre data anterioara si data nasterii
            int nrz2 = (zi2 - dateTimePickerN.Value.Date).Days;/// diferenta de zile dintre data urmatoare  si data nasterii
                                                               /// tre sa repr functiile sin(2*pi*t/23),(../28),....(/33)
            int x;
            for (x = 0; x <= lx; x++)
            {
                double xsin1 = nrz1 + (double)x / lx * (nrz2 - nrz1); /// lx suparafata de desenare in pixeli
                double xsin2 = nrz1 + (double)(x + 1) / lx * (nrz2 - nrz1);/// varialbila xsin1 sau xsin2 creste intre nrz1 si nrz2 ;daca x =0 atunci xsin este nrz1 si daca x= lx atunci xsin este nrz2
                /// deci practic calculam nr de zile la fiecare zi din intervalul de zile pe care ni-l da trackbarul
                g.DrawLine(new Pen(Color.Red, 2), 
                    x, ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin1 / 23) * (ly / 2 - 10)),
                    x + 1,  ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin2 / 23) * (ly / 2 - 10)) );
                g.DrawLine(new Pen(Color.Blue, 2), x, ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin1 / 28) * (ly / 2 - 10)),
                    x + 1, ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin2 / 28) * (ly / 2 - 10)));
                g.DrawLine(new Pen(Color.Green, 2), x, ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin1 / 33) * (ly / 2 - 10)),
                    x + 1, ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin2 / 33) * (ly / 2 - 10)));
            }
            
            pictureBox1.Refresh();

        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button_zodie_Click(object sender, EventArgs e)
        {
            /// Varsator
            if (dateTimePickerN.Value.Month == 1 && dateTimePickerN.Value.Day >= 20 || dateTimePickerN.Value.Month == 2 && dateTimePickerN.Value.Day <= 18)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\varasator.jpg");
                label_zodie.Text = "Varasator";
            }
            ///Pesti

            if (dateTimePickerN.Value.Month == 2 && dateTimePickerN.Value.Day >= 19 || dateTimePickerN.Value.Month == 3 && dateTimePickerN.Value.Day <= 20)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\pesti.jpg");
                label_zodie.Text = "Pesti";
            }
             /// Berbec

            if (dateTimePickerN.Value.Month == 3 && dateTimePickerN.Value.Day >= 21 || dateTimePickerN.Value.Month == 4 && dateTimePickerN.Value.Day <= 20)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\berbec.jpg");
                label_zodie.Text = "Berbec";
            }
            /// Taur

            if (dateTimePickerN.Value.Month == 4 && dateTimePickerN.Value.Day >= 21 || dateTimePickerN.Value.Month == 5 && dateTimePickerN.Value.Day <= 20)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\taur.jpg");
                label_zodie.Text = "Taur";
            }

            ///Gemeni

            if (dateTimePickerN.Value.Month == 5 && dateTimePickerN.Value.Day >= 21|| dateTimePickerN.Value.Month == 6 && dateTimePickerN.Value.Day <= 21)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\gemeni.jpg");
                label_zodie.Text = "Gemeni";
            }

            /// Rac
            
            if (dateTimePickerN.Value.Month == 6 && dateTimePickerN.Value.Day >= 22 || dateTimePickerN.Value.Month == 7 && dateTimePickerN.Value.Day <= 22)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\rac.jpg");
                label_zodie.Text = "Rac";
            }
            /// Leu

            if (dateTimePickerN.Value.Month == 7 && dateTimePickerN.Value.Day >= 23 || dateTimePickerN.Value.Month == 8 && dateTimePickerN.Value.Day <= 22)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\leu.jpg");
                label_zodie.Text = "Leu";
            }
            /// Fecioara

            if (dateTimePickerN.Value.Month == 8 && dateTimePickerN.Value.Day >= 23 || dateTimePickerN.Value.Month == 9 && dateTimePickerN.Value.Day <= 22)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\fecioara.jpg");
                label_zodie.Text = "Fecioara";
            }
            /// Balanta

            if (dateTimePickerN.Value.Month == 9 && dateTimePickerN.Value.Day >= 23 || dateTimePickerN.Value.Month == 10 && dateTimePickerN.Value.Day <= 22)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\balanta.jpg");
                label_zodie.Text = "Balanta";
            }
            /// Scorpion

            if (dateTimePickerN.Value.Month == 10 && dateTimePickerN.Value.Day >= 23|| dateTimePickerN.Value.Month == 11 && dateTimePickerN.Value.Day <= 21)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\scorpion.jpg");
                label_zodie.Text = "Scorpion";
            }

            /// Sagetator

            if (dateTimePickerN.Value.Month == 11 && dateTimePickerN.Value.Day >= 22 || dateTimePickerN.Value.Month == 12 && dateTimePickerN.Value.Day <= 20)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\sagetator.jpg");
                label_zodie.Text = "Sagetator";
            }

            /// Capricorn

            if (dateTimePickerN.Value.Month == 12 && dateTimePickerN.Value.Day >= 21|| dateTimePickerN.Value.Month == 1 && dateTimePickerN.Value.Day <= 19)
            {
                pictureBox_zodie.Image = Image.FromFile(@"imagini\capricorn.jpg");
                label_zodie.Text = "Capricorn";
            }
        }

       /* private void DrawSin(Graphics g, int t, int nrz1, int nrz2, Color c)
        {
            int x;
            for (x = 0; x <= lx; x++)
            {
                double xsin1 = nrz1 + (double)x / lx * (nrz2 - nrz1);
                double xsin2 = nrz1 + (double)(x + 1) / lx * (nrz2 - nrz1);
                g.DrawLine(
                    new Pen(c, 2),
                    x,
                    ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin1 / t) * (ly / 2 - 10)),
                    x + 1,
                    ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin2 / t) * (ly / 2 - 10))
                );
                //g.DrawLine(new Pen(Color.Blue, 2), x, ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin1 / 28) * (ly / 2 - 10)),
                   // x + 1, ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin2 / 28) * (ly / 2 - 10)));
               // g.DrawLine(new Pen(Color.Green, 2), x, ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin1 / 33) * (ly / 2 - 10)),
                   // x + 1, ly / 2 + (int)(Math.Sin(2 * Math.PI * xsin2 / 33) * (ly / 2 - 10)));
            }
        }*/

        
    }
}
