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

//ham khoi tao so nguyen lon
//Ly thuc hien
BigInt::BigInt()
{
	for(int i = 0; i <100; i++)
	{
		this->num[i]=0;
	}
	this->len = 0;
}

//ham nhap so nguyen lon
//Ly thuc hien
void BigInt::input(char *s)
{
	this->len = strlen(s);
	for(int i=0; i<this->len; i++)
	{
		this->num[i] = s[this->len-i-1] - '0';
	}
}

//ham kiem tra xem co chua nhung ki tu khong phai la ki tu so khong?
//Tuan thuc hien
int BigInt::checkError(char *s)
 {
	 char *t = new char[100];
	 int j=0;
	 for(int i=0; i<this->len; i++)
	 {
		 if(s[i]<'0' || s[i]>'9')
		 {
			 return 1;
		 }
	 }
	 return 0;
 }
	
//ham xuat ket qua cong
//Truyen thuc hien
void BigInt::ouput()
{
	for(int i=0; i<this->len; i++)
	{
		cout<<this->num[this->len-i-1];
	}
}

//ham cong so nguyen lon
//Liem thuc hien
BigInt BigInt::add(BigInt b)
{
	BigInt tam;
	int n= (this->len > b.len)?this->len:b.len;
	tam.len = n;
	int m=0;//bien nho
	for(int i=0; i<n;i++)
	{
		tam.num[i]=this->num[i]+b.num[i]+m;
		if(tam.num[i]>9)
		{
			tam.num[i]-=10;
			m=1;
		}
		else
			m=0;
	}
	if(m)
	{
		tam.num[tam.len]=1;
		tam.len+=1;
		
	}
	return tam;
}

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
	