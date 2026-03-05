#include <iostream>
#include <cmath>

class ComplexNumber {
private:
    double real;
    double imag;

public:
    ComplexNumber(double r = 0.0, double i = 0.0) : real(r), imag(i) {}

    ComplexNumber add(ComplexNumber& num) {
        return ComplexNumber(real + num.real, imag + num.imag);
    }

    ComplexNumber subtract(ComplexNumber& num) {
        return ComplexNumber(real - num.real, imag - num.imag);
    }

    ComplexNumber multiply(ComplexNumber& num) {
        return ComplexNumber(
            real * num.real - imag * num.imag,
            real * num.imag + imag * num.real
        );
    }

    ComplexNumber divide(ComplexNumber& num) {
        double denom = num.real * num.real + num.imag * num.imag;
        if (denom == 0) return ComplexNumber(0, 0);
        return ComplexNumber(
            (real * num.real + imag * num.imag) / denom,
            (imag * num.real - real * num.imag) / denom
        );
    }

    double getMagnitude() {
        return std::sqrt(real * real + imag * imag);
    }

    void input() {
        std::cout << "¬вед≥ть д≥йсну частину: ";
        std::cin >> real;
        std::cout << "¬вед≥ть у€вну частину: ";
        std::cin >> imag;
    }

    void display() {
        std::cout << real << (imag >= 0 ? " + " : " - ") << std::abs(imag) << "i";
    }
};

