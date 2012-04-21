/**************************************************************
                 Module Name: Main.cpp
               Describe: Main application
***************************************************************/

#include "Number.h"
#include "iostream"
#include "stdio.h"
#include "conio.h"

using namespace std;

/********************************************************************************************
*********************************************************************************************/
void main()
{
	StringNumber snN1, snN2, snResult;	// variable of first number, second number and result
	
	cout<<endl<<"Add2N ";
	cin>>snN1; cin>>snN2;	// input value of number
	
	if(snN1.Test()==true && snN2.Test()==true)
	{
		snResult=snN1+snN2;		// add two number
		cout<<endl<<snN1<<" + "<<snN2<<" = "<<snResult;	// output result
	}
	else
		cout<<"Error input..!";
	
	getch();
}