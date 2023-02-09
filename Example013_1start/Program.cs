using static System.Console;
Clear();

string[,] table = new string[2, 5];
// String.Empty - инициализация строк
// table [0, 0]  table [0, 1]  ...  table [0, 4]
// table [1, 0]  table [1, 1]  ...  table [1, 4]


// table [1, 2] = "слово";             // обращение к нужному элементу

// for (int rows = 0; rows < 2; rows ++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Write($"-{table[rows, columns]}- ");
//     }
//      WriteLine();
// }


int[,] matrix = new int[3, 4];
PrintArray(matrix);

Fillarray(matrix);
WriteLine();
PrintArray(matrix);


void PrintArray(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]} ");
        }
        WriteLine();
    }
}

void Fillarray(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            inMatrix[i, j] = new Random().Next(1, 10);
        }
    }
}