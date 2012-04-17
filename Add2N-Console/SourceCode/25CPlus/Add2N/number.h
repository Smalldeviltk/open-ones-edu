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

};


