using System;

namespace _2
{

    class String
    {
        private string _line;

        public String()
        {
            _line = "Пусто";
        }

        public String (string Line)
        {
            if (Line.Length > 10)
                _line = "Слишком длинная строка";
            else
                _line = Line;
        }

        public void Display()
        {
            Console.WriteLine(_line);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String str = new String();
            str.Display();
            String str1 = new String("12345678910");
            str1.Display();
            String str2 = new String("123");
            str2.Display();

            Console.ReadKey();
        }
    }
}
