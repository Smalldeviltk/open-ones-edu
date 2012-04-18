#include "chArray.h"
#include "logical.h"

/************************************************
Method Name:	logic::logic();
Description:    construction
*************************************************/
logical::logical()
{
}
/**************************************************
Method Name:	logic::wMax(int wTempA, int wTampB)
Description:    compare two number

Parameter:		chArray chArrNumA,chArray chArrNumB .. 
				two number of tha equation
**************************************************/
int logical::wMax(int wTempA, int wTempB)
{
	if (wTempA > wTempB) 
	{
		return wTempA;
	}
	else 
	{
		return wTempB;
	}
}
/**************************************************
Method Name:	logic::pAdd2N(chArray chArrNumA,chArray chArrNumB)
Description:    Add 2 Number

Parameter:		chArray chArrNumA,chArray chArrNumB .. 
				two number of tha equation
**************************************************/
void logical::pAdd2N(chArray chArrNumA, chArray chArrNumB, chArray &chArrSum)
{
	int wMaximum, wTemp;
	wMaximum = wMax(chArrNumA.wGetNumChars(), chArrNumB.wGetNumChars());
	

	char chTemp = '0';
	char *pcharA, *pcharB, *pcharSum;

	chArrNumA.invertChars();
	chArrNumB.invertChars();

	pcharA = chArrNumA.pGetPChar();
	pcharB = chArrNumB.pGetPChar();
	pcharSum = chArrSum.pGetPChar();

	for (int i = 0; i < wMaximum; i++)
	{
		wTemp = 1;
		if (chTemp == '1') 
		{
			wTemp = 0;
		}
		chTemp = pcharA[i] + pcharB[i] - 48;
		if (chTemp > '9')
		{
			chArrSum.addChar(pcharB[i] - ('9' - pcharA[i] + wTemp));
			chTemp = '1';
		}
		else 
		{
			chArrSum.addChar(chTemp);
			chTemp = '0';
		}
	}
	if (chTemp != '0') chArrSum.addChar(chTemp);

	chArrSum.invertChars();
	chArrNumA.invertChars();
	chArrNumB.invertChars();

}