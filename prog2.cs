using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Zadacha2
{
    public class Student
    {
        public string Fullname { get; set; }
        public string Group { get; set; }
        public double Stipendia { get; set; }
        public double Mark { get; set; }
        public Student(string fullName, string group, double mark)
        {
            Fullname = fullName;
            Group = group;
            Mark = mark;
        }

        public virtual double Stipuha(double mark)
        {
            if (mark < 5)
            {
                Stipendia = 1900;
            }
            else
            {
                Stipendia = 2000;
            }
            return Stipendia;
        }
        public void Vivod()
        {
            double st = Stipuha(Mark);
            Console.WriteLine(Fullname);
            Console.WriteLine(Group);
            Console.WriteLine(st);
        }
    }
    public class Aspirant : Student
    {
        public string ResearchWork { get; set; }
        public Aspirant(string fullName, string group, double mark, string researchwork) : base(fullName, group, mark)
        {
            Fullname = fullName;
            Group = group;
            Mark = mark;
            ResearchWork = researchwork;
        }
        public override double Stipuha(double mark)
        {
            if (mark < 5)
            {
                Stipendia = 2200;
            }
            else
            {
                Stipendia = 2500;
            }
            return Stipendia;
        }
        public new void Vivod()
        {
            double st = Stipuha(Mark);
            Console.WriteLine(Fullname);
            Console.WriteLine(Group);
            Console.WriteLine(st);
            Console.WriteLine(ResearchWork);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Serbeev Vladislav Igorevich", "ISpP-22-1", 5.00);
            Student b = new Student("Serbeev Vladislav Igorevich", "ISpP-22-1", 4.99);
            a.Vivod();
            b.Vivod();
            Aspirant c = new Aspirant("Serbeev Vladislav Igorevich", "ISpP-22-1", 4.99, "Issledovanie Belok");
            Aspirant d = new Aspirant("Serbeev Vladislav Igorevich", "ISpP-22-1", 5, "Issledovanie Belok");
            c.Vivod();
            d.Vivod();
            Console.ReadKey();
        }
    }
}