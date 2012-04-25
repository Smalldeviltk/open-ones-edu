#include "Add2N.h"
bool Kiemtra(char*);
char* Tong(char*, char*); 
void main()
{
	char a[100],b[100];
	cout<<"Add2N: ";
	fflush(stdin);
	gets(a);
	gets(b);
	if(Kiemtra(a)==false || Kiemtra(b)==false)
		cout<<"Error";
	else
		cout<<a<<" + "<<b<<" = "<<Tong(a,b);
	getch();
}