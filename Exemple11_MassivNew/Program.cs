//Метод заполнения массива
void FillArray(int[] collection)
{
    int length = collection.Length;
    int i = 0;

    while (i < length)
    {
        collection[i] = new Random().Next(1, 10);
        i++;
    }
}
//Метод печати массива на экран
void PrintArray(int[] collection)
{
    int count = collection.Length;
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(collection[i]);
        i++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int i = 0;
    //Чтобы вместо ненайденной позиции выдавался не "0", а "-1", чтобы было более наглядно
    int position = -1;
    while (i < count)
    {
        if (collection[i] == find)
        {
            position = i;
            break;
        }
        i++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
//принудительное добавление "4"
array[4] = 4;
array [6] = 4;
PrintArray(array);
Console.WriteLine();

int position = IndexOf(array, 444);
Console.WriteLine(position);