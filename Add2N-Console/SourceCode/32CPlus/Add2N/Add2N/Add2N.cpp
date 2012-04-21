// Add2N.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "BigInteger.h"

/*************************************************************************
 * ++
 * Method Name:	ExtractCommand
 * Description: Phan tich chuoi nhap vao thanh cac toan hang va kiem tra
				loi
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 * Parameters:	const string&:	Chuoi lenh do nguoi dung nhap vao
 *				BigInteger&:	Toan hang thu nhat
 *				BigInteger&:	Toan hang thu hai
 * Return value: none
 *
 * Modifications: 15.04.12 - Pham Minh Triet - Nhom 32 - Nhap Mon Cong Tac Ki Su
						Functions first created
 * --
***************************************************************************/
void ExtractCommand(const string&, BigInteger&, BigInteger&);


/*************************************************************************
 * ++
 * Method Name:	_tmain
 * Description: Ham main cua chuong trinh
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 *				xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
 * Parameters:	int argc
				_TCHAR* argv[]
 * Return value: int
 *
 * Modifications: 15.04.12 - Luu Quang Vu - Nhom 32 - Nhap Mon Cong Tac Ki Su
						Functions first created
 * --
***************************************************************************/
int _tmain(int argc, _TCHAR* argv[])
{
	string szCommand;
	getline(cin, szCommand);
	BigInteger op1, op2;
	try
	{
		ExtractCommand(szCommand, op1, op2);
		cout<<op1<<" + "<<op2<<" = "<<(op1 + op2)<<endl;
	}
	catch (string szErr)
	{
		cout<<szErr<<endl;
	}

	system("pause");

	return 0;
}