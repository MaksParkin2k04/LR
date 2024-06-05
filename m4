import sympy as sp

# Функция, уравнение которой нужно решить
def is_function_valid(expr):
    x = sp.symbols('x')
    try:
        sp.sympify(expr)
        return True
    except (sp.SympifyError, TypeError):
        return False

def f(x_str):
    x = sp.symbols('x')
    return sp.sympify(x_str)

# Метод трапеции
def trapezoidal_method(f, a, b, n):
    h = (b - a) / n
    result = (f(a) + f(b)) / 2.0
    for i in range(1, n):
        result += f(a + i*h)
    result *= h
    return result

# Метод Симпсона
def simpsons_method(f, a, b, n):
    h = (b - a) / n
    result = f(a) + f(b)
    for i in range(1, n, 2):
        result += 4 * f(a + i*h)
    for i in range(2, n-1, 2):
        result += 2 * f(a + i*h)
    result *= h/3
    return result

# Метод прямоугольников
def rectangle_method(f, a, b, n):
    h = (b - a) / n
    result = 0
    for i in range(n):
        result += f(a + (i + 0.5) * h)
    result *= h
    return result

# Пример использования
expression = input("Введите функцию в виде выражения Python: ")
if is_function_valid(expression):
    func = lambda x: float(f(expression).subs('x', x))
    a = float(input("Введите нижний предел интегрирования: "))
    b = float(input("Введите верхний предел интегрирования: "))
    n = int(input("Введите количество разбиений: "))

    result_trapezoidal = trapezoidal_method(func, a, b, n)
    result_simpsons = simpsons_method(func, a, b, n)
    result_rectangle = rectangle_method(func, a, b, n)


    print("Метод трапеции:", result_trapezoidal)
    print("Метод Симпсона:", result_simpsons)
    print("Метод прямоугольников:", result_rectangle)

else:
    print("Введенное выражение не является функцией.")
