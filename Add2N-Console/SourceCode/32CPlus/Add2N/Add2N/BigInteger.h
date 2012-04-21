#ifndef BIGINTEGER_H
#define BIGINTEGER_H

/************************************************************************
 * ++
 * Author:		Nhom 32 - Nhap Mon Cong Tac Ky Su
 * Module Name: BigInteger.h
 * Description: Khai bao lop BigInteger mo ta so nguyen duong lon va mot 
	so phuong thuc tren do
 xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 *
 xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 *
 * Mod. History: 21.04.12 - Nhom 32 - Nhap Mon Cong Tac Ky Su
 *							File first created
 * --
 ************************************************************************/

#include <string>
#include <iostream>

using namespace std;

/*************************************************************************
 * ++
 * Method Name:	IsDigit
 * Description: Kiem tra mot ki tu co phai la chu so hay khong
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 * Parameters:	const char&:	Ki tu can kiem tra
 * Return value: none
 *
 * Modifications: 21.04.12 - Nhom 32 - Luu Quang Vu
 * --
***************************************************************************/
inline bool IsDigit(const char&);

class BigInteger
{
public:
	//Constructors
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger()
	 * Description: Khoi tao mot so nguyen duong lon mac dinh bang 0
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	none
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Nguyen Thanh Tam - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Function first created
	 * --
	***************************************************************************/
	BigInteger();
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger(const string&);
	 * Description: Khoi tao mot so nguyen duong lon voi gia tri bang mot chuoi cho truoc
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const string&:	Chuoi so khoi tao
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Nguyen Thanh Tam - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Function first created
	 * --
	***************************************************************************/
	BigInteger(const string&);
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::operator =(const string&);
	 * Description: Ham khoi tao sao chep hai so nguyen duong lon
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const BigInteger&: So nguyen duong goc
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Nguyen Thanh Tam - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Function first created
	 * --
	***************************************************************************/
	BigInteger(const BigInteger&);

	//Assign operators
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::operator =(const string&);
	 * Description: Toan tu gan mot chuoi cho mot so nguyen duong lon
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const string&: Chuoi can gan
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Nguyen Thanh Tam - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Function first created
	 * --
	***************************************************************************/
	const BigInteger& operator =(const string&);
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::operator =(const BigInteger&)
	 * Description: Toan tu gan mot so nguyen duong lon cho mot so khasc
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const BigInteger&:	So goc
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Nguyen Thanh Tam - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Funtions first created
	 * --
	***************************************************************************/
	const BigInteger& operator =(const BigInteger&);

	//Compare operators
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::operator ==(const BigInteger&)
	 * Description: Toan tu bang so sanh hai so nguyen duong lon
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const BigInteger&:	So can so sanh
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Pham Minh Triet - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Functions first created
	 * --
	***************************************************************************/
	bool operator ==(const BigInteger&) const;
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::operator !=(const BigInteger&)
	 * Description: Toan tu khac so sanh hai so nguyen duong lon
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const BigInteger&:	So can so sanh
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Pham Minh Triet - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Functions first created
	 * --
	***************************************************************************/
	bool operator !=(const BigInteger&) const;
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::operator >(const BigInteger&)
	 * Description: Toan tu lon hon so sanh hai so nguyen duong lon
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const BigInteger&:	So can so sanh
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Pham Minh Triet - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Functions first created
	 * --
	***************************************************************************/
	bool operator >(const BigInteger&) const;
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::operator >=(const BigInteger&)
	 * Description: Toan tu lon hon hoac bang so sanh hai so nguyen duong lon
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const BigInteger&:	So can so sanh
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Pham Minh Triet - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Functions first created
	 * --
	***************************************************************************/
	bool operator >=(const BigInteger&) const;
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::operator <(const BigInteger&)
	 * Description: Toan tu nho hon so sanh hai so nguyen duong lon
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const BigInteger&:	So can so sanh
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Pham Minh Triet - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Functions first created
	 * --
	***************************************************************************/
	bool operator <(const BigInteger&) const;
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::operator <=(const BigInteger&)
	 * Description: Toan tu nho hon hoac bang so sanh hai so nguyen duong lon
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const BigInteger&:	So can so sanh
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Pham Minh Triet - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Functions first created
	 * --
	***************************************************************************/
	bool operator <=(const BigInteger&) const;

	//Mathematic operator
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::operator +=(const BigInteger&)
	 * Description: Toan tu cong don hai so nguyen duong lon
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const BigInteger&:	So nguyen duong can cong
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Tran Thi Bich Tuyen & Pham Vinh - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Functions first created
	 * --
	***************************************************************************/
	const BigInteger& operator +=(const BigInteger&);
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::operator +(const BigInteger&)
	 * Description: Toan tu cong hai so nguyen duong
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	const BigInteger&:	Toan hang
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Tran Thi Bich Tuyen & Pham Vinh - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Functions first created
	 * --
	***************************************************************************/
	BigInteger operator +(const BigInteger&) const;

	//Standar Out:
	/*************************************************************************
	 * ++
	 * Method Name:	operator<<(ostream&, const BigInteger&)
	 * Description: Toan tu chen dong xuat ra man hinh mot so nguyen duong lon
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	ostream&: Dong xuat
					const BigInteger&: So can xuat
	 * Return value: ostream&: Dong xuat
	 *
	 * Modifications: 21.04.12 - Luu Quang Vu - Nhom 32 - Nhap Mon Cong Tac Ki Su
							Funtions first created
	 * --
	***************************************************************************/
	friend ostream& operator<<(ostream&, const BigInteger&);
private:
	/*************************************************************************
	 * ++
	 * Method Name:	BigInteger::RemoveZero()
	 * Description: Xoa bo cac so 0 nam o dau tien
	xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
	 * Parameters:	none
	 * Return value: none
	 *
	 * Modifications: 21.04.12 - Luu Quang Vu - Nhap Mon Cong Tac Ki Su
							Funtions first created
	 * --
	***************************************************************************/
	void RemoveZero();

	string szNumber;
};

#endif