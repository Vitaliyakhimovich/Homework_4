/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */

int[] mas = new int [8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 9);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

FillArray(mas);
PrintArray(mas);
