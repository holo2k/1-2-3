using System;

namespace _3
{
    class Triangle
    {
        private bool triangle;
        private double alpha;
        private double beta;
        private double gamma;

        public Triangle(int l1, int l2, int l3)
        {
           double Alpha = (Math.Acos((Math.Pow(l1, 2) + Math.Pow(l2, 2) - Math.Pow(l3, 2)) / (2 * l1 * l2)))*(180 / Math.PI);
            double Beta = (Math.Acos((Math.Pow(l2, 2) + Math.Pow(l3, 2) - Math.Pow(l1, 2)) / (2 * l2 * l3)))*(180 / Math.PI);
            double Gamma = (Math.Acos((Math.Pow(l3, 2) + Math.Pow(l1, 2) - Math.Pow(l2, 2)) / (2 * l1 * l3)))*(180 / Math.PI);

            if ((l1 + l2 > l3) && (l2 + l3 > l1) && (l1 + l3 > l2))
            {
                triangle = true;

                alpha = Alpha;
                beta = Beta;
                gamma = Gamma;
            }
            else
            {
                triangle = false;
            }
                
        }

        public void Display()
        {
            if (triangle == true)
            {
                Console.WriteLine($"\nТреугольник можно построить\n\n" +
                                  $"Углы:\n" +
                                  $"Alpha : {alpha.ToString("##.##")}" +
                                  $"\nBeta : {beta.ToString("##.##")}" +
                                  $"\nGamma: {gamma.ToString("##.##")}");
            }
            else
                Console.WriteLine("\nТреугольник нельзя построить");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle trg = new Triangle(7, 7, 7);
            trg.Display();
            Triangle trg1 = new Triangle(6, 8, 4);
            trg1.Display();
            Triangle trg2 = new Triangle(32, 4, 13);
            trg2.Display();
            Console.ReadKey();
        }
    }
}
