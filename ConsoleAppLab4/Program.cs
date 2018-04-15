using System;

namespace ConsoleAppLab4
{
    class Square
    {
        protected double b0;
        protected double b1;
        protected double b2;

        public Square()
        {
            b0 = 0;
            b1 = 0;
            b2 = 0;
        }
        public Square(double b0, double b1, double b2)
        {
            this.b0 = b0;
            this.b1 = b1;
            this.b2 = b2;
        }
        public double GetB0()
        {
            return b0;
        }
        public double GetB1()
        {
            return b1;
        }
        public double GetB2()
        {
            return b2;
        }

        public void SetB0(double b0)
        {
            this.b0 = b0;
        }
        public void SetB1(double b1)
        {
            this.b1 = b1;
        }
        public void SetB2(double b2)
        {
            this.b2 = b2;
        }
        public void Print_Coeff()
        {
            Console.Write("\n");

            Console.WriteLine("b0 = " + b0);
            Console.WriteLine("b1 = " + b1);
            Console.WriteLine("b2 = " + b2);

            Console.Write("\n");
        }
        public void Set_Coeff(double b0, double b1, double b2)
        {
            this.b0 = b0;
            this.b1 = b1;
            this.b2 = b2;
        }
        public void Get(double xb)
        {
            double s = b2 * xb * xb + b1 * xb + b0;
            if (s == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        public void Discriminant()
        {
            double d = b1 * b1 - 4 * b2 * b0;
            if (d < 0)
            {
                Console.WriteLine("Немає коренiв");
            }
            else
            {
                double x1 = (-b1 + Math.Sqrt(d)) / 2 * b2;
                double x2 = (-b1 - Math.Sqrt(d)) / 2 * b2;
                Console.WriteLine("x1=... " + x1);
                Console.WriteLine("x2=... " + x2);

            }
        }
        public static Square operator +(Square element1, Square element2)
        {
            return new Square(element2.b0 + element1.b0, element2.b1 + element1.b1, element2.b2 + element1.b2);
        }
    }
    class Cube : Square
    {
        protected double a0;
        protected double a1;
        protected double a2;
        protected double a3;

        public Cube() : base()
        {
            a0 = 0;
            a1 = 0;
            a2 = 0;
            a3 = 0;
        }
        public Cube(double b0, double b1, double b2, double a0, double a1, double a2, double a3) : base(b0,b1,b2)
        {
            this.a0 = a0;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;

        }
        public void SetA0(double a0)
        {
            this.a0 = a0;
        }
        public void SetA1(double a1)
        {
            this.a1 = a1;
        }
        public void SetA2(double a2)
        {
            this.a2 = a2;
        }
        public void SetA3(double a3)
        {
            this.a3 = a3;
        }

        public double GetA0()
        {
            return a0;
        }
        public double GetA1()
        {
            return a1;
        }
        public double GetA2()
        {
            return a2;
        }
        public double GetA3()
        {
            return a3;
        }
        public new void Print_Coeff()
        {
            Console.Write("\n");

            Console.WriteLine("b0 = " + b0);
            Console.WriteLine("b1 = " + b1);
            Console.WriteLine("b2 = " + b2);

            Console.Write("\n");

            Console.WriteLine("a0 = " + a0);
            Console.WriteLine("a1 = " + a1);
            Console.WriteLine("a2 = " + a2);
            Console.WriteLine("a3 = " + a3);

            Console.Write("\n");
        }
        public void Get2(double xa)
        {
            double c1 = a3 * Math.Pow(xa, 3) + a2 * Math.Pow(xa, 2) + a1 * xa + a0;

            if (c1 == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        public void Set_Coeff(double b0, double b1, double b2, double a0, double a1, double a2, double a3)
        {
            Set_Coeff(b0, b1, b2);
            this.a0 = a0;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
        }
        public static Cube operator +(Cube element1, Cube element2)
        {
            return new Cube(element2.b0 + element1.b0, element2.b1 + element1.b1, element2.b2 + element1.b2, element2.a0 + element1.a0, element2.a1 + element1.a1, element2.a2 + element1.a2, element2.a3 + element1.a3);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            double xb, xa;
            double b0, b1, b2, a0, a1, a2, a3;
            Console.Write("Input b0: ");
            b0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b1: ");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b2: ");
            b2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n");

            Console.Write("Input a0: ");
            a0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input a1: ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input a2: ");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input a3: ");
            a3 = Convert.ToDouble(Console.ReadLine());

            Cube c = new Cube(b0, b1, b2, a0, a1, a2, a3);
            c.Print_Coeff();
            Console.WriteLine("\n\n Input (xb,xa)");
            Console.Write(" Input xb: ");
            xb = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Input xa: ");
            xa = Convert.ToDouble(Console.ReadLine());
            c.Get(xb);
            c.Discriminant();
            c.Get2(xa);

            Cube c2 = new Cube(5, 5, 5, 5, 5, 5, 5);
            Cube res = c + c2;
            res.Print_Coeff();
            Console.ReadKey();
        }
    }
}