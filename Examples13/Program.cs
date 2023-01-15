string[,] table = new string[2, 5];
table[1 ,2] = "Слово";
//Инициализация String.Empty
// table [0,0]      table [0,1]     table [0,2]     table [0,4]
// table [1,0]      table [1,1]     table [1,2]     table [1,4]


// table[1, 2] = "Слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// int[,] matrix = new int[3, 4];

// for(int i = 0; i < 3; i++)
// {
//     for(int j = 0; j < 4; j++)
//     {
//         // Мужду } " ставим пробел - он учитывается и между цифрами стоит пробел
//         // дубль WriteLine Делает новую строку после каждой операции.
//         Console.Write(($"{matrix[i, j]} "));
//         }
//         Console.WriteLine();
// }



//Вариант 2 GetLength - выводит сразу в 4 столбика
// int[,] matrix = new int[3, 4];

// for(int i = 0; i < matrix.GetLength(1); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         // Мужду } " ставим пробел - он учитывается и между цифрами стоит пробел
//         // дубль WriteLine Делает новую строку после каждой операции.
//         Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
// }


// Метод который выводит таблицу на экран и заполняет ее числами



void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
        {
            for(int j = 0; j < matr.GetLength(1); j++)
            {
         // Мужду } " ставим пробел - он учитывается и между цифрами стоит пробел
         // дубль WriteLine Делает новую строку после каждой операции.
                Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// FillArray - Заполняет матрицу случаными числами.

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[1,j] = new Random().Next(1,10);
        }
    }    
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);