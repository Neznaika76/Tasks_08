// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// Сортировка массива
void SortingTheArray(int[,] Array)
    {
        int Variable = 1;
        while (Variable == 1)
            {
                Variable = 0;
                for(int i=0; i<Array.GetLength(0); i++)
                    for(int j=0; j<Array.GetLength(1)-1; j++)
                        if(Array[i,j]<Array[i,j+1])
                            {
                                Variable=Array[i,j];
                                Array[i,j]=Array[i,j+1];
                                Array[i,j+1]=Variable;
                                Variable=1;
                            }
            }
        return;
    }

// Программа
Console.WriteLine("Введите значение m - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n - ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
FillingTheArray(array);
OutputTheArray(array);
SortingTheArray(array);
Console.WriteLine("_____________________________");
OutputTheArray(array);
