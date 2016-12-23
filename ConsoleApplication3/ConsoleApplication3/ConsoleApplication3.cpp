// ConsoleApplication3.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

string GetPosition(arr[3][3],int n)
{
	string result= "";

    for (int i = 0; i < n; i++)
    {
       for (int j = 0; j < n; i++)
		{
			if (arr[i][j] % 5 == 0)
				result += i + "," + j + '\n';
		}
    }
	return result;
}

int _tmain(int argc, _TCHAR* argv[])
{
	
	cout << GetPosition(3) <<endl;
	return 0;
}


