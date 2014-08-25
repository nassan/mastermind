using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mastermind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Aqua);
            SolidBrush sbr = new SolidBrush(Color.IndianRed);
            SolidBrush sbgold = new SolidBrush(Color.Goldenrod);
            SolidBrush sbwhite = new SolidBrush(Color.White);
            SolidBrush sbblack = new SolidBrush(Color.Black);
            SolidBrush sbblue = new SolidBrush(Color.Blue);
            SolidBrush sbgreen = new SolidBrush(Color.Green);
            SolidBrush sbyello = new SolidBrush(Color.Yellow);
            SolidBrush sbpurpal = new SolidBrush(Color.Purple);
            SolidBrush sbTurquoise = new SolidBrush(Color.Turquoise);
            Pen pen = new Pen(Color.Olive, 5);
            FontFamily ff = new FontFamily("Courier New");
            System.Drawing.Font font = new System.Drawing.Font(ff, 17, FontStyle.Bold);
            Graphics g = panel1.CreateGraphics();
          
            
            g.FillRectangle(sb, 20, 0, 1500, 1500);
            g.DrawString("Master mind", font, sbgold, new PointF(130, 5));
            //line one
            int y = 590, x = 75;
            g.FillRectangle(sbgold, 75, 590, 290, 70);
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbwhite, 310, y + 10, 20, 20);
            g.FillEllipse(sbblack, 310, y + 40, 20, 20);
            g.FillEllipse(sbwhite, 340, y + 10, 20, 20);
            g.FillEllipse(sbblack, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end
            //line two
            y = 510; x = 75;
            g.FillRectangle(sbgold, 75, 510, 290, 70);
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbwhite, 310, y + 10, 20, 20);
            g.FillEllipse(sbblack, 310, y + 40, 20, 20);
            g.FillEllipse(sbwhite, 340, y + 10, 20, 20);
            g.FillEllipse(sbblack, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end
            //line three
            y = 430; x = 75;
            g.FillRectangle(sbgold, 75, 430, 290, 70);
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbwhite, 310, y + 10, 20, 20);
            g.FillEllipse(sbblack, 310, y + 40, 20, 20);
            g.FillEllipse(sbwhite, 340, y + 10, 20, 20);
            g.FillEllipse(sbblack, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end
            //line four
            y = 350; x = 75;
            g.FillRectangle(sbgold, 75, 350, 290, 70);
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbwhite, 310, y + 10, 20, 20);
            g.FillEllipse(sbblack, 310, y + 40, 20, 20);
            g.FillEllipse(sbwhite, 340, y + 10, 20, 20);
            g.FillEllipse(sbblack, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end
            //line five
            y = 270; x = 75;
            g.FillRectangle(sbgold, 75, 270, 290, 70);
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbwhite, 310, y + 10, 20, 20);
            g.FillEllipse(sbblack, 310, y + 40, 20, 20);
            g.FillEllipse(sbwhite, 340, y + 10, 20, 20);
            g.FillEllipse(sbblack, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end
            //line six
            y = 190; x = 75;
            g.FillRectangle(sbgold, 75, 190, 290, 70);
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbwhite, 310, y + 10, 20, 20);
            g.FillEllipse(sbblack, 310, y + 40, 20, 20);
            g.FillEllipse(sbwhite, 340, y + 10, 20, 20);
            g.FillEllipse(sbblack, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end
           //line seven
            y = 110; x = 75;
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbwhite, 310, y + 10, 20, 20);
            g.FillEllipse(sbblack, 310, y + 40, 20, 20);
            g.FillEllipse(sbwhite, 340, y + 10, 20, 20);
            g.FillEllipse(sbblack, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end

            //line eight
             y = 30;x=75;
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x+=5, y+10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbwhite, 310, y + 10, 20, 20);
            g.FillEllipse(sbblack, 310, y+40, 20, 20);
            g.FillEllipse(sbwhite, 340, y + 10, 20, 20);
            g.FillEllipse(sbblack, 340, y+40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y+70);
            // end
            // g.DrawRectangle(pen, 40, 60, 50, 50);
    
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }
}
