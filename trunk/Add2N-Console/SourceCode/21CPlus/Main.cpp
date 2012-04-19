#include <iostream>
#include "input.h"
#include "output.h"
#include "checkError.h"
#include "convertLength.h"
#include "getSum.h"
#include "string.h"

using namespace std;

int main()
{
	char *a = new char;
	char *b = new char;
	char *result = new char;

	input(a,b);
	if(checkError(a,b) == 0) return 0;
	catstr(a,b);
	convertLength(a,b);
	result = getSum(a,b);
	output(a,b,result);
	getch();
	return 1;
}
