﻿//вывести матрицу, посчитать сумму элементов, найти мин мах значение, найти их координаты, поменять их местами 
//1 вариант 


#include <iostream> //стандартная библиотека ввода и вывода
#include <stdio.h>  // для языка С, содержит макросы, константы и объявляет функции ввода и вывода (printf и scanf) 
#pragma warning(disable:4996) // (Отключает ошибку и предупреждение)


int main(int argc, char** argv) //??
{
	setlocale(0, "Rus");// выводит на русском
	const int SIZE1 = 3, SIZE2 = 3; // фиксированный рамер матрицы
	int a[SIZE1][SIZE2], i, s = 0, j, min, max, imin, imax, jmax, jmin, temp; //задаем переменные и матрицу

///////////////////////////
	printf("Введите числа в матрицу: ");
	for (i = 0; i < SIZE1; i++)//числа в строке от 0/не должны выходить за массив/увеличивает на 1
	{
		for (j = 0; j < SIZE2; j++)//числа в столбце от 0/не должны выходить за массив/увеличивает на 1
		{
			printf("\n a[%d][%d]=", i, j);//вывод матрицы			
			scanf("%d", &a[i][j]);//вывод в консоль массива						
		}
	}
	printf("\n"); //переход на новую строчку

	printf("Матрица: ");
	printf("\n"); //переход на новую строчку
	for (i = 0; i < SIZE1; i++)//числа в строке от 0/не должны выходить за массив/увеличивает на 1
	{
		for (j = 0; j < SIZE2; j++)//числа в столбце от 0/не должны выходить за массив/увеличивает на 1
		{
			printf("%d ", a[i][j]);//вывод матрицы	
		}
		printf("\n"); //переход на новую строчку
	}
	printf("\n"); //переход на новую строчку
////////////////////////////////
	printf("\n"); //переход на новую строчку
	for (i = 0; i < SIZE1; i++)//числа в строке от 0/не должны выходить за массив/увеличивает на 1
	{
		for (j = 0; j < SIZE2; j++)//числа в столбце от 0/не должны выходить за массив/увеличивает на 1
		{
			s = a[i][j] + s;//числа в массиве + 0 = сумма
		}
	}
	printf("Сумма элементов в массиве: %d ", s);//вывод в консоль сумму
	printf("\n"); //переход на новую строчку
	printf("\n"); //переход на новую строчку
/////////////////////////////////
	printf("Минимальный и максимальный: ");
	min = max = a[0][0]; //??
	imin = jmin = imax = jmax = 0; //??
	for (i = 0; i < SIZE1; i++)//числа в строке от 0/не должны выходить за массив/увеличивает на 1
	{
		for (j = 0; j < SIZE2; j++)//числа в столбце от 0/не должны выходить за массив/увеличивает на 1
		{
			if (min > a[i][j]) { min = a[i][j]; imin = i; jmin = j; }
			if (max < a[i][j]) { max = a[i][j]; imax = i; jmax = j; }
		}
	}
	printf("min=%d max=%d", min, max);
	printf("\n");//новая строчка
	printf("\n");//новая строчка
//////////////////////////////////////////////////////////
	printf("Меняем максимальный и минимальный: ");
	temp = a[imin][jmin];
	a[imin][jmin] = a[imax][jmax];
	a[imax][jmax] = temp;
	for (i = 0; i < SIZE1; i++)
	{
		printf("\n");
		for (j = 0; j < SIZE2; j++)
			printf("%d ", a[i][j]);
	}
	printf("\n");//новая строчка
	printf("\n");//новая строчка  
///////////////////////////////////////////////////////
	system("pause");
	return 0;
}
