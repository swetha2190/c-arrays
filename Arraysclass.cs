using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALL_BY_REF_AND_NUM
{
    class Arraysclass
    {
        int[] a;

        public void CountOfEvenOdd()
        {

            int count = 0, temp = 0;

            Console.WriteLine("enter number of elements");
            int N = Convert.ToInt32(Console.ReadLine());

            a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] % 2 == 0)
                {
                    count++;
                }
                else
                {
                    temp++;

                }
            }
            Console.WriteLine("count of even numbers is {0}", count);
            Console.WriteLine("count of odd numbers is {0}", temp);


        }

        

        public bool CheckPrime(int n)
        {
            int j;
            bool ch = true;
            for(j=2;j<n;j++)
            {
                if(n % j==0)
                {
                    ch = false;
                    break;
                }
            }
            if(j==n)
            {
                ch = true;
            }
            return ch;


        }

        public void PrintingPrimeNumbers()
        {
            int count = 0;
           
            int i;

            for (i = 0; i < 5; i++)
            {
                if (CheckPrime(i))
                {
                    count++;

                    Console.WriteLine("prime numbers are{0}", a[i]);
                    

                }
            }

            Console.WriteLine("count of prime numbers is ::{0}", count);

        }

        public void ReversingArray()
        {
            int[] arr = new int[5];
            int j;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter value ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

             Array.Reverse(arr);

            Console.WriteLine("after reversing array");
            for ( j = 0; j < 5; j++)
            {

                Console.WriteLine(arr[j]);
            }

            Array.Sort(arr);

            Console.WriteLine("after sorting array {0}",arr[j]);
            Console.WriteLine("minimum of array is{0}", arr[0]);
            Console.WriteLine("max of array is {0}", arr[4]);
        }

       
    }
}
