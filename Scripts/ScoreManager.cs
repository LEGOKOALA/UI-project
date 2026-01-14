using Godot;

namespace UIProject.Scripts;

public partial class ScoreManager : Node
{
	public static ScoreManager Instance { get; private set; }

	public int Score { get; private set; } = 0;

	[Signal]
	public delegate void ScoreChangedEventHandler(int newScore);

	public override void _Ready()
	{
		Instance = this;
	}

	public void AddScore(int amount)
	{
		Score += amount;
		GD.Print($"ScoreManager: score is now {Score}");
		EmitSignal(SignalName.ScoreChanged, Score);
	}

	public void ResetScore()
	{
		Score = 0;
		EmitSignal(SignalName.ScoreChanged, Score);
	}
}
