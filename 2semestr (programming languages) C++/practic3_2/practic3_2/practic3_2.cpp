#include <iostream>
#include <stdlib.h>
#include <ctime>
//#include <time.h>

using namespace std;

int main()
{
	setlocale(0, "Rus");
	srand(time(0));
	int M;
	cin >> M;
	int** arr = new int* [M];
	for (int i = 0; i < M; i++)
	{
		arr[i] = new int[M];
	}
	cout << endl;

	for (int i = 0; i < M; i++)
	{
		for (int j = 0; j < M; j++)
		{
			arr[i][j] = rand() % 10;
			cout << arr[i][j] << " ";
		}
		cout << endl;
	}
	cout << endl;

	for (int i = 0, j = M - 1; i < M && j >= 0; i++, j--)
	{
		cout << arr[i][j] << " ";

	}
	cout << endl;

	int summ = 0;

	for (int i = 1; i < M; i++)
	{
		for (int j = M - i; j <= M - 1; j++)
		{
			summ = arr[i][j] + summ;
			cout << arr[i][j] << " ";
		}
		cout << endl;
	}
	cout << endl;
	cout << summ;

	for (int i = 0; i < M; i++)
	{
		delete[] arr[i];
	}
	delete arr;
	//int arr2[M][M];
	return 0;
}