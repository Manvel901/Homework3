// Задание 2: Замена элементов массива
// Описание: Задайте массив из 10 элементов, заполненный числами от -10 до 10.
// Замените отрицательные числа на их абсолютные значения, а положительные числа
// на их отрицательные эквиваленты.

Random rnd = new Random();
int[] array = new int[10];

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
   array[i] = rnd.Next(-11, 11);
Console.Write($"{array[i]} ");
    array[i] = array[i] * -1;
}
Console.Write("]");
foreach (int e in array)
{
    Console.Write($"{e} ");
}
