using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[]
            {
                new MyException(),
                new ArgumentNullException(),
                new ArgumentOutOfRangeException(),
                new DirectoryNotFoundException(),
                new Exception(),
            };
            try
            {
                new ArgumentNullException();
                new ArgumentOutOfRangeException();
                new DirectoryNotFoundException();
                new Exception();
                throw new MyException();
            }
            catch (MyException ex)
            {
                Console.WriteLine("Материал пройден, но осталось закрепить практикой.");
            }

            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Произошла ошибка номер 33. Попробуйте снова.");
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка. Попробуйте ещё раз.");
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Вы сделали что-то не так. Попробуйте по другому.");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ошибка");
            }

            finally
            {
                Console.Read();
            }
        }
    }

    public class MyException : Exception
    {
        public MyException() { }

        public MyException(string message) : base() { }
    }
}