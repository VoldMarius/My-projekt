// Console.WriteLine("Введите ширину прямоугольника:   ");
// int width = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите высоту прямоугольника:   ");
// int heigth = int.Parse(Console.ReadLine());

// for (int i = 0; i < heigth; i++)
// {
//     for (int j = 0; j < width; j++)
//     {
//         Console.Write("#");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();


Console.WriteLine("Введите высоту треугольника:   ");
int heigthT = int.Parse(Console.ReadLine());
for (int t = 0; t <= heigthT; t++)
{
    for (int g = 0; g <= t; g++)
    {
        Console.Write("* *");
    }
    Console.WriteLine();
}

