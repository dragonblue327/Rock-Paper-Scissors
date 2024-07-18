using RockPaperScissors;

public class GameManger
{
	private IPlayer _player;
	private IPlayer _computer;
	public GameManger(IPlayer player, IPlayer computer)
	{
		_player = player;
		_computer = computer;
	}
	public RoundResult PlayRound()
	{
		Choice player = _player.GetChoice();

		Choice computer = _computer.GetChoice();

		Console.WriteLine($"Human player picks {player.ToString()} computer player picks {computer.ToString()}");
		if (player == computer)
		{
			return RoundResult.Draw;
		}
		if ((player == Choice.Scissors && computer == Choice.Rock)
			|| (player == Choice.Paper && computer == Choice.Scissors)
			|| (player == Choice.Rock && computer == Choice.Paper))
		{
			return RoundResult.Computer;
		}
		else
		{
			return RoundResult.Humen;
		}

	}
}
