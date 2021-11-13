//STROKA (выводит биты каждой буквы) +

#include <iostream>
#include <stdio.h>
#include <string.h>


int main(int argc, char** argv) {
	char a[10];
	//scanf("%s",a);
	gets(a);
	printf("\n %s %d %d", a, sizeof(a), strlen(a));
	//a[9] ='f';
	//printf("\n %s %d %d",a, sizeof(a),strlen(a));
	puts(a);
	return 0;
}