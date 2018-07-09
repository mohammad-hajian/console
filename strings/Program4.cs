using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsText
{
    class Program4
    {
        static void Main(string[] args)
        {
            string str1 = "mohammad hajian";
            string str2 = "MOHAMMAD HAJIAN";
            Console.WriteLine($"avalin harf hast: {str1[0]}");
            Console.WriteLine($"avalin matn hast: {str1}");
            Console.WriteLine($"dovomin matn hast: {str2}");
            if (str1 == str2)
            {
                Console.WriteLine($"{str1} , {str2} mesle ham hastand.");
            }
            else
            {
                Console.WriteLine($"{str1} , {str2} mesle ham nistand.");
            }

            if (String.Compare(str1, str2, true) == -1)
            //*1     //Case Insensitive==> !!حساس بودن به بزرگ و کوچک بودن!! ==>
            // اگر تروو بدهیم اعمال نمیشود (مهم: نمیشود) و اگر فالس بدهیم اعمال میشود
            //*2     // در اینجا اگر مساوی صفر بود یعنی مثل هم هستند و اگر منفی یک بود یعنی مثل هم نیستند
            {
                Console.WriteLine($"{str1} , {str2} mesle ham hastand.");
            }
            else
            {
                Console.WriteLine($"{str1} , {str2} mesle ham nistand.");
            }
            int intTemp;
            bool blnTemp;
            intTemp = str1.Length;
            str1 = str1.TrimStart();
            str1 = str1.TrimEnd();
            str1 = str1.Trim();
            str1 = str1.ToUpper();
            str1 = str1.ToLower();
            blnTemp = str1.Equals(str2);
            intTemp = str1.CompareTo(str2);
            blnTemp = str1.StartsWith("m");
            blnTemp = str1.StartsWith("D");
            intTemp = str1.IndexOf("d");
            //Console.WriteLine(intTemp);
            //Console.ReadLine();
            str1 = str1.Remove(2, 2);
            str2 = str1.Substring(2, 2);
            str1 = str1.Replace("o", "r");
            str1 = str1.Insert(2, "y");
            str1 = str1.PadLeft(10, '!');//اونقدر ! اضافه میکنیم که تعداد کارکتر ها به 10 تا برسد
            str1 = str1.PadRight(10, '!');
            /////////////////////////////////////////////////////////////
            string[] anyString;
            anyString = str1.Split('m', ' ');
            foreach (var str in anyString)
            {
                Console.WriteLine(str);
            }
            str1.ToString();
            ////////////////////// system.text ///////////////////////////////////////
            StringBuilder builder = new StringBuilder();
            Console.WriteLine($"Length ==>             {builder.Length}");//0
            Console.WriteLine($"Capacity ==>             {builder.Capacity}");//16
            Console.WriteLine($"Max Capacity ==>             {builder.MaxCapacity}");//about 2 GB
            Console.WriteLine($"Length ==>             {builder}");//
            Console.WriteLine("-------------------------------");

            builder.Append("Hello");
            Console.WriteLine($"Length ==>             {builder.Length}");//5
            Console.WriteLine($"Capacity ==>             {builder.Capacity}");//16
            Console.WriteLine($"Max Capacity ==>             {builder.MaxCapacity}");//about 2 GB
            Console.WriteLine($"Length ==>             {builder}");//Hello
            Console.WriteLine("-------------------------------");

            builder.Append("Hello.How are you? I'm mohammad hajian.");
            Console.WriteLine($"Length ==>             {builder.Length}");//44
            Console.WriteLine($"Capacity ==>             {builder.Capacity}");//44
            Console.WriteLine($"Max Capacity ==>             {builder.MaxCapacity}");//about 2 GB
            Console.WriteLine($"Length ==>             {builder}");//Hello.How are you? I'm mohammad hajian.
            Console.WriteLine("-------------------------------");

            builder.Remove(0, builder.Length);
            Console.WriteLine($"Length ==>             {builder.Length}");//0
            Console.WriteLine($"Capacity ==>             {builder.Capacity}");//44 !!ظرفیت پر شده خالی نمیشود!!
            Console.WriteLine($"Max Capacity ==>             {builder.MaxCapacity}");//about 2 GB
            Console.WriteLine($"Length ==>             {builder}");//
        }
    }
}
