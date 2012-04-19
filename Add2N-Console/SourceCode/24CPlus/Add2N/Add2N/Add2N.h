#include <stdio.h>
/***********************************************************************
*++
* Author:		Group 24
*				Member: 
*				NGUYỄN VĂN TOÀN					 09520444
*				DOÃN THỊ PHƯƠNG THÚY			 09520297
*				NGUYỄN LÊ HUY				     10520156
*				HOÀNG MINH THẮNG				 10520247
*				TRẦN TIẾN TRUNG					 10520098
* Module Name:	Add2N.cpp	
*
*Description:	This applicaiton help you calculate a lot ot complex operation
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
*
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
*Mod. History:	19/04/2012 - Add2N
*				Add2N.h, Add2N.cpp
*--
***********************************************************************/
#include <conio.h>
#include <string>
#include <stdlib.h>
#include "iostream"

using namespace std;

class Add2N
{
	public:
	char chFirstNumber[100], chSecondNumber[100];
	string strResult;
	char chOperation;

	Add2N(){};
	~Add2N(){};
	void GetInput();
	void GetSumOfNumber();
	bool TestInputValid(char *s);
};