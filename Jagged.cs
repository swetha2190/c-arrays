using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWO_D_ARRAYS
{
    class Jagged
    {
        static void Main(string[] args)
        {


            Jagged obj = new Jagged();
            obj.Display();
            Console.ReadLine();

        }

        public void Display()
        {

            int[][] jarray = new int[3][];

            jarray[0] = new int[3] { 1, 2, 3 };

            jarray[1] = new int[4] { 4, 5, 6, 7 };
            jarray[2] = new int[5] { 12, 34, 56, 78, 99 };

            
            for(int i=0;i<jarray.Length;i++)
            {
                Console.WriteLine("elements of jagged aray :{0}", i);
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    

                    Console.WriteLine( jarray[i][j]+"\t");
                }
                Console.WriteLine();
            }
        }
        
    }
}
