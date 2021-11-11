//выводит строку символов -

#include <iostream>
#include <string>
#include <clocale>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");

    string s;
    int n = 0;
    cout << "Введите строку > ";
    getline(cin, s);

    cout << endl << "В этой строке " << s.length() << " символов" << endl;

    for (int i = 0; i < s.length(); i++)
    {
        cout << i << "-й символ: " << s[i] << endl;
        if (s[i] == '(')
            n += 1;
        else
            if (s[i] == ')')
                n -= 1;
    }
    if (n == 1)
        cout << "\nВсе скобки парные\n";
    else
        if (n < 0)
        {
            n = -n;
            cout << "\nЕсть " << n << " непарных скобок '('\n";
        }


    //cout <<"n=" << n;
    return 0;
}