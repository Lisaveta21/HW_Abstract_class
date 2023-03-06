using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW_
{
    public abstract class Human
    {
        string _firstName;
        string _lastName;
        DateTime _birthDate;

        public Human(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }

      

        public override string ToString()
        {
            return $"Имя: {_firstName}\nФамилия: {_lastName}\nДата рождения: {_birthDate}";
        }
    }

    abstract class Student_ : Human
    {
        string _institution;

        public Student_(string firstName, string lastName, DateTime birthDate, string institution) : base(firstName, lastName, birthDate)
        {
            _institution = institution;
        }

        public abstract void Study();

        public override string ToString()
        {
            return base.ToString() + $"\nУчебное заведение: {_institution}";
        }
    }


    class Polimorfism
    {
        static void Main(string[] args)
        {
            Student_[] student_ =
            {
               
                new Student("Namjoon", "Kim", new DateTime(1995, 09,12)),
                new SchoolChild("Jungook", "Jeon", new DateTime(1999, 09,01), "Seoul High School", "HS-21"),
                new SchoolChild("Jimin", "Park", new DateTime(1998, 10,15), "Busan High School", "IT-33")
            };
            foreach (Student_ item in student_)
            {
                WriteLine(item);
                
                item.Study();
            }
        }
    }

    internal class Student : Student_
    {
        private string v1;
        private string v2;
        private DateTime dateTime;

        public Student_(string v1, string v2, DateTime dateTime)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.dateTime = dateTime;
        }

        public override void Study()
        {
            throw new NotImplementedException();
        }
    }

    internal class SchoolChild : Student_
    {
        private string v1;
        private string v2;
        private DateTime dateTime;
        private string v3;
        private string v4;

        public SchoolChild(string v1, string v2, DateTime dateTime, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.dateTime = dateTime;
            this.v3 = v3;
            this.v4 = v4;
        }

        public override void Study()
        {
            throw new NotImplementedException();
        }
    }
}
