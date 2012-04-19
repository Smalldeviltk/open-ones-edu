#include <string.h>

char * getSum (char *a, char *b)
{
	int code0 = 48;
	int length = strlen(a);
	char *result = new char[length + 1];
	char *a1 = a;
	strrev(a1);
	char *a2 = b;
	strrev(a2);

	int temp = 0;
	
	for(int i = 0; i < length; ++i)
	{
		if (a[i] - code0 + b[i] - code0 + temp <= 9)
		{
			result[i] = a[i] + b[i] + temp - code0;
			temp = 0;
		}
		else
		{
			result[i] = (a[i] - code0 + b[i] - code0 + temp) % 10 + code0;
			temp = 1;
		}
	}
	if( temp == 1)
		result[length] = code0 + 1;
	result[length+1] = '\0';
	strrev(result);
	return result;
}