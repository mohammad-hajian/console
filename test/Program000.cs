using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class person
    {
        public person()
        {

        }
        public person(int age,string firstName, string lastName)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        private int _age;
        private string _firsName;
        private string _lastName;
        public int Age { get { return (_age); }
            set
            {
                if ((value >= 0) && (value <= 99)) { _age = value; }
                
            } }
        public string FirstName { get { return (_firsName); } set {_firsName=value; } }
        public string LastName { get { return (_lastName); } set { _lastName = value; } }

        public void ShowInfo()
        {
            Console.WriteLine($"age: {_age}, firstname: {_firsName}, lastname: {_lastName}");
        }
    }
    class Program000
    {
        static void Main(string[] args)
        {
            person person1 = new person(20, "mohammad", "hajian");
            person1.ShowInfo();
            if (person1.Age > 10) Console.WriteLine("mashalla");
        }
    }
}
