using System;

namespace Lab_1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Num num1 = new Num("1960", "Дрейк", 26, 1420);
            Num num2 = new Num("1970", "Троїцький", 14, 1875);
            Num num3 = new Num("1978", "Хоровiц", 300, 1665);
            Console.WriteLine("Рiк   Науковий керiвник  Дiаметр антени(м)  Робоча частота(Мгц)");
            Console.WriteLine(num1.Details());
            Console.WriteLine(num2.Details());
            Console.WriteLine(num3.Details());
        }
    }

    class Num
    {
        public string year { get; set; }

        public string director { get; set; }

        public short diameter { get; set; }

        public double frequency { get; set; }

        public Num(Num previousNum)
        {
            year = previousNum.year;
            director = previousNum.director;
            diameter = previousNum.diameter;
            frequency = previousNum.frequency;
        }

        public Num(string Year, string Director, short Diameter, double Freaquency)
        {
            year = Year;
            director = Director;
            diameter = Diameter;
            frequency = Freaquency;
        }

        public string Details()
        {
            return year + "      " + director + "       " + diameter.ToString() + "             " + frequency.ToString();
        }
    }
}
