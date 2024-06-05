import numpy as np
import matplotlib.pyplot as plt
from scipy.interpolate import interp1d

def linear_interpolation(x, y, x_interp):
    f = interp1d(x, y, kind='linear')
    y_interp = f(x_interp)
    return y_interp

def nonlinear_interpolation(x, y, x_interp):
    f = interp1d(x, y, kind='cubic')
    y_interp = f(x_interp)
    return y_interp

def plot_interpolation(x, y, x_interp, y_linear_interp, y_nonlinear_interp):
    plt.plot(x, y, 'o', label='Исходные данные')
    plt.plot(x_interp, y_linear_interp, '--', label='Линейная интерполяция')
    plt.plot(x_interp, y_nonlinear_interp, '-', label='Нелинейная интерполяция')
    plt.xlabel('x')
    plt.ylabel('y')
    plt.title('Интерполяция данных')
    plt.legend()
    plt.grid(True)
    plt.show()

def main():
    # Пример данных для интерполяции
    x = np.array([0, 1, 2, 3, 4])
    y = np.array([0, 1, 4, 9, 16])

    # Точки для интерполяции
    x_interp = np.linspace(0, 4, 100)

    # Линейная интерполяция
    y_linear_interp = linear_interpolation(x, y, x_interp)

    # Нелинейная (кубическая) интерполяция
    y_nonlinear_interp = nonlinear_interpolation(x, y, x_interp)

    # Вывод результатов
    print("Линейная интерполяция:")
    for i in range(len(x_interp)):
        print(f"x_interp = {x_interp[i]}, y_interp = {y_linear_interp[i]}")

    print("\nНелинейная интерполяция:")
    for i in range(len(x_interp)):
        print(f"x_interp = {x_interp[i]}, y_interp = {y_nonlinear_interp[i]}")

    # Графическое представление
    plot_interpolation(x, y, x_interp, y_linear_interp, y_nonlinear_interp)

if __name__ == "__main__":
    main()
