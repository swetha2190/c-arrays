using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWO_D_ARRAYS
{
    class TwoDclass
    {
        int[,] arr;

        public void  DisplayArray()
        {

            Console.WriteLine("enter row size");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter COLUMN size");
            int column = Convert.ToInt32(Console.ReadLine());

            arr = new int[row, column];

            Console.WriteLine("enter elements of first array");
            

            for(int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("elements entered are");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine("arr[{0},{1}] = {2}", i, j, arr[i, j]);
                }

            }
            Console.WriteLine();
        }

        public void addition()
        {

            int[,] arr1 = new int[2, 3];
            int[,] arr2 = new int[2, 3];
            int[,] result = new int[2, 3];

            Console.WriteLine("enter elements of first array");


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i, j] = Int32.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine();

            

            Console.WriteLine("enter second array elements");
            for (int i= 0; i < 2; i++)
            {
                for (int j=0;j<3;j++)
                {
                   arr2[i,j]= Int32.Parse(Console.ReadLine());
                }
            }



            Console.WriteLine("elements after adding are::");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = arr1[i, j] + arr2[i, j];

                    Console.Write(result[i, j] + " ");
                }

                Console.WriteLine();




            }

        }
    }
}


