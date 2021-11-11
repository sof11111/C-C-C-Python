//Вывод массива +

#include <iostream>
using namespace std;

void func(int[], int);

int main()
{
	int N = 5, mas[N] = { 1,2,3,4,5 };
	func(mas, N); //имя массива без индекса - это указатель на первый элемент массива
	return 0;
}

void func(int mas[], int N)
{
	for (int i = 0; i < N; i++)
	{
		cout << mas[i] << "\t";
	}
}