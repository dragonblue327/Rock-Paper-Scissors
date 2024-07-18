namespace RockPaperScissors;

public class ComputerPlayer : IPlayer
{

	public Choice GetChoice()
	{
		Random _reg = new Random();

		Choice Computer = (Choice)_reg.Next(0, 3);

		return Computer;

	}
}

