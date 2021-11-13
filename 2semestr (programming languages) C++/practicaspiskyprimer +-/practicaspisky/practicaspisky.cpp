#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <conio.h>
#include "windows.h"
#pragma warning(disable:4703)
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	// объявление структуры элемента списка
	//	и указателей на требуемые элементы

	struct el 
	{
		struct el* pred;
		int ELEM;
		struct el* posl;
	}
	EL1, *pTEK, *pPRED, *temp, *pSTART1, *pEND1, *pSTART2, *pEND2;
	int i, z, flag = 0;

	system("CLS"); //clrscr();

	// бесконечный цикл для ввода элементов первого списка
	// так как количество элементов неизвестно
	for (;;)
	{
		cout << "\nввести элемент?"; cin >> z;
		if (z < 1) break;
		pTEK = (struct el*)(malloc(sizeof(EL1))); //выделенная память 						
												  //заносится в указатель
												  //на текущий элемент
		cout << " \nэлемент="; cin >> pTEK->ELEM; //первоначальное
																			   
		pTEK->pred = 0;  //определение полей элемента
		pTEK->posl = 0;  //списка	
						//при создании первого элемента сохраняются соответствующие адреса
		if (flag == 0) 
		{
			pSTART1 = pTEK; 
			pPRED = pTEK;
			pEND1 = pTEK; 
			flag = 1; 
			continue;
		}
		pPRED->posl = pTEK;  // заполнение полей
		pTEK->pred = pPRED;  // элементов списка
		pEND1 = pPRED = pTEK; // изменение указателей на конец списка 				
							  // и предыдущий элемент
	}
	// вывод на экран первого списка
	pTEK = pSTART1;	

	cout << "\nадрес нач элем:" << pSTART1;
	do
	{
		cout << "\n " << pTEK->pred << "  " << pTEK->ELEM << "  " << pTEK->posl;
		pTEK = pTEK->posl;
	}
	while (pTEK != 0);
	cout << "\nадрес кон элем:" << pEND1;
	// бесконечный цикл для ввода элементов второго списка
	// так как количество элементов неизвестно
	flag = 0;
	for (;;) 
	{
		cout << "\n ввести элемент:"; cin >> z;
		if (z < 1) break;
		pTEK = (struct el*)(malloc(sizeof(EL1)));
		cout << "\n элемент="; cin >> pTEK->ELEM;
		pTEK->pred = 0;
		pTEK->posl = 0; 	
		if (flag == 0) 
		{
			pSTART2 = pTEK; pPRED = pTEK; pEND2 = pTEK; flag = 1;
			continue;
		}
		pPRED->posl = pTEK;
		pTEK->pred = pPRED;
		pEND2 = pPRED = pTEK;
	}
	// вывод на экран второго  списка
	pTEK = pSTART2;
	cout << "\nадрес нач элем:" << pSTART2;
	do
	{
		cout << "\n " << pTEK->pred << "  " << pTEK->ELEM << "  " << pTEK->posl;
		pTEK = pTEK->posl;
	}
	while (pTEK != 0);
	cout << "\nадрес кон элем:" << pEND2;
	int ch, d;
	cout << "\nВвести число для проверки ";
	cin >> ch;
	// поиск искомого числа в первом списке и добавление его
	// в конец второго списка
	flag = 0;	//flag указание на начало работы с  первым эл
	pTEK = pSTART1;
	for (;;)
	{
		temp = pTEK->posl; // в temp хранится адрес послед элем списка
					// что требуется для выхода из цикла
		if (pTEK->ELEM != ch)
			if (temp == 0) break;
		{
			pTEK = pTEK->posl; flag = 1;
			continue;
		}

		if (flag == 0)pSTART1 = pTEK->posl;//если начальный элемент списка
						//удаляется то изменяется
						//начальный адрес списка 	((pTEK->pred)->posl)=(pTEK->posl);                                           // перезапися адресов впер-
		((pTEK->posl)->pred) = (pTEK->pred); // вом списке
		pEND2->posl = pTEK;	//добавлениеэлемента в
		pTEK->posl = 0;	// конец второго списка, и
		pTEK->pred = pEND2;	// настройка
	//соответствующих
		pEND2 = pTEK;	// полей элем
		pTEK = temp;	// занесение в указатель
							// адреса след элем
	}
	// вывод на экран первого списка
	cout << "\n--------------------------";
	pTEK = pSTART1;
	cout << "\nадрес нач элем:" << pSTART1;
	do
	{
		cout << "\n " << pTEK->pred << "  " << pTEK->ELEM << "  " << pTEK->posl;
		pTEK = pTEK->posl;
	}
	while (pTEK != 0);
	// вывод на экран второго списка
	pTEK = pSTART2;
	cout << "\nадрес нач элем:" << pSTART2;
	do
	{
		cout << "\n " << pTEK->pred << "  " << pTEK->ELEM << "  " << pTEK->posl;
		pTEK = pTEK->posl;
	}
	while (pTEK != 0);
	cin >> d;
	/* добавление в первый список  */
	flag = 0;
	pTEK = pSTART2;
	for (;;)
	{
		temp = pTEK->posl;
		if (pTEK->ELEM != ch)
			if (temp == 0) break;
		pTEK = pTEK->posl; flag = 1;
		continue;
		if (flag == 0)pSTART2 = pTEK->posl;
		((pTEK->pred)->posl) = (pTEK->posl);
		((pTEK->posl)->pred) = (pTEK->pred);
		pSTART1->pred = pTEK;
		pTEK->pred = 0;
		pTEK->posl = pSTART1;
		pSTART1 = pTEK;
		pTEK = temp;
	}
	cout << "\n--------------------------";
	pTEK = pSTART1;
	cout << "\nадрес нач элем:" << pSTART1;
	do
	{
		cout << "\n " << pTEK->pred << "  " << pTEK->ELEM << "  " << pTEK->posl;
		pTEK = pTEK->posl;
	}
	while (pTEK != 0);
	pTEK = pSTART2;
	cout << "\nадрес нач элем:" << pSTART2;
	do
	{
		cout << "\n " << pTEK->pred << "  " << pTEK->ELEM << "  " << pTEK->posl;
		pTEK = pTEK->posl;
	}
	while (pTEK != 0);

	return 0;
}
