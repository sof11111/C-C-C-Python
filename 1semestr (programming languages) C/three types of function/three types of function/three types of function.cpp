//функции

#include <iostream>
using namespace std;

//передача даных по значению
int maxx(int x1, int x2)
{
	x1 = x1 + 10;
	if (x1 > x2) return x1; else return x2;
}

//передача даных по адресу
int maxa(int* x1, int* x2)
{
	*x1 = *x1 + 10;
	if (*x1 > *x2) return *x1; else return *x2; //взять данные по адресу и сравнить 
}

//передача даных по ссылке
int maxc(int& x1, int& x2)
{
	x1 = x1 + 10;
	if (x1 > x2) return x1; else return x2;
}

int main(int argc, char** argv)
{
	setlocale(LC_CTYPE, "");
	int n, m;
	scanf("%d%d", &n, &m);

	printf("\n max=%d", maxx(n, m));
	printf("\n %d", n);

	printf("\n %d max=%d %d", n, maxa(&n, &m), n);
	printf("\n %d", n);

	printf("\n max=%d", maxc(n, m));
	printf("\n %d", n);

	return 0;
}


