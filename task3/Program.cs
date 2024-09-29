// Задание 3: Поиск среднего значения массива
// Описание: Задайте массив из 10 целых чисел. Найдите среднее значение элементов
// массива.
int[] array = new int[10] { 2, -4, 8, 6, 3, -66, 500, -35, 2, 1 };
double sum = 0;

for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
}
double result = sum / array.Length;
Console.WriteLine($"{result} ");