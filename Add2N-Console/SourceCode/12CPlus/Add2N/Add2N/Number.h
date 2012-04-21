
/**************************************************************
                   Module Name: Number.h
             Describe: Create class StringNumber
***************************************************************/


#include "iostream"
#include "string.h"

using namespace std;
/********************************************************************
*********************************************************************/

class StringNumber {	//	StringNumber is a number of type string
public:
	char* cValue;		// cursor save address of nummber

	//***************************************************************
	//  function test data input
	bool Test()
	{
		for(int i=0; i<strlen(this->cValue);i++)
			if(this->cValue[i]<'0' || this->cValue[i]>'9')
			return false;
		return true;
	}

	//***************************************************************
	//	oveload operator ">>" using to add input value of number
	friend istream& operator>>(istream& is, StringNumber &stringNum)
	{
		stringNum.cValue=new char[100];
		is>>stringNum.cValue;
		return is;
	}
	
	//***************************************************************
	//	overload operator "<<" using to print number on screen
	friend ostream& operator<<(ostream& os, StringNumber stringNum)
	{
		os<<stringNum.cValue;
		return os;
	}

	//***************************************************************
	//	oveload operator "+" using to use to add 2 number
	friend StringNumber operator+(StringNumber stringNum1, StringNumber stringNum2)
	{
		StringNumber snResult;	// variable save result
		char cRemember=0;		// variable save some memory
		
		int iLen1=strlen(stringNum1.cValue);	// length of first number
		int iLen2=strlen(stringNum2.cValue);	// length of second number
		int iLen=0;								// length of result

		// to issue memory to variable result
		if(iLen1>=iLen2)
			snResult.cValue=new char[iLen1];
		else
			snResult.cValue=new char[iLen2];

		// start add from the unit
		while((iLen1>0) && (iLen2>0))
		{
			char cSum=stringNum1.cValue[--iLen1]+stringNum2.cValue[--iLen2] -2*'0'+cRemember;
			snResult.cValue[iLen++]=cSum%10+'0';
			cRemember=cSum/10;
		}

		// when second number end
		while(iLen1>0)
		{
			char cSum=stringNum1.cValue[--iLen1]-'0'+cRemember;
			snResult.cValue[iLen++]=cSum%10+'0';
			cRemember=cSum/10;
		}
		// when first number end
		while(iLen2>0)
		{
			char cSum=stringNum2.cValue[--iLen2]-'0'+cRemember;
			snResult.cValue[iLen++]=cSum%10+'0';
			cRemember=cSum/10;
		}

		if(cRemember) snResult.cValue[iLen++]='1';
		snResult.cValue[iLen]=0;
		
		// reverse result
		strrev(snResult.cValue);
		return snResult;
	}
};