using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class person
    {
        public person()
        {
        }
        public int Age;
        public string FullName;

    }
    class Program5
    {
        static void Main(string[] args)
        {
            int[] arrayIntNumbers = new int[2];
            arrayIntNumbers[0] = 5;
            arrayIntNumbers[1] = 10;
            person[] person1 = new person[2];
            //wrong==>
            //person1[0].Age=20;
            person1[0] = new person();
            person1[1] = new person();
            //یا ==>
            for (int i = 0; i < person1.Length; i++)
            {
                person1[i] = new person();
            }
            person1[0].Age = 21;
            person1[0].FullName = "mohammad hajian";

            /////////////////////////////////////////////////////////////////////////////

            int[,] rectangularArray = new int[2, 3];//rectangular Array
            rectangularArray[0, 0] = 5;
            rectangularArray[0, 1] = 6;
            rectangularArray[0, 2] = 7;
            rectangularArray[1, 0] = 8;
            rectangularArray[1, 1] = 9;
            rectangularArray[1, 2] = 10;

            int[][] jaggedArray = new int[3][];//jaggedArray
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0][0]= 5;
            jaggedArray[1][0]= 6;
            jaggedArray[1][1]= 7;
            jaggedArray[1][2]= 8;
            jaggedArray[2][0]= 9;
            jaggedArray[2][1]= 10;
        }
    }
}
