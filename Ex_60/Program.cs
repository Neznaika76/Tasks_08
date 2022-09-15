// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// перебор трехмерного массива
void PassingTheArray(int[,,] Array, int x, int y, int z)
    {
        int Element = 0;
        for(int i=0; i<=x; i++)
            for(int j=0; j<=y; j++)
                for(int k=0; k<=z-1; k++)
                    if(Array[i,j,k]==Array[x,y,z])
                        {
                            Array[x,y,z]=Array[x,y,z]+i;
                            Element = 1;
                        }               
        if(Element==1)
            PassingTheArray(Array,x,y,z);
        return;
    }

// заполние трехмерного массива
void FillingTheArray(int[,,] Array)
    {
        Random random = new Random();
        for(int i=0; i<Array.GetLength(0); i++)
            for(int j=0; j<Array.GetLength(1); j++)
                for(int k=0; k<Array.GetLength(2); k++)
                    {
                        Array[i,j,k]=random.Next(0,99);
                        PassingTheArray(Array,i,j,k);
                    }
        return;
    }

// Вывод массива
void OutputTheArray(int[,,] Array)
    {
        for(int i=0; i<Array.GetLength(0); i++)
            for(int j=0; j<Array.GetLength(1); j++)
            {
                for(int k=0; k<Array.GetLength(2); k++)
                    {
                        Console.Write(" {0} ",string.Join(",",Array[i,j,k]));
                        Console.Write($"({i},{j},{k})");
                    }
                Console.WriteLine("");
            }
        return;
    }



// Программа
Console.WriteLine("Введите значение X - ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Y - ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Z - ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[x,y,z];
FillingTheArray(array);
Console.WriteLine("_____________________________");
OutputTheArray(array);