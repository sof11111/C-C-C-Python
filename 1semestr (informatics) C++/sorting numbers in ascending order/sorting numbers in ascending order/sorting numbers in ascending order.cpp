// сортировка чисел по возрастанию  +

#include <iostream>
using namespace std;
/*
int main()
{
	setlocale(LC_CTYPE, "");
	int a[10] = { 6,-1,0,2,1,5,10,-2,2,4 }, rab;
	bool f = true;
	while (f)
	{
		f = false;
		for (int i = 0; i < 9; i++)
		{
			if (a[i] > a[i + 1])
			{
				rab = a[i + 1];
				a[i + 1] = a[i];
				a[i] = rab;
				f = true;
			}
		}
	}

	for (int i = 0; i < 10; i++)
	{
		cout << " " << a[i];
	}

	return 0;
}*/
//////////////////////////////////////////////////////////////////////
#include <iostream>
using namespace std;

/*int main()
{
	setlocale(LC_CTYPE, "");
	int a[10] = {5, -1, -2, 3}, rab;
	bool f = true;
	while (f)
	{
		f = false;
		for (int i=0; i<9; i++)
		{
			if (a[i] > a[i+1])
			{
				rab = a[i+1];
				a[i+1] = a[i];
				a[i] = rab;
				f = true;
			}
		}
	}

	for (int i=0; i<10; i++)
	{
		cout << " " << a[i];
	}

	return 0;
} */

////

int main()
{
	setlocale(LC_CTYPE, "");
	int i = 1; // указатель на элемент массива
	int N = 4, M[] = { 5, -1, -2, 3 };
	int rab; // ячейка лдя обмена значений элементов массива
	int k = 0; //счетчик циклов 
	cout << "Исходный массив\n";
	for (int i = 0; i < N; i++)
		cout << M[i] << "\t";
	while (i < N)
	{
		k++;
		if (M[i - 1] < M[i]) //Есди < - сортировка по возрастанию, > - по убыванию 
			i++;
		else
		{
			rab = M[i];
			M[i] = M[i - 1];
			M[i - 1] = rab;
			i = i - 1; // после обмена возраст к предыдущему элементу массива 
		}
		if (i == 0)
			i = 1;
	}
	cout << " \nРезультат сортировки\n";
	for (int i = 0; i < N; i++)
		cout << M[i] << "\t";
	cout << "\nСчетчик циклов =" << k;
	return 0;
}

//-2 -1 3 5 





