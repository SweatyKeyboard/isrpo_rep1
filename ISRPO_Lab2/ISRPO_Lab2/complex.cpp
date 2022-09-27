#include "complex.h"

using namespace std;


string complex::get_value() {
	return to_string(real) + " + " + to_string(imaginary) + "i";
}

complex::complex(double r, double i) {
	real = r;
	imaginary = i;
}

double complex::r() {
	return real;
}

double complex::i() {
	return imaginary;
}

complex operator + (complex c1, complex c2) {
	return complex(c1.r() + c2.r(), c1.i() + c2.i());
}

complex operator - (complex c1, complex c2) {
	return complex(c1.r() - c2.r(), c1.i() - c2.i());
}

complex operator * (complex c1, complex c2) {
	return complex(
		c1.r() * c2.r() - c1.i() * c2.i(),
		c1.i() * c2.r() + c1.r() * c2.i());
}

complex operator / (complex c1, complex c2) {
	return complex(
		(c1.r() * c2.r() + c1.i() * c2.i()) / (c2.r() * c2.r() + c2.i() * c2.i()),
		c1.i() * c2.r() - c1.r() * c2.i() / (c2.r() * c2.r() + c2.i() * c2.i()));
}