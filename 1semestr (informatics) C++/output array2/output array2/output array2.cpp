//Вывод массива2 +

#include <iostream>
using namespace std;

void func(int n, int m, int* mas); //прототип функции
//void func (int, int, int *); //прототип можно описать так 

int main()
{
	int N = 4, M = 3, A[N][M] = { {1,2,3},{4,5,6},{7,8,9},{3,2,1} };

	func(N, M, A[0]); //A[0] - указатель на первый элемент первой строки 

	return 0;
}

void func(int n, int m, int* mas)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			cout << mas[i * m + j] << "\t"; //
		}
		cout << endl;
	}
}