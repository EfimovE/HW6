// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[]CreateArrayInt (int size)  // объект для создания массива
{
    int[]array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите значение элемента массива и нажмите Enter.");
        int elemArray = Convert.ToInt32(Console.ReadLine());
        array[i] = elemArray;
    }
    return array; 
}
void PrintArray (int[]array) // метод для вывода в консоль
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]} ]");
}
int SumPosElem(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
Console.WriteLine("Введите количество элементов в массиве и нажмите Enter.");
int number = Convert.ToInt32(Console.ReadLine());
int[]newArray = CreateArrayInt (number);
Console.Write($"Количество чисел больше нуля в массиве ");
PrintArray(newArray);
int result = SumPosElem(newArray);
Console.WriteLine($" = {result}.");