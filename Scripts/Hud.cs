using Godot;
using System;

public partial class Hud : Control
{
	private Label label;

	public override void _Ready()
	{
		label = GetNode<Label>("Level/HUD/Label");
		GD.Print("ready");
	}
}
