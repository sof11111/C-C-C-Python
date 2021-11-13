//primer

#include <iostream>
#include <stdio.h>

using namespace std;

int main(void) {
	setlocale(LC_ALL, "Russian");
	int c;
	int f;
	int b;
	unsigned int n;
	unsigned int UnitStateWord;

	printf("Введите код состояния (0 - 31) >");
	scanf("%d", &c);
	UnitStateWord = ((unsigned int)c & 0x1F) << 11;

	printf("Введите признак ошибки (0 / 1) >");
	scanf("%d", &f);
	UnitStateWord |= ((unsigned int)f & 1) << 9;

	printf("Введите признак занятости (0 / 1) >");
	scanf("%d", &b);
	UnitStateWord |= ((unsigned char)b & 1) << 8;

	printf("Введите количество переданных байт (0 - 255) >");
	scanf("%d", &n);
	UnitStateWord |= n & 0xFF;

	printf("\nСлово состояния устройства = %04x\n", UnitStateWord);

	c = (UnitStateWord >> 11) & 0x1F;
	f = (UnitStateWord >> 9) & 1;
	b = (UnitStateWord >> 8) & 1;
	n = UnitStateWord & 0xFF;
	printf("Код состояния = %d\n", c);

	return 0;
}