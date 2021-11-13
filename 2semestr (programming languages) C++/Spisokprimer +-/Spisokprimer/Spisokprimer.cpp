// SPISOK.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
// реализация программы по построению двунаправленного 
// кольцевого списка
// выполняются следующие действия
// ввод элемента
// удаление элемента
// замена элемента
// добавление элемента
// печать списка
// поиск элемента
// печать элемента
//получение адреса элемента списка по его id

//#include "pch.h"
#include <iostream>
#include <windows.h>
#include <stdio.h>
using namespace std;

int fmenu(char**);          // объявление функции меню
// создаем структуру списка
struct Spis
{
	Spis* previous_item; //место для хранения адреса предыдущего элемента
	int d;               // значение элемента
	int id;              // идентификатор элемента списка создается автом начиная с 0
	Spis* next_item;     // место для хранения адреса последующего элемента 
};
// окончание создания структуры списка


//-----------------------------------------------------
// создаем массив меню

char m1[] = { "1.ввод элемента                    :\n" };
char m2[] = { "2.удаление элемента по его id      :\n" };
char m3[] = { "3.замена элемента по его значению  :\n" };
char m4[] = { "4.добавление элемента              :\n" };
char m5[] = { "5.печать списка                    :\n" };
char m6[] = { "6.поиск элемента по его значению   :\n" };
char m7[] = { "7.печать элемента по его id        :\n" };
char m8[] = { "8.печать элемента по его значению  :\n" };
char m9[] = { "9.выход                            :\n" };
char* menu[] = { m1,m2,m3,m4,m5,m6,m7,m8,m9 };
//---------------------печать-----------------------------------
Spis* pStart,       // пер-ная. для хра-ния адреса начала списка 
* pEnd,              // пер-ная. для хра-ния адреса последнего эл-та 
* pCurrent,          // пер-ная. для хра-ния адреса текущего эл-та списка
* pTemp,             // пер-ная. для хра-ния промежуточного адреса эл-та списка
* pPrev;             // пер-ная. для хра-ния предыдущего адреса эл-та списка
int count0 = -1;

void input_item();              // функция ввода элемента списка
void del_item(int);             // функция удаления элемента списка по его id
void change_item(int);          // функция замены элемента списка по его значению
void add_item(int, int);         // функация добавления элемента в список 1 аргумент
								// перед каким добавляем 2-ой что добавляем
void print_spis();              // печать всего списка
int find_item(int);             // поиск элемента списка по его значению возвращает его id
Spis* find_item(int, int fl);    // поиск элемента списка по его значению возвращает адрес 
void print_item_id(int);        // печать элемента списка по его id
void print_item_value(int);     // печать элемента списка по его значению
void exit_programm();           // выход из программы
char z;
int main()
{

	SetConsoleCP(1251);      // подключаем русский язык 
	SetConsoleOutputCP(1251);// на вывод и ввод
			 // счетчик элементов списка -1 элем-тов нет
	Spis* pStart,            // пер-ная. для хра-ния адреса начала списка 
		* pEnd,              // пер-ная. для хра-ния адреса последнего эл-та 
		* pCurrent,          // пер-ная. для хра-ния адреса текущего эл-та списка
		* pTemp,             // пер-ная. для хра-ния промежуточного адреса эл-та списка
		* pPrev;             // пер-ная. для хра-ния предыдущего адреса эл-та списка
	for (; 1;)
		switch (fmenu(menu))
		{
		case 1:input_item(); break;//вызов функции ввода элемента;
		case 2:int id; cout << "введи id для удаления:"; cin >> id;
			del_item(id); break;//вызов функции удаления элемента по его id;
		case 3:int value1; cout << "введи value для поиска и дальнейшей замены:";
			cin >> value1; change_item(value1); break;//вызов функции замены элемента по его номеру в списке;
		case 4:int value3, value2; cout << "введи value для поиска:";
			cin >> value3;
			cout << endl << "введи value для добавления:";
			cin >> value2;
			add_item(value3, value2); break;//вызов функции добавление элемента на место элемента 
							// c определенным значением;
		case 5:print_spis(); break;//вызов функции печать списка;
		case 6:int value, id_find; cout << "введи value для поиска:"; cin >> value;
			id_find = find_item(value); cout << id_find << endl; break;
			//вызов функции поиск элемента по его значению;
			// возвращает id найденного элемента
		case 7:int id0; cout << "введи id для поиска:"; cin >> id0;
			print_item_id(id0); break;//вызов функции печать элемента по его номеру;
		case 8:int value0; cout << "введи value для поиска:"; cin >> value0;
			print_item_value(value0); break;// печать элемента по его значению
		case 9:exit_programm();//вызов функции выход;
		default: {cout << "неверен пункт меню, повторите"; system("pause"); break;
		}
		}
}
void flush_stdin()
{
	cin.clear();
	while (cin.get() != '\n');
}
int fmenu(char* x[])
{
	int q;
	for (int i = 0; i < 9; i++)
		cout << x[i];  // вывод пунктов меню
	cin >> q;

	return q;                  // возвращается пункт меню
}
void input_item()
{
	pCurrent = new Spis;
	cout << endl << "введите значение элемента:";
	cin >> pCurrent->d;
	if (count0 == -1) //не создавали ни одного элемента списка
	{
		count0 += 1;
		pCurrent->id = count0;
		pStart = pCurrent; // запомнили адрес начала списка
		pEnd = pCurrent;   // запомнили адрес последнего элемента списка
		pCurrent->previous_item = pCurrent;//  для 0-го элемента адрес предыдущего эл-та
		pCurrent->next_item = pCurrent;    // совпадает с адресом последующего эл-та
		pTemp = pCurrent;                  // запомнили тек. адрес, потребуется при вводе 
											// следующего эл-та		
	}
	else
	{
		count0 += 1;
		pCurrent->id = count0;
		pEnd = pCurrent;       // запомнили адрес последнего элемента списка
		pCurrent->previous_item = pTemp;// запомнили в текущем адрес предыдущего эл-та
		pCurrent->next_item = pTemp->next_item;// в поле след. текущего переписали
											   // след. из предыщего
		//cin >> pCurrent->d;
		pStart->previous_item = pEnd;
		pTemp->next_item = pCurrent;
		pTemp = pCurrent;            // запомнили тек. адрес, потребуется при вводе 
											// следующего эл-та
	}
}
void print_spis()
{
	if (count0 < 0) {
		cout << "элементов в списке нет" << endl;
		system("pause"); return;
	}
	pCurrent = pStart;
	cout << pStart << endl;
	for (int i = 0; i <= count0; i++)
	{
		cout << pCurrent->previous_item << " : " << pCurrent->id << " : " <<
			pCurrent->d << " : " << pCurrent->next_item << endl;
		pCurrent = pCurrent->next_item;
	}
	cout << pEnd << endl;
}
void print_item_id(int n)
{
	int flag = 0;
	if (count0 < 0) {
		cout << "элементов в списке нет" << endl;
		system("pause"); return;
	}
	if (n > count0) {
		cout << "переданный номер больше махсимального в списке" << endl;
		system("pause"); return;
	}
	pCurrent = pStart;
	for (int i = 0; i <= count0; i++)
	{
		if (pCurrent->id == n) // совпадают ли id
		{
			flag = 1;
			cout << pCurrent->previous_item << " : " << pCurrent->id << " : " <<
				pCurrent->d << " : " << pCurrent->next_item << endl;
			return;
		}
		else
			pCurrent = pCurrent->next_item;	// получение адреса след. элемента	
	}
	if (!flag) cout << "элемента с id=" << n << " нет в списке" << endl;
}
void print_item_value(int value)
{
	int d;
	int flag = 0;
	pCurrent = pStart;
	for (int i = 0; i <= count0; i++)
	{
		if (pCurrent->d == value)
		{
			flag = 1;
			cout << pCurrent->previous_item << " : " << pCurrent->id << " : " <<
				pCurrent->d << " : " << pCurrent->next_item << endl;
			cout << "искать далее?(1/0)"; cin >> d;
			if (d == 0)return;
			pCurrent = pCurrent->next_item;
		}
		else
			pCurrent = pCurrent->next_item;
	}
	if (!flag) cout << "элемента с зачением=" << value << " нет в списке" << endl;
}
void exit_programm() { exit(1); }
void del_item(int n) {
	int flag = 0;
	if (count0 < 0) {
		cout << "элементов в списке нет" << endl;
		system("pause"); return;
	}
	if (n > count0) {
		cout << "переданный номер больше махсимального в списке" << endl;
		system("pause"); return;
	}
	pCurrent = pStart;
	for (int i = 0; i <= count0; i++)
	{
		if (pCurrent->id == n)
		{
			flag = 1;
			// берем в найденном элементе адрес предыдущего и в поле следующего
			// предыдущего элемента записываем значение следующего из найденного
			pCurrent->previous_item->next_item = pCurrent->next_item;

			//берем в найденном элементе адрес последующего и в поле предыдущего
			// следущего элемента записываем значение предыдущего из найденного
			pCurrent->next_item->previous_item = pCurrent->previous_item;
			delete pCurrent;
			count0 -= 1;
			return;
		}
		else
			pCurrent = pCurrent->next_item;
	}
	if (!flag) cout << "элемента с id=" << n << " нет в списке" << endl;

}
int find_item(int value)
{
	int d;
	int flag = 0;
	pCurrent = pStart;
	for (int i = 0; i <= count0; i++)
	{
		if (pCurrent->d == value) // совпадают ли значения
		{
			flag = 1;
			cout << pCurrent->previous_item << " : " << pCurrent->id << " : " <<
				pCurrent->d << " : " << pCurrent->next_item << endl;
			cout << "искать далее?(1/0)"; cin >> d;
			if (d == 0) return pCurrent->id;//возвращаем id найденного элемента
			pCurrent = pCurrent->next_item; flag = 0;
		}
		else
			pCurrent = pCurrent->next_item;
	}
	if (!flag) {
		cout << "элемента с зачением=" << value << " нет в списке" << endl;
		return -1;
	}
}
Spis* find_item(int value, int fl)
{
	int d;
	int flag = 0;
	pCurrent = pStart;
	for (int i = 0; i <= count0; i++)
	{
		if (pCurrent->d == value)
		{
			flag = 1;
			cout << pCurrent->previous_item << " : " << pCurrent->id << " : " <<
				pCurrent->d << " : " << pCurrent->next_item << endl;
			cout << "искать далее?(1/0)"; cin >> d;
			if (d == 0) return pCurrent;//возвращаем адрес найденного элемента
			pCurrent = pCurrent->next_item; flag = 0;
		}
		else
			pCurrent = pCurrent->next_item;
	}
	if (!flag) {
		cout << "элемента с зачением=" << value << " нет в списке" << endl;
		return nullptr;
	}

}
void change_item(int value1)
{
	Spis* x;
	int z;        // переменная для замены
	x = find_item(value1, 1);
	if (x == nullptr) return;
	cout << "введи значение для замены:"; cin >> z;
	cout << endl;
	x->d = z;
}
void add_item(int value3, int value2)
{
	Spis* pAdd, * pFind;
	pFind = find_item(value3, 1);//находим адрес искомого элемента
	if (pFind == nullptr) return;//если искомого нет то вываливаемся
	pAdd = new Spis;  // создаем новый элемент списка
	count0 += 1;// увеличиваем счетчик элементов и получаем новый id
	pAdd->d = value2;
	pAdd->id = count0;
	// заполнение полей
	// берем у найденного элемента(pFind) из поля предыдущий элемент(previous_item)
	// его адрес, и по этому адресу вытаскиваем из поле следующего элемента(previous_item)
	// адрес и заносим его в  поле (next)следующего добавляемого элемента по адресу pAdd
	pAdd->next_item = pFind->previous_item->next_item;
	// меняем на адрес pAdd поле next_item в 
	//элементе pFind->previous_item
	pFind->previous_item->next_item = pAdd;
	// берем у найденного элемента(pFind) значение поля previous_item
	// и прописываем его в поле previous_item добавляемого элемента(pAdd)
	pAdd->previous_item = pFind->previous_item;
	// заменяем поле previous_item элемента pFind на значение pAdd
	pFind->previous_item = pAdd;
}
