using Godot;
using System;

public partial class LeftPaddle : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	[Export]
	public float paddleSpeed = 5.0f;

	[Export]
	public float speed = 10f;

	[Export]
	public float rotationSpeed = 2.0f;

	private float rotationDirection;
	public override void _Ready()
	{
		
	}

    public void GetInput()
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
		float yChange = yMovement * paddleSpeed * (float)delta;

		//X position lock but y freedom of movement
		Vector2 newPosition = new Vector2(Position.X, Position.Y + yChange);

		Position = newPosition;
		
		GetInput();
		Rotation += rotationDirection * rotationSpeed * (float)delta;

	}
}
