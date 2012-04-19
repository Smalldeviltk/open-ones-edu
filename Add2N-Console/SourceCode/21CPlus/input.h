
#include <string.h>
#include <stdlib.h>
#include <iostream>
using namespace std;
int la, lb;
void input(char *a, char *b)
{
	char d[50];//khai bao mang tam
	int k=0;
	cout<<"Add2N ";
	gets(d);
	for(int i=0; i<strlen(d);i++)//duyet mang tam
	{
		if(d[i]==' ')
		{
			a[i]='\0';
			while(i<strlen(d))
			{
				i++;
				b[k]=d[i];
				k++;
			}
			break;
		}
		a[i]=d[i];	
	}
	la=strlen(a);
	lb=strlen(b);
	b[lb]='\0';
}