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
 * Mod. History: 21.04.12 - Pham Minh Triet - Nhom 32 - Nhap Mon Cong Tac Ky Su
 *							File first created
 * --
 ************************************************************************/

#include "stdafx.h"
#include "BigInteger.h"
#include <algorithm>
#include <iostream>
#include <vector>
#include <string>

bool IsDigit(const char &c)
{
	return ((c >= '0') && (c <= '9'));
}

bool BigInteger::operator ==(const BigInteger &bigInt) const
{
	if (this->szNumber.size() != bigInt.szNumber.size())
		return false;
	else
	{
		for (unsigned int i = 0; i < this->szNumber.size(); ++i)
			if (this->szNumber[i] != bigInt.szNumber[i])
				return false;

		return true;
	}
}

bool BigInteger::operator !=(const BigInteger &bigInt) const
{
	return (!this->operator ==(bigInt));
}

bool BigInteger::operator >(const BigInteger &bigInt) const
{
	if (this->szNumber.size() > bigInt.szNumber.size())
		return true;
	else if (this->szNumber.size() < bigInt.szNumber.size())
		return false;
	else //(this->szNumber.size() == bigInt.size())
	{
		for (unsigned int i = 0; i < this->szNumber.size(); ++i)
		{
			if (this->szNumber[i] > bigInt.szNumber[i])
				return true;
			else if (this->szNumber[i] < bigInt.szNumber[i])
				return false;
		}

		return false;
	}
}

bool BigInteger::operator >=(const BigInteger &bigInt) const
{
	return (!this->operator <(bigInt));
}

bool BigInteger::operator <(const BigInteger &bigInt) const
{
	if (this->szNumber.size() < bigInt.szNumber.size())
		return true;
	else if (this->szNumber.size() > bigInt.szNumber.size())
		return false;
	else //(this->szNumber.size() == bigInt.size())
	{
		for (unsigned int i = 0; i < this->szNumber.size(); ++i)
		{
			if (this->szNumber[i] < bigInt.szNumber[i])
				return true;
			else if (this->szNumber[i] > bigInt.szNumber[i])
				return false;
		}

		return false;
	}
}

bool BigInteger::operator <=(const BigInteger &bigInt) const
{
	return (!this->operator >(bigInt));
}


void ExtractCommand(const string& szCommand, BigInteger &op1, BigInteger &op2)
{
	int nSpacePos1, nSpacePos2;
	nSpacePos1 = szCommand.find(' ', 0);
	nSpacePos2 = szCommand.find(' ', nSpacePos1 + 1);

	if ((nSpacePos1 <= 0) || (nSpacePos2 <= 0))
		throw string("Loi cu phap!");

	string prefix = szCommand.substr(0, nSpacePos1);
	if (prefix != "Add2N")
		throw string("Loi cu phap");

	vector<string> szErrors;
	szErrors.reserve(2);
	try
	{
		op1 = szCommand.substr(nSpacePos1 + 1, nSpacePos2 - nSpacePos1 - 1);
	}
	catch (string szErr)
	{
		szErrors.push_back(szErr);
	}

	try
	{
		op2 = szCommand.substr(nSpacePos2 + 1, szCommand.size() - nSpacePos2);
	}
	catch (string szErr)
	{
		szErrors.push_back(szErr);
	}

	if (szErrors.size() > 0)
	{
		string szError = szErrors[0];
		for (unsigned int i = 1; i < szErrors.size(); ++i)
			szError += ", " + szErrors[i];
		szError += " khong hop le";

		throw szError;
	}
}
