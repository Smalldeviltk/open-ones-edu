/**
*
Tên: Lý Vĩnh Tường.
Nhóm: 21
*/

#include <stdio.h>
#include <string.h>

/***
chức năng tương tự strcat, nhưng thay vì thêm vào cuối chuỗi thì hàm này thêm vào đầu chuỗi
****/
char* catstr(char *s,char *d)  
{
	int length = strlen(s) + strlen(d) + 1;
	char *returnStr = new char[length];
	strcpy(returnStr,s);
	strcat(returnStr,d);
	returnStr[length] = '\0';
	return returnStr;
}
/***
đưa 2 chuỗi về cùng chiều dài
***/
void convertLength(char *&a,char *&b) 
{
	int la = strlen(a);
	int lb = strlen(b);
	if (la > lb)
	{
		for (int i=0;i<la-lb;i++)
		{
			b = catstr("0",b);
		}
	}
	else
	{
		for (int i=0;i<lb-la;i++)
		{
			a = catstr("0",a);
		}
	}
}