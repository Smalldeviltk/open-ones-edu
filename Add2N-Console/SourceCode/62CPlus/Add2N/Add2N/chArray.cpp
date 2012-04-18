#include <iostream>
#include "chArray.h"

using namespace std;

/**************************************************
Method Name:	chArray::chArray(int wNumChars);
Description:    construction of class.

Parameter: int wNumChars, the Number of this array.
**************************************************/
chArray::chArray(int wNumChars)
{
	this->wNumChars = wNumChars;
	this->pchar = new char[wNumChars];
}
/*************************************************
Method Name:	chArray::invertChars()
Description:	to invert this array

Return value:	void
Parameter:		None.
*************************************************/
void chArray::invertChars()
{
	char *pcharTemp = new char[this->wNumChars];

	for (int i = this->wNumChars - 1; i >= 0; i--)
	{
		pcharTemp[this->wNumChars - i] = this->pchar[i];
	}
	for (int i = 0; i < this->wNumChars; i++)
	{
		this->pchar[i] = pcharTemp[i];
	}
	delete pcharTemp;
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
Method Name: chArray::wgetNumChars();
Description: get the Number of this array

return value: int
Parameter: None
************************************************/
int chArray::wgetNumChars()
{
	return this -> wNumChars;
}