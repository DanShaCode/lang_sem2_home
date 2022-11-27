// Принимаем на вход цифру, которая обозначает день недели
// И проверяет является ли этот день выходным

Console.WriteLine("Введите день недели (число от 1 до 7):");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 | day > 7)
{
   Console.WriteLine("Ошибка ввода. Введите число от 1 до 7."); 
}

if (day == 1 | day == 2 | day == 3 | day == 4 | day == 5)
{
    Console.WriteLine("Рабочий день");
}

if (day == 6 | day == 7)
{
    Console.WriteLine("Выходной день");
}

// Решено