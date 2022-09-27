#include <iostream>
#include "complex.h"

int main()
{
    complex c1(2, -3);
    complex c2(-4, 5);

    cout << c1.get_value() << endl;
    cout << c2.get_value() << endl;
    cout << (c1 + c2).get_value() << endl;
    cout << (c1 - c2).get_value() << endl;
    cout << (c1 * c2).get_value() << endl;
    cout << (c1 / c2).get_value() << endl;
}