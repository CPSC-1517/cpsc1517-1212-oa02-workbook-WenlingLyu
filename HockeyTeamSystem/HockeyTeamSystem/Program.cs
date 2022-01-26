// See https://aka.ms/new-console-template for more information
using HockeyTeamSystem;
using static System.Console;

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
