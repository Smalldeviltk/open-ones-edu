#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <stdlib.h>
#include <iostream>
using namespace std;
void cong(char *s1,char *s2,char *st)
{
strrev(s1);
strrev(s2);
 int n,i,carry=0,d1,d2,tmp;
 n=strlen(s1);
 if(strlen(s2)>n) n=strlen(s2);
 for(i=0;i<n;i++)
 {
  if(i>strlen(s1)-1) d1=0;
  else d1=(s1[i]-'0');
  if(i>strlen(s2)-1) d2=0;
  else d2=(s2[i]-'0');
  tmp=(d1+d2+carry)%10;
  itoa(tmp,&st[i],10);
  carry=(d1+d2+carry)/10;
 }
 if(carry>0)
  itoa(carry,&st[n],10);
}
bool Kiemtra(char *s)
{
	bool kt=true;
	for(int i=0;i<strlen(s);i++)
	{
		if(s[i]<'0'||s[i]>'9') 
		kt=false;
	}
	return kt;
}

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
