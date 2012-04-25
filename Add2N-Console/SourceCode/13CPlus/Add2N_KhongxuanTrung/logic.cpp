
#include "Add2N.h"
char* Tong(char* a, char* b)
{
	char *kq,nho=0;
    int len1=strlen(a);
	int len2=strlen(b);
	int len=0;
    if(len1>=len2)
		kq=new char[len1];
    else 
		kq=new char[len2];
    while((len1>0)&&(len2>0))
    {
        char tong=a[--len1]+b[--len2]-2*'0'+nho;
        kq[len++]=tong%10+'0';
        nho=tong/10;
    }
    while(len1>0)
    {
        char tong=a[--len1]-'0'+nho;
        kq[len++]=tong%10+'0';
        nho=tong/10;
    }
    while(len2>0)
    {
        char tong=b[--len2]-'0'+nho;
        kq[len++]=tong%10+'0';
        nho=tong/10;
    }
    if(nho) kq[len++]='1';
    kq[len]=0;
    strrev(kq);
    return kq;
}

bool Kiemtra(char* a)
{
	for(int i=0; i<strlen(a);i++)
		if(a[i]<'0' || a[i]>'9')
			return false;
	return true;
}