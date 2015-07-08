using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj6
{
    public partial class Form1 : Form
    {

        char[,] bitmatrix = new char[1000, 1000];
        char[] symbols = { 'o', '`', '@', '.', '<', '0', '#', '%', '^', '&', '*', '_', '-', '=', '+', '"', '$', '>', '/', '?', '~' };
        int i, j;
        Color c;
        char character;
        Bitmap bmp = new Bitmap(@"C:\Users\ana.palihovici\Documents\Visual Studio 2013\Projects\proj6\proj6\Ducky.png");
       

        public Form1()
        {
            InitializeComponent();

            textBox1.ReadOnly = true;
            textBox1.Text += "";

            //resize picture
            Bitmap bitmap = new Bitmap(bmp, new Size(bmp.Width / 10, bmp.Height / 10));

            //assign symbol for pixels in picture in grayscale
            for (i = 0; i < bitmap.Height; i++)
            {
                for (j = 0; j < bitmap.Width; j++)
                {   
                    //generate grayscale
                    c = bitmap.GetPixel(j, i);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                    bitmap.SetPixel(j, i, Color.FromArgb(gray, gray, gray));

                    //assign symbol
                    int sel = (int)(gray) / (symbols.Length);
                    int pos = (int)(sel)%(symbols.Length);
                    character = symbols[pos];

                    //store in matrix
                    bitmatrix[j, i] =character;
                   

                }
            }

            //print in textbox
            for (int k = 0; k < bitmap.Height; k+=2)
            {
                for (int l = 0; l < bitmap.Width; l+=2)
                {
                    textBox1.Text += bitmatrix[l, k]+ "     ";
                }
                
                textBox1.Text += "\r\n";
                textBox1.Text += "\r\n";
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { 
            //resize and show grayscale image
            Bitmap bitmap = new Bitmap(bmp);

            Bitmap bmap = (Bitmap)bitmap.Clone();
            Color c;
           
            for (i = 0; i < bmap.Height; i++)
            {
                for (j = 0; j < bmap.Width; j++)
                {
                    c = bmap.GetPixel(j, i);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                    bmap.SetPixel(j, i, Color.FromArgb(gray, gray, gray));
              
                }
            }
          
            bitmap = (Bitmap)bmap.Clone();
            e.Graphics.DrawImage(bitmap, 60, 10);
        }

      
        }
    }

