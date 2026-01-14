#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    int n;
    bool laSoNguyenTo = true;

    do
    {
        cout << "Nhap n (n >= 2): ";
        cin >> n;
    } while (n < 2);

    for (int i = 2; i <= sqrt(n); i++)
    {
        if (n % i == 0)
        {
            laSoNguyenTo = false;
            break;
        }
    }

    if (laSoNguyenTo)
        cout << n << " la so nguyen to.";
    else
        cout << n << " khong phai la so nguyen to.";

    return 0;
}
