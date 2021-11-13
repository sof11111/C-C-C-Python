#pragma once
#include <iostream>
using namespace std;

struct FIO
{
	string name;
	string surname;
	string middlename;
	FIO() {};
	FIO(string name, string surname, string middlename)
	{
		this->name = name;
		this->surname = surname;
		this->middlename = middlename;
	}
};
struct Date
{
	int day;
	int month;
	int year;
	Date() {};
	Date(int day, int month, int year)
	{
		this->day = day;
		this->month = month;
		this->year = year;
	}
};


class Person
{
	FIO fullName;
	Date dateOfBirth;
public: 
	Person(string name, string surname, string middlename, int day, int month, int year);

	
};

