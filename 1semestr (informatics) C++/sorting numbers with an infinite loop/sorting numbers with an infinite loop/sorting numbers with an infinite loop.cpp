// сортировка чисел с бесконечным циклом +

#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_CTYPE, "");
	int A[10] = { 3, -1, 5, 2, 10, -3, 0, 7, -2, 11 };
	int r, f;
	cout << "Исходные данные\n";
	for (int i = 0; i <= 9; i++) //результат сортировки
	{
		cout << A[i] << "\t";
	}
	for (;;) //бесконечный цикл
	{
		f = 0; //нет обменов
		for (int i = 0; i <= 8; i++)
		{
			if (A[i] > A[i + 1])
			{
				r = A[i + 1]; //обмен
				A[i + 1] = A[i];
				A[i] = r;
				f = 1; //были обмены
			}
		}
		if (f == 0) // быход из цикла 
			break;
	}

	cout << "\nРезультат сортировки\n";
	for (int i = 0; i <= 9; i++) //результат сортировки
	{
		cout << A[i] << "\t";
	}

	return 0;
}