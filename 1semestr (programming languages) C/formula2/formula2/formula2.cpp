#define _USE_MATH_DEFINES // для математический формул языка С
#include <math.h> // для математический формул языка С
#include <clocale> // для setlocale(LC_ALL, "Russian");
#include <Windows.h>  // Для SetConsoleCP(1251) и 								
// SetConsoleOutputCP(1251)
#include <iostream> //стандартная библиотека ввода и вывода
#pragma warning(disable:4996) // (Отключает ошибку и предупреждение)


using namespace std; //пространство имен

int main(void) // входим в программу  
{
	setlocale(LC_ALL, "Russian"); // выводит на русском 
	SetConsoleCP(1251); // в потоке ввода на русском
	SetConsoleOutputCP(1251); // в поток вывода на русском
	//const float e1 = 2.718281828459045235360287471;

	float u, t1, t2, t3, t4, x, y, z; //числа с плавающей точкой

	printf("Введите x, y, z >"); // ввод в консоли 
	scanf("%f%f%f", &x, &y, &z); // числа с плавающей точкой
								 //ссылки на переменные

	t1 = pow(8 + (pow((fabs(x - y)), 2) + 1), 1 / 3); // возведение в степень и модуль
	t2 = pow(x, 2) + pow(y, 2) + 2; // возведение в степень и сложение
	t3 = pow(M_E, fabs(x - y)); // возведение в степень е и модуль 
	t4 = pow(pow(tan(z), 2) + 1, x); // возведение в степень и тангенс 
	u = t1 / t2 - t3 * t4; // деление, вычитание и умножение

	printf("u=%f", u); // вывод в консоль ответ

	return 0; //выход из функции
}

//вводим -4,5
//0, 000075
//84, 5
