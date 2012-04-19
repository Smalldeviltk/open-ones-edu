#include "Add2N.h"


//************************************
// Method:    main
// FullName:  main
// Access:    public 
// Returns:   void
// Qualifier:
// Description: Main funtion
// Author: Nguyen Van Toan & Nguyen Le Huy
//************************************
void main()
{
	Add2N cAddTwoNumber;
	char wContinueCalculate = '0';

	while(true)
	{
		strcpy(&cAddTwoNumber.chOperation, "");
		cAddTwoNumber.strResult.clear();
		cAddTwoNumber.GetInput();
		cAddTwoNumber.GetSumOfNumber();
		cout<< "Result: " << cAddTwoNumber.chFirstNumber << " + " << cAddTwoNumber.chSecondNumber << " = " << cAddTwoNumber.strResult ;
		cout<<"\nContinue to calculate?\n 0: Continue \n Ohter: Exit \n";
		
		cin>> wContinueCalculate;
		
		if(wContinueCalculate != '0')
		{
			return;
		}
	}
}

//************************************
// Method:    GetInput
// FullName:  Add2N::GetInput
// Access:    public 
// Returns:   void
// Qualifier: 
// Description: Get input from the users
// Author: Doan Thi Phuong Thuy & Tran Tien Trung
//************************************
void Add2N::GetInput()
{
	do
	{
		printf("\n----------------Add2N--Deverlop by group 24----------------\n");
		printf("The First number: \n");
		cin>>chFirstNumber;
		fflush(stdin);
		printf("The Second number: \n");
		cin>>chSecondNumber;
		fflush(stdin);

		if(!TestInputValid(chFirstNumber) && !TestInputValid(chSecondNumber))
			cout<< chFirstNumber << ", " << chSecondNumber << " are invalid!";
		else
		{
			if(!TestInputValid(chFirstNumber))
			{
				cout<< chFirstNumber << " is invalid!";
			}
			else if(!TestInputValid(chSecondNumber))
			{
				cout<< chSecondNumber << " is invalid!";
			}

		}
	}
	while(!TestInputValid(chFirstNumber) || !TestInputValid(chSecondNumber));
}

//************************************
// Method:    GetSumOfNumber
// FullName:  Add2N::GetSumOfNumber
// Access:    public 
// Returns:   void
// Qualifier:
// Description: Get sum of the number
// Author: Nguyen Van Toan & Nguyen Le Huy
//************************************
void Add2N::GetSumOfNumber()
{
	int wMaxLenght, wi, wCarry = 0, wD1, wD2, wTemp;

	wMaxLenght = strlen(chFirstNumber);
	

	if(strlen(chSecondNumber) > wMaxLenght) 
		wMaxLenght = strlen(chSecondNumber);

	for(wi = 1; wi <= wMaxLenght; wi++)
	{
		if(wi > strlen(chFirstNumber)) 
			wD1 = 0;
		else 
			wD1 = (chFirstNumber[strlen(chFirstNumber) - wi] - '0');

		if(wi > strlen(chSecondNumber)) 
			wD2 = 0;
		else 
			wD2 = (chSecondNumber[strlen(chSecondNumber) - wi] - '0');

		wTemp=(wD1 + wD2 + wCarry) % 10;
		itoa(wTemp, &chOperation,10);
		strResult.insert(0,1, chOperation);
		wCarry = (wD1 + wD2 + wCarry) / 10;
	}
	
	if(wCarry > 0)
	{
		itoa(wCarry, &chOperation, 10);
		strResult.insert(0,1, chOperation);
	}
}

//************************************
// Method:    TestInputValid
// FullName:  Add2N::TestInputValid
// Access:    public 
// Returns:   bool
// Qualifier:
// Parameter: char * s
// Description: Test input is valid or invalid
// Author: Doan Thi Phuong Thuy & Hoang Minh Thang
//************************************
bool Add2N::TestInputValid( char *s )
{
	int wX;

	for(int i = 0;i < strlen(s); i++)
		if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z') || s[i] == '.' || s[i] == '-')
		{
			return false;
		}

		wX=atoi(s);

		if(wX <= 0)
		{
			return false;
		}
		
		return true;
}


