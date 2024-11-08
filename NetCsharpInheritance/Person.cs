using Microsoft.VisualBasic;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpInheritance
{
    internal class Person
    {
        protected string name {   get; set; }
        protected string surname { get; set; }
        protected int age { get; set; }
        protected string phone { get; set; }
        public Person()
        {
            name = "";
            surname = "";
            age = 0;
            phone = "";
        }
        public Person(string n, string sn, int a, string ph)
        {
            name = n;
            surname = sn;
            age = a;
            phone = ph;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surename: {surname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Phone: {phone}");
        }

    }
    internal class Student: Person
    {
        private double average {  get; set; }
        private int number_of_group { get; set; }
        public Student() : base()
        {
            average = 0;
            number_of_group = 0;
        }
        public Student(string n, string sn, int a, string ph, int av, int ng ):base(n, sn, a, ph)
        {
            average = av;
            number_of_group = ng;
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Number of group: {number_of_group}");
        }
        public static bool operator ==(Student arr, string sn)
        {
            if (arr is null)
            {
                return false;
            }
            else
            {
                return arr.surname == sn;
            }
        }

        public static bool operator !=(Student arr, string sn)
        {
            if (arr is null)
            {
                return true;
            }
            else
            {
                return arr.surname != sn;
            }
        }
        public override string ToString()
        {
            return $"Name: {name} - Surename: {surname} - Age: {age} - Phone: {phone} - Average: {average} - Group number: {number_of_group}";
        }
    }
    internal class Academy_group
    {
        private Student[] arr { get; set; }
        int count { get; set; }
   
        public Academy_group(int size)
        {
            count = 0;
            arr=new Student[size];
        }
        public void Add(Student st)
        {
            if (count < arr.Length)
            {
                arr[count] = st;
                count++;
            }
            else
            {
                Console.WriteLine("Group is full");
            }
        }
        public void Remove(string sn)
        {
            
         for (int i = 0; i < count; i++)
            {
                if (arr[i] == sn)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[count - 1] = null;
                    count--;
                    return;
                }
            }
            Console.WriteLine("Student doesn`t found!");
        }
        public void Edit(string sn, Student stud)
        {

            for (int i = 0; i < count; i++)
            {
                if (arr[i] == sn)
                {
                    arr[i] = stud;
                }
                return;
            }
            Console.WriteLine("Student doesn`t found!");
        }
        public void Print()
        {

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
           
        }

    }
}
