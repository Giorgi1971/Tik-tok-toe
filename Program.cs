// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Diagnostics;
using System.Dynamic;
using System.Text;


Console.WriteLine("Enter Player1 name: ");
// string player1 = Console.ReadLine();
string player1 = "Ale";
Console.WriteLine("Enter Player2 name: ");
// string player2 = Console.ReadLine();
string player2 = "Niko";
string currentPlayer = player1;

bool move = true;
string mark = "X";


while (move)
{
    if (currentPlayer != player1)
    {
        currentPlayer = player1;
    }
    else{
        currentPlayer = player2;
    }
    Console.WriteLine($"Enter {currentPlayer} position");
    cord = getCoordinate();
    

    string[,] cells = new string[3, 3]{{"1","2","3"},{"4","5","6"},{"7","8","9"}}; 
    for (int i = 0; i < 3; i++)
    {
        Console.Write("\n");
        for (int j = 0; j < 3; j++)
            Console.Write(cells[i, j] + " ");
    }
    move = false;
}

static int[,] getCoordinate()
{
    while(true)
    {
        try
        {
            string text = Console.ReadLine();
            string[] subs = text.Split(' ', ',');
            int x = Convert.ToInt16(subs[0]);
            int y = Convert.ToInt16(subs[1]);
            var coordinate = new int[x,y];
            return coordinate;
        }
        catch
        {
            Console.WriteLine("oeeeeeeeeee!");
            continue;
        }
    }
}