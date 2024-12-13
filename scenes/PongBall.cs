using Godot;
using System;

public partial class PongBall : RigidBody2D
{
	PackedScene pongball;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        pongBall = ResourceLoader.Load<PackedScene>("res://prefabs/pong_ball.tscn");

    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//for spawning balls for play
		if (Input.IsActionJustPressed("spawnball"))
		{
			PackedScene packedscene = ResourceLoader.Load<PackedScene>("res://prefabs/pong_ball.tscn");
			var newball = packedscene.Instantiate();

			AddChild(newball);

			newball.Position = new Vector2(400, 300);

			newdisk.Name = "pongball";
        }
		
	}
}
