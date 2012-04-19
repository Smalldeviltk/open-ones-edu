// 08_ADD2N.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


#include <stdio.h>
#include<conio.h>
#include<string.h>
#include <iostream>
using namespace std;

// PHAM VU QUOC VINH
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

void List::addLast (int newdata){
	Node* pTemp=new Node;
	pTemp->data =newdata;
	if(pHead==NULL){
		pHead=pTemp;
		pHead->next =NULL;
		pHead->prev=NULL;
		count ++;
	}
	else
	{
		if(pHead->next == NULL){
			pHead->next=pTemp;
			pHead->prev=pTemp;
			pTemp ->next=pHead;
			pTemp->prev=pHead;
			count++;
		}
		else{
			Node* pTail=new Node;
			pTail=pHead->prev;
			pTail->next=pTemp;
			pHead->prev=pTemp;
			pTemp->next=pHead;
			pTemp->prev =pTail;
			count++;
		}
	}
}
void List::addFirst(int newdata)
{
	Node* pTemp=new Node;
	pTemp->data =newdata;
	if(pHead==NULL){
		pHead=pTemp;
		pHead->next=NULL;
		pHead->prev=NULL;
		count ++;
	}
	else
	{
		if(pHead->next  ==NULL){
			pHead->prev=pTemp;
			pHead->next=pTemp;
			pTemp->next=pHead;
			pTemp->prev=pHead;
			pHead=pTemp;
			count++;
		}
		else{
			Node* pTail=new Node;
			pTail=pHead->prev;
			pHead->prev=pTemp;
			pTemp->next=pHead;
			pTemp->prev =pTail;
			pHead=pTemp;
			pTail->next=pHead;
			count++;
		}
	}	
}
