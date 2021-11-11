//adressa +

#include <iostream>


int main(int argc, char** argv) {
	int A[5], i;
	for (i = 0; i < 5; i++)
		*(A + i) = i;//A[i]=i
	for (i = 0; i < 5; i++)
		printf("\n %d %d %d %d", &A[i], A[i], A + i, *(A + i));

	return 0;
}