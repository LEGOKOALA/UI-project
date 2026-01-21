using Godot;

namespace UIProject.Scripts;

public partial class UI : CanvasLayer
{
	private Label _scoreLabel;

	public override void _Ready()
	{
		_scoreLabel = GetNode<Label>("ScoreLabel");

		// Connect to the signal using the singleton instance
		ScoreManager.Instance.ScoreChanged += OnScoreChanged;

		// Initialize the label
		_scoreLabel.Text = $"Score: {ScoreManager.Instance.Score}";
		
		GD.Print("UI READY"); // sanity check
	}

	private void OnScoreChanged(int newScore)
	{
		GD.Print($"UI received score: {newScore}");
		_scoreLabel.Text = $"Score: {newScore}";
	}
}
