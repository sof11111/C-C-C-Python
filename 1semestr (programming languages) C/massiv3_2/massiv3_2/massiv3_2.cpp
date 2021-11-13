#include <iostream>
#include <stdio.h>
#include <time.h>
#pragma warning(disable:4996)

using namespace std;

int main(int argc, char** argv)
{
	setlocale(0, "Rus");
	//srand(time(0));
	const int N = 3, M = 3;
	int arr[N][M], min, max, ctolbMin = 0, ctolbMax = 0, temp[N];
	/*for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < M; j++)
			arr[i][j] = rand() % 99;
	}*/
	printf("Введите элементы массива: \n");
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < M; j++)
			scanf("%d", &arr[i][j]);
	}
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < M; j++)
			printf("%d ", arr[i][j]);
		printf("\n");
	}
	min = arr[0][0];
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < M; j++)
		{
			if (min > arr[i][j])
			{
				min = arr[i][j];
				ctolbMin = j;
			}
		}
	}

	printf("Минимальный элемент: %d ", min);
	printf("\nНомер столбца с минимальный элементом: %d ", ctolbMin);

	max = arr[0][0];
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < M; j++)
		{
			if (max < arr[i][j])
			{
				max = arr[i][j];
				ctolbMax = j;
			}
		}
	}
	printf("\nМаксимальный элемент: %d ", max);
	printf("\nНомер столбца с максимальным элементом: %d \n", ctolbMax);
	if (ctolbMin != ctolbMax)
	{
		printf("Массив с измененными столбцами: \n");
		for (int i = 0; i < N; i++)
		{
			temp[i] = arr[i][ctolbMin];
			//printf("%d \n", temp[i]);
		}
		for (int i = 0; i < N; i++)
		{
			arr[i][ctolbMin] = arr[i][ctolbMax];
			arr[i][ctolbMax] = temp[i];
		}
		for (int i = 0; i < N; i++)
		{
			for (int j = 0; j < M; j++)
				printf("%d ", arr[i][j]);
			printf("\n");
		}
	}
	else
	{
		printf("Номера столбцов с минимальным и максимальным элементом совпадают");
	}
	//вывести матрицу, найти мин и мах, поменять местами столбцы с мин и мах
	/*int a[3][3], i, j, s, min, max, imin, imax, jmax, jmin, temp;
	s = 0;
	int arrmin[3];
	for (i = 0; i < 3; i++)
		arrmin[i] = a[i][0];
	for (j = 1; j < 3; j++)
		if (arrmin[i] > a[i][j]) arrmin[i] = a[i][j];
	printf("\n");
	for (i = 0; i < 3; i++)
		printf("%d ", arrmin[i]);

	if (jmin == jmax) { printf("\n no change"); return 0; }
	for (i + 0; i < 3; i++)
	{
		temp = a[i][jmin];
		a[i][jmin] = a[i][jmax];
		a[i][jmax] = temp;
	}
	for (i = 0; i < 3; i++)
	{
		printf("\n");
		for (j = 0; j < 3; j++)
			printf("%d ", a[i][j]);
	}*/

	return 0;
}