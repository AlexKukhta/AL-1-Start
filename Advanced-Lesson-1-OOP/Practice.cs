using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class Finish
    {
        public virtual double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
    public class Practice
    {
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {

        }


        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
            var c1 = new Circle(2);
            var c2 = new Circle(4);
            var s3 = new Square(4);
            var s4 = new Square(6);
            var tr1 = new Treangle(2, 5);
            var tr2 = new Treangle(7, 20);

            //var array = new Finish [] {c1,c2,s3,s4};

            //for (int i = 0; i < 4; i++)
            //{
            //    array[i].CalculateArea();
            //    Console.WriteLine(array[i].CalculateArea());
            //}

            var array2 = new Finish[] { c1, c2, s3, s4, tr1, tr2 };

            for (int i = 0; i < 6; i++)
            {
                array2[i].CalculateArea();
                Console.WriteLine(array2[i].CalculateArea());
            }
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {            
        }

        class Treangle:Finish
        {
            public int a;
            public int h;
            public Treangle(int a, int h)
            {
                this.a = a;
                this.h = h;
            }
            public override double CalculateArea()
            {
                return a*h*1/2;
            }
        }


        class Circle:Finish
        {
            public int rad;

            public Circle(int rad)
            {
                this.rad = rad;
            }

            public override double CalculateArea()
            {
                return Math.PI * rad * rad;
            }
        }

        class Square:Finish
        {
            public int l;
            public Square(int l)
            {
                this.l = l;
            }
            public override double CalculateArea()
            {
                return l * l;
            }
        }
    }
}
