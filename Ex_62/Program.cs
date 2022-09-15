// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// заполние двумерного массива
void FillingTheArray(int[,] Array)
    {
        int n = Array.GetLength(0);
        int k1 = 0;
        int k2 = n-1;
        int Znachenie = 1;
        while (Znachenie<=n*n)
            {
                for(int j = k1; j < k2+1; j++)
                    {
                    Array[k1,j] = Znachenie;
                    Znachenie++;
                    }
                
                for(int j = k1+1; j < k2+1; j++)
                    {
                    Array[j,k2] = Znachenie;
                    Znachenie++;
                    }

                for(int j = k2-1; j >=k1; j--)
                    {
                    Array[k2,j] = Znachenie;
                    Znachenie++;
                    }

                for(int j = k2-1; j >=k1+1; j--)
                    {
                    Array[j,k1] = Znachenie;
                    Znachenie++;
                    }

                k1++;
                k2--;
            }
        return;
    }

// Вывод массива
void OutputTheArray(int[,] Array)
    {
        for(int i=0; i<Array.GetLength(0); i++)
            {
                for(int j=0; j<Array.GetLength(1); j++)
                    if(Array[i,j]<10)
                        Console.Write("  0{0} ",string.Join(",",Array[i,j]));
                    else
                        if(Array[i,j]<100)
                            Console.Write("  {0} ",string.Join(",",Array[i,j]));
                        else
                            Console.Write(" {0} ",string.Join(",",Array[i,j]));
                Console.WriteLine("");
            }
        return;
    }

// Программа
Console.WriteLine("Введите размер массива m - ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,m];
FillingTheArray(array);
OutputTheArray(array);
