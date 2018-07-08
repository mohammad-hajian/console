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
        private string _jobplace;
        public int Age { get { return _age; } set { _age = value; } }
        public string FullName { get { return _fullName; } set { _fullName = value; } }
        public string Jobplace { get { return _jobplace; } set { _jobplace = value; } }
        public void ShowInfo()
        {
            Console.WriteLine($"fullName is {_fullName}. \n age is {_age}.");
            if (Jobplace != null)
            {
                Console.WriteLine($"jobplace is {_jobplace}.");
            }
        }
    }
    class Factory
    {
        public Factory()
        {

        }
        public Factory(string name, Person manager)
        {
            Name = name;
            Manager = manager;
        }
        private Person _manager;
        private string _name;
        public Person Manager { get { return _manager; } set { _manager = value; _manager.Jobplace = this._name; } }
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
    class Program6
    {
        static void Main(string[] args)
        {
            Person person = new Person("mohammad hajian", 21);
            person.ShowInfo();
            Factory factory = new Factory("hajians factory", person);
            Console.WriteLine("-------------------");
            person.ShowInfo();
        }
    }
}
