using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PracticeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        private static void SecondTask()
        {
            ArrayList list = new ArrayList();
            Random random = new Random();
            int size = 10;
            int sum = 0;
            double average = 0;
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(-100, 100));
                sum += (int)list[i];
            }

            foreach (var item in list)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            average = sum / size;
            Console.WriteLine("Среднее арифметическое коллекции: {0}\n", average);

            foreach (var item in list)
                if ((int)item > average) Console.Write(item + " ");

                 Console.ReadLine();
        }

        private static void FirstTask()
        {
            ArrayList list = new ArrayList();
            Random random = new Random();
            int size = 10;
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(-100, 100));
            }

            foreach (var item in list)
            {
                Console.Write(item+ " ");
            }

            for (int i = list.Count - 1; i >= 0; i--)
                if ((int)list[i] % 2 != 0) list.Remove(list[i]);

            foreach (var item in list)
                Console.Write("\n"+item + " ");

            Console.ReadLine();
        }
    }
}
