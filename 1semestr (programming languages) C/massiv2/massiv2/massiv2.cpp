//massiv2 (вывести матрицу, найти мин и выбрать мах) ++

#include <iostream>
#include <stdio.h>

using namespace std;

int main(int argc, char** argv)
{
	//найти в каждой строке 2 массива мин значение и из них выбрать мах
	const int N = 3, M = 4;
	int a[N][M], i, j, min, max;

	int arrmin[N];
	for (i = 0; i < N; i++)
	{
		for (j = 0; j < M; j++)
		{
			a[i][j] = rand() % 99;
			cout << a[i][j] << " ";
			//printf("%d ", a[i][j]);
		}
		cout << endl;
		//printf("\n");
	}
	for (i = 0; i < N; i++)
	{
		arrmin[i] = a[i][0];
		for (j = 1; j < M; j++)
			if (arrmin[i] > a[i][j]) arrmin[i] = a[i][j];
	}

	//printf("\n");
	cout << endl;
	for (i = 0; i < N; i++)
		cout << arrmin[i] << " ";
	//printf("%d ", arrmin[i]);

	cout << endl;
	max = arrmin[0];
	for (i = 1; i < N; i++)
		if (arrmin[i] > max) max = arrmin[i];
	cout << "m=" << max << endl;
	//printf("\nm=%d", max);


	return 0;
}


//упорядоченная программа
/*//найти в каждой строке 2 массива мин значение и из них выбрать мах
#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
	const int N = 3, M = 4;
	int a[N][M], i, j, max, arrmin[N];

	for (i = 0; i < N; i++)//рандом с выводом массива
	{
		for (j = 0; j < M; j++)
		{
			a[i][j] = rand() % 99;
			cout << a[i][j] << " ";
		}
		cout << endl;
	}

	for (i = 0; i < N; i++) //находим мин в каждой строке
	{
		arrmin[i] = a[i][0];
		for (j = 0; j < M; j++)
		{
			if (arrmin[i] > a[i][j])
			{
				arrmin[i] = a[i][j];
			}
		}
	}
	cout << endl;

	for (i = 0; i < N; i++) //выводим мин из каждом строки
	{
		cout << arrmin[i] << " ";
	}
	cout << endl;

	max = arrmin[0]; //находим среди них мах
	for (i = 1; i < N; i++)
	{
		if (arrmin[i] > max)
		{
			max = arrmin[i];
		}
	}
	cout << "m=" << max << endl;

	return 0;
}*/

