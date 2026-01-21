using Godot;
using System;

public partial class Hud : Control
{
	private Label label;


	public override void _Ready()
	{
		label = GetNode<Label>("Label");
		GD.Print("ready");


	}
}
