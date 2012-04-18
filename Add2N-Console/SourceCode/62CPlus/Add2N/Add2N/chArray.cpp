#include <iostream>
#include "chArray.h"

using namespace std;

/**************************************************
Method Name:	chArray::chArray();
Description:    construction of class.

Parameter: None
**************************************************/
chArray::chArray()
{
	this->wNumChars = 0;
	this->pchar = new char;
}
/**************************************************
Method Name:	chArray::chArray(int wNumChars);
Description:    construction of class.

Parameter: int wNumChars, the Number of this array.
**************************************************/
chArray::chArray(int wNumChars)
{
	this->wNumChars = wNumChars;
	this->pchar = new char;
}
/************************************************
Method Name: ~chArray::chArray;
Description: destruction of this class

return value: None
Parameter: None
************************************************/
chArray::~chArray()
{
}
/*************************************************
Method Name:	chArray::invertChars()
Description:	to invert this array

Return value:	void
Parameter:		None.
*************************************************/
void chArray::invertChars()
{
	char chTemp;
	for (int i = 0 ; i <= (this->wNumChars - 1)/2; i++)
	{
		chTemp = this->pchar[i];
		this->pchar[i] = this->pchar[wNumChars - 1 - i];
		this->pchar[wNumChars - 1 - i] = chTemp;
	}
}
/************************************************
Method Name:  chArray::showChars()
Description:  show this array

Return value: void
Parameter:    None   
************************************************/
void chArray::showChars()
{
	for (int i = 0; i < this->wNumChars; i++)
	{
		cout << this->pchar[i];
	}
}
/************************************************
Method Name: chArray::SetNumChars(int wNumChars);
Description: set the Number of this array

return value: void
Parameter: wNumChars, the number of the array
************************************************/
void chArray::setNumChars(int wNumChars)
{
	this->wNumChars = wNumChars;
}
/************************************************
Method Name: chArray::wgetNumChars();
Description: get the Number of this array

return value: int
Parameter: None
************************************************/
int chArray::wGetNumChars()
{
	return this -> wNumChars;
}
/************************************************
Method Name: chArray::pGetPChar(char *pchar);
Description: set pointer of this chars

return value: void
Parameter: the value of pchar
************************************************/
void chArray::setPChar(char *pchar)
{
	this->pchar = pchar;
}
/************************************************
Method Name: chArray::pGetPChar();
Description: get pointer of this chars

return value: char*
Parameter: None
************************************************/
char * chArray::pGetPChar()
{
	return this->pchar;
}
/************************************************
Method Name: chArray::addChar(char chNew);
Description: add new char

return value: void
Parameter: the value of char
************************************************/
void chArray::addChar(char chNew)
{
	this->wNumChars++;
	this->pchar[wNumChars - 1] = chNew;
}
