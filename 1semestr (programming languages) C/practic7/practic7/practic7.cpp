#include <stdio.h> 
#include <stdlib.h>
#include <conio.h>
#include <Windows.h>


int LastPos(char* text, char* toFind)
{
	int index = 0, counter = 0;
	for (int i = strlen(text) - 1; i >= 0; i--)
	{
		for (int j = strlen(toFind) - 1; j >= 0; j--)
		{
			if (text[i - counter] == toFind[j])
			{
				if (counter == strlen(toFind) - 1)
					return index = i - counter + 1;
				counter++;
			}
			else
			{
				counter = 0;
			}
		}
	}
	return index;
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

