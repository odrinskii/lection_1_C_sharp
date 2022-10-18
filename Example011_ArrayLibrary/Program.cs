// создаем метод для заполнения массива случайными числами
// void - 
void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// создаем метод для вывода нужного элемента 
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

// пишем метод поиска индекса(позиции) нужного числа
int IndexOf(int[] collection, int find) //задаем 2 аргумента
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
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


int[] array = new int[10]; //задаем размер массива

//теперь прописываем созданные методы на практике
FillArray(array);
PrintArray(array);

Console.WriteLine(); //пустая строка

int pos = IndexOf(array, 5); // используем наш метод на практике, задаем
// аргументы в виде массива array и искомого значения 4 под аргументом find
Console.WriteLine(pos);
