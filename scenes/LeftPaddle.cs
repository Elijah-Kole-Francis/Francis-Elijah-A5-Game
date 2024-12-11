using Godot;
using System;

public partial class LeftPaddle : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	[Export]
	public float paddlespeed = 5.0f;

	[Export]
	public float speed = 10f;

	[Export]
	public float rotationspeed = 2.0f;

	private float rotationDirection;
	public override void _Ready()
	{
		rotationDirection = Input.GetAxis("counterclockwise", "clockwise");
		Velocity = Transform.X * Input.GetAxis("up", "down"); * speed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// - for up
		// null when nothing pressed
		// + for down
		float yMovement = Input.GetAxis("up", "down");

		//for constant position of paddle
		float yChange = yMovement * paddlespeed * (float)delta;

		//X position lock but y freedom of movement
		Vector2 newPosition = new Vector2(Position.X, Position.Y + yChange);

		Position = newPosition;

		if (Input.IsActionPressed("counterclockwise"));
		{ 
			
		}

		if (Input.IsActionPressed("clockwise"));
		{

		}
	}
}
