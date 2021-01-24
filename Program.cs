using System;
using System.Numerics;

namespace UniYar
{
    class Square
    {
        public Square() 
        {
            lentght = 1.0f;
            topLeft = new Vector2(0.0f, 0.0f);
        }
        public Square(float _lenght, Vector2 _topLeft)
        {
            validate(_lenght);
            lentght = _lenght;
            topLeft = _topLeft;
        }

        public virtual float Perimetr()
        {
            return (4 * lentght);
        } 

        public virtual float Area()
        {
            return (lentght * lentght);
        }

        public float Lenght
        {
            get
            {
                return lentght;
            }

            set
            {
                validate(value);
                lentght = value;
            }
        }


        protected void validate(float _lenght)
        {
            if (_lenght < 0.0f)
            {
                throw new ArgumentException("Lentgh must be positive");
            }
        }
        private Vector2 topLeft;
        private float lentght;
    }

    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("\nSquare ");
            Square a1 = new Square();
            Square a2 = new Square(2.3f, new Vector2(0.0f, 0.0f));

            Console.WriteLine(String.Format("a1 - Perimetr = {0}", a1.Perimetr()));
            Console.WriteLine(String.Format("a2 - Perimetr = {0}", a2.Perimetr()));

            Console.WriteLine(String.Format("a1 - Area = {0}", a1.Area()));
            Console.WriteLine(String.Format("a2 - Area = {0}", a2.Area()));
        }
    }
}
