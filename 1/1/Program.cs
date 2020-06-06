using System;

namespace _1
{
    class Numbers
    {
        private int _num1;
        private int _num2;

        public Numbers()
        {
            
        }

        public Numbers(int Num1)
        {
            _num1 = Num1;
        }

        public Numbers(int Num1, int Num2)
        {
            _num1 = Num1;
            _num2 = Num2;
        }

        public void Display()
        {
            Console.WriteLine($"{_num1} {_num2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Numbers nmb = new Numbers();
            nmb.Display();
            Numbers nmb1 = new Numbers(1);
            nmb1.Display();
            Numbers nmb2 = new Numbers(2, 3);
            nmb2.Display();

            Console.ReadLine();
        }
    }
}
