// See https://aka.ms/new-console-template for more information
using HockeyTeamSystem;
using static System.Console;


//Define a constant fot the location of players CSV file
const string HockeyPlayerCsvFile = "../../../HockeyPlayer.csv";
//Create a new hockeyCoach instance for the team
HockeyCoach coach = new HockeyCoach("DaveTippet", "May 28, 2019");
WriteLine(coach);
//Create players for the team
HockeyPlayer palyer1 = new HockeyPlayer("Leon Draisaitl", 29, PlayerPosition.Center, 29, 30);
WriteLine(palyer1);
HockeyPlayer palyer2 = new HockeyPlayer("Connor McDavid", 97, PlayerPosition.Center, 20, 37);
WriteLine(palyer2);
HockeyPlayer palyer3 = new HockeyPlayer("Ryan Nugent-Hopkins", 93, PlayerPosition.Center, 3, 24);
WriteLine(palyer3);
HockeyPlayer palyer4 = new HockeyPlayer("Jesse Puljujarvi", 13, PlayerPosition.RightWing, 10, 15);
WriteLine(palyer4);
//Create a hockey team
HockeyTeam team1 = new HockeyTeam("Edmonton Oilers", TeamDivison.Pacific, coach);
//Add players tp the hockey team
team1.AddPlayer(palyer1);
team1.AddPlayer(palyer2);
team1.AddPlayer(palyer3);
team1.AddPlayer(palyer4);
/*
//Test with valid fullname, primary number 
HockeyPlayer player1 = new("Connor McDavid", 97, PlayerPosition.Center);
WriteLine(player1); //The HockeyPlayer.ToString() will be invoked indirection 

//Test with invaild PlayerNumber
try
{
    HockeyPlayer player2 = new("Connor McDavid", 0, PlayerPosition.Center);
    WriteLine("Test case failed");
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

try
{
    HockeyPlayer player2 = new("Connor McDavid", 100, PlayerPosition.Center);
    WriteLine("Test case failed");
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

//Test with invaild FullName----null FullName
try
{
    HockeyPlayer player2 = new(null, 100, PlayerPosition.Center);
    WriteLine("Test case failed");
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

//Test with invaild FullName----empty string for FullName
try
{
    HockeyPlayer player2 = new("", 100, PlayerPosition.Center);
    WriteLine("Test case failed");
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

//Test with invaild FullName----1 character for FullName
try
{
    HockeyPlayer player2 = new("A", 100, PlayerPosition.Center);
    WriteLine("Test case failed");
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

//Test with invaild FullName----whitespaces for FullName
try
{
    HockeyPlayer player2 = new("   ", 100, PlayerPosition.Center);
    WriteLine("Test case failed");
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

Person Person2 = new("Ab");
*/