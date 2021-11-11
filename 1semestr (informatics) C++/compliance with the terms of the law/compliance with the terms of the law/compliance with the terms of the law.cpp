// программа проверки соответствия условия закона  -

#include <iostream>
#include <string>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");

    int a;
    cout << "Введите число > ";
    cin >> a;

    a >= 18 ? cout << "Можно купить " : cout << "Нельзя купить";

    return 0;
}
