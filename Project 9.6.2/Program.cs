using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
                NumberReader numberReader = new NumberReader();
                numberReader.NumberEnteredEvent += ShowNumber;
           
            while(true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }
        }

        static void ShowNumber(int number)
        {
            switch (number)
            {
                case 1: Console.WriteLine("Демиденко, Иванов, Кузнецов, Петров, Смирнов"); break;
                case 2: Console.WriteLine("Смирнов, Петров, Кузнецов, Иванов, Демиденко"); break;
            }
        }
    }

    public class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent;

        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите число 1 для сортировки А-Я или число 2 для сортировки Я-А: Кузнецов, Иванов, Демиденко, Петров, Смирнов");

            int number = Convert.ToInt32(Console.ReadLine());

            if(number != 1 && number != 2) throw new FormatException();

            NumberEntered(number);
        }
        
        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
}