#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <string.h>
using namespace std;
int main()
{
	setlocale(0, "");
	FILE* f;
	int c;
	int digitcaunter = 0, sum = 0;
	char buf[50];
	if ((f = fopen("t.txt", "r")) == 0)
		perror("t.txt");
	else
		while ((c = fgetc(f)) != EOF)
		{
			putchar(c);
			if (c >= '0' && c <= '9')
			{
				digitcaunter++;
				sum += c - '0';
			}
		}
	cout << "Количество чисел: " << digitcaunter << endl << "Cумма чисел: " << sum << endl;		
	fclose(f);
	system("pause");
	return 0;
}
