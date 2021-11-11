//вычисление фибоначчи через рекурсию +

#include <iostream>
#include <iomanip>
using namespace std;

unsigned long int fib(unsigned long);

int main()
{
    setlocale(LC_CTYPE, "");
    unsigned long numf;
    cout << "Количество членов ряда фибоначчи > ";
    cin >> numf;
    for (int i = 1; i <= numf; i++)
        cout << setw(2) << i << " = " << fib(i) << endl;

    return 0;
}

unsigned long fib(unsigned long numf)
{
    if (numf == 1 || numf == 2)
        return (numf - 1);
    return fib(numf - 1) + fib(numf - 2);

}
