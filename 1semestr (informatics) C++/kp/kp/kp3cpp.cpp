//kp1(3) +

#include <iostream>

using namespace std;
int main() {
	setlocale(0, "Rus");
	const int n = 3, m = 3;
	int A[n][m], B[n], min;
	int  j, i;
	int summ = 0;


	cout << "Матрица: \n";
	for (i = 0; i < n; i++) {
		for (j = 0; j < m; j++)
			cin >> A[i][j];
	}


	cout << endl;
	for (i = 0; i < n; i++) {
		for (j = 0; j < m; j++)
		{
			summ = A[i][j] + summ;
		}
		cout << "Сумма по строкам: " << summ << endl;
		B[i] = summ / m;
		cout << "Среднеарифмитическое: " << B[i] << endl;
		summ = 0;
		cout << endl;
	}


	cout << endl;
	cout << "Минимальное среднеарифмитическое: ";
	min = B[0];
	for (i = 0; i < n; i++)
	{
		if (B[i] < min)
			min = B[i];
	}
	cout << min << endl;


	return 0;
}
