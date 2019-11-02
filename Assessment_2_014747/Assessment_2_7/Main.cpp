//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 12/10/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 2 - A program that subtracts 2 numbers and outputs the result. Same as Assessment 1A.
// Language: C++
//******************************************************************
#include <iostream>

using namespace std;

int main()
{
	double num1;
	double num2;
	double answer;

	cout << "Enter 2 decimal numbers with a space or enter inbetween:\n";
	while (1)//check if a deciaml number is entered
	{
		cin >> num1 >> num2;
		if (cin.good())
		{
			break;
		}
		else {
			cout << "Input 2 decimal numbers only.\n";
			cin.clear();
			cin.ignore(100000, '\n');
		}
	}

	answer = num1 - num2;

	cout << num1 << "-" << num2 << " is " << answer;


	//code to stop the exe from closing immediately
	cout << "\nPaused.";
	cin.clear();
	cin.ignore(INT_MAX, '\n');
	cin.get();
	return 0;
}