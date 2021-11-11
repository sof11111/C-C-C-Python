//massiv(cумма под главной диагональю) +

#include <iostream>

using namespace std;
const int SIZE = 4;

int summUnderMainDiag(int arr[][SIZE])//, int size)
{
	int summ = 0;
	for (int i = 1; i < SIZE; i++)
	{
		for (int j = 0; j < i; j++)
		{
			//cout << arr[i][j] << " ";
			summ = arr[i][j] + summ;
		}
		//cout << endl;
	}
	return summ;
}
int main()
{
	setlocale(0, "Rus");
	const int SIZE1 = SIZE, SIZE2 = SIZE;
	int arr[SIZE1][SIZE2];
	for (int i = 0; i < SIZE1; i++)
	{
		for (int j = 0; j < SIZE2; j++)
		{
			arr[i][j] = rand() % 100;
		}
	}
	for (int i = 0; i < SIZE1; i++)
	{
		for (int j = 0; j < SIZE2; j++) //цикл по квартирам
		{
			cout << arr[i][j] << " ";
		}
		cout << endl;
	}
	cout << endl;
	int summa = summUnderMainDiag(arr);
	cout << "Сумма элементов под главной диагоналей = " << summa;
	return 0;
}