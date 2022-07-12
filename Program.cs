using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Задание 2
    Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона 
от –100 до 100. Определить сумму элементов массива, расположенных между минимальным 
и максимальным элементами.
 */

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание и заполнение массива
            int[][] array = new int[5][];
            int max = -100, min = 100;
            int sumBetweenMinMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[5];
            }

            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i][j] = rand.Next(-100, 101);
                    if (max < array[i][j])
                        max = array[i][j];
                    if (min > array[i][j])
                        min = array[i][j];
                }
            }

            //Вывод полученного массива на экран
            foreach (var row in array)
            {
                foreach (var item in row)
                {
                    Console.Write($"{item}\t");
                }
                Console.WriteLine();
            }

            //Подсчет суммы чисел между мин и макс
            bool flag = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (max == array[i][j] || min == array[i][j] && flag == false)
                    {
                        flag = true;
                        sumBetweenMinMax = array[i][j] * (-1);
                    }
                        
                    else if (max == array[i][j] || min == array[i][j] && flag == true)
                        flag = false;
                    if(flag)
                    {
                        sumBetweenMinMax += array[i][j];
                    }
                }
            }
            Console.WriteLine($"\n Минимальное значение = {min} ");
            Console.WriteLine($" Максимальное значение = {max} ");
            Console.WriteLine($" Сумма чисел между min и max = {sumBetweenMinMax} ");

        }
    }
}
