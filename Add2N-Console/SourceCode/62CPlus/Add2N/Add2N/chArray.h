/**********************************************************
Author:           Truong Van Linh
Module Name:      chArray.cpp
Description:      include some method what work with an array of char

*********************************************************/


#ifndef CHARRAY_H
#define CHARRAY_H

class chArray
{
private:
	char *pchar; 
	int wNumChars;
public:
	chArray(int);
	~chArray();
	void invertChars();
	void showChars();
	int wGetNumChars();
	char* pGetPChar();
}
#endif