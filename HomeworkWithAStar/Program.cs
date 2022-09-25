Console.Clear();
Console.WriteLine($"Программа принимает радиус круга и находит его площадь округленную до целого числа");
Console.Write($"введите радиус круга:");
double radius = Convert.ToDouble(Console.ReadLine());
double areaCircle = Math.PI * Math.Pow(radius, 2);
Console.WriteLine(areaCircle);
areaCircle = areaCircle % 10;
Console.WriteLine(areaCircle);
double result = Math.Round(areaCircle);
Console.WriteLine(result);
Console.Write($"округленная площадь  = {result}");

