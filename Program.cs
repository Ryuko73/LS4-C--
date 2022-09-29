//Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
void Task1()
{
    Console.WriteLine("Введите число А");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int cicle = num;
    for (int i = 1; i < num2; i++)
    {
        cicle = cicle * num;
    }
    Console.WriteLine("число A в степень B " + cicle);
}
//Task1();
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Task2()
{
    Console.WriteLine("введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int mult = 1;
    while (num > 0)
    {
        int digit = num % 10;
        sum = sum + digit;
        num = num / 10;
    }
    Console.WriteLine("Сумма чисел " + sum);
}
//Task2();
//Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
void Task3()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    SortArray(numbers);
    void FillArray(int[] numbers)
    {
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-10, 10);
            Console.Write(" " + numbers[i]);
        }
    }
    void SortArray(int[] numbers)
    {
        for (int i = numbers.Length - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (Math.Abs(numbers[j]) > Math.Abs(numbers[j + 1]))
                {
                    int temp = numbers[j + 1];
                    numbers[j + 1] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

    }
    Console.WriteLine();
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(" " + numbers[i]);
    }
}
Task3();