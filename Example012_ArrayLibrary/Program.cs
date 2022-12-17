void FillArray(int[] collection) // void - метод, который НЕ ВОЗВРАЩАЕТ значение и return НЕ НУЖЕН
{
    int length = collection.Length;
    int index = 0;

    while(index<length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Если отображается -1, значит искомый элемент НЕ НАЙДЕН в массиве

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10]; // new int[10] - создаём новый массив, в которм будет 10 чисел

FillArray(array);
array[4] = 4; // Назначили в случайный массив метода FillArray значение 4 в позицию индекса массива array[4] 
array[6] = 4; // Назначили в случайный массив метода FillArray значение 4 в позицию индекса массива array[6]
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);