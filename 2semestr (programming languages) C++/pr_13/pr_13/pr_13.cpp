#include <iostream>

using namespace std;

class Comand
{
	protected:
		static double rating;
		static double everageScore;
		
		void setRating(double rating1)
		{
			rating = rating1;
		}
		double countRatingInSeazon()
		{
			return rating + lastRezalt;
		}

	private:
		double lastRezalt;
		string comandName;
		int numOfPlayer;
		bool checkRating()
		{
			if (rating < 0)
				return false;
			return true;
		}
		bool checkScore()
		{
			if (everageScore < 0)
				return false;
			return true;
		}
		bool checkNumOfPlayer()
		{
			if (numOfPlayer < 0)
				return false;
			return true;
		}
	public:
		string *pointerComandName=&comandName;
		static double rating1;
		int *pointerNumOfPlayer=&numOfPlayer;
		double* pointerRating = &rating1;
		double* pointerRezalt = &lastRezalt;
		void ShowAllInfo()
		{
			cout << comandName << endl;
			if (checkNumOfPlayer())
				cout << numOfPlayer << endl; 
			
			cout << lastRezalt << endl; 
		}		
};

double Comand::rating1 = 4;
int main()
{
	setlocale(0, "Rus");
	Comand comand1;
	(*comand1.pointerComandName) = "Зенит";
	(*comand1.pointerNumOfPlayer) = 27;
	(*comand1.pointerRezalt) = 45;
	comand1.ShowAllInfo();
	cout << Comand::rating1 << endl; 
	comand1.rating1 = 10;
	cout << comand1.rating1 << endl; 
	double R = 10;
	(*comand1.pointerRating) = 10.5;

	return 0;
}