void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;//int position = 0; -1 делаем, чтобы несуществующее число в массиве помещалось на эту позицию.Можно как -2 прописать

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;


}

int[] array = new int[10];

FillArray(array);

array[4] = 6;
array[8] = 6;//принудительно добавили еще цифры для проверки кода
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 33);//попробуем искать в массиве число 456, если не найдем должно переместиться на -1 позицию
Console.WriteLine(pos);

