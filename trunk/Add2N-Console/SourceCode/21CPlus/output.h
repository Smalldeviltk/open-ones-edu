#include <string.h>
#include <stdlib.h>
#include <iostream>
using namespace std;
void xuatso(char *a, int d);
void output(char *a, char *b, int *kq)
{
	if(la>lb)
	{
		xuatso(&*a,0);
		cout<<" + ";
		xuatso(&*b,la-lb);
		cout<<" = ";
		for(int i=0; i<la;i++)
		{
			cout<<kq[i];		
		}
	}
	else if(lb>la)
	{
		xuatso(&*a,lb-la);
		cout<<" + ";
		xuatso(&*b,0);
		cout<<" = ";
		for(int i=0; i<lb;i++)
		{
			cout<<kq[i];		
		}
	}
	else
	{
		xuatso(&*a,0);
		cout<<" + ";
		xuatso(&*b,0);
		cout<<" = ";
		for(int i=0; i<la;i++)
		{
			cout<<kq[i];		
		}
	}
		
}
void xuatso(char *a, int d)
{
	for(int i=d; i<strlen (a);i++)
		{
			cout<<a[i];		
		}
}