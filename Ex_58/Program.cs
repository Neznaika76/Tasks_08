// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// заполние двумерного массива
void FillingTheArray(int[,] Array)
    {
        Random random = new Random();
        for(int i=0; i<Array.GetLength(0); i++)
            for(int j=0; j<Array.GetLength(1); j++)
                Array[i,j]=random.Next(0,10);
        return;
    }

// Вывод массива
void OutputTheArray(int[,] Array)
    {
        for(int i=0; i<Array.GetLength(0); i++)
            {
                for(int j=0; j<Array.GetLength(1); j++)
                    Console.Write(" {0} ",string.Join(",",Array[i,j]));
                Console.WriteLine("");
            }
        return;
    }

//Находим произведение массива
void MultiplicationTheArray(int[,] Array1, int[,] Array2)
    {
        int[,] NewArray = new int[Array1.GetLength(0),Array1.GetLength(1)];
        for(int i=0; i<Array1.GetLength(0); i++)   
            for(int j=0; j<Array1.GetLength(1); j++)
                NewArray[i,j] = Array1[i,j]*Array2[i,j];
        OutputTheArray(NewArray);
        return;
    }

// Программа
Console.WriteLine("Введите значение m - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n - ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[m,n];
int[,] array2 = new int[m,n];
FillingTheArray(array1);
FillingTheArray(array2);
Console.WriteLine("_____________________________");
OutputTheArray(array1);
Console.WriteLine("_____________________________");
OutputTheArray(array2);
Console.WriteLine("_____________________________");
MultiplicationTheArray(array1,array2);