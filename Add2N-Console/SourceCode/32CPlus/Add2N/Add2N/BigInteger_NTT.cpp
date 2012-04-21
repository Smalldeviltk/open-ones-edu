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
 * Mod. History: 21.04.12 - Nguyen Thanh Tam - Nhom 32 - Nhap Mon Cong Tac Ky Su
 *							File first created
 * --
 ************************************************************************/

#include "stdafx.h"
#include "BigInteger.h"
#include <algorithm>

BigInteger::BigInteger()
{
	this->szNumber = "0";
}

BigInteger::BigInteger(const string &szNum)
{
	for (unsigned int i = 0; i < szNum.size(); ++i)
	{
		if (!IsDigit(szNum[i]))
			throw szNum;
	}

	this->szNumber = szNum;

	this->RemoveZero();
}

BigInteger::BigInteger(const BigInteger &bigInt)
{
	this->szNumber = bigInt.szNumber;
}

const BigInteger& BigInteger::operator =(const string &szNum)
{
	for (unsigned int i = 0; i < szNum.size(); ++i)
	{
		if (!IsDigit(szNum[i]))
			throw szNum;
	}

	this->szNumber = szNum;

	this->RemoveZero();

	return (*this);
}

const BigInteger& BigInteger::operator =(const BigInteger &bigInt)
{
	this->szNumber = bigInt.szNumber;

	return (*this);
}