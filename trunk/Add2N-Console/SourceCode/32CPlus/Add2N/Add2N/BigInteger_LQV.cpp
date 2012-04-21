/************************************************************************
 * ++
 * Author:		Nhom 32 - Nhap Mon Cong Tac Ky Su
 * Module Name: BigInteger.cpp
 * Description: Khai bao lop BigInteger mo ta so nguyen duong lon va mot 
	so phuong thuc tren do
 xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 *
 xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 *
 * Mod. History: 15.04.12 - Luu Quang Vu - Nhom 32 - Nhap Mon Cong Tac Ky Su
 *							File first created
 * --
 ************************************************************************/

#include "stdafx.h"
#include "BigInteger.h"
#include <algorithm>

ostream& operator<<(ostream &os, const BigInteger &bigInt)
{
	return  os<<bigInt.szNumber;
}

void BigInteger::RemoveZero()
{
	unsigned int i = 0;
	while ((i < this->szNumber.size()) && (this->szNumber[i] == '0'))
		++i;

	if (i > 0)
		this->szNumber.erase(0, i);

	if (this->szNumber.empty())
		this->szNumber = "0";
}