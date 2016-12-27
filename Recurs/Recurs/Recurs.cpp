// Recurs.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include "iostream"
using namespace std;

float Math(float n, int m)
{
	float result = (sin(n))/n;	
	if( m > 2)
		return Math(n,m)*Math(n,m-1);
	else
		return result;
}

void _tmain(int argc, _TCHAR* argv[])
{

	float result;
	float x;
	int n;
	cout << "Enter x: ";
	cin >> x; 
	cout << "Enter number of steps: ";
	cin >> n; 

	result = Math(x, n);
	cout << result;
	
}

