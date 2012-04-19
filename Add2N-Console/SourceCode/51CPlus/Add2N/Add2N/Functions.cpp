#include "Functions.h"

// Ham kiem tra tinh hop le cua doi so
bool InputOK(int argc, char* argv[])
{
	if ( argc != 3)

	{

		cout<<endl<<"<Loi> Sai dinh dang tham so nhap vao !"<<endl
			<<"Ban phai nhap theo dinh dang sau: "
			<<"Add2N <so thu nhat> <so thu hai>"<<endl;
		return false;

	}

	else

	{

		string s1(argv[1]);
		string s2(argv[2]);
		int i = 0;
		bool bS1IsOK = true;
		bool bS2IsOK = true;

		// Kiem tra so thu nhat
		for (i = 0; i< s1.length(); i++)
			if ( s1[i] > '9' || s1[i] < '0' )
			{

				cout<<s1<<"\t Khong hop le !"<<endl;
				bS1IsOK = false;
				break;

			}
			
		// Kiem tra so thu hai
		for (i = 0; i< s2.length(); i++)
			if ( s2[i] > '9' || s2[i] < '0' )
			{

				cout<<s2<<"\t Khong hop le !"<<endl;
				bS2IsOK = false;
				break;

			}

		if ( bS1IsOK == false || bS2IsOK == false )

			return false;

	}

	return true;

}

// Cong hai so nguyen nhu cong bang tay
string Add(string s1, string s2)
{

	string sResult;
	int wNho = 0;
	int wTong = 0;

	while(s1.length() > 0 || s2.length() > 0)
	{

		// Tinh tong hai so cung cot
		wTong = 0;
		if( s1.length() > 0 )

			wTong += (s1[s1.length() - 1] - '0');

		if( s2.length() > 0 )

			wTong += (s2[s2.length() - 1] - '0');

		// Tong moi
		wTong += wNho;

		// Tinh ket qua
		char chDigit = '0' + (wTong % 10);
		sResult = chDigit + sResult;

		// Nho moi
		wNho = wTong / 10;

		// Chuan bi cho lan cong moi
		if( s1.length() > 0 )

			s1.erase(s1.length()-1, 1);

		if( s2.length() > 0 )

			s2.erase(s2.length()-1, 1);
		
	}

	if (wNho == 1)

		sResult.insert(0,"1");

	return sResult;
}

// Hien thi ket qua
void ViewResult(string s1, string s2, string sum)
{
	cout<<s1<<" + "<<s2<<" = "<<sum<<endl;
}