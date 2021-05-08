using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prt6
{
    class Exam
    {
        //string predmet;
        
        public string Predmet
        {
            get;
            /*{
                return predmet;
            }*/
            set;
            /*{
                predmet = value;
            }*/
        }

        public int Ocenka
        {
            get;
            set;            
        }

        public DateTime DateExam
        {
            get;
            set;            
        }

        public Exam(string studentPredmet, int studentOcenka, DateTime studentDateExam)
        {
            Predmet = studentPredmet;
            Ocenka = studentOcenka;
            DateExam = studentDateExam;
        }
        public Exam() {

            Predmet = "";
            Ocenka = 0;
            DateExam = new DateTime();
        }

        //public Person() : this("studentPredmet", "studentOcenka", new DateTime(1999, 09, 9)) { }

        public override string ToString()
        {
            return Predmet + " " + Ocenka + " " + DateExam;
        }
    }

    enum Education { Specialist, Вachelor, SecondEducation }

    class Student
    {
        //private string name;
        private Education educationSt;
        private int number;
        private Person person1;
        private Exam[] exams;

        public Student(Person p, Education E, int Number)
        {
            //name = Name;
            educationSt = E;
            number = Number;
            person1 = p;
            exams = null;
        }
        public Student()
        {
            person1 = null;
            exams = null;
            number = 0;
            educationSt = Education.Вachelor;
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public Exam[] Exams
        {
            get
            {
                return exams;
            }
            set
            {
                exams = value;
            }
        }
        public Person Person1
        {
            get
            {
                return person1;
            }
            set
            {
                person1 = value;
            }
        }

        /*public string Name
        {
            get
            {
                return name;
            }
        }*/

        public Education EducationSt
        {
            get
            {
                return educationSt;
            }
            set
            {
                educationSt = value;
            }
        }

        public double AveragePoint
        {
            get
            {
                double point = 0;
                if (exams != null)
                {
                    foreach (Exam e in exams)
                    {
                        point += e.Ocenka;
                    }
                    point = point / exams.Length;
                }
                return point;
            }
        }
        public bool this[Education index]
        {
            get
            {
                if (educationSt == index)
                    return true;
                else
                    return false;
            }
        }
        public void AddExams(params Exam[] ex) 
        {
            Exam[] bufer = new Exam[exams.Length + ex.Length];
            for (int i = 0; i<exams.Length; i++)
            {
                bufer[i] = exams[i];
            }
            for (int i = exams.Length; i< bufer.Length;i++)
            {
                bufer[i] = ex[i - exams.Length];
            }
            exams = bufer; 
        }

        public override string ToString()
        {
            string examsInfo = "";
            for(int i = 0; i<exams.Length; i++)
            {
                examsInfo = examsInfo + exams[i].ToString() + "\n";
            }
            return person1.ToString() + " " + number + " " + educationSt + " " + examsInfo;
        }

        public virtual string ToShortString()
        {
            return person1.ToString() + " " + number + " " + educationSt + " " + AveragePoint;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime ferst = DateTime.Now;
            Student std = new Student(new Person("саша", new DateTime(2000,05,12)),Education.Вachelor,4);
            Console.WriteLine(std.ToShortString());
            Exam exam1 = new Exam("математика", 4, DateTime.Now);
            std.Exams = new Exam[] {exam1};
            Console.WriteLine(std.ToString());
            Console.WriteLine(exam1.ToString());
            Exam ex2 = new Exam("алгебра", 5, DateTime.Now);
            //
            std.AddExams(ex2);
            //
            Console.WriteLine(std[Education.Вachelor]);
            Console.WriteLine(std[Education.Specialist]);
            Console.WriteLine(std[Education.SecondEducation]);
            Console.WriteLine(std.ToString());
            DateTime last = DateTime.Now;
            Console.WriteLine(last - ferst);
        }

    }
    
}

