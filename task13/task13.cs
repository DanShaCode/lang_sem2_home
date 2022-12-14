// Вводим любое число.
// Если в числе есть как минимум 3 цифры - выводим третью цифру этого числа.
// Если в числе нет трех цифр - выводим сообщение что третьей цифры нет.

Console.WriteLine("Введите любое число не меньше трехзначного:"); // Инструкция ввода
int num = Convert.ToInt32(Console.ReadLine());

if (num > -100 && num < 100) // Ошибка ввода 
{
    Console.WriteLine("Ошибка ввода. Введите как минимум трехзначное число.");
}

int a = num; // Нахождения 3-й цифры для чисел с плюсом
if (a > 99)
{
    while (a > 1000)
    {
        a = a / 10;
    }
    int intares = a % 10;
    Console.WriteLine("Третья цифра введеного числа: " + intares);
}

int a2 = num; // Нахождения 3-й цифры для чисел с минусом
if (a2 < -99)
{
    while (a2 < -1000)
    {
        a2 = a2 / 10;
    }
    int inta2res = a2 % 10;
    int inta2resplus = -inta2res; // Перевод числа из минуса в плюс
    Console.WriteLine("Третья цифра введеного числа: " + inta2resplus);
}

//Задача оказалась сложнее чем я думал. 

// Вариант через if мне пришел в голову сразу, но он грубоват, большой 
// и при этом не является универсальным.

// Этот код получился более универсальным,а так же работает для чисел с минусом.