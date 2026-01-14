#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    double a, b, c;
    double delta, x1, x2;

    cout << "Nhap a: ";
    cin >> a;

    cout << "Nhap b: ";
    cin >> b;

    cout << "Nhap c: ";
    cin >> c;

    if (a == 0)
    {
        cout << "Day khong phai la phuong trinh bac hai.";
    }
    else
    {
        delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            x1 = (-b + sqrt(delta)) / (2 * a);
            x2 = (-b - sqrt(delta)) / (2 * a);
            cout << "Phuong trinh co hai nghiem phan biet:\n";
            cout << "x1 = " << x1 << endl;
            cout << "x2 = " << x2;
        }
        else if (delta == 0)
        {
            x1 = -b / (2 * a);
            cout << "Phuong trinh co nghiem kep:\n";
            cout << "x = " << x1;
        }
        else
        {
            cout << "Phuong trinh vo nghiem trong tap so thuc.";
        }
    }

    return 0;
}
