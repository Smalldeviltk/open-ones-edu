#include <iostream>
#include <string>
#include "chArray.h"
#include "model.h"

using namespace std;
/**************************************************
Method Name:	view::view();
Description:    construction

Parameter:		none
Variable		none
**************************************************/
model::model()
{
}
/**************************************************
Method Name:	view::wTestInput(char* chInput)
Description:    function return 0 if it is true else it is false

Parameter:		char* chInput, input data 
Variable		none
**************************************************/
int model::wTestInput(chArray chArrInput)
{
	char *pTemp = chArrInput.pGetPChar();
	for (int i = 0; i < chArrInput.wGetNumChars(); i++)
	{
		if ((pTemp[i] < '0') || (pTemp[i] >'9')
			&& (pTemp[i] != 32) && (pTemp[i] != '/0'))
		{ 
			cout << endl;
			chArrInput.showChars();
			cout << " khong hop le";
			return 0;
		}
	}
	return 1;
}
/**************************************************
Method Name:	view::showForm(chArray, chArray, chArray);
Description:    view true form of this program

Parameter:		3 Number saved by chArray
Variable		none
**************************************************/
void model::showForm(chArray chArrNumA, chArray chArrNumB, chArray chArrSum)
{
	cout << endl;
	chArrNumA.showChars();
	cout << " + ";
	chArrNumB.showChars();
	cout << " = ";
	chArrSum.showChars();
}