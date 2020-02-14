using System;

namespace ArrayTest
{
    class Class1
    {
        static int ArTest(int[] a)
        {
            int tester = 1;

            Array.Sort(a);

            foreach (int i in a)
            {
                if (i == tester && i < 100)
                {
                    tester++;
                }
                else
                {
                    break;
                }
            }
            Console.Write("{0} is the smallest positive integer (greater than 0) that does not occur in A", tester);
            return tester;
        }

        static void Main()
        {
            int[] test = new int[] { 5, 3, 4, 9, 2, 1, 6, 18, 35, 7, 8 };
            ArTest(test);
        }
    }
}
