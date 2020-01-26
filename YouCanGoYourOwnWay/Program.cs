using System;
using System.Collections.Generic;
using System.Text;

namespace YouCanGoYourOwnWay
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

            int limit = Int32.Parse(Console.ReadLine());
            Stack<char> Marker = new Stack<char>();

            StringBuilder sb = new StringBuilder();
            

            char[] lydiasPath = "EESSSESE".ToCharArray();
            char[,] origin = new char[limit,limit];

            bool MarkE = false, MarkS = false;

            for(int a = 0; a < lydiasPath.Length ;)
            {

                if(lydiasPath[a] == 'E')
                {
                    while (!MarkS)
                    {
                        if (lydiasPath[a] == 'S')
                            MarkS = true;
                        sb.Append(lydiasPath[a]);
                        a++;
                    }+

                    MarkS = false;
                }

            }


            EES SSE SE
                
            SEE ESS ES


        }
    }
}


/*

            foreach (char v in lydiasPath)
                Console.WriteLine("Lydia's Path : {0}", v);

            //int[,] array2D = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            //int cases = Int32.Parse(Console.ReadLine());

            //string lydiasPath = Console.ReadLine();

            Console.WriteLine("\n---------------\n");
            foreach (char z in origin)
                Console.WriteLine("Origin {0}", z);



            //int[,] array = new int[limit+1, limit+1];

           

            //Console.WriteLine(array[3,3]);

            for(int i=0; i < lydiasPath.Length; i++)
            {
                if (lydiasPath[i] == 'E')
                {
                    origin[x, y] = 'E';
                    y += 1;
                }

                else
                {
                    origin[x, y] = 'S';
                    x += 1;
                }
            }

*/
