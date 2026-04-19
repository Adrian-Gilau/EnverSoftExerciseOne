using System;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Two arrays/lists as follows:

            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };



            // ========================================================
            // Method 1
            // Using LINQ: Intersect and Except
            // ========================================================

            Console.WriteLine("Method 1:");

            // a.i. Show the common elements in both lists.

            int[] list3 = list1.Intersect(list2).ToArray();

            Console.WriteLine(string.Join(" ", list3));



            // b.i. Show the elements from list1, not found in list2.

            int[] list4 = list1.Except(list2).ToArray();

            Console.WriteLine(string.Join(" ", list4));



            // c.i. Show the elements from list2, not found in list1.

            int[] list5 = list2.Except(list1).ToArray();

            Console.WriteLine(string.Join(" ", list5));



            // ========================================================
            // Method 2
            // Using LINQ: Where, Contains, IEnumerable
            // ========================================================

            Console.WriteLine("Method 2:");

            // a.ii. Common elements

            IEnumerable<int> listSharedIntegers = 
                list1.Where(x => list2.Contains(x));

            Console.WriteLine(string.Join(" ", listSharedIntegers));



            // b.ii. Items unique to list1
            IEnumerable<int> listOneUniqueIntegers = 
                list1.Where(x => !list2.Contains(x));

            Console.WriteLine(string.Join(" ", listOneUniqueIntegers));



            // c.ii. Items unique to list2
            IEnumerable<int> listTwoUniqueIntegers = 
                list2.Where(x => !list1.Contains(x)); 

            Console.WriteLine(string.Join(" ", listTwoUniqueIntegers));



            // ========================================================
            // Method 3
            // Manual loop-based method
            // ========================================================

            Console.WriteLine("Method 3:");

            // a.iii. Common elements

            foreach (int x in list1)
            {
                foreach (int y in list2)
                {
                    if (x == y)
                    {
                        Console.Write(x + " ");
                    }
                }
            }

            Console.WriteLine();



            // b.iii. Items unique to list1

            foreach (int x in list1)
            {
                bool found = false;

                foreach (int y in list2)
                {
                    if (x == y)
                    {
                        found = true;
                    }
                }

                if (found != true)
                {
                    Console.Write(x + " ");
                }
            }

            Console.WriteLine();


            // c.iii. Items unique to list2

            foreach (int x in list2)
            {
                bool found = false;

                foreach (int y in list1)
                {
                    if (x == y)
                    {
                        found = true;
                    }
                }

                if (found != true)
                {
                    Console.Write(x + " ");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
            
        }
    }
}