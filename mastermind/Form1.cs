using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace mastermind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Aqua);
            SolidBrush sbr = new SolidBrush(Color.Gray);
            SolidBrush sbgold = new SolidBrush(Color.Goldenrod);
            SolidBrush sbwhite = new SolidBrush(Color.White);
            SolidBrush sbblack = new SolidBrush(Color.Black);
            SolidBrush sbblue = new SolidBrush(Color.Blue);
            SolidBrush sbgreen = new SolidBrush(Color.Green);
            SolidBrush sbyello = new SolidBrush(Color.Yellow);
            SolidBrush sbpurpal = new SolidBrush(Color.Purple);
            SolidBrush sbTurquoise = new SolidBrush(Color.Turquoise);
            SolidBrush sbred = new SolidBrush(Color.DarkRed);
            Pen pen = new Pen(Color.Olive, 5);
            FontFamily ff = new FontFamily("Courier New");
            System.Drawing.Font font = new System.Drawing.Font(ff, 17, FontStyle.Bold);
            Graphics g = panel1.CreateGraphics();


            g.FillRectangle(sb, 20, 0, 1500, 1500);
            g.DrawString("Master mind", font, sbgold, new PointF(130, 5));
            //line one
            int y = 590, x = 75;
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end
            //line two
            y = 510; x = 75;
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end
            //line three
            y = 430; x = 75;
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end
            //line four
            y = 350; x = 75;
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end
            //line five
            y = 270; x = 75;
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
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
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end
            //line seven
            y = 110; x = 75;
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            //end

            //line eight
            y = 30; x = 75;
            g.FillRectangle(sbgold, x, y, 290, 70);
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            g.DrawLine(pen, 305, y, 305, y + 70);
            // end
            // g.DrawRectangle(pen, 40, 60, 50, 50);
    

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public SolidBrush Pingui(Row row, int line)
        {
            if (row.black_pins + row.white_pins >= line)
            {
                if (line <= row.black_pins)
                {
                    SolidBrush sbblack = new SolidBrush(Color.Black);
                    return sbblack;
                }
                else
                    if (line > row.black_pins && line <= row.black_pins + row.white_pins)
                    {
                        SolidBrush sbwhite = new SolidBrush(Color.White);
                        return sbwhite;
                    }
            }

            SolidBrush sbgold = new SolidBrush(Color.Goldenrod);
            return sbgold;

        }
        public SolidBrush brush(Row row, int line)
        {
            switch (row.row[line].numcolor)
            {
                case 0:
                    SolidBrush sbred = new SolidBrush(Color.DarkRed);
                    return sbred;
                case 1:
                    SolidBrush sbgreen = new SolidBrush(Color.Green);
                    return sbgreen;
                case 2:
                    SolidBrush sbblue = new SolidBrush(Color.Blue);
                    return sbblue;
                case 3:
                    SolidBrush sbyello = new SolidBrush(Color.Yellow);
                    return sbyello;
                case 4:
                    SolidBrush sbpurpal = new SolidBrush(Color.Purple);
                    return sbpurpal;
                case 5:
                    SolidBrush sbTurquoise = new SolidBrush(Color.Turquoise);
                    return sbTurquoise;
                default:
                    SolidBrush sbr = new SolidBrush(Color.Gray);
                    return sbr;

            }
        }
        
        public void graphics(int line, Row row,Manager manager)
        {
            Graphics g = panel1.CreateGraphics();
            Graphics g1 = panel2.CreateGraphics();
            int w = 40, z = 40;
            g1.FillEllipse(brush(manager.answer, 0), w += 5, z + 10, 50, 50);
            g1.FillEllipse(brush(manager.answer, 1), w += 55, z + 10, 50, 50);
            g1.FillEllipse(brush(manager.answer, 2), w += 55, z + 10, 50, 50);
            g1.FillEllipse(brush(manager.answer, 3), w += 55, z + 10, 50, 50);
            int y = 590, x = 75;
            switch (line)
            {
                case 0:
                    g.FillEllipse(brush(row, 0), x += 5, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 1), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 2), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 3), x += 55, y + 10, 50, 50);
                    //pins
                    g.FillEllipse(Pingui(row, 1), 310, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 2), 310, y + 40, 20, 20);
                    g.FillEllipse(Pingui(row, 3), 340, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 4), 340, y + 40, 20, 20);
                    break;
                case 1:
                    y = 510; x = 75;
                    g.FillEllipse(brush(row, 0), x += 5, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 1), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 2), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 3), x += 55, y + 10, 50, 50);
                    //pins
                    g.FillEllipse(Pingui(row, 1), 310, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 2), 310, y + 40, 20, 20);
                    g.FillEllipse(Pingui(row, 3), 340, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 4), 340, y + 40, 20, 20);
                    break;
                case 2:
                    y = 430; x = 75;
                    g.FillEllipse(brush(row, 0), x += 5, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 1), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 2), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 3), x += 55, y + 10, 50, 50);
                    //pins
                    g.FillEllipse(Pingui(row, 1), 310, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 2), 310, y + 40, 20, 20);
                    g.FillEllipse(Pingui(row, 3), 340, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 4), 340, y + 40, 20, 20);
                    break;
                case 3:
                    y = 350; x = 75;
                    g.FillEllipse(brush(row, 0), x += 5, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 1), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 2), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 3), x += 55, y + 10, 50, 50);
                    //pins
                    g.FillEllipse(Pingui(row, 1), 310, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 2), 310, y + 40, 20, 20);
                    g.FillEllipse(Pingui(row, 3), 340, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 4), 340, y + 40, 20, 20);
                    break;
                case 4:
                    y = 270; x = 75;
                    g.FillEllipse(brush(row, 0), x += 5, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 1), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 2), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 3), x += 55, y + 10, 50, 50);
                    //pins
                    g.FillEllipse(Pingui(row, 1), 310, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 2), 310, y + 40, 20, 20);
                    g.FillEllipse(Pingui(row, 3), 340, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 4), 340, y + 40, 20, 20);
                    break;
                case 5:
                    y = 190; x = 75;
                    g.FillEllipse(brush(row, 0), x += 5, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 1), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 2), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 3), x += 55, y + 10, 50, 50);
                    //pins
                    g.FillEllipse(Pingui(row, 1), 310, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 2), 310, y + 40, 20, 20);
                    g.FillEllipse(Pingui(row, 3), 340, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 4), 340, y + 40, 20, 20);
                    break;
                case 6:
                    y = 110; x = 75;
                    g.FillEllipse(brush(row, 0), x += 5, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 1), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 2), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 3), x += 55, y + 10, 50, 50);
                    //pins
                    g.FillEllipse(Pingui(row, 1), 310, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 2), 310, y + 40, 20, 20);
                    g.FillEllipse(Pingui(row, 3), 340, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 4), 340, y + 40, 20, 20);
                    break;
                case 7:
                    y = 30; x = 75;
                    g.FillEllipse(brush(row, 0), x += 5, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 1), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 2), x += 55, y + 10, 50, 50);
                    g.FillEllipse(brush(row, 3), x += 55, y + 10, 50, 50);
                    //pins
                    g.FillEllipse(Pingui(row, 1), 310, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 2), 310, y + 40, 20, 20);
                    g.FillEllipse(Pingui(row, 3), 340, y + 10, 20, 20);
                    g.FillEllipse(Pingui(row, 4), 340, y + 40, 20, 20);
                    break;
                default:
                    MessageBox.Show("The computer lost! :-(");
                    break;
            }
        }
        public void logic(Random rnd)
        {

            Manager manager = new Manager(rnd);
            Row a = new Row();
            int count = 0;

            do
            {
                if (manager.possibilities.Count == 0)
                {
                    Console.WriteLine("mistake");
                    break;
                }
                a = manager.possibilities[rnd.Next(manager.possibilities.Count - 1)] as Row;
                a.pins(manager.answer, a);
                
                graphics(count, a,manager);
                //goes therw the hole array from up to down and ereases the not possiable options
                for (int i = manager.possibilities.Count - 1; i >= 0; i--)
                {
                    Row check = manager.possibilities[i] as Row;
                    int samePlace = HowManySamePlace(a, check);
                    int amount = HowManySameAll(a, check);
                    //the logic
                    if (a.black_pins != samePlace || amount > a.white_pins + a.black_pins)
                        manager.possibilities.RemoveAt(i);

                }
                count++;
            } while (a.black_pins < 4);


            //function that checks how many are at the same place
        }
        public static int HowManySamePlace(Row first, Row second)
        {
            int total = 0;
            for (int i = 0; i < first.row.Length; i++)
            {
                if (first.row[i].numcolor == second.row[i].numcolor)
                    total++;
            }
            return total;
        }
        //function that checks how many similaritis are their 
        public static int HowManySameAll(Row first, Row second)
        {
            int total = 0;
            bool[] didThisup = new bool[first.row.Length];
            bool[] didThisdown = new bool[second.row.Length];
            for (int i = 0; i < first.row.Length; i++)
            {
                for (int z = 0; z < second.row.Length; z++)
                {
                    if (first.row[i].numcolor == second.row[z].numcolor && didThisdown[z] == false && didThisup[i] == false)
                    {
                        total++;
                        didThisdown[z] = true;
                        didThisup[i] = true;
                    }
                }
            }
            return total;
        }
        public enum Colore
        {
            Red, Green, Blue, Yellow, Purple, Turquoise,

        }

        public class Manager
        {
            public ArrayList possibilities { get; set; }
            public Row answer { get; set; }

            public Manager()
            {

            }

            public Manager(Random rnd)
            {
                possibilities = new ArrayList();

                //Create the possibilities
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        for (int k = 0; k < 6; k++)
                        {
                            for (int l = 0; l < 6; l++)
                            {
                                Slot[] to_send = new Slot[4];
                                to_send[0] = new Slot(i);
                                to_send[1] = new Slot(j);
                                to_send[2] = new Slot(k);
                                to_send[3] = new Slot(l);

                                possibilities.Add(new Row(to_send));

                            }

                        }

                    }

                }
                //Finished creating possiblities

                //Choose an answer for the guesser to guess

                answer = (Row)possibilities[rnd.Next(possibilities.Count)];





            }



        }

        class Response
        {

        }

        public class Row
        {
            public Slot[] row { get; set; }
            public int white_pins { get; set; }
            public int black_pins { get; set; }


            public Row(Slot[] peg_list)
            {
                white_pins = 0;
                black_pins = 0;
                this.row = peg_list;
            }
            public Row()
            {

            }
            //creates the white and black pins
            public void pins(Row answer, Row row)
            {
                bool[] didThisup = new bool[answer.row.Length];
                bool[] didThisdown = new bool[row.row.Length];
                //black pins
                for (int i = 0; i < answer.row.Length; i++)
                {
                    if (answer.row[i].numcolor == row.row[i].numcolor)
                    {
                        row.black_pins++;
                        didThisdown[i] = true;
                        didThisup[i] = true;
                    }
                }
                //white pins
                for (int i = 0; i < answer.row.Length; i++)
                {
                    for (int z = 0; z < row.row.Length; z++)
                    {
                        if (answer.row[i].numcolor == row.row[z].numcolor && didThisdown[z] == false && didThisup[i] == false)
                        {
                            row.white_pins++;
                            didThisdown[z] = true;
                            didThisup[i] = true;
                        }
                    }
                }

            }
            //public static implicit operator Row(object i)
            //{
            //    Row a = new Row();

            //    return a.row;
            //}
            public override string ToString()
            {
                return String.Format("Row:\t {0}\t{1}\t{2}\t{3}", row[0], row[1], row[2], row[3]);
            }
        }

        public class Slot
        {
            public Colore color { get; set; }
            public int numcolor { get; set; }

            public Slot(int Color1)
            {
                this.color = (Colore)Color1;
                this.numcolor = Color1;
            }

            public override string ToString()
            {
                return this.color.ToString();//.ToCharArray()[0].ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SolidBrush sbr = new SolidBrush(Color.Gray);
            SolidBrush sbgold = new SolidBrush(Color.Goldenrod);
            SolidBrush sbgreen = new SolidBrush(Color.LightSeaGreen);
            FontFamily ff = new FontFamily("Comic Sans MS");
            System.Drawing.Font font = new System.Drawing.Font(ff, 17, FontStyle.Italic);
            Graphics g = panel1.CreateGraphics();
            Graphics g1 = panel2.CreateGraphics();
            g1.FillRectangle(sbgreen, 40, 40, 290, 70);
            g1.DrawString("The Answer Is", font, sbgreen, new PointF(50, 5));
            int y = 590, x = 75;
            //one
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            //two
            y = 510; x = 75;
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            //three
            y = 430; x = 75;
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            //four
            y = 350; x = 75;
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            //five
            y = 270; x = 75;
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            //six
            y = 190; x = 75;
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            //seven
            y = 110; x = 75;
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            //eight
            y = 30; x = 75;
            g.FillEllipse(sbr, x += 5, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbr, x += 55, y + 10, 50, 50);
            g.FillEllipse(sbgold, 310, y + 10, 20, 20);
            g.FillEllipse(sbgold, 310, y + 40, 20, 20);
            g.FillEllipse(sbgold, 340, y + 10, 20, 20);
            g.FillEllipse(sbgold, 340, y + 40, 20, 20);
            Random rnd = new Random();

            logic(rnd);
        }

        public void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }




}
