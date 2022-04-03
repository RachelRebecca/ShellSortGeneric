using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSortGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
             
            //create int array
            int[] intArray = testInt(new int[] { 5, 1, 20, 8, 14, 10, 9, 13, 6, 11, 15, 18, 17, 9, 7, 12 });
            foreach (int intIndex in intArray)
            {
                Console.WriteLine(intIndex);
            }

            Console.WriteLine();


            //create string array
            string[] strArray = testStr(new string[] { "Beautiful!", "It all worked:)", "Amazing!", "123"});

            foreach (string strIndex in strArray)
            {
                Console.WriteLine(strIndex);
            }
        }

        public static int[] testInt(int[] array)
        {
            GenericShellSorter<int> gssInt = new GenericShellSorter<int>();
            return gssInt.sort(array);
        }

        public static String[] testStr(string[] array)
        {
            GenericShellSorter<string> gssStr = new GenericShellSorter<string>();
            return gssStr.sort(array);
        }
    }

}
