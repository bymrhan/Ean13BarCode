using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing; // yazmak için

namespace barkodolustur
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

        private void button1_Click(object sender, EventArgs e)
        {
            

            PrintDocument doc = new PrintDocument(); //yazmak içim

            Ean13Barcode2005.Ean13 barcode = new Ean13Barcode2005.Ean13();





            //bu kod barkodun ilk 2 hanesi -ülke kodu

            barcode.CountryCode = btncountrycode.Text;



            //Bu kod üretici-imalatçı numarası -bu kısımın legal illegal gibi durumları da var

            barcode.ManufacturerCode = textBox2.Text;



            //Bu kod ürün kodu
            barcode.ProductCode = textBox3.Text;

            //Bu kısım boş geçilsede birşey değişmiyor EAN-13 te zaten 12 veri okuyorsunuz ,bu sayı  barkodun sonunda oluyor. kontrol kodu
            barcode.ChecksumDigit = "5";


            pictureBox1.Image = barcode.CreateBitmap();


            Bitmap bitmap = new Bitmap(pictureBox1.Image);

            Graphics grafik = Graphics.FromImage(bitmap);




            Graphics g = pictureBox1.CreateGraphics();
        }
    }
}
