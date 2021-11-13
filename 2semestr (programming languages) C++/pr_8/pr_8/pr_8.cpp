#include <iostream> 
#include <stdio.h> 
#include "math.h" 

using namespace std;

class FuncSolver
{
private:
	double x;
	double y;
	double z;
	double rez;
public:
	FuncSolver() {}
	FuncSolver(double x, double y, double z)
	{
		this->x = x;
		this->y = y;
		this->z = z;
	}
	void set(double x, double y, double z)
	{
		this->x = x;
		this->y = y;
		this->z = z;
	}
	double run() 
	{
		double tmp1 = pow((x - 1), (1.0 / 3.0));
		double tmp2 = pow((y + tmp1), (1.0 / 4.0));
		double tmp3 = abs(x - y);
		double tmp4 = sin(z) * sin(z) + tan(z);
		//double temp0 = pow(sin(z), 2);
		rez = tmp2 / (tmp3 * tmp4);
		return rez;
	}
	void print()
	{
		cout << "x = " << x << " " << "y = " << y << " " << "z = " << z << endl;
		cout << "Результат вычислений: " << rez << endl;
	}
};

int main()
{
	setlocale(0, "Rus");

	double x = 17.421;
	double y = 10.365 * pow(10, -3);
	double z = 0.828 * pow(10, 5);

	FuncSolver f1(x, y, z);
	f1.run();
	f1.print();

	FuncSolver* p1 = &f1;
	p1->set(1.1, 1.1, 1.1);
	p1->run();
	p1->print();
	f1.print();

	FuncSolver* f2 = new FuncSolver(x, y, z);
	f2->run();
	f2->print();

	return 0;
}