// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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

//Находим номер минимальной строки
void MinTheArray(int[,] Array)
    {
        int MinStroka = 0;
        int MinSumma = 0;
        int SumStroka =0;
        for(int j=0; j<Array.GetLength(1); j++)
            SumStroka = SumStroka+Array[0,j];
        MinSumma=SumStroka;
        for(int i=1; i<Array.GetLength(0); i++)
            {  
            SumStroka = 0;   
            for(int j=0; j<Array.GetLength(1); j++)
                SumStroka = SumStroka+Array[i,j];
            if(MinSumma>SumStroka)
                {
                    MinSumma=SumStroka;
                    MinStroka=i;
                }
            else if(MinSumma==SumStroka)
                    Console.WriteLine("Возможно несколько строк с наименьшей суммой");

            }
        Console.WriteLine($"Строка с наименьшей суммой элементов - {MinStroka+1}");
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
Console.WriteLine("_____________________________");
MinTheArray(array);