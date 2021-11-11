//matrica(выведение и транспанирование и сумма по столбцам)-работает везде

#include <iostream>
using namespace std;
int main() {
	setlocale(0, "Rus");
	const int n = 3;
	int A[n][n], B[n][n], j, i, summStolb[n];
	int counter = 0;
	cout << "Исходная матрица: \n";
	for (i = 0; i < n; i++) {
		for (j = 0; j < n; j++)
			cin >> A[i][j];
	}
	for (i = 0; i < n; i++) {
		for (j = 0; j < n; j++)
			B[i][j] = A[j][i];
	}
	cout << "Транспонированная матрица: \n";
	for (i = 0; i < n; i++) {
		for (j = 0; j < n; j++)
			cout << B[i][j] << " ";
		cout << endl;
	}
	for (j = 0; j < n; j++) {
		counter = 0;
		for (i = 0; i < n; i++) {
			if (B[i][j] >= 0)
				counter += B[i][j];
		}
		summStolb[j] = counter;
	}
	cout << "Суммы по столбцам: \n";
	for (j = 0; j < n; j++)
		cout << summStolb[j] << " ";
	cout << endl;
	system("pause");
	return 0;
}