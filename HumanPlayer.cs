namespace RockPaperScissors;

public class HumanPlayer : IPlayer
{
	public Choice GetChoice()
	{
		Choice player = new Choice();
		do
		{

			Console.WriteLine("Enter Your Choice R=> Rock , P => Paper , S => Scissors");
			string input = Console.ReadLine().ToUpper();
			if (input == "P")
			{
				player = Choice.Paper;
				break;
			}
			if (input == "R")
			{
				player = Choice.Rock;
				break;
			}
			if (input == "S")
			{
				player = Choice.Scissors;
				break;
			}
			else
			{
				Console.WriteLine("Invalid Choice");
			}

		} while (true);
		return player;
	}
}
