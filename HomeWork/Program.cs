Console.Clear();
Console.Write("Enter tusk number:");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine($"является ли оно палиндромом ?");
        Console.Write($"Enter a five-digit number:");
        int fiveDig = Convert.ToInt32(Console.ReadLine()); // 12321
        if (fiveDig < 10000 || fiveDig > 99999)
            Console.Write($"Incorrect value. Error !");
        else
        {
            int num1 = fiveDig / 10000;
            int num2 = fiveDig / 1000 % 10;
            int num4 = fiveDig / 10 % 10;
            int num5 = fiveDig % 10;
            if (num1 == num5 && num2 == num4) Console.Write($"number is a palindrome!");
            else Console.Write("number is not a palindrome :-/ ");
        }
        break;

    case 2:
        Console.WriteLine($" координаты двух точек и находит расстояние между ними в 3D пространстве");
        Console.Write($"введите первую кооринату xa:");
        double xa = Convert.ToInt32(Console.ReadLine());
        Console.Write($"введите вторую координату ya:");
        double ya = Convert.ToInt32(Console.ReadLine());
        Console.Write($"введите третью кооринату za:");
        double za = Convert.ToInt32(Console.ReadLine());

        Console.Write($"введите первую кооринату xb:");
        double xb = Convert.ToInt32(Console.ReadLine());
        Console.Write($"введите вторую координату yb:");
        double yb = Convert.ToInt32(Console.ReadLine());
        Console.Write($"введите третью кооринату zb:");
        double zb = Convert.ToInt32(Console.ReadLine());
        double otvet = Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2);
        double tvet = Convert.ToDouble(Math.Sqrt(otvet));
        Console.WriteLine($"ответ: {tvet}");
        break;
    case 3:
        Console.WriteLine($"программа которая выдает таблицу кубов от 1 до n:");
        Console.Write($"введите число:");
        double cubing = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        while (cubing >= count)
        {
            Console.WriteLine($"квадрат = {Math.Pow(count, 3)}");
            count++;
        }
        break;
}








