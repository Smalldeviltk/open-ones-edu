/***********************************************************************************************************
 * ++
 * Author:			Doan Quang Khoi
 * Module Name:		application.cpp
 *
 * Description:		Main application
 *					Start the application with parameters
 * 
 * Mod. History:	16.04.12	-	Doan Quang Khoi		File First Created
 *
 *					18.04.12	-	Tran Minh Thanh		Create main
 *														Description: Supporting parameters
 *
 *					18.04.12	-	Tran Duc Tien		Create main					
 *														Description: Analyze and output the result					
 * --
 **********************************************************************************************************/


#include <stdio.h>
#include <iostream>
#include <conio.h>
#include "number.h"

using namespace std;

void main(int argc, const char* argv[]) {
	Number *N1, *N2;
	if (argc == 3) {
		N1 = new Number(argv[1]); //First number created from 2nd parameter
		N2 = new Number(argv[2]); //Second number created from 3rd parameter

		//Calculate the value
		Number Result = *N1 + *N2;
		
		//Check fail
		if (!N1->fail && !N2->fail)
			cout<<argv[1]<<" + "<<argv[2]<<" = "<<Result; //Output the value
	}
}