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
	chArray();
	chArray(int);
	~chArray();
	void invertChars();
	void showChars();
	void addChar(char);
	void setNumChars(int);
	void setPChar(char*);
	int wGetNumChars();
	char* pGetPChar();
};
#endif