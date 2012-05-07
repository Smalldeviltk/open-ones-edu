/**********************************************************************************
*++
*Author:	   Nhom 53
*Module Name:  Add2n.cpp
*
*Description: Chuong trinh cong 2 so nguyen duong lon dung doi so dong lenh
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
*
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
*
*Mod. History: 03.05.2012 -Xay dung chuong trinh
*
*
*
* _ _
**********************************************************************************/
#include <stdio.h>
#include <conio.h>
#include <iostream>


using namespace std;


class BigInt
{
private:
	int len;//so luong phan tu cua so nguyen duong lo
	int num[100];//quy dinh so phan tu toi da la 100
public:
	BigInt();//ham khoi tao so nguyen lon
	void input(char *s);//ham nhap
	int checkError(char *s);//kiem tra loi
	void ouput();//xuat ket qua tinh toan
	BigInt add(BigInt b);//ham cong hai so nguyen lon
};


//ham main
//Duong thuc hien
void main(int argc, char* argv[])
{
	BigInt a, b;

	a.input(argv[1]);
	b.input(argv[2]);
	if(a.checkError(argv[1])==1 || b.checkError(argv[2])==1)
	{
		if(a.checkError(argv[1])==1)
		{
			cout<<argv[1]<<" ";
		}
		if (b.checkError(argv[2])==1)
		{
			cout<<argv[2];
		}
		cout<<" khong hop le."<<endl;
	}
	else
	{
		BigInt c;
		c=a.add(b);
		cout<<"tong hai so la ";
		c.ouput();
	}
	_getch();
}
	