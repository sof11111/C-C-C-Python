#include <stdio.h> 
#include <stdlib.h>
#include <conio.h>
#include <Windows.h>

int LastPos(char* s, char* s1) //Возвращает позицию (с 1) последнего вхождения подстроки s1 в строку s или 0 если вхождения нет
{
	char* len;
	char* len2;
	for (len = NULL, len2 = strstr(s, s1); len2; len2 = strstr((len = ++len2), s1));
	{
		if (len)
			return (len - s);
	}

	return 0;
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	char s1[20];
	char s[20];

	scanf("%s", s1);
	scanf("%s", s);

	printf("\nПоследнее вхождение строки %s в строку %s на %d-й позиции\n", s1, s, LastPos(s, s1));

	getch();
}

