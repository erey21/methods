using System;
using System.Collections.Generic;
using System.Linq;

namespace homework_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнения 05.11.2021");
            homework();





        }

        //метод со списком задач:
        static void homework() {
            Console.ForegroundColor = ConsoleColor.White;
            int choice = -1;
            Console.WriteLine("1 - Сравнение двух чисел");
            Console.WriteLine("2 - Больше 5 и меньше 10");
            Console.WriteLine("3 - Равно 5 или равно 10");
            Console.WriteLine("4 - Вклад в банк");
            Console.WriteLine("5 - Вклад в банк с бонусом");
            Console.WriteLine("6 - Описание операций");
            Console.WriteLine("7 - Простой калькулятор");
            Console.WriteLine("8 - Вклад на месяцы");
            Console.WriteLine("9 - Вклад на месяцы (while)");
            Console.WriteLine("10 - Сортировка массивов");
            Console.WriteLine("11 - Разность элементов массива");
            Console.WriteLine("0 - Выход");
            Console.Write("Введите номер упражнения: ");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите число от 1 до 11, либо 0 для выхода.");
                homework();
            }
            switch (choice)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Сравнение двух чисел");
                    less_1();
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Больше 5 и меньше 10");
                    less_2();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Равно 5 или равно 10");
                    less_3();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Вклад в банк");
                    less_4();
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Вклад в банк с бонусом");
                    less_5();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Описание операций");
                    less_6();
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Простой калькулятор");
                    less_7();
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Вклад на месяцы");
                    less_8();
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Вклад на месяцы (while)");
                    less_9();
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Сортировка массивов");
                    less_10();
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Разность элементов массива");
                    less_11();
                    break;

                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("See You!");
                    break;


                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите число от 1 до 11: ");
                    homework();
                    break;
            }

            // общие методы
            static int get_int_num() {
                int n = 0;
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.Write("Требуется ввести число. Попробуйте ещё раз:");
                    return get_int_num();
                }
                return n;
            }

            static double get_d_num() {
                double d = Convert.ToDouble(Console.ReadLine());
                return d;
            }

            static void back() {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("1 - Назад к выбору упражнений \n0 - Выход");
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice) {
                        case 1:
                            homework();
                            break;
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("See You!");
                            break;
                    }
                    

                }
                catch {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите либо 1 либо 0");
                    back();
                }

            }

        // задание № 1
            static void less_1() {
                Console.Write("Введите первое число для сравнения: ");
                int num1 = get_int_num();
                Console.Write("Введите второе число для сравнения: ");
                int num2 = get_int_num();
                sravnenie(num1, num2);
                back();
            }
            static void sravnenie(int n1, int n2) {
                if (n1 > n2)
                {
                    Console.WriteLine("Первое число больше второго");
                }
                else if (n1 < n2)
                {
                    Console.WriteLine("Первое число меньше второго");
                }
                else {
                    Console.WriteLine("Два числа равны");
                }           
            }
        // задание № 2
            static void less_2() {
                Console.Write("Введите число: ");
                int n = get_int_num();
                if (n > 5 && n < 10)
                {
                    Console.WriteLine("Число больше 5 и меньше 10");
                }
                else {
                    Console.WriteLine("Неизвестное число");
                }
                back();
            }
        // задание № 3
        static void less_3() {
                Console.Write("Введите число: ");
                int n = get_int_num();
                if (n == 5 || n < 10)
                {
                    Console.WriteLine("Число равно 5 или 10");
                }
                else
                {
                    Console.WriteLine("Неизвестное число");
                }
                back();
            }
        // задание № 4
            static void less_4()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Введите сумму вклада: ");
                double sum = 0;
                try {
                    sum = get_d_num();
                }
                catch {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите сумму: ");
                    less_4();
                }
                if (sum > 0)
                {
                    Console.WriteLine($"Сумма возврата: {summa_vklada(sum)}");
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Сумма должны быть больше 0");
                    less_4();
                }
                back();
            }

            static double summa_vklada(double d) {
                
                if (d > 0 && d < 100)
                {
                    return d += d * 0.05;
                }
                else if (d > 0 && d < 200)
                {
                    return d += d * 0.07;
                }
                else
                {
                    return d += d * 0.1;
                }
                

            }
        // задание 5
            static void less_5() {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Введите сумму вклада: ");
                double sum = 0;                
                try
                {
                    sum = get_d_num();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите сумму: ");
                    less_5();
                }
                if (sum > 0)
                {
                    Console.WriteLine($"Сумма возврата: {summa_vklada(sum) + 15}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Сумма должны быть больше 0");
                    less_5();
                }
                back();
            }

        // задание 6
            static void less_6() {
                Console.Write("Операции: \n1. Сложение \n2. Вычитание \n3. Умножение \nВведите номер => ");
                int choice = get_int_num();
                switch (choice) {
                    case 1:
                        Console.WriteLine("Операция -  Сложение");
                        back();
                        break;
                    case 2:
                        Console.WriteLine("Операция -  Вычитание");
                        back();
                        break;
                    case 3:
                        Console.WriteLine("Операция -  Умножение");
                        back();
                        break;
                    default:
                        Console.WriteLine("Попробуйте ещё раз: ");
                        less_6();
                        break;
                }           
            }
        // задание № 7
            static void less_7() {
                Console.Write("Введите первое число: ");
                int n1 = get_int_num();
                Console.Write("Введите второе число: ");
                int n2 = get_int_num();
                Console.WriteLine("Выберите операцию: \n1. Сложение \n2. Вычитание \n3. Умножение");
                int choice = get_int_num();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Операция 'Сложение' {n1 + n2}");
                        back();
                        break;
                    case 2:
                        Console.WriteLine($"Операция 'Вычитание' {n1 - n2}");
                        back();
                        break;
                    case 3:
                        Console.WriteLine($"Операция 'Умножение' {n1 * n2}");
                        back();
                        break;
                    default:
                        Console.WriteLine("Попробуйте ещё раз: ");
                        try
                        {
                            choice = get_int_num();
                        }
                        catch {
                            Console.WriteLine("Введите число от 1 до 3");
                            choice = get_int_num();
                        }
                        Console.WriteLine("Начните всё сначала!");
                        less_7();
                        break;
                }
            }
        // задание 8
            static void less_8() {
                Console.Write("Введите сумму вклада: ");
                double sum = get_d_num();
                Console.Write("Введите количество месяцев: ");
                double month = get_d_num();
                for (int i = 0; i < month; i++) {
                    sum += sum * 0.07;
                }
                Console.WriteLine($"Сумма с процентами по истечению срок: {sum}") ;
                back();
            }

        // задание 9
            static void less_9() {
                Console.Write("Введите сумму вклада: ");
                double sum = get_d_num();
                Console.Write("Введите количество месяцев: ");
                double month = get_d_num();
                while (month > 0) {
                    sum += sum * 0.07;
                    month--;
                }
                Console.WriteLine($"Сумма с процентами по истечению срока: {sum}");
                back();
            }

        // задание 10
            static void less_10() {
                Console.Write("Введите количество элементов массива: ");
                int n = get_int_num();
                int[] array = create_ar(n);
                Console.WriteLine("Сгенерированный отсортированный массив:");               
                Array.Sort(array);
                write_ar(array);
                List<int> chet = new List<int>();
                List<int> nechet = new List<int>();
                foreach (int i in array)
                {
                    if (i % 2 == 0)
                    {
                        chet.Add(i);
                    }
                    else {
                        nechet.Add(i);
                    }
                }
                Console.WriteLine("Чётный массив:");
                write_l(chet);
                Console.WriteLine("Нечётный массив:");
                write_l(nechet);


                back();
            }
            static int[] create_ar(int n) {
                int[] ar = new int[n];
                Random r = new Random();
                for(int i = 0; i < n; i++)
                {
                    ar[i] = r.Next(0, 1000);
                }
                return ar;
            }
            static void write_l(List<int> arr)
            {
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            static void write_ar(int[] arr) {
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
                     

        // задание 11
            static void less_11()
            {
                Console.Write("Введите количество элементов массива: ");
                int n = get_int_num();
                double[] ar = create_arr(n);
                foreach (double d in ar) {
                    Console.Write(d + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"Максимальный Элемент: {ar.Max()}");
                Console.WriteLine($"Минимальный Элемент: {ar.Min()}");
                razn(ar.Max(), ar.Min());
                back();
            }
            static double[] create_arr(int n) { 
                double[] array = new double[n];
                Random r = new Random();
                for (int i = 0; i < n; i++){
                    array[i] = r.Next(0, 1000);
                }
                return array;
            }
            static void razn(double max, double min) {
                Console.WriteLine($"Разность Макс элемента и Мин элемента: {max - min}");
            }
            
        }
    }
}
