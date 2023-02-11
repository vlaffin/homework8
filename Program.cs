//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.WriteLine("введите количество строк");
// int line = int.Parse(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int column = int.Parse(Console.ReadLine());
// int[,] numbers = new int[line, column];
// GenerateArray(numbers);
// Console.WriteLine();
// Console.WriteLine("Массив до изменения: ");
// PrintArray(numbers);

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1) - 1; j++)
//     {
//         for (int h = 0; h < numbers.GetLength(1) - 1; h++)
//         {
//             if (numbers[i, h] < numbers[i, h + 1])
//             {
//                 int temp = 0;
//                 temp = numbers[i, h];
//                 numbers[i, h] = numbers[i, h + 1];
//                 numbers[i, h + 1] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Массив по убыванию чисел: ");
// PrintArray(numbers);

// void GenerateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(10, 100);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// int[,] array = new int[5, 4];
// GenerateArray(array);
// PrintArray(array);
// Console.WriteLine();
// LineAmount(array);


// void LineAmount(int[,] array)
// {
//     int min = 0;
//     int minSum = 0;
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         min = min + array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//         {
//         sum = sum + array[i, j];
//         }
//         if (sum < min)
//         {
//             min = sum;
//             minSum = i;
//         }
//         sum = 0;
//     }
//     Console.Write($"{minSum + 1} строка");
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void GenerateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }


//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// Console.WriteLine("Введите количество строк: ");
// int line = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int column = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int[,] array = new int[line, column];
// int[,] secondArray = new int[line, column];
// int[,] resultArray = new int[line, column];

// GenerateArray(array);
// PrintArray(array);

// Console.WriteLine();

// GenerateArray(secondArray);
// PrintArray(secondArray);

// Console.WriteLine();

// if (array.GetLength(0) != secondArray.GetLength(1))
// {
//     Console.WriteLine(" Нельзя перемножить ");
//     return;
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < secondArray.GetLength(1); j++)
//     {
//         resultArray[i, j] = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             resultArray[i, j] += array[i, k] * secondArray[k, j];
//         }
//     }
// }

// PrintArray(resultArray);



// void GenerateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// System.Console.WriteLine("Введите размерность 1: ");
// int Razmer1 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите размерность 1: ");
// int Razmer2 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите размерность 1: ");
// int Razmer3 = int.Parse(Console.ReadLine());
// int countNums = 89;

// if (Razmer1 * Razmer2 * Razmer3 > countNums)
// {
//     Console.Write("Перебор,массив слишком большой");
//     return;
// }

// int[,,] ThreeDimensionalArray = Create3DMassive(Razmer1, Razmer2, Razmer3);

// for (int i = 0; i < ThreeDimensionalArray.GetLength(0); i++)
// {
//     for (int j = 0; j < ThreeDimensionalArray.GetLength(1); j++)
//     {
//         for (int k = 0; k < ThreeDimensionalArray.GetLength(2); k++)
//         {
//             Console.WriteLine($"[{i},{j},{k}] - {ThreeDimensionalArray[i, j, k]}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int[,,] Create3DMassive(int size1, int size2, int size3)
// {
//     int[,,] array = new int[size1, size2, size3];
//     int[] values = new int[countNums];
//     int num = 10;
//     for (int i = 0; i < values.Length; i++)
//         values[i] = num++;

//     for (int i = 0; i < values.Length; i++)
//     {
//         int randomInd = new Random().Next(0, values.Length);
//         int temp = values[i];
//         values[i] = values[randomInd];
//         values[randomInd] = temp;
//     }

//     int valueIndex = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = values[valueIndex++];
//             }
//         }
//     }
//     return array;
// }

// Напишите программу, которая заполнит спирально массив 4 на 4.

// int razmer = 4;
// int[,] array = new int[razmer, razmer];
// ArraySpiralniy(array, razmer);
// PrintArray(array);



// void ArraySpiralniy(int[,] array, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }