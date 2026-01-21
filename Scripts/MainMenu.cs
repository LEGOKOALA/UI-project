using Godot;
using System;

public partial class MainMenu : Control
{
	// Called when the node enters the scene tree for the first time.
	public void _on_start_pressed()
	{
		GD.Print("Button Press");
		//var scene= ResourceLoader.Load("res://Scenes/Level.tscn").Instantiate();
		GetTree().ChangeSceneToFile("res://Scenes/Level.tscn") ;
	}
	
	public void _on_exit_pressed()
	{
		GD.Print("Button Press");
		GetTree().Quit();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
