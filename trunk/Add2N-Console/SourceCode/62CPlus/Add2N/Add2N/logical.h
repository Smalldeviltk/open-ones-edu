/**********************************************************
Author:           Loc Van Tien
Module Name:      logical.cpp
Description:      some logic functions to work with data

*********************************************************/

#ifndef LOGIC_H
#define LOGIC_H

#include "chArray.h"

class logical
{
private:
	int wMax(int, int);
public:
	logical();
	void pAdd2N(chArray, chArray, chArray &);
};

#endif