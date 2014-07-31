using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace mm_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }

    public enum Color
    {
        Red, Green, Blue, Yellow, Purple, Turquoise,
    }

    class Manager
    {
        ArrayList possibilities;
        Row answer;
        private Random rand;


        public Manager()
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
                            to_send[0] = new Slot((Color)i);
                            to_send[1] = new Slot((Color)j);
                            to_send[2] = new Slot((Color)k);
                            to_send[3] = new Slot((Color)l);

                            possibilities.Add(new Row(to_send));
                        }

                    }

                }

            }
            //Finished creating possiblities

            //Choose an answer for the guesser to guess
            rand = new Random();
            answer = (Row)possibilities[rand.Next(possibilities.Count)];

        }


    }

    class Response
    {

    }

    class Row
    {
        public Slot[] row { get; set; }
        public int white_pins { get; set; }
        public int black_pins { get; set; }

        public Row(Slot[] peg_list)
        {
            this.row = peg_list;
        }

        public override string ToString()
        {
            return String.Format("Row:\t {0}\t{1}\t{2}\t{3}", row[0], row[1], row[2], row[3]);
        }
    }

    class Slot
    {
        public Color color { get; set; }

        public Slot(Color color)
        {
            this.color = color;    
        }

        public override string ToString()
        {
            return this.color.ToString().ToCharArray()[0].ToString();
        }
        
    }

    
}
