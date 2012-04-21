
/**************************************************************
**********			Module Name: Number.h			***********
**********	Describe: Create class StringNumber		***********
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
};