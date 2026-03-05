#include <Windows.h>
#include <iostream>
#include "ComplexNumber.cpp"

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    
    ComplexNumber n1, n2;

    std::cout << "Число 1:\n";
    n1.input();
    std::cout << "Число 2:\n";
    n2.input();

    ComplexNumber sum = n1.add(n2);
    ComplexNumber diff = n1.subtract(n2);
    ComplexNumber prod = n1.multiply(n2);
    ComplexNumber quot = n1.divide(n2);

    std::cout << "\n--- Результати ---\n";
    std::cout << "Сума: "; sum.display(); std::cout << "\n";
    std::cout << "Різниця: "; diff.display(); std::cout << "\n";
    std::cout << "Добуток: "; prod.display(); std::cout << "\n";
    std::cout << "Ділення: "; quot.display(); std::cout << "\n";
    std::cout << "Модуль першого числа: " << n1.getMagnitude() << "\n";
    std::cout << "Модуль другого числа: " << n2.getMagnitude() << "\n";


    return 0;
}



//Створити клас для виконання операцій з комплексними числами. Передбачити операції: 
// складання та віднімання; множення та ділення; обчислення модулю; консольне введення та виведення; ініціалізацію.