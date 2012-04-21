// [58]_bai tap.cpp : Defines the entry point for the console application.
//


#include "stdafx.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"
#include <iostream>
using namespace std;

void xuatChuoi(char a[200]);
void congChuoi(char a[200],char b[200]);
void main()
{
   char a[200];
   char b[200];
   cout<<"Nhap chuoi so thu 1 : ";
   gets(a);
   cout<<"Nhap chuoi so thu 2 : ";
   gets(b);
   congChuoi(a,b);
   getch();
}
void congChuoi(char a[200],char b[200])
{
   int i,doDaiChuoi,soSanhChuoi;
   char c[200];
   char temp1[200];
   char temp2[200];
   int dem;
   soSanhChuoi= strlen(b)-strlen(a);
   strrev(a);
   strrev(b);
   if(soSanhChuoi<0)
   {
      strcpy(temp1,a);
      strcpy(temp2,b);
      strcpy(a,temp2);
      strcpy(b,temp1);
      doDaiChuoi= strlen(b);
      for(i=(doDaiChuoi-(strlen(b)-strlen(a)));i<doDaiChuoi;i++)
      {
      a[i]=48;
      }
   }
   else if(soSanhChuoi>0)
   {
      doDaiChuoi= strlen(b);
      for(i=(doDaiChuoi-(strlen(b)-strlen(a)));i<doDaiChuoi;i++)
      {
      a[i]=48;
      }
   }
   else if(soSanhChuoi==0)
   {
      doDaiChuoi= strlen(b);
   }
   dem=0;
   for(i=0;i<doDaiChuoi;i++)
   {
      if((a[i]+b[i])>105)
      {
         if(dem==1)
         {
            c[i]=(a[i]+b[i])-48-10+1;
            if(((a[i]+b[i])-48+1)>57)
            {
                dem=1;
            }
            else if(((a[i]+b[i])-48+1)<58)
            {
                dem=0;
            }
         }
         else if(dem==0)
         {
            c[i]=(a[i]+b[i])-48-10;
            dem=1;
         }
      }
      else if((a[i]+b[i])<106)
      {
         if(dem==1)
         {
            c[i]=(a[i]+b[i])-48+1;
            if(((a[i]+b[i])-48+1)>57)
            {
                dem=1;
                c[i] -=10;
            }
            else if(((a[i]+b[i])-48+1)<58)
            {
                dem=0;
            }
         }
         else if(dem==0)
         {
            c[i]=(a[i]+b[i])-48;
            dem=0;
         }
      }
   }
   if( c[doDaiChuoi-1]==48)
   {
      c[doDaiChuoi]=49;
      c[doDaiChuoi+1]=0;
   }
   else if( c[doDaiChuoi-1]!=48)
   {
      if(soSanhChuoi==0)
      {
        c[doDaiChuoi]=49;
        c[doDaiChuoi+1]=0;
      }
      if(soSanhChuoi!=0)
      {
         c[doDaiChuoi]=0;
      }
   }
   strrev(c);
   cout<<"Vay tong 2 chuoi la: ";
   puts(c);
}