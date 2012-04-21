#include <string.h>
#include <stdlib.h>
#include <iostream>
using namespace std;
void xuatso(char *a, int d);
void output(char *a, char *b, char *kq)
{
	if(la>lb)
	{
		xuatso(&*a,0);
		cout<<" + ";
		xuatso(&*b,la-lb);
		cout<<" = ";
		xuatso(&*kq,0)
	}
	else if(lb>la)
	{
		xuatso(&*a,lb-la);
		cout<<" + ";
		xuatso(&*b,0);
		cout<<" = ";
		xuatso(&*kq,0)
	}
	else
	{
		xuatso(&*a,0);
		cout<<" + ";
		xuatso(&*b,0);
		cout<<" = ";
		xuatso(&*kq,0)
	}
		
}
void xuatso(char *a, int d)
{
	for(int i=d; i<strlen (a);i++)
		{
			cout<<a[i];		
		}
}