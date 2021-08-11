using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 2
            System.Console.Write("\nВведите стоимость покупки : ");
            double price = double.Parse(Console.ReadLine());
            price = price - price * (price > 1000 ? 0.05 : price > 500 ? 0.03 : 0);
            System.Console.WriteLine($"Стоимость вашей покупки с учетом скидки : {price}");

            //Задача 3
            System.Console.WriteLine("\nВведите ваши четыре числа : ");
            int[] nums = new int[4];
            for (int i = 0; i < 4; i++)
                nums[i] = int.Parse(Console.ReadLine());
            int min = nums[0];
            bool cond1 = true, cond2 = true;
            for (int i = 0; i < 3; i++)
            {
                if (cond1 && nums[i] >= nums[i + 1])
                    cond1 = false;
                if (cond2 && nums[i] != nums[i + 1])
                    cond2 = false;
                min = nums[i + 1] < min ? nums[i + 1] : min;
            }
            if (cond1)
                System.Console.WriteLine("Числа располежены по возрастанию");
            else if (cond2)
                System.Console.WriteLine($"Произведение чисел равна : {Math.Pow(nums[0], 4)}");
            else
                System.Console.WriteLine($"Минимальное из чисел : {min}");

            //задача 4
            System.Console.WriteLine("\nВведите значения ваших переменных a,b,c (в таком порядке) : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int temp = a;
            if (a < b || a < c)
            {
                a = b > c ? b : c;
                if (b > c) b = temp;
                else c = temp;
            }
            if (c > b)
            {
                temp = b;
                b = c;
                c = temp;
            }
            System.Console.WriteLine($"Значения ваших переменных теперь :\na = {a}\nb = {b}\nc = {c}");
        }
    }
}
