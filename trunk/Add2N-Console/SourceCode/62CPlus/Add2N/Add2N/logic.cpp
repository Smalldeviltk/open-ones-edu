#include "chArray.h"
#include "logic.h"

/**************************************************
Method Name:	logic::wMax(int wTempA, int wTampB)
Description:    compare two number

Parameter:		chArray chArrNumA,chArray chArrNumB .. 
				two number of tha equation
**************************************************/
int logic::wMax(int wTempA, int wTempB)
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
Variable		chArrSum: result of this equation
**************************************************/
chArray logic::pAdd2N(chArray chArrNumA, chArray chArrNumB)
{
	int wMax = this->wMax(chArrNumA.wGetNumChars(), chArrNumB.wGetNumChars());
	chArray chArrSum(wMax + 2);

	char chTemp = '0';
	char *pcharA, *pcharB, *pcharSum;

	chArrNumA.invertChars();
	chArrNumB.invertChars();

	pcharA = chArrNumA.pGetPChar();
	pcharB = chArrNumB.pGetPChar();
	pcharSum = chArrSum.pGetPChar();

	for (int i = 0; i < wMax; i++)
	{
		chTemp += pcharA[i] + pcharB[i];
		if (chTemp > '9')
		{
			pcharSum[i] = '0';
			chTemp = '1';
		}
		else 
		{
			pcharSum[i] = chTemp;
			chTemp = '0';
		}
	}
	chArrSum.invertChars();

	return chArrSum;
}