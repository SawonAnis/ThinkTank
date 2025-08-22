#include <iostream>
#include <iomanip>

using namespace std;

int main(){
  float A, B, C;
cin >> A >> B >> C;

const double PI = 3.14159;
double triangulo = (A * C) / 2.0;
    double circulo = PI * C * C;
    double trapezio = ((A + B) * C) / 2.0;
    double quadrado = B * B;
    double retangulo = A * B;

   cout << fixed << setprecision(3);

    cout << "TRIANGULO: " << triangulo << endl;
    cout << "CIRCULO: " << circulo << endl;
    cout << "TRAPEZIO: " << trapezio << endl;
    cout << "QUADRADO: " << quadrado << endl;
    cout << "RETANGULO: " << retangulo << endl;

    return 0;
}