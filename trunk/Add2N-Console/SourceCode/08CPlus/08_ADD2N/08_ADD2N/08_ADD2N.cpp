// 08_ADD2N.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


#include <stdio.h>
#include<conio.h>
#include<string.h>
#include <iostream>
using namespace std;
class Node {
      public:
	 int data; 
	 Node* next;
	 Node* prev;
};

class List {
	private:
		int count;
		Node* pHead;
	public:
		List() ;
		void addFirst(int) ;
		void addLast(int);
		void display();
		void CongHaiSoLon(List *,List *,List *);
		int empty();
		void removeFirst();
		void clear();
		~List();	
};
List::List() {
	pHead = NULL;
	count = 0;
}
