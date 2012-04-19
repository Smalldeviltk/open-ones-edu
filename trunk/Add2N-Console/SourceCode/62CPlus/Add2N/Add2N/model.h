/**********************************************************
Author:           Le Quach Minh Hoang
Module Name:      model.cpp
Description:      work with input and output

*********************************************************/

#ifndef VIEW_H
#define VIEW_H

#include "chArray.h"

class model
{
public:
	model();
	int wTestInput(chArray);
	void showForm(chArray, chArray, chArray);
};

#endif