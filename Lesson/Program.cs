/* Console.Write($"введите первую кооринату А1:");
double xa = Convert.ToInt32(Console.ReadLine());
Console.Write($"введите вторую координату А2:");
double ya = Convert.ToInt32(Console.ReadLine());
Console.Write($"введите первую кооринату В1:");
double xb = Convert.ToInt32(Console.ReadLine());
Console.Write($"введите вторую координату В2:");
double yb = Convert.ToInt32(Console.ReadLine());
double otvet = Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2);
double tvet = Convert.ToDouble(Math.Sqrt(otvet));
Console.WriteLine($"ответ: {tvet}"); */

/* A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */

/* if (num1 == 1){Console.WriteLine($"диапозон 1 четверти по x и y 0 до бесконечности");
} 
else if (num1 == 2){Console.WriteLine($"диапозон 2 четверти по х от 0 до -бесконечности , y  от 0 до бесконечности");
} 
 */

/*  Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

Console.Write($"введите число:");
double num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (num >= count)
{
    Console.WriteLine($"квадрат = {count*count}");
    count++;
}