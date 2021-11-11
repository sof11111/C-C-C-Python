//вычисление факториала через рекурсию +

#include <iostream>

using namespace std;

unsigned long int fkt(unsigned long int);
int i = 1;
unsigned long int res;

int main()
{
	int n;
	cout << "Enter n!: ";
	cin >> n;
	for (int j = 1; j <= n; j++)
	{
		cout << j << "!" << "=" << fkt(j) << endl;
	}
	cout << "\nNovemer of rekurs = " << i;
	return 0;
}

unsigned long int fkt(unsigned long int f)
{
	if (f == 0 || f == 1)
		return 1;
	i++;
	res = f * fkt(f - 1);
	return res;
}
