using System;

class Program
{
    static void Main()
    {
        //Цикл перебирает каждый элемент массива fruits и выводит на экран
        string[] fruits = { "Apple", "Banana", "Cherry" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Целое число
        int age = 37;

        if (age >= 18)
        {
            Console.WriteLine("Совершеннолетний");
        }
        else
        {
            Console.WriteLine("Несовершеннолетний");
        }

        //Дробное число
        double height = 188;

        //Значение строки
        string name = "Jaroslaw";

        //Логическое значение (истина\ложь)
        bool isStudent = true;

        //Цикл for, будет выполнен 5 раз, пока значение переменной i меньше 5
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Значение i: " +  i);
        }



        //Вывод значений
        Console.WriteLine("Имя:" + name);
        Console.WriteLine("Возраст: " + age);
        Console.WriteLine("Рост: " + height);
        Console.WriteLine("Студент: " + isStudent);
    }
}