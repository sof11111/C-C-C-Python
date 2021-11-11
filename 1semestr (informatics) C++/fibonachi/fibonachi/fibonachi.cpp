//fibonachi +

#include <iostream>
#include <locale>

using namespace std;

int main()
{
	setlocale(LC_CTYPE, "rus");
	const int N = 10;

	int Fib[N];
	Fib[0] = 0;
	Fib[1] = 1;

	for (int i = 2; i < N; i++)
	{
		Fib[i] = Fib[i - 2] + Fib[i - 1];
	}

	cout << "/t" << N << " первых чисел фибоначчи\n\n";

	for (int i = 0; i < N; i++)
	{
		cout << Fib[i] << "\t";
	}
	cout << "\n";

	return 0;

}