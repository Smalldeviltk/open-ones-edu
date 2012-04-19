/**********************************************************
Author:           Le Vo Huu Tri
Description:      main function of this program

*********************************************************/

#include <iostream>
#include <string>
#include "chArray.h"
#include "logical.h"
#include "model.h"

using namespace std;

int main ()
{
	logical lgMath;
	model modelTest;
	chArray chArrNumA, chArrNumB, chArrSum;
	char *pchTemp = new char;
	int wTemp = 6, wTemp1 = 0, wTempLen = 0;
	
	cin.getline(pchTemp,400);
	wTempLen = strlen(pchTemp);
	pchTemp[strlen(pchTemp)] = '/0';

	while (pchTemp[wTemp] != 32)
	{
		wTemp ++;
	}
	for (int i = 6; i < wTemp; i++)
	{
		chArrNumA.addChar(pchTemp[i]);
	}
	while (pchTemp[wTemp] == 32)
	{
		wTemp++;
	}
	wTemp1 = wTemp;
	while ((wTemp < wTempLen) && (pchTemp[wTemp] != 32)
		&& (pchTemp[wTemp] > 32) && (pchTemp[wTemp] < 127))
	{
		wTemp ++;
	}
	for (int i = wTemp1; i < wTemp; i++)
	{
		chArrNumB.addChar(pchTemp[i]);
	}
	if ((modelTest.wTestInput(chArrNumA)) && (modelTest.wTestInput(chArrNumB)))
	{
		lgMath.pAdd2N(chArrNumA,chArrNumB,chArrSum);
		modelTest.showForm(chArrNumA, chArrNumB, chArrSum);
	}
	return 0;
}