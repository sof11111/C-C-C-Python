//инверсия +

#include <iostream>
#include <string>

using namespace std;

int main()
{
    setlocale(LC_CTYPE, "rus_rus.1251");
    setlocale(LC_CTYPE, "rus_rus.866");

    string str;
    getline(cin, str);
    int l = str.length();

    if (l < 4)
        cout << "False!" << endl;

    else
    {
        string s1;

        s1 = str[l - 1];
        s1 += str[l - 2];

        for (int i = 2; i < l - 2; i++)
            s1 += str[i];

        s1 += str[1];
        s1 += str[0];

        cout << s1 << endl;
    }

    return 0;
}