﻿ int n = 5;
 int[] array = { 2, 11, 7, 3, 1 };
 int i = 0;
 int max = array[0];

 while (i < n)
 {
     if (array[i] > max)
     {
         max = array[i];
     }
     i++;
 }

 Console.WriteLine(max);