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
 * --
***********************************************************************************************************/


#include <stdio.h>

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

