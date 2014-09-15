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
            // made one random that everybody can call it
       

        }

        public static void logic(Random rnd)
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
                Console.WriteLine(manager.answer.ToString() + " answer\n");
                Console.WriteLine(a.ToString() + " guess\n");
                Console.WriteLine(a.black_pins + " " + a.white_pins);
                
                //goes threw the hole array from up to down and erases the not possible options
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

            Console.WriteLine("it took " + count + " times");

        }

        //function that checks how many are at the same place
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
    }

    public enum Color
    {
        Red, Green, Blue, Yellow, Purple, Turquoise,
    }

    class Manager
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

    class Row
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

    class Slot
    {
        public Color color { get; set; }
        public int numcolor { get; set; }

        public Slot(int Color1)
        {
            this.color = (Color)Color1;
            this.numcolor = Color1;
        }

        public override string ToString()
        {
            return this.color.ToString();//.ToCharArray()[0].ToString();
        }

    }


}
