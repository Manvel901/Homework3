// Задание 1: Поиск элемента в массиве
// Описание: Задайте массив целых чисел. Напишите программу, которая проверяет,
// присутствует ли заданное число в массиве. Программа должна вывести:
// Присутствует/Не присутствует.
int[] array = new int[5] { 2, 5, -5, 9, 53 };
Console.WriteLine("Ведите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool ismatches = false;
for (int i = 0; i < array.Length; i++)
{
    if (num == array[i])
    {
        ismatches = true;
        break;
    }
}
Console.WriteLine(ismatches ? "Да" : "Нет");