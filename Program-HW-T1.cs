// Пользователь вводит с клавиатуры M чисел. Посчитать сколько чисел больше 0 ввел пользователь.
Console.WriteLine("Введите необходимое количество чисел");
int countM=Convert.ToInt32(Console.ReadLine());
int count=0;
for (int i=0; i<countM; i++)
{
    Console.Write($"Введите {i}-ое число:");
    int number=Convert.ToInt32(Console.ReadLine());
    if (number>0) count++;
}
Console.WriteLine($"Количество чисел больше нуля равно {count}");