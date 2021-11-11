//matrica(выведение и переворачивание и сумма по столбцам и умножение)-работает

#include <iostream>
using namespace std;
const int n = 3;
void matrMult(int a[n][n], int b[n][n], int rez[n][n])
{
	int counter = 0;
	//if (stolb_a == strok_b) 
	for (int i = 0; i < n; i++) {//меняется медленнее всего (в нашем случаее номер строки i a[i][k])
		for (int j = 0; j < n; j++) { // меняется бысрее (в нашем случаее номер столбца j b[k][j])
			for (int k = 0; k < n; k++) // меняется быстрее всего
				counter += a[i][k] * b[k][j];//номер столбца k a[i][k] и номер строки k b[k][j] изменяются бысро и одновременно
			rez[i][j] = counter;//результат записываем после перебора столбцов a[i][k] и строк b[k][j]
			counter = 0;
		}
		/*for (int j = 0; j < n; j++)
			rez[j][i]=counter;
		counter=0;*/
	}
}
int main() {
	setlocale(0, "Rus");
	//const int n = 3;
	int A[n][n], B[n][n], j, i, summStolb[n];
	int counter = 0, rez[n][n];
	cout << "Ввести элементы матрицы: \n";
	for (i = 0; i < n; i++) {
		for (j = 0; j < n; j++)
			cin >> A[i][j];
	}
	for (i = 0; i < n; i++) {
		for (j = 0; j < n; j++)
			B[i][j] = A[j][i];
	}
	cout << "Транспанированная матрица: \n";
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
	cout << "Сумма по столбцам: \n";
	for (j = 0; j < n; j++)
		cout << summStolb[j] << " ";
	cout << endl;
	cout << "Результат умножения матриц: \n";
	; matrMult(A, B, rez);
	for (i = 0; i < n; i++) {
		for (j = 0; j < n; j++)
			cout << rez[i][j] << " ";
		cout << endl;
	}
	system("pause");
	return 0;
}