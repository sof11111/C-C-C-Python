#include <iostream>

using namespace std;

class MyList
{
public:
	char data;
	MyList* head;
	MyList* teal;
	MyList* prev;
	MyList* next;
	//MyList() {}
	void Add(char data)
	{
		MyList* buff = new MyList();
		this->data = buff->data = data;
		if (head == NULL)
		{
			head = teal = buff;
			teal->prev = head;
			teal->next = head;
			head->next = teal;
		}
		else
		{
			teal->next = buff;
			buff->prev = teal;
			teal = buff;
			buff->next = head;
		}
	}
	void PrintList()
	{
		MyList* listForPrint = head;
		int counter = 0;
		while(listForPrint!=head||counter==0)
		{
			cout << listForPrint->data << endl;
			listForPrint = listForPrint -> next;
			counter++;
		}
	} 
	void PrintList2()
	{
		MyList* listForPrint = head;
		cout << listForPrint->data << endl;
		listForPrint = listForPrint->next;		
		while (listForPrint != head)
		{
			cout << listForPrint->data << endl;
			listForPrint = listForPrint->next;
		}
	}
	MyList* SearchEl(char info)
	{
		MyList* ListForSearch = head;
		int counter = 0;
		while (ListForSearch!=head||counter==0)
		{
			if (ListForSearch->data == info)
				return ListForSearch;
			ListForSearch = ListForSearch->next;
		}
		return NULL;
	}
	void Replace(MyList* pointer, char newData)
	{
		pointer->data = newData;
	}
	void PrintListold(int counter)
	{
		int cnt = 0;
		MyList* listForPrint = head;		
		while (cnt<counter)
		{
			cout << listForPrint->data << endl;
			listForPrint = listForPrint->next;
			cnt++;
		}
	}
	~MyList()
	{
		
		while(head!=NULL)
		{
			MyList* listForDel = head->next;
			delete head;// listForDel;
			head = next;
			//listForDel = listForDel->next;
		}
	}
};

int main()
{
	MyList* list1 = new MyList();
	list1->Add('1');	
	list1->Add('2');	
	list1->Add('3');
	list1->Add('4');
	list1->Add('5');
	list1->Add('6');
	list1->PrintList2();
	MyList* pointer = list1->SearchEl('1');
	list1->Replace(pointer, '0');
	list1->PrintList();
	list1->~MyList();

	return 0;
}