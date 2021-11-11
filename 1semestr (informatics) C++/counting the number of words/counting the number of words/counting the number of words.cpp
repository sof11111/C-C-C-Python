//подсчет количества слов +

#include <iostream>
#include <string>
#include <cstring>
//#include <clocale>
//#include <conio.h>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	const int n = 100;
	char s[n];
	cout << "Введите строчку: " << endl;
	cin.getline(s, 100);
	//cout << s << endl;
	int count = 0;
	int p = strlen(s), i = 0;

	/*for(i = 0; i<p; i++)
	{
		if ((s[i] == ' ' || s[i+1] == '\0'))
			count++;
	}
	do
	{
		if ((s[i] == ' ' ||s[i] == '.'|| s[i+1] == '\0'))
			count++;
		i++;
	} while(i<p);*/

	while (i < p)
	{
		if ((s[i] == ' ' || s[i] == '.' || s[i + 1] == '\0'))
			count++;
		i++;
	}


	cout << endl << "Количество слов: " << count << endl;

	system("pause");

	return 0;
}