using Godot;

public partial class EndCamera : Camera2D
{
	[Export] public float Speed = 1f; // units per second

	public override void _Process(double delta)
	{
		Position += new Vector2(-Speed * (float)delta, 0);
	}
}
