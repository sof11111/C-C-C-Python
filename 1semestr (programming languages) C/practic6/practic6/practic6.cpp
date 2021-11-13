//Практическая работа 6 _массивы_и_указатели -

#include <locale.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int* masiv(int* a, int* b)
{
    for (; a < b - 1; a++)
        if (*a == *(a + 1))
            return a;
    return b;
}

int main()
{
    setlocale(0, "Rus");
    int* arr, n, cnt, * p;

    while (printf("Введите значение: ") && scanf("%d", &n) && n >= 5 && n <= 20)
    {
        if ((arr = (int*)malloc(n * sizeof(int))) == NULL)
        {
            //printf("Выходит за допустимое значение\n");
            return 1;
        }


        for (printf("Массив:\n"), p = arr; p < arr + n; p++)
            printf("%3d%c", *p = -50 + rand() % 101, (p - arr + 1) % 16 ? ' ' : '\n');

        for (p = arr, cnt = 0;
            (p = masiv(p, arr + n)) != arr + n; p++, cnt++);

        printf("\nКоличество пар %d\n", cnt);

        free(arr);
    }
    return 0;
}
