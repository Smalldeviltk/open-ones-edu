#include "Functions.h"

int main(int argc, char* argv[])
{

	if(InputOK(argc, argv))
	{

		string AddResult;
		string SN1(argv[1]);
		string SN2(argv[2]);

		AddResult = Add( SN1, SN2);
		ViewResult(SN1, SN2, AddResult);

	}

	return 1;

}