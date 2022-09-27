#include <string>
#include <stdio.h>
#pragma once

using namespace std;

class complex
{
private:
	double real;
	double imaginary;

public:
	complex(double r, double i);
	string get_value();
	double r();
	double i();
};

complex operator + (complex c1, complex c2);
complex operator - (complex c1, complex c2);
complex operator * (complex c1, complex c2);
complex operator / (complex c1, complex c2);
