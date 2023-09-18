using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ConsoleApp2
{
    class Program
    {
        enum DaysOfWeek
        {
            Monday = 5, Tuesday = 10, Wednesday = 15, Thursday = 20, Friday = 25, Saturday = 30, Sunday = 35
        }

        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int RandomNum = rnd.Next(1, 10);
            //int size = Convert.ToInt32(rnd);
            //int[] arrx = new int[size];
            //int[] arrx2 = new int[size];

            //int Even = 0, Odd = 0, Unique = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    arrx[i] = rnd.Next(1, 10);
            //    Console.WriteLine("Элемент массива " + i + " = " + arrx[i]);
            //}

            //foreach (int i in arrx)
            //{
            //    if (i % 2 == 0 && i != 0)
            //    {
            //        Even++;
            //    }
            //    if (i % 2 != 0 && i != 0)
            //    {
            //        Odd++;
            //    }
            //    if (i == 0)
            //    {
            //       Unique++;
            //    }
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        arrx2[i] = arrx[j];
            //    }
            //}

            //DaysOfWeek day = DaysOfWeek.Monday;
            //Console.WriteLine(day);
            //int[] arr = new int[10] {0,1,2,3,4,5,6,7,8,9 };
            //int[,] arr2 = new int[16, 16];
            //int[][] arr3 = new int[2][];

            //string str = "Hello"; //не изменяется

            //arr3[0] = new int[] { 1, 2 };
            //arr3[1] = new int[] { 3, 4 };
            //Console.WriteLine(arr3[1][0]);

            //int sum = 0;

            //foreach (int i in arr)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //int resultEv = 0;
            //int resultOd = 0;
            //int resultUn = 0;

            //foreach (int i in arr)
            //{
            //    if (i % 2 == 0 && i != 0)
            //    {
            //        resultEv ++;
            //    }
            //    if (i % 2 != 0 && i != 0)
            //    {
            //        resultOd ++;
            //    }
            //    if (i == 0)
            //    {
            //        resultUn ++;
            //    }

            //}
            //Console.WriteLine(resultEv);
            //Console.WriteLine(resultOd);
            //Console.WriteLine(resultUn);

            string sentence = "Куда ты попал?";
            sentence = sentence.Trim(new char[] { ',', '.', '?' });
            string[] textArray = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Слова: " + textArray.Length);

            Random rnd = new Random();
            int length;
            length = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[length];
            int min, max;
            int RandomNum = rnd.Next(1, 10);
            for (int i = 0; i < length; i++)
            {
                Array[i] = rnd.Next(1, 10);
                Console.WriteLine(Array[i]);
            }
            min = Array[0];
            max = Array[0];
            foreach(int i in Array)
            {
                if (min > i)
                {
                    min = i;
                }
                if (max < i)
                {
                    max = i;
                }
            }
            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);
        }
    }
}