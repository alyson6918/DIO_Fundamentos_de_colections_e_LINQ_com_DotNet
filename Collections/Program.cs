﻿using Collections.Helper;
ArrayOperations operations = new ArrayOperations();
int[] n = new int[5]{4,9,3,2,1};
System.Console.WriteLine("Array Original:");
operations.ArrayImpress(n);
operations.BlubleSortOrder(ref n);
System.Console.WriteLine("Array ordenado:");
operations.ArrayImpress(n);

// int[,] matriz = new int[4, 2]{{8,8},{9,2},{3,4},{5,1}};
// for (int i = 0; i < matriz.GetLength(0); i++)
// {
//     for (int j = 0; j < matriz.GetLength(1); j++)
//     {
//         System.Console.WriteLine($"matriz posição {i}, {j}: {matriz[i,j]}");
//     }
// }

// int[] arrayInts = new int[3];
// arrayInts[0]=10;
// arrayInts[1]=20;
// arrayInts[2]=30;
// foreach(int i in arrayInts){System.Console.WriteLine(i);}