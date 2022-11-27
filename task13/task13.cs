// Вводим любое число.
// Если число трехзначное - выводим третью цифру этого числа.
// Если числе НЕ трехзначное - выводим сообщение что третьей цифры нет.

int num = Convert.ToInt32(Console.ReadLine());

if (num > -100 && num < 100)
{
    Console.WriteLine("Ошибка ввода.Введите минимум трехзначное число.");
}
else
{ 
  if(num > -1000 && num < -99 | num > 99 && num < 1000)
  {
    num = num % 10;
    Console.WriteLine(num);
  }
  else
  {
    int numRes = 0;
    for (int i = 0; num > -1000 | num < 1000; i++)
    {
        numRes = num / 10;
    }
    numRes = numRes % 10;
    Console.WriteLine(numRes); 
  }
}

