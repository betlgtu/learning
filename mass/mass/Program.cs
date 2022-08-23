using System;

namespace mass
{
    class Program
    {
        static void Main(string[] args)
        {


            Figure[] figurs = new Figure[4];
            for (int i = 0; i < 4; i++)
            {
                figurs[i] = new Figure(i);
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Фигура №{i+1}: приметр = {figurs[i].PrintPerimeter()}, площадь = {figurs[i].PrintSquare()}");
            }
        }

    }


    class Figure
    {
        public int NumberOfSides;
        public double[] SideLengths;
        public Figure(int NumberFigure)
        {
            Console.WriteLine($"Введите количество сторон геометрической фигуры №{NumberFigure + 1}: ");
            NumberOfSides = Convert.ToInt32(Console.ReadLine());
            SideLengths = new double[NumberOfSides];
            Console.WriteLine("Введите длины сторон");
            for (int i = 0; i < NumberOfSides; i++)
            {
                SideLengths[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double PrintPerimeter()
        {
            double Perimeter = 0;
            for (int i = 0; i < NumberOfSides; i++)
            {
                Perimeter = Perimeter + SideLengths[i];

            }
            if (NumberOfSides == 3) { return Perimeter; }
            else { return Perimeter * 2; }
        }
        public double PrintSquare()
        {
            double Square = 0;
            if (NumberOfSides == 3)
            {
                double HalfPerimeter = PrintPerimeter()/2;
                Square = Math.Sqrt (HalfPerimeter *(HalfPerimeter - SideLengths[0])*(HalfPerimeter - SideLengths[1])*(HalfPerimeter - SideLengths[2]));
            }
            else if (NumberOfSides == 2)
            {
                Square = SideLengths[0] * SideLengths[1];
            }


            return Square;
        }

    }
}


