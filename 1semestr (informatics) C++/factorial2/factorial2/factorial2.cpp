//factorial - работает везде +

#include <iostream>
using namespace std;

int factorial(int numb)
{
	int mnoj = 1;
	for (int a = 1; a <= numb; a++)
	{
		mnoj = mnoj * a;
	}
	return mnoj;
}

int summa(int numb)
{
	int sum = 0;
	for (int a = 0; a < numb; a++)
	{
		sum = sum + a;
	}
	return sum;
}

int main()
{
	int sum = summa(1);
	//cout << sum << endl;
	int fact = factorial(3);
	cout << fact;

	return 0;
}