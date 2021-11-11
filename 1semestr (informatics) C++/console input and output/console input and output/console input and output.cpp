//ввод и вывод кирилицы в консольном приложение

#include <iostream>
#include <string>
using namespace std;


int main()
{
	string s; //объявляем строковую переменную

	//setlocale(LC_CTYPE, "rus_rus.1251"); //установить кодировку кириллицы для вывода на экран текста

	setlocale(LC_CTYPE, ""); //аналог предыдущей строки 	
	cout << "Введите строку > "; //вывод на экран консоли текста
	std::getline(cin, s);//ввод с консоли строки
	cout << "\nВведена строка > ";//вывод на экран консоли текста
	setlocale(LC_CTYPE, "rus_rus.866");//смена кодировки кириллицы, для корректного отображения на консоли содержимого переменной
	cout << s << '\n';//вывод переменной

	setlocale(LC_CTYPE, "rus_rus.1251");
	cout << "\n\nВведите еще одну строку > ";
	std::getline(cin, s);
	cout << "\nВведена строка > ";
	setlocale(LC_CTYPE, "rus_rus.866");
	cout << s << '\n';

	return 0;
}