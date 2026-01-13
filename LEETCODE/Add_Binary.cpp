#include <iostream>
#include <string>
using namespace std;

string addBinary(string a, string b) {
  
    while (a.length() < b.length()) a = "0" + a;
    while (b.length() < a.length()) b = "0" + b;

    string result = "";
    int carry = 0;


    for (int i = a.length() - 1; i >= 0; i--) {
        int sum = (a[i] - '0') + (b[i] - '0') + carry;
        carry = sum / 2;
        result = char((sum % 2) + '0') + result;
    }

    if (carry) result = "1" + result;

    return result;
}

int main() {
    string a, b;

    cout << "Enter first binary string: ";
    cin >> a;

    cout << "Enter second binary string: ";
    cin >> b;

    cout << "Binary Sum: " << addBinary(a, b) << endl;

    return 0;
}
