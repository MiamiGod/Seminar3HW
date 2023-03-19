// //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Console.Write("Введите число: ");
// string number = Console.ReadLine();
// if (number.Length == 5) ;
// else Console.WriteLine($"Введи пятизначное число");

// if (number[0] == number[4] || number[1] == number[3])
// {
//   Console.WriteLine($"Ваше число: {number} - палиндром.");
// }
// else Console.WriteLine($"Ваше число: {number} - не палиндром.");




// //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// Console.Write("Введите A(x): ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите A(y): ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите A(z): ");
// int z1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine();
// Console.Write("Введите B(х): ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите B(y): ");
// int y2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите B(z): ");
// int z2 = int.Parse(Console.ReadLine()!);

// double distance = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);

// Console.Write($"Расстояние между точками А и В в 3D пространстве равно {distance}");


// //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n > 0)
// {
//   for (int i = 1; i <= n; i++)
//   {
//     Console.Write(Math.Pow(i, 3) + " ");
//   }
// }
// else
// {
//   for (int i = 1; i >= n; i--)
//   {
//     Console.Write(Math.Pow(i, 3) + " ");
//   }
// }