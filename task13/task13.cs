// Вводим любое число.
// Если число трехзначное - выводим третью цифру этого числа.
// Если числе НЕ трехзначное - выводим сообщение что третьей цифры нет.

int num3 = Convert.ToInt32(Console.ReadLine());

if (num3 < 100 | num3 > -100)
{
    Console.WriteLine("Ошибка ввода.Число не является трехзначным.");
}
else
{
    if(num3 > 99 | num3 < -99)
    {
        int last = num3 % 10;
        Console.WriteLine(last);
    }
}