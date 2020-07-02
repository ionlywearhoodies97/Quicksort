using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    class Program
    {
        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            { 
                if (arr[j] < pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);

                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        static bool xCheck(int[] arr, int x)
        {
            bool flag = false;

            int n = arr.Length;
            quickSort(arr, 0, n - 1);

            int counter = 0;
            for(int i = 0; i < n-1; i++)
            {
                if (arr[i] == x)
                    counter++;

                if(counter >= 2)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        static void Main(string[] args)
        {
            Console.Write("Input: n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input: X = ");
            int x = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Element " + i + " = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            bool answer = xCheck(arr, x);

            if (answer)
            {
                Console.WriteLine("X can be found two times in sequence");
            }
            else
            {
                Console.WriteLine("X is not found two times in sequence");
            }

            Console.ReadLine();
        }
    }
}
