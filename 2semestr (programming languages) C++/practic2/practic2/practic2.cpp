#include<stdio.h>
#include <Windows.h>.
#include <clocale>
#include <iostream>
#pragma warning(disable:4996)
using namespace std;

struct Anketa
{
	char FIO[30];
	char street[30];
	int num_house;
	int kv_house;
	char pol;
	int vozrast;
};


int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	setlocale(LC_ALL, "rus");

	int i, j, g;
	Anketa Anketa1[3];


	for (i = 0; i < sizeof(Anketa1) / sizeof(Anketa); i++)
	{
		printf("Введите ФИО: \n");
		scanf("%s %s %s", &Anketa1[i].FIO, &Anketa1[i].FIO, &Anketa1[i].FIO);

		printf("Введите улица:");
		scanf("%s", &Anketa1[i].street);

		printf("Введите номер дома:");
		scanf("%d", &Anketa1[i].num_house);

		printf("Введите номер квартиры:");
		scanf("%d", &Anketa1[i].kv_house);

		printf("Введите пол:");
		scanf("%s", &Anketa1[i].pol);

		printf("Введите возраст:");
		scanf("%d", &Anketa1[i].vozrast);
	}

	g = 0;
	for (i = 0; i < sizeof(Anketa1) / sizeof(Anketa); i++)
	{
		for (j = i + 1; j < sizeof(Anketa1) / sizeof(Anketa); j++)
		{
			if (Anketa1[i].num_house == Anketa1[j].num_house && i != j)
			{
				if ((Anketa1[j].pol == 'r') && (Anketa1[j].vozrast >= 30) && strcmp(Anketa1[i].street, Anketa1[j].street) == 0)
				{
					g++;
				}
				if (g == sizeof(Anketa1) / sizeof(Anketa) - 1 && i == 0)
				{
					i = sizeof(Anketa1) / sizeof(Anketa);
					j = sizeof(Anketa1) / sizeof(Anketa);
					//g++;					
				}
			}
		}
	}
	printf("Количество женщин в доме = %d", g + 1);

	return 0;
}

