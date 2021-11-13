#include <iostream>
#include <string.h>
#include <fstream>

using namespace std;
int main()
{
	setlocale(0, "");
	fstream f("t.txt");
	char c;
	int sum = 0, caunter = 0;
	if (!f)
	{
		cout << "Ошибка файл не открыт" << endl;
	}
	else
	{
		while((f.peek())!=EOF)
		{
			f >> c;
			cout << c << endl;
			if (c >= '0' && c <= '9')
			{
				caunter++;
				sum += c -'0';
			}
		}
	}
	cout << sum << endl << caunter << endl;
	f.close();
	return 0;
}