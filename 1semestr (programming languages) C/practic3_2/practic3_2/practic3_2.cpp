//Программа распаковки и упаковки (София Г. 2вариант.)

#include <iostream>
#include <stdio.h>

using namespace std;

int main(void) {
	setlocale(LC_ALL, "Russian");

	unsigned int c, e, i, p, k;
	unsigned int UnitStateWord;

	printf("Введите маску каналов  (0 - 3) >");
	scanf("%d", &c);
	UnitStateWord = ((unsigned int)c & 3) << 12;
	//cout << UnitStateWord << endl;

	printf("Введите маску внешнего прерывания >");
	scanf("%d", &e);
	UnitStateWord |= ((unsigned int)e & 1) << 11;
	//cout << UnitStateWord << endl;

	printf("Введите маску внутреннего прерывания >");
	scanf("%d", &i);
	UnitStateWord |= ((unsigned char)i & 1) << 10;
	//cout << UnitStateWord << endl;

	printf("Введите маску программного прерывания >");
	scanf("%d", &p);
	UnitStateWord |= ((unsigned char)p & 1) << 9;
	//cout << UnitStateWord << endl;

	printf("Введите ключ защиты памяти >"); // предпологаем что мах к = 1
	scanf("%d", &k);
	UnitStateWord |= ((unsigned char)k & 1) << 3;//
	////cout << UnitStateWord << endl;

	printf("\nСлово состояния устройства = %04x\n", UnitStateWord);

	c = (UnitStateWord >> 12) & 3;
	e = (UnitStateWord >> 11) & 1;
	i = (UnitStateWord >> 10) & 1;
	p = (UnitStateWord >> 9) & 1;
	k = (UnitStateWord >> 3) & 1;//
	printf("Код состояния = %d\n", c);

	return 0;
}