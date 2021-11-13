//вывести матрицу, найти мин и мах, поменять местами столбцы с мин и мах

#include <iostream>
#include <stdio.h>
//#include <time.h>
//#pragma warning(disable:4996)

using namespace std;

int main(int argc, char** argv)
{
	setlocale(0, "Rus");
	const int N = 3, M = 3;
	int arr[N][M], min, max, ctolbMin = 0, ctolbMax = 0, temp[N];

	cout << "Введите элементы матрицы: \n";
	//printf("Введите элементы матрицы: \n");
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < M; j++)
			cin >> arr[i][j];
		//scanf("%d", &arr[i][j]);
	}

	cout << "Ваша матрица: \n";
	//printf("Ваша матрица: \n");
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < M; j++)
			cout << arr[i][j] << " ";
		//printf("%d ", arr[i][j]);
		cout << endl;
		//printf("\n");
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
	cout << "Минимальный элемент: " << min;
	//printf("Минимальный элемент: %d ", min);
	cout << "\nНомер столбца с минимальный элементом: " << ctolbMin;
	//printf("\nНомер столбца с минимальный элементом: %d ", ctolbMin);

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
	cout << "\nМаксимальный элемент: " << max;
	//printf("\nМаксимальный элемент: %d ", max);
	cout << "\nНомер столбца с максимальным элементом: " << ctolbMax << endl;
	//printf("\nНомер столбца с максимальным элементом: %d \n", ctolbMax);

	if (ctolbMin != ctolbMax)
	{
		cout << "Массив с измененными столбцами: \n";
		//printf("Массив с измененными столбцами: \n");
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
				cout << arr[i][j] << " ";
			//printf("%d ", arr[i][j]);
			cout << endl;
			//printf("\n");
		}
	}
	else
	{
		cout << "Номера столбцов с минимальным и максимальным элементом совпадают";
		//printf("Номера столбцов с минимальным и максимальным элементом совпадают");
	}
	return 0;
}







