#include <iostream>
#include <string>
#include <Windows.h>


using namespace std;
int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	string processor_1, processor_2, processor_3; //три названия процессора
	string frequency_1, type_1; //частота и тип Pentium-III
	string frequency_2, type_2; //частота и тип AMD-К6
	string frequency_3, type_3; //частота и тип PowerPC-620

	cout << "Введите название процессоров:\n";
	cin >> processor_1 >> processor_2 >> processor_3;
	cout << "Введите частоту (Mgz) и тип для " << processor_1 << endl;
	cin >> frequency_1 >> type_1;
	cout << "Введите частоту (Mgz) и тип для " << processor_2 << endl;
	cin >> frequency_2 >> type_2;
	cout << "Введите частоту (Mgz) и тип для " << processor_3 << endl;
	cin >> frequency_3 >> type_3;

	//вывод данных//

	cout << "|---------------------------------------------------------------|" << endl;
	cout << "|                      Характеристики ПЭВМ                      |" << endl;
	cout << "|---------------------------------------------------------------|" << endl;
	cout << "|Процессор\t|Частота (Mgz)\t|RAM (Mb)\t |Тип\t\t|" << endl;
	cout << "|---------------------------------------------------------------|" << endl;
	cout << "|" << processor_1 << "\t|" << frequency_1 << "\t\t|" << " \t\t |" << type_1 << "\t\t|" << endl;
	cout << "|---------------------------------------------------------------|" << endl;
	cout << "|" << processor_2 << "\t\t|" << frequency_2 << "\t\t|" << " \t\t |" << type_2 << "\t\t|" << endl;
	cout << "|---------------------------------------------------------------|" << endl;
	cout << "|" << processor_3 << "\t|" << frequency_3 << "\t\t|" << " \t\t |" << type_3 << "\t\t|" << endl;
	cout << "|---------------------------------------------------------------|" << endl;
	cout << "|          Тип: C - CISC-процессор, R - RISC-процессор          |" << endl;
	cout << "|---------------------------------------------------------------|" << endl;

	return 0;

}


/*вводим
--
Pentium-III
AMD-К6
PowerPC-620
--
233
C
--
166
C
--
2000
R
--
*/
