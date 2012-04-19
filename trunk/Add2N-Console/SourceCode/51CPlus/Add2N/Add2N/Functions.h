/************************************************************************
********
 * ++
 * Author        :  ITEW1.C21_5
 * Module Name   :  Functions.h
 *
 * Description   :
 Gom cac ham dung trong chuong trinh Add2N - Con hai so nguyen duong lon
 *
 * Mod.  History : 19.04.12 - Con hai so nguyen duong lon
 * --

 ************************************************************************
 ********/
#include <string>
#include <iostream>
using namespace std;

// Ham kiem tra tinh hop le cua doi so
bool InputOK(int argc, char* argv[]);

// Cong hai so nguyen nhu cong bang tay
string Add(string s1, string s2);

// Hien thi ket qua
void ViewResult(string s1, string s2, string sum);