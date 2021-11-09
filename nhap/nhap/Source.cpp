#include<iostream>
#include<math.h>
using namespace std;
double fabs(double x);
int main() {
	double a, b;
	a = fabs(10.5);

	b = fabs(-12.5);
	cout << "\nGia tri tuyet doi cua a : " << a;
	cout << "\nGia tri tuyet doi cua b : " << b;
	system("pause");
	return 0;
}