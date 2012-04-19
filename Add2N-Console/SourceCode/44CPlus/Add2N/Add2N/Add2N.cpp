#include <iostream>
#include <string>
#include <conio.h>
using namespace std;
#define max 100

bool check(char *str)
{
	int i = 0;
	int countSpace = 0;
	while(str[i] != NULL)
	{
		int temp = str[i] - '0';
		if(str[i] == ' ')
		{
			countSpace++;
			//neu vi tri dau tien, cuoi cung, hay co 2 space thi return false
			if(i == 0|| str[i + 1] == NULL|| countSpace == 2)
				return false;
		}
		//neu ky tu khong phai tu 0 --> 9 thi return false
		else if(temp> 9 || temp < 0)
			return false;
		i++;
	}

	return true;
}

char* Cong(string strA, string strB)
{
	int lengthA = strA.length();
	int lengthB = strB.length();
	int carry = 0;
	int a, b, result, size;

	if(lengthA > lengthB)
		size = lengthA + 1;
	else
		size = lengthB + 1;

	char *str = new char[size];
	lengthA--;
	lengthB--;
	str[size] = NULL;
	int k = size - 1;

	while(lengthA >= 0 || lengthB >= 0)
	{
		if(lengthA >= 0)
		{
			a = strA[lengthA] - '0';
			lengthA--;
		}
		else
			a = 0;

		if(lengthB >= 0)
		{
			b = strB[lengthB] - '0';
			lengthB--;
		}
		else 
			b = 0;

		result = a + b + carry;
		carry = result / 10;
		str[k--] = '0' + result % 10;
	}
	if(carry == 0)
		for (int i = 0; i < size; i++)
			str[i] = str[i + 1];
	else
		str[0] = '0' + carry;
	return str;

}

int main()
{
	//mang char luu tru chuoi nhap vao
	char str[max];

	//nhap chuoi
	cout<<"Add2N ";
	cin.getline(str, max);

	//kiem tra chuoi co hop le khong
	//neu hop le   --> tien hanh cong
	//khong hop le --> ket thuc chuong trinh
	if(check(str))
	{
		//2 bien string luu gia tri 2 so
		string a,b;
		int i = 0;

		//tien hanh luu 2 so can cong vao 2 bien string
		//gan so thu 1 cho bien a
		while(str[i] != ' ')
			a += str[i++];

		i++;

		//gan so thu 2 cho bien b
		while(str[i] != NULL)
			b += str[i++];

		//xuat ra ket qua
		cout<<a<<" + "<<b<<" = "<<Cong(a,b)<<endl;
	}
	else
		cout<<str<<" khong hop le"<<endl;

	getch();
	return 0;
}

