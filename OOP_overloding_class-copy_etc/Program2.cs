using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_overloding_classcopy_etc
{
    public enum PersonEzdevaj
    {
        mojarad, badbakht, rahat
    }
    public enum PersonJensiat
    {
        mard = 4, zan
    }
    //######################################################//
    class Person
    {
        public int Age;
        public string Nam;
        public PersonEzdevaj Ezdevaj;
        public PersonJensiat Jensiat;
        //######################################################//
        public Person()
        {

        }
        public Person(int age, string nam, PersonEzdevaj ezdevaj, PersonJensiat jensiat)
        {
            Age = age;
            Nam = nam;
            Ezdevaj = ezdevaj;
            Jensiat = jensiat;
        }
        public Person(Person person)
        {
            Age = person.Age;
            Nam = person.Nam;
            Ezdevaj = person.Ezdevaj;
            Jensiat = person.Jensiat;
        }
        public void Showinfo()
        {
            Console.WriteLine($"age:{Age} , nam:{Nam} , jensiat:{Jensiat} , ezdevaj:{Ezdevaj}");
        }
    }
    //######################################################//
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(34, "asiye", PersonEzdevaj.badbakht, PersonJensiat.zan);
            Person person2 = new Person()
            {
                Age = 21,
                Nam = "mohammad",
                Ezdevaj = PersonEzdevaj.mojarad,
                Jensiat = PersonJensiat.mard
            };
            Person person3 = new Person(person2)
            {
                Age = 21,
                Nam = "mahdi",
                Ezdevaj = PersonEzdevaj.mojarad,
                Jensiat = PersonJensiat.mard
            };
            person1.Showinfo();
            person2.Showinfo();
            person3.Showinfo();
            //یا ==>   
            Console.WriteLine($"age:{person3.Age} , nam:{person3.Nam} , jensiat:{person3.Jensiat} , ezdevaj:{person3.Ezdevaj}");
            //یا ==>
            switch (person3.Jensiat)
            {
                case PersonJensiat.mard:
                    {
                        Console.WriteLine("oo mard ast.");
                        break;
                    }
                case PersonJensiat.zan:
                    {
                        Console.WriteLine("oo zan ast.");
                        break;
                    }
            }
        }
    }
}