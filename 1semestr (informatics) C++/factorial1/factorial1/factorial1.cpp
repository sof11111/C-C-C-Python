//factorial через функцию +

#include <iostream>

using namespace std;

double fact(int n); //определяем функцию

int main()
{
	setlocale(LC_CTYPE, "rus");
	double x;
	int n;
	cout << "\nВведите число 'n'> ";
	cin >> n;
	double xn = fact(n); //вызываем функцию и получаем результат

	cout << "\nФакториал n = " << n << " равен " << xn << "\n\n";

	return 0;
}

//реализуем фунцкию
double fact(int n)
{
	double res = 1; //определяем переменную, которая будет результатом

	for (int i = 2; i <= n; i++)
	{
		res = res * i; //вычисляем степень
	}

	return res; //возвращаем результат
}