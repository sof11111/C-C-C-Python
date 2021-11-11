def calculate():
    print("Укажите операцию")
    print("* - умножение")
    print("/ - деление")
    print("+ - сложение")
    print("- - вычитание")

    operation = input()

    if operation == '*':
        a = input("Введите первое число: ")
        b = input("Введите второе число: ")
        try:
            res = int(a) * int(b)
        except ValueError:
            print("Неверное значение") 
        else:
            print(res)

    elif operation == '/':
        a = input("Введите первое число: ")
        b = input("Введите второе число: ")
        try:
            res = int(a) / int(b)
        except ValueError:
            print("Неверное значение") 
        else:
            print(res)

    elif operation == '+':
        a = input("Введите первое число: ")
        b = input("Введите второе число: ")
        try:
            res = int(a) + int(b)
        except ValueError:
            print("Неверное значение") 
        else:
            print(res)

    elif operation == '-':
        a = input("Введите первое число: ")
        b = input("Введите второе число: ")
        try:
            res = int(a) - int(b)
        except ValueError:
            print("Неверное значение") 
        else:
            print(res)
    calculate()


calculate() 