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
 * Mod. History: 21.04.12 - Pham Vinh & Tran Thi Bich Tuyen - Nhom 32 - Nhap Mon Cong Tac Ky Su
 *							File first created
 * --
 ************************************************************************/

#include "stdafx.h"
#include "BigInteger.h"
#include <algorithm>

const BigInteger& BigInteger::operator +=(const BigInteger &bigInt)
{
	unsigned int nMaxSize = max(this->szNumber.size(), bigInt.szNumber.size());
	BigInteger biMax = max((*this), bigInt);
	unsigned int nMinSize = min(this->szNumber.size(), bigInt.szNumber.size());
	const BigInteger& biMin = min((*this), bigInt);
	int nCarry = 0;

	unsigned int i;
	for (i = 1; i <= nMinSize ; ++i)
	{
		biMax.szNumber[nMaxSize - i] += nCarry + biMin.szNumber[nMinSize - i] - 2 * '0';

		if (biMax.szNumber[nMaxSize - i] > 9)
		{
			biMax.szNumber[nMaxSize - i] %= 10;
			nCarry = 1;
		}

		biMax.szNumber[nMaxSize - i] += '0';
	}

	while ((i <= nMaxSize) && (nCarry))
	{
		biMax.szNumber[nMaxSize - i] += nCarry;
		if (biMax.szNumber[nMaxSize - i] > '9')
			biMax.szNumber[nMaxSize - i] = '0';
		else
			nCarry = 0;

		++i;
	}

	if (nCarry)
		biMax.szNumber.insert(0, 1, '1');

	(*this) = biMax;
	return (*this);
}

BigInteger BigInteger::operator +(const BigInteger &bigInt) const
{
	BigInteger result = (*this);
	result.operator +=(bigInt);

	return result;
}