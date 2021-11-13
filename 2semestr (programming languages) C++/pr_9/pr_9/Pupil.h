#pragma once
#include "Person.h"


class Pupil
{
	FIO fullName;
	Date dateOfBirth;
	int schoollnumber;
	int startyear;
	char classnumber[];

public: Pupil();
	  Pupil(string name, string surname, string middlename, int day, int month, int year);
};

