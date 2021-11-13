//matrica(выведение и переворачивание и сложение и умножение)

#include <iostream>

using namespace std;

int main()
{
	setlocale(0, "Rus");
	const int Nstolb = 4;
	const int Nstrok = 3;
	int arr[Nstrok][Nstolb];
	int imax = -1, jmax = -1, imin = -1, jmin = -1;
	for (int i = 0; i < Nstrok; i++)
	{
		for (int j = 0; j < Nstolb; j++)
		{
			arr[i][j] = rand() % 10;

			printf("%d ", arr[i][j]);
		}
		printf("\n");
	}
	int summ = 0;
	for (int i = 0; i < Nstrok; i++)
	{
		for (int j = 0; j < Nstolb; j++)
		{
			summ = arr[i][j] + summ;
		}
	}
	printf("Сумма всех элементов массива: %d ", summ);
	printf("\n");
	int max = -1000;
	for (int i = 0; i < Nstrok; i++)
	{
		for (int j = 0; j < Nstolb; j++)
		{
			if (max < arr[i][j])
			{
				max = arr[i][j];
				imax = i;
				jmax = j;
			}
		}
	}
	printf("Максимальный элемент массива: %d ", max);
	printf("\n");
	printf("Координаты максимума: %d %d", imax, jmax);
	printf("\n");
	int min = 10000;
	for (int i = 0; i < Nstrok; i++)
	{
		for (int j = 0; j < Nstolb; j++)
		{
			if (min > arr[i][j])
			{
				min = arr[i][j];
				imin = i;
				jmin = j;
			}
		}
	}
	printf("Минимальный элемент массива: %d ", min);
	printf("\n");
	printf("Координаты минимума: %d %d", imin, jmin);
	printf("\n");
	int temp = arr[imax][jmax];
	arr[imax][jmax] = arr[imin][jmin];
	arr[imin][jmin] = temp;
	for (int i = 0; i < Nstrok; i++)
	{
		for (int j = 0; j < Nstolb; j++)
		{
			printf(" %d", arr[i][j]);
		}
		printf("\n");
	}
	return 0;
}
