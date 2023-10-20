using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace ExampleProject
{

    public abstract class Human
    {
        protected string Name;
        protected string Surname;
        protected string Gender;
        protected int Age;

        public virtual void ShowInfo()
        {
            WriteLine("Name : " + Name);
            WriteLine("Surname : " + Surname);
            WriteLine("Gender : " +  Gender);
            WriteLine("Age : " +  Age);
        }
        public virtual void Salary()
        {
            WriteLine("There is no salary info");
        }
        public virtual void RaiseSalary() 
        {
            WriteLine("This is impoisble cuz this person is not belong hospital");
        }

    }
    
    public class Doctor : Human, IDisposable
    {
        private string DoctorSpecialties;
        private double salary = 17000;
        public Doctor()
        {
            WriteLine("Doctor created without info\nThis can be cause some error");
        }
        public Doctor(string doctorSpecialties, double salary,string name,string surname,string gender,int age)
        {
            DoctorSpecialties = doctorSpecialties;
            this.salary = salary;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
        }
        public void GetSalary()
        {
            string pronoun = (Gender == "Woman" || Gender == "woman") ? "Mss." : "Mrs.";
            WriteLine($"Doctor {pronoun}{Name} {Surname}:{salary}");
        }
        public override void ShowInfo()
        {
            WriteLine($"Name : {Name}\n" +
                      $"Surname : {Surname}\n" +
                      $"Gender : {Gender} \n" +
                      $"Age : {Age} \n" +
                      $"DoctorSpecialties : {DoctorSpecialties}\n");
        }
        public override void RaiseSalary()
        {
            salary = salary + (salary / 10);
            string pronoun = (Gender == "Woman" || Gender == "woman") ? "Mss." : "Mrs.";
            WriteLine($"Doctor {pronoun}{Name} {Surname} New Salary:{salary}");
        }
        public void Dispose()
        {
            WriteLine("Executed Sucssesfuly");
        }
    }
    public class Nurse : Human , IDisposable
    {
        private string NurseSpecialties;
        private double salary = 10000;

        public Nurse(string NurseSpecialties, double salary, string name, string surname, string gender, int age)
        {
            this.NurseSpecialties = NurseSpecialties;
            this.salary = salary;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
        }
        public void GetSalary()
        {
            string pronoun = (Gender == "Woman" || Gender == "woman") ? "Mss." : "Mrs.";
            WriteLine($"Nurse {pronoun}{Name} {Surname}:{salary}");
        }
        public override void ShowInfo()
        {
            WriteLine($"Name : {Name}\n" +
                      $"Surname : {Surname}\n" +
                      $"Gender : {Gender} \n" +
                      $"Age : {Age} \n" +
                      $"NurseSpecialties : {NurseSpecialties}\n");
        }
        public override void RaiseSalary()
        {
            salary = salary + (salary / 50);
            string pronoun = (Gender == "Woman" || Gender == "woman") ? "Mss." : "Mrs.";
            WriteLine($"Nurse {pronoun}{Name} {Surname} New Salary:{salary}");
        }
        public Nurse()
        {
            WriteLine("Nurse created without info\nThis can be cause some error");
        }
        public void Dispose()
        {
            WriteLine("Executed Sucssesfuly");
        }
    }
    public class Security : Human  , IDisposable
    {
        private string SecurityLocation;
        private string Team;
        private double Sale = 11000;
        public Security()
        {
            WriteLine("Security created without info\nThis can be cause some error");
        }
        public Security(string SecurityLocation, string Team,double Sale,string name,string surname,string gender,int age)
        {
            this.SecurityLocation = SecurityLocation;
            this.Team = Team;
            this.Sale = Sale;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
        }
        public override void ShowInfo()
        {
            WriteLine($"Name : {Name}\n" +
                      $"Surname : {Surname}\n" +
                      $"Gender : {Gender} \n" +
                      $"Age : {Age} \n" +
                      $"Team : {Team}\n");
        }
        public override void RaiseSalary()
        {
            Sale = Sale + (Sale / 50);
            string pronoun = (Gender == "Woman" || Gender == "woman") ? "Mss." : "Mrs.";
            WriteLine($"Security {pronoun}{Name} {Surname} New Salary:{Sale}");
        }
        public void Dispose()
        {
            WriteLine("Executed Sucssesfuly");
        }
    }
    public class Janitory : Human, IDisposable
    {
        private string JanitoryBlock;
        private string JanitorySpecialties;
        private double salary = 8000;
        public Janitory()
        {
            WriteLine("Jenitory created without info\nThis can be cause some error");
        }
        public Janitory(string JanitorySpecialties, string JanitoryBlock, double salary, string name, string surname, string gender, int age)
        {
            this.JanitorySpecialties = JanitorySpecialties;
            this.JanitoryBlock = JanitoryBlock;
            this.salary = salary;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
        }
        public override void ShowInfo()
        {
            WriteLine($"Name : {Name}\n" +
                      $"Surname : {Surname}\n" +
                      $"Gender : {Gender} \n" +
                      $"Age : {Age} \n" +
                      $"JanitorySpecialties : {JanitorySpecialties}\n" +
                      $"JanitoryBlock : {JanitoryBlock}\n");
        }
        public override void RaiseSalary()
        {
            salary = salary + (salary / 50);
            string pronoun = (Gender == "Woman" || Gender == "woman") ? "Mss." : "Mrs.";
            WriteLine($"Janitory {pronoun}{Name} {Surname} New Salary:{salary}");
        }
        public void Dispose()
        {
            WriteLine("Executed Sucssesfuly");
        }
    }
    public class Patient : Human, IDisposable
    {
        private string Description;
        private string BackGround;
        private string illness;
        private int Kat;
        private string Blok;
        private int odanumarası;
        private static double PatientDebt = 150.1;
        public Patient()
        {
            WriteLine("Patient created without info\nThis can be cause some error");
        }
        public Patient(string name,string surname,string gender,int age,string description, string backGround, string illness, int kat, string blok, int odanumarası)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
            Description = description;
            BackGround = backGround;
            this.illness = illness;
            Kat = kat;
            Blok = blok;
            this.odanumarası = odanumarası;
            PatientDebt = 150.1;
        }
        public override void ShowInfo()
        {
            WriteLine($"Name : {Name}\n" +
                      $"Surname : {Surname}\n" +
                      $"Gender : {Gender} \n" +
                      $"Age : {Age} \n" +
                      $"Description : {Description}\n" +
                      $"BackGround : {BackGround}\n" +
                      $"illness : {illness}\n" +
                      $"Kat : {Kat} Blok : {Blok} odanumarası : {odanumarası}\n" +
                      $"PatientDebt : {PatientDebt}\n");

        }
        //Bazı özellikler eklenecek
        public void RaiseDebt()
        {
            PatientDebt = PatientDebt + 500;
        }

        public void Dispose()
        {
            WriteLine("Executed Sucssesfuly");
        }
    }
}
