#include <iostream>
using namespace std;

// declaring global, so that easily to play around with array
char gameBoard[3][3];

// creating empty board
void makeInitialBoard() {
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            gameBoard[i][j] = ' ';
        }
    }
}

/*
This should display something like:
   |   | 
-----------
   |   |
-----------
   |   | 
*/

//put an 'X' character at the given location          
bool placeX(int x, int y) {
    gameBoard[x][y] = 'X';
    return true;
}

//put an 'O' character at the given location         
bool placeO(int x, int y) {
    gameBoard[x][y] = 'O';
    return true;
}

// Return true if there are 3 'X' marks placed in a single
// column, row, or diagnol.  Return false otherwise.
bool xWins() {
    bool xwin = false;
    for (int i = 0; i < 3; i++)
    {
        if (gameBoard[i][0] == 'X' && gameBoard[i][1] == 'X' && gameBoard[i][2] == 'X')
            xwin = true;
        if (gameBoard[0][i] == 'X' && gameBoard[1][i] == 'X' && gameBoard[2][i] == 'X')
            xwin = true;
        if (gameBoard[0][0] == 'X' && gameBoard[1][1] == 'X' && gameBoard[2][2] == 'X')
            xwin = true;
        if (gameBoard[2][0] == 'X' && gameBoard[1][1] == 'X' && gameBoard[0][2] == 'X')
            xwin = true;
    }
    return xwin;
}

// Return true if there are 3 'O' marks placed in a single
// column, row, or diagnol.  Return false otherwise.      
bool oWins() {
    bool owin = false;
    for (int i = 0; i < 3; i++)
    {
        if (gameBoard[i][0] == 'O' && gameBoard[i][1] == 'O' && gameBoard[i][2] == 'O')
            owin = true;
        if (gameBoard[0][i] == 'O' && gameBoard[1][i] == 'O' && gameBoard[2][i] == 'O')
            owin = true;
        if (gameBoard[0][0] == 'O' && gameBoard[1][1] == 'O' && gameBoard[2][2] == 'O')
            owin = true;
        if (gameBoard[2][0] == 'O' && gameBoard[1][1] == 'O' && gameBoard[0][2] == 'O')
            owin = true;
    }
    return owin;
}

// Return true if there are either 3 'X' marks or 3 'O' marks
// placed in a single column, row, or diagnol, or if the board is full.
// Return false otherwise.
bool gameOver() {
    if (oWins() == true || xWins() == true)
        return true;
    else
        return false;
}

// cout a nice looking picture of the board configuration 
void display() {
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            cout << gameBoard[i][j];
            if(j == 1 || j == 0)
                cout << "|";
        }
        cout << endl;
        if (i == 1 || i == 0)
            cout << "-----" << endl;
    }
}

//MY ADDITION.
bool badPlacement(int i, int j) {
    if (gameBoard[i][j] == 'X' || gameBoard[i][j] == 'O')
        return true;
    else if (i < 0 || i > 2 || j < 0 || j > 2)
        return true;
    else
        return false;
}

// main of the program
// input should be like this
// Player One [X]: 0 0
// Player Two [O]: 1 1

//Ouput of the above snippet will be
/*
This should display something like:
 X |   | 
-----------
   | O |
-----------
   |   | 
*/

int main()
{
	bool ending, badplacement = false;
	int moves = 9;
	int xmove, ymove; // x is row and y is column, 

	do {
		ending = false;
		for (int i = 0; i < moves; i++)
		{
			if (i % 2 == 0)
			{
				cout << "Player One [X]: ";
				cin >> xmove >> ymove; // which row and which column e.g. 1 2
				if (badPlacement(xmove, ymove) == true)
				{
					do {
                        // something already there or action is out of bound
						cout << "Move Placement Error" << endl;
						cout << "Player One [X]: ";
						cin >> xmove >> ymove;
					} while (badPlacement(xmove, ymove) == true);
				}
				placeX(xmove, ymove);
			}
			else
			{
				cout << "Player Two [O]: ";
				cin >> xmove >> ymove;
				if (badPlacement(xmove, ymove) == true)
				{
					do {
						cout << "Placement Error. Something Is Already There Or You Are Out Of Bounds." << endl;
						cout << "Player Two [O]: ";
						cin >> xmove >> ymove;
					} while (badPlacement(xmove, ymove) == true);
				}
				placeO(xmove, ymove);
			}
			system("cls");
			display();

			//check wins
			if (xWins() == true)
			{
				cout << "X WON!" << endl;
				ending = true;
				return 0;
			}
			else if (oWins() == true)
			{
				cout << "O WON!" << endl;
				ending = true;
				return 0;
			}
			else if ((i+1) == moves)
			{
				cout << "IT'S A TIE!" << endl;
				ending = true;
				return 0;
			}
		}
	} while(ending != true); //when it is over, then stops

	return 0;
}