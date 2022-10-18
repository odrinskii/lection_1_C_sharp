// поиск индекс искомого числа

int[] array = { 1, 2, 3, 4, 5, 2, 34, 32, 43, 45 };

int n = array.Length;
int find = 2;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //остановка ветвления
    }
    //index = index +1;
    index++;

}