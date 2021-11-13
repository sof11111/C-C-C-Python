#include <iostream>
#include <string>

using namespace std;
int main()
{
	setlocale(0, "Rus");
	int t, row(0), col(0);

	cout << "Введите t: " << endl;
	cin >> t;

	int* a = new int[5];
	int* b = new int[5];

	cout << "заполните массив A: " << endl;
	for (int i = 0; i < 5; i++)
	{
		cout << "a[" << i << "]=";
		cin >> a[i];
	}


	cout << "заполните массив B: " << endl;
	for (int i = 0; i < 5; i++)
	{
		cout << "b[" << i << "]=";
		cin >> b[i];
	}

	for (int i = 0; i < 5; i++)
	{
		if (a[i] < t)
			row++;
		if (b[i] < t)
			col++;
	}
	cout << "В массиве А: " << row << " количество элементов, меньших значения t " << t << endl;

	cout << "В массиве B: " << col << " количество элементов, меньших значения t " << t << endl;

	if (row < col)
	{
		for (int i = 0; i < 5; i++)
		{
			cout << a[i] << " ";
		}
		cout << endl;

		for (int i = 0; i < 5; i++)
		{
			cout << b[i] << " ";
		}
		cout << endl;
	}

	else
	{
		for (int i = 0; i < 5; i++)
		{
			cout << b[i] << " ";
		}
		cout << endl;

		for (int i = 0; i < 5; i++)
		{
			cout << a[i] << " ";
		}
		cout << endl;
	}

	return 0;

}