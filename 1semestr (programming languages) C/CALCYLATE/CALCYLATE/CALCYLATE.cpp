//CALCYLATE

#include <iostream>
#include <stdio.h>
//#pragma warning(disable:4996)

using namespace std;

int main()
{

	float x1, x2;
	char c;
	//scanf("%f %c %f", &x1, &c, &x2);
	cin >> x1 >> c >> x2;
	switch (c)
	{
	case '+':
		//printf("\n%f", x1 + x2);
		cout << x1 + x2 << endl;
		break;
	case '-':
		//printf("\n%f", x1 - x2);
		cout << x1 - x2 << endl;
		break;
	case '*':
		//printf("\n%f", x1 * x2); 
		cout << x1 * x2;
		break;
	case '/':
		if (x2 == 0)
			//printf("Error davilizion by 0");
			cout << "Error davilizion by 0";
		else
			//printf("\n%f", (x1) / (x2));
			cout << (x1) / (x2) << endl;
		break;
	default:
		//printf("\n operation error");
		cout << "operation error";
	}
	return 0;
}