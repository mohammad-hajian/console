using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classintoclass
{
    class Person
    {
        public Person()
        {

        }
        public Person(string fullName)
        {
            FullName = fullName;
        }
        public Person(string fullName, int age)
            : this(fullName)
        {
            Age = age;
        }
        private int _age;
        private string _fullName;
        public int Age { get { return _age; } set { _age = value; } }
        public string FullName { get { return _fullName; } set { _fullName = value; } }
        public void ShowInfo()
        {
            Console.WriteLine($"fullName is {_fullName} and age is {_age}");
        }
    }
    class Factory
    {
        public Factory()
        {

        }
        public Factory(string name)
        {
            Name = name;
        }
        private Person _manager;
        private string _name;
        public Person Manager { get { return _manager; } set { _manager = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public void ShowInfo()
        {
            Console.WriteLine($"name is {Name}");
            if (Manager != null)
            {
                Manager.ShowInfo();
            }
        }
    }
    class Program000
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory("hajians factory");
            factory.ShowInfo();
            Console.WriteLine("-------------------");
            /////////////////////////////////////////////////
            Person person = new Person("mohammad hajian", 21);
            factory.Manager = person;
            factory.ShowInfo();
        }
    }
}
