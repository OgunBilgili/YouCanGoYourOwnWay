using System;

namespace YouCanGoYourOwnWay
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

            int limit = Int32.Parse(Console.ReadLine());
            
            char[] lydiasPath = "EESSSESE".ToCharArray();
            char[,] origin = new char[limit,limit];



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


*/
