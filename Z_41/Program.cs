/*Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите количество элементов массива:  ");
int elemCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elemCount];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:  ");
    array[i] = Convert.ToInt32(Console.ReadLine());

}

int countPozitiv = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        countPozitiv++;
    }
}
Console.Write($"\nКоличество положительных чисел, введенных пользователем: {countPozitiv}");

/* вариант ввода с консоли чисел и помещение их в масив, найден в Интернете
Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");
*/