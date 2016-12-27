// ConsoleApplication1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"

#include "iostream"
#include <math.h> 

using namespace std;


double Math(int x, int n)
{
	if( x >= 2 && x != n)
	{
	    x += 1;
	    return ((sin(x))/x)*Math(x,n-1);
	}
	else
	{
	    return (sin(x))/x;
	}
		
}


int _tmain(int argc, _TCHAR* argv[])
{
	double result;
	int x = 1;
	int n;
	cout << "Enter number of steps: ";
	cin >> n; 

	result = Math(x, n);
	cout << result<< endl;
	system("Pause");
	return 0;
}

