using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {// Выдача всех чисел возведенных в квадрат
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число больше нуля");
            int n = int.Parse(Console.ReadLine());
            
            for (int z = 1 ; z > 0; z++) // цикл начало (инициализация счетчика, условие, изменение счетчика). 
                
                {
                double a = Math.Pow(z, 2);// выполнение условий
                
                if (z == n+1) // сравнение при котором счетчик остановится
                        break; // завершение
                    Console.WriteLine("Квадрат числа {0} равен {1}", z, a);
                }
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
            
        }
    }
}
