// На вход принимаем трехзначное число 
// На выходе показываем вторую цифру этого числа 

int num3 = Convert.ToInt32(Console.ReadLine());

int res = (num3 / 10) % 10;

Console.WriteLine(res);

//Решено