#include <iostream>
#include <string>
using namespace std;



struct points
{
	double x1;
	double x2;
	double y1;
	double y2;
};

int main()
{

	char cordinates;
	int counter = 0;
	cout << "Please choose X or Y coordinates : ";
	cin >> cordinates;
	points PointsXy[4];
	if (cordinates == 'x' || cordinates == 'X')
	{
		cout << "Please enter X coordinates : \n";
		cout << "X1: ";
		cin >> PointsXy[0].x1;
		cout << "X2: ";
		cin >> PointsXy[1].x2;


		cout << "Please enter Y coordinates : \n";
		cout << "Y1: ";
		cin >> PointsXy[2].y1;
		cout << "Y2: ";
		cin >> PointsXy[3].y2;



		if (PointsXy[0].x1 == PointsXy[2].y1 && PointsXy[0].x1 >= 0 && PointsXy[2].y1 >= 0)
		{
			counter += 1;
			cout << "X1 and Y1 lie at the bisector and are in the 1st quadrant.\n";

		}
		if (PointsXy[3].y2 == PointsXy[1].x2 &&PointsXy[3].y2 >= 0 && PointsXy[1].x2 >= 0)
		{
			counter += 1;
			cout << "Y2 and X2 lie at the bisector and are in the 1st quadrant.\n";
		}
		// Second If construction
	}
	else if (cordinates == 'y' || cordinates == 'Y')
	{
		cout << "Please enter Y coordinates : \n";
		cout << "Y1: ";
		cin >> PointsXy[2].y1;
		cout << "Y2: ";
		cin >> PointsXy[3].y2;

		cout << "Please enter X coordinates : \n";

		cout << "X1: ";
		cin >> PointsXy[0].x1;
		cout << "X2: ";
		cin >> PointsXy[1].x2;

		if (PointsXy[3].y2 == PointsXy[1].x2 &&PointsXy[3].y2 > 0 && PointsXy[1].x2 >= 0)
		{
			counter += 1;
			cout << "Y2 and X2 lie at the bisector and are in the 1st quadrant.\n";
		}

		if (PointsXy[0].x1 == PointsXy[2].y1 && PointsXy[0].x1 > 0 && PointsXy[2].y1 >= 0)
		{
			counter += 1;
			cout << "X1 and Y1 lie at the bisector and are in the 1st quadrant.\n";

		}

	}
	if (counter > 0)
	{
		cout << "the number of points that lie on  the bisector of the first quadrant are: " << counter << ".";
	}

	else {
		cout << "No relevant points have been entered. ";
	}

	return 0;
}