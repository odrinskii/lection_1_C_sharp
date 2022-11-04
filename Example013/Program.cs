// Продолжение третьей лекции
// Сортировка массива от минимального к максимальному.
// Алгоритм действий:
// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы. 


//int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };


void FillArray(int[] array)  // метод для заполнения массива рандомными числами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)   // метод для вывода на экран полученного массива
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)    // метод для сортировки массива от меньшего к большему
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int[] arr = new int[30];  // определяем новый массив с указанием количества значений
FillArray(arr);
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);