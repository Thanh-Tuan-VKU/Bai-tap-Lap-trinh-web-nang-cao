#include <iostream>
using namespace std;

int main()
{
    int a, b;
    char pheptinh;

    cout << "Nhap a: ";
    cin >> a;

    cout << "Nhap b: ";
    cin >> b;

    cout << "Nhap phep tinh (+ - * /): ";
    cin >> pheptinh;

    switch (pheptinh)
    {
    case '+':
        cout << "Ket qua = " << a + b;
        break;

    case '-':
        cout << "Ket qua = " << a - b;
        break;

    case '*':
        cout << "Ket qua = " << a * b;
        break;

    case '/':
        if (b != 0)
            cout << "Ket qua = " << (float)a / b;
        else
            cout << "Loi: Khong the chia cho 0!";
        break;

    default:
        cout << "Phep tinh khong hop le!";
    }

    return 0;
}
