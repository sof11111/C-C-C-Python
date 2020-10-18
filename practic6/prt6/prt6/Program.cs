using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prt6
{
    class Exam
    {
        string predmet;
        int ocenka;
        System.DateTime DateExam;

        public Exam(string studentPredmet, int studentOcenka, DateTime studentDateExam)
        {
            predmet = studentPredmet;
            ocenka = studentOcenka;
            DateExam = studentDateExam;
        }


        public Person() : this("studentPredmet", "studentOcenka", new DateTime(1999, 09, 9)) { }

        public override string ToString()
        {
            return
        }
    }


    class Student
    {
        private string name;
        private string education;
        private int number;
        //private Exam[] info;

        public Student(string Name, string Education, int Number, string Info)
        {
            Name = name;
            Education = education;
            Number = number;
            //Info = info; 
        }       

        public string name
        {
            get
            {
                return name;
            }
        }

        public string education
        {
            get
            {
                return education;
            }
        }

        public

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            Console.WriteLine(std.Student());
        }

    }

    
}

