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

//CAO HOANG VU

void List::CongHaiSoLon(List *kq,List *f2,List *f1)
{
	
	int sosothu1=f1->count;
	int sosothu2=f2->count;
		int max_size;
		(sosothu1>sosothu2)?max_size=sosothu1:max_size=sosothu2;
		int dem;
		if(sosothu1>sosothu2){
			int i=sosothu1-sosothu2;
			while(i>0){
				f2->addFirst(0);
				i--;
			}
		}
		else{
			if(sosothu1<sosothu2){
			int i=sosothu2-sosothu1;
				while(i>0){
					f1->addFirst(0);
					i--;
				}
			}
		}
		dem=1;
		Node* pHead1=new Node();
		Node* pHead2=new Node();
		Node* pTail1=new Node();
		Node* pTail2=new Node();
		Node* pHeadkq=new Node();
		pHead1=f1->pHead;
		pHead2 =f2->pHead;
		pTail1=pHead1->prev;
		pTail2 =pHead2->prev;
		while(dem<=max_size)
		{
			if((pTail1 ->data +pTail2->data)<10)
			{
				kq->addFirst (0);
				pHeadkq=kq->pHead;
				pHeadkq ->data =(pTail1 ->data +pTail2->data);
				pTail1 =pTail1 ->prev;
				pTail2=pTail2->prev;
				dem++;
			}
			else
			{
				kq->addFirst (0);
				pHeadkq=kq->pHead;
				pHeadkq ->data =(pTail1 ->data +pTail2->data)%10;
				pTail1 =pTail1 ->prev;
				pTail2=pTail2->prev;
				if(dem==max_size) break;
				pTail2->data=pTail2 ->data+1;
				dem++;
			}
		}
		pTail1=f1->pHead;
		pTail2 =f2->pHead;
		if(pTail1 ->data +pTail2->data>=10){
					kq->addFirst(1);
			}
}
