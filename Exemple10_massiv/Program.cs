﻿// Имеется одномерный массив array из n элементов, требуется 
// найти элемент массива, равный find
// 1. Установить счетчик index в позицию 0
// 2. Если array [index] = find, алгоритм завершил работу 
// успешно.
// 3. Увеличить index на 1
// 4. Если index < n, то перейти к шагу 2. В противном случае 
// алгоритм завершил работу безуспешно.

int[] array = { 5, 34, 8, 11, 8, 90 };

int n = array.Length;
int find = 8;
int i = 0;

while (i < n)
{
    if (array[i] == find) 
    {
        Console.WriteLine(i);
       //break прерывает цикл после нахождения 1-го нужного нам элемента
        break;
    }
    i++;
}