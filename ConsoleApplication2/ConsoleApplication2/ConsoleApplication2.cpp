// ConsoleApplication1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"

#include "iostream"
#include <math.h> 

using namespace std;


double Math(int k, int n)
{
	double result = (sin(k))/k; 
    if(n > 1)
    {
        for( int i = 2; i <= n; i++)  
            result *= (sin(i))/i; 
    }
  
    return result; 
}


int _tmain(int argc, _TCHAR* argv[])
{
	double result;
	int k = 1;
	int n;
	cout << "Enter number of steps: ";
	cin >> n; 

	result = Math(k, n);
	cout << result<< endl;
	return 0;
}

