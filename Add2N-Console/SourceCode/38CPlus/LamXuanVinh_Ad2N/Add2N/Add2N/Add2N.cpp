#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <stdlib.h>
#include <iostream>
#include "add.h"
using namespace std;
int main(int argc, char** argv)
{
	if(argc!=3)
	{
		cout<<"Nhap theo cu phap: Add2N sothu1 sothu2\n";
	}
	else
	{
		char *st;
		if(!Kiemtra(argv[1]))
		{
			cout<<argv[1]<<" Khong hop le";
		}
		if(!Kiemtra(argv[2]))
		{
			cout<<argv[2]<<" Khong hop le";
		}
		if(Kiemtra(argv[1])&&Kiemtra(argv[2]))
		{

			st= new char(255);
			cong(argv[1],argv[2],st);
			strrev(st);
			cout<<strrev(argv[1])<<"+"<<strrev(argv[2])<<"="<<st;
		}
	}
 return 0;
}
