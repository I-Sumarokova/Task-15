using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число х");
            int x = Convert.ToInt32(Console.ReadLine());

            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(x);
            Console.WriteLine("Арифметическая прогрессия:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", + arithProgression.getNext());
            }

            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(x);
            Console.WriteLine();
            Console.WriteLine("Геометрическая прогрессия:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", +geomProgression.getNext());
            }

            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }

    class ArithProgression : ISeries
    {
        int number=0;
        int step=3; // шаг

        public void setStart(int x) //устанавливает начальное значение
        {
            number = x;
        }
        public int getNext() //возвращает следующее число ряда
        {
            number += step;
            return number;
        }

        public void reset()//выполняет сброс к начальному значению
        {
            number = number-step;
        }

    }

    class GeomProgression : ISeries
    {
        int number = 0;
        int step = 3; // шаг
        public void setStart(int x)
        {
            number = x;
        }
        public int getNext()
        {
            number = number * step;
            return number;
        }

        public void reset()
        {
            number = number / step;
        }
    }
}

