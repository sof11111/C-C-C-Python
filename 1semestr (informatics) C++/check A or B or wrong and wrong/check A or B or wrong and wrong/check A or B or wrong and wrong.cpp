// проверка А или В или не то и не то  -

#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_CTYPE, "");
	char c;
	cout << "\n  Введите букву >";
	cin >> c;
	cout << "\n Введена буква - " << c;

	switch (c)
	{
	case 'A': case 'a':
		cout << "\n Это буква А \n";
		break;
	case 'B': case 'b':
		cout << "\n Это буква B \n";
		break;
	default:
		cout << "\n Это не А и не B \n";
	}
	return 0;
}