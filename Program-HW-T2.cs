// Напишите программу, котрая найдет точку пересечения двух прямых, заданных уравнениями: y=k1*x+b1; y2=k2*x+b2. Значения b1, b2, k1, k2 задаются пользователем.
Console.WriteLine("Введите коэффициент b1");
int b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
int b2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1");
int k1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
int k2=Convert.ToInt32(Console.ReadLine());
double x;
double y;
if (k1!=k2)
{
    x=(b2-b1)/(k1-k2);
    y=k1*x+b1;
    Console.WriteLine($"Точка пересечения прямых ({x},{y})");
}
else
{
    Console.WriteLine("Точек пересечения нет, прямые параллельны");
}