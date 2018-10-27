using System;

namespace Day1_2
{
    class Myconstants
    {
        public const double P1 = 3.14;    //멤버 필드
        public const int MYAGE = 22;     // 멤버, 필드
    }

    class Program
    { 
        static void Main(string[] args)    //프로그램 진입점
        {
           double raidus = 2;
           double area = Myconstants.P1 * (raidus * raidus);
           Console.WriteLine("Area = {0}, Age ={1}", area, Myconstants.MYAGE);

           const string name = "홍길동";
           Console.WriteLine("name : " + name);
        }
    }
}

