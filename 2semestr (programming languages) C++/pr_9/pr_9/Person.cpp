#include "Person.h"

Person::Person(string name, string surname, string middlename, int day, int month, int year)
{
	fullName = FIO(name, surname, middlename);
	dateOfBirth = Date(day, month, year);
}