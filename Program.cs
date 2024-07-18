using RockPaperScissors;

GameManger gm = new GameManger(new HumanPlayer(), new ComputerPlayer());
do
{
	RoundResult result = gm.PlayRound();	
	if(result == RoundResult.Humen)
	{
		Console.WriteLine("you Win !!!");

	}
	if (result == RoundResult.Computer)
	{
		Console.WriteLine("Computer Win !!!");

	}
	if (result == RoundResult.Draw)
	{
		Console.WriteLine("Its' Draw");
	}
	Console.WriteLine("Play again ? (Y/N)");

} while(Console.ReadLine().ToUpper() == "Y");