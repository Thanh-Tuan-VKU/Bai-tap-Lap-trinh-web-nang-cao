#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

int main()
{
    int soBiMat, soDoan;
    int soLan = 7;

    srand(time(0));

    soBiMat = rand() % 100 + 1;

    cout << "=== TRO CHOI DOAN SO ===\n";
    cout << "Ban co 7 lan doan mot so tu 1 den 100.\n";

    for (int i = 1; i <= soLan; i++)
    {
        cout << "\nLan doan thu " << i << ": ";
        cin >> soDoan;

        if (soDoan == soBiMat)
        {
            cout << "Chuc mung! Ban da doan dung so.\n";
            break;
        }
        else if (soDoan < soBiMat)
        {
            cout << "So ban doan NHO HON so bi mat.\n";
        }
        else
        {
            cout << "So ban doan LON HON so bi mat.\n";
        }

        if (i == soLan)
        {
            cout << "\nBan da het luot doan.\n";
            cout << "So bi mat la: " << soBiMat << endl;
        }
    }

    return 0;
}
