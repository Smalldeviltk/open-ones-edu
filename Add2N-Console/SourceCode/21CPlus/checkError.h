#include <string.h>
using namespace std;
int checkError(char *a,char *b) //Kiem tra loi
 {
	 int i,n=strlen(a); 
	 int j, m=strlen(b);
	 
	 for( i=0;i<n;i++)
	 {
		 if(a[i]<'0'||a[i]>'9') break;
	 }
	  for(j=0;j<m;j++)
	 {
		 if(b[j]<'0'||b[j]>'9') break;
	 }
	 if(i!=n )
	 {
		 cout<<"chuoi "<<a<<" khong phai la so\n";
	 }
	  if(j!=m )
	 {
		 cout<<"chuoi "<<b<<" khong phai la so\n";
	 }
	  if(i==n && j==m)
	  {
		  return 1;
	  }
	 else return 0;
	
 }