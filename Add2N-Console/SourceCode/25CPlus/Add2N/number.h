/***********************************************************************************************************
 * ++
 * Author:			Doan Quang Khoi
 * Module Name:		number.h
 *
 * Description:		Create a link list to store number in char list.
 *					Support plus operator
 * 
 * Mod. History:	16.04.12	-	Doan Quang Khoi		File First Created
 *
 *					16.04.12	-	Doan Quang Khoi		Create subNumber class
 *														Description: Store a sequential number
 *
 *					16.04.12	-	Vu Vuong Hiep		Create Number class
 *														Description: create structure and constructors
 *
 *					16.04.12	-	Doan Quang Khoi		Create Number class
 *														Description: Operator+ & Operator<<
 * --
***********************************************************************************************************/


#include <stdio.h>
#include <iostream>

using namespace std;
class subNumber { //subNumber in a sequent of number
public:
	char num;
	subNumber *pNext; //Pointer to the next subNumber
	subNumber *pPrev; //Pointer to the previous subNumber

	subNumber() { //Default subNumber constructor
		pNext = NULL;
		pPrev = NULL; 
	}

	subNumber(char Num) { //Constructor with a character
		if (Num >= '0' && Num <= '9') {
			num = Num;
		}
		pNext = NULL;
		pPrev = NULL;
	}

	subNumber(int Num) { //Constructor with an int
		if (Num >= 0 && Num <= 9)
			num = '0' + Num;

		pNext = NULL;
		pPrev = NULL;
	}

	int ToInt() { //Convert to int
		return (num - '0');
	}
};


class Number { //Link list contain sequence of subNumber items
public:
	subNumber *pHead, *pTail; //Head & Tail of the link list
	int fail;

	Number(const char *Num) { //Constructor with a char array
		fail = 0;
		const char *oNum = Num;
		pHead = pTail = NULL;

		while(Num[0] >= '0' && Num[0] <= '9') {
			subNumber *num = new subNumber(*(Num++));
			AddTail(num);
		}

		if (Length() == 0 || ((Num[0] < '0' || Num[0] > '9') && Num[0] != '\0' )) { //Check the value
			printf("%s khong hop le\r\n", oNum);
			fail = 1;
		}
	}

	Number() { //Default constructor
		fail = 0;
		pHead = pTail = NULL;
	}

	int Length() { //Calculate the number of the elements
		int length = 0;
		subNumber *current = pHead;
		while(current != NULL) {
			current = current->pNext;
			length++;
		}
		return length;
	}

	/*
	 * Oveload operator + using to use to add 2 number
	 */
	friend Number operator+(Number &Num1, Number &Num2) {
		int Remember = 0; //Define the memory
		Number *nResult = new Number(); //To store the result
		Number Max = Num2; //Determine the max "Number"
		if (Num1.Length() > Num2.Length())
			Max = Num1;
		
		subNumber *stopflag = Max.pTail; //Stopflag to determine when to stop looping elements
		subNumber *N1 = Num1.pTail; //The first number
		subNumber *N2 = Num2.pTail; //The second number

		while(stopflag != NULL) { //Stop whenever stopflag == NULL
			//Convert to int if the element is not NULL
			int sN1 = 0, sN2 = 0;
			if (N1 != NULL)
				sN1 = N1->ToInt(); 
			if (N2 != NULL)
				sN2 = N2->ToInt();

			//Get the result and the value to remember
			int Result = (sN1 + sN2 + Remember) % 10;
			Remember = (sN1 + sN2 + Remember) / 10;
			
			//Create new subNumber element of the result
			subNumber *sResult = new subNumber(Result);
			//Add to result
			nResult->AddHead(sResult);

			//Take to the previous element
			stopflag = stopflag->pPrev;
			if (N1 != NULL) N1 = N1->pPrev;
			if (N2 != NULL) N2 = N2->pPrev;
		}

		//Checking memory when calculation completed
		if (Remember > 0) {
			subNumber *last = new subNumber(Remember);
			nResult->AddHead(last);
		}

		//return the result
		return *nResult;
	}
	
	/*
	 * Oveload operator << using in cout<<(Number)
	 */
	friend ostream &operator<<(ostream &stream, Number num) {
		subNumber *current = num.pHead;
		while(current != NULL) {
			stream<<current->num; //output the element value
			current = current->pNext;
		}
		return stream;
	}
};


