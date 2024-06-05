from math import log, exp
import numpy as np
import matplotlib.pyplot as plt

# исходные данные
x = np.array([1, 2, 3, 4, 5, 6, 7, 8, 9, 10])
y = np.array([1.1, 3.9, 8, 15.8, 26, 35.7, 50, 65, 80.5, 99.9])

# функции для вычисления средних значений и регрессии
def mean(arr):
    return sum(arr) / len(arr)

def lin_regress(x, y):
    n = len(x)
    x_mean = mean(x)
    y_mean = mean(y)
    xy_mean = mean(x * y)
    xx_mean = mean(x * x)
    a = (xy_mean - x_mean * y_mean) / (xx_mean - x_mean**2)
    b = y_mean - a * x_mean
    return a, b

# гипербола
u = 1 / x
a, b = lin_regress(u, y)
y_hyperbola = a / x + b
hyperbola_eq = f'y = {a:.3f}/x + {b:.3f}'

# дробная рационализация вида y=x/(ax+b)
a, b = lin_regress(u, 1 / y)
y_drob = x / (a * x + b)
drob_eq = f'y = x / ({a:.3f}x + {b:.3f})'

# логарифм
loga = np.log(x)
a, b = lin_regress(loga, y)
y_log = a * np.log(x) + b
log_eq = f'y = {a:.3f} * ln(x) + {b:.3f}'

# обратный метод
rever = 1 / y
a, b = lin_regress(x, rever)
reverse_eq = f'y = 1 / ({a:.3f}x + {b:.3f})'

# исключаем точки, где происходит деление на 0
x1 = x[x <= -b/a]
x2 = x[x > -b/a]

y_rever1 = 1 / (a * x1 + b)
y_rever2 = 1 / (a * x2 + b)

# линейная регрессия
a, b = lin_regress(x, y)
y_lin = a * x + b
lin_eq = f'y = {a:.3f}x + {b:.3f}'

# степенная функция
step_y = np.log(y)
a, b = lin_regress(loga, step_y)
a_exp = exp(b)
y_step = a_exp * (x ** a)
step_eq = f'y = e^({b:.3f}) * x^{a:.3f}'

# построение графиков
fig, axs = plt.subplots(3, 2, figsize=(12, 12))

# гипербола
axs[0, 0].scatter(x, y, color='red', label='Исходные данные')
axs[0, 0].plot(x, y_hyperbola, color='blue', label='Гипербола')
axs[0, 0].set_title('Гипербола')
axs[0, 0].legend()
axs[0, 0].text(0.5, 0.1, hyperbola_eq, ha='center', va='center', transform=axs[0, 0].transAxes)

# дробная рационализация
axs[0, 1].scatter(x, y, color='red', label='Исходные данные')
axs[0, 1].plot(x, y_drob, color='blue', label='Дробная рационализация')
axs[0, 1].set_title('Дробная рационализация')
axs[0, 1].legend()
axs[0, 1].text(0.5, 0.1, drob_eq, ha='center', va='center', transform=axs[0, 1].transAxes)

# логарифм
axs[1, 0].scatter(x, y, color='red', label='Исходные данные')
axs[1, 0].plot(x, y_log, color='blue', label='Логарифм')
axs[1, 0].set_title('Логарифм')
axs[1, 0].legend()
axs[1, 0].text(0.5, 0.1, log_eq, ha='center', va='center', transform=axs[1, 0].transAxes)

# обратный метод (ветви графика)
axs[1, 1].scatter(x, y, color='red', label='Исходные данные')
axs[1, 1].plot(x1, y_rever1, color='blue', label='Обратный метод (ветвь 1)')
axs[1, 1].plot(x2, y_rever2, color='green', label='Обратный метод (ветвь 2)')
axs[1, 1].set_title('Обратный метод')
axs[1, 1].legend()
axs[1, 1].set_ylim([-10, 200])
axs[1, 1].text(0.5, 0.4, reverse_eq, ha='center', va='center', transform=axs[1, 1].transAxes)

# линейная регрессия
axs[2, 0].scatter(x, y, color='red', label='Исходные данные')
axs[2, 0].plot(x, y_lin, color='blue', label='Линейная регрессия')
axs[2, 0].set_title('Линейная регрессия')
axs[2, 0].legend()
axs[2, 0].text(0.5, 0.1, lin_eq, ha='center', va='center', transform=axs[2, 0].transAxes)

# степенная функция
axs[2, 1].scatter(x, y, color='red', label='Исходные данные')
axs[2, 1].plot(x, y_step, color='blue', label='Степенная функция')
axs[2, 1].set_title('Степенная функция')
axs[2, 1].legend()
axs[2, 1].text(0.5, 0.1, step_eq, ha='center', va='center', transform=axs[2, 1].transAxes)

plt.tight_layout()
plt.show()
