// string[,] table = new string[2, 5];
// // //По умолчаеию пустыми строками заполняется массив
// // table[1, 2] = "Слово";

// // for (int rows = 0; rows < table.GetLength(0); rows++)
// // {
// //     for (int columns = 0; columns < table.GetLength(1); columns++)
// //     {
// //         Console.Write($"-{table[rows, columns]}-");
// //     }
// // }


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) // Метод генерации и зполнения нового массива случайными числами в неком диапазоне
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine("Новый сгенерированный массив: ");
PrintArray(matrix);