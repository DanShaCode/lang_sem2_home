// Вводим любое число.
// Если число трехзначное - выводим третью цифру этого числа.
// Если числе НЕ трехзначное - выводим сообщение что третьей цифры нет.

int num = Convert.ToInt32(Console.ReadLine());

if (num > -100 && num < 100)
{
    Console.WriteLine("Ошибка ввода.Введите минимум трехзначное число.");
}

if(num > -1000 && num < -99 | num > 99 && num < 1000) // 3 знака
{
    num = num % 10;
    Console.WriteLine(num);
}

if(num > -10000 && num < -999 | num > 999 && num < 10000) // 4 знака
{
    num = (num / 10) % 10;
    Console.WriteLine(num);
}

if(num > -100000 && num < -9999 | num > 9999 && num < 100000) // 5 знаков
{
    num = (num / 100) % 10;
    Console.WriteLine(num);
}

if(num > -1000000 && num < -99999 | num > 99999 && num < 1000000) // 6 знаков
{
    num = (num / 1000) % 10;
    Console.WriteLine(num);
}

if(num > -10000000 && num < -999999 | num > 999999 && num < 10000000) // 7 знаков
{
    num = (num / 10000) % 10;
    Console.WriteLine(num);
}

if(num > -100000000 && num < -9999999 | num > 9999999 && num < 100000000) // 8 знаков
{
    num = (num / 100000) % 10;
    Console.WriteLine(num);
}

if(num > -1000000000 && num < -99999999 | num > 99999999 && num < 1000000000) // 9 знаков
{
    num = (num / 1000000) % 10;
    Console.WriteLine(num);
}

// Как это решить через метод пока не понял
// Так же если вводить число с минусом, то он будет показывать минус в результате