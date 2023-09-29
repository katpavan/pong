using UnityEngine;

public class ComputerPaddle : Paddle
{
    [SerializeField] private Rigidbody2D ball;

    private void FixedUpdate()
    {
        // Check if the ball is moving towards the paddle (positive x velocity)
        // or away from the paddle (negative x velocity)
        if (ball.velocity.x > 0f)
        {
            // Move the paddle in the direction of the ball to track it
            if (ball.position.y > this.transform.position.y) { //the ball's position is above the computer paddle's position
                _rigidbody.AddForce(Vector2.up * speed); //move paddle up
            } else if (ball.position.y < this.transform.position.y) { //the ball's position is below the computer paddle's position
                _rigidbody.AddForce(Vector2.down * speed); //move paddle down
            }
        }
        else
        {
            // Move towards the center of the field and idle there until the
            // ball starts coming towards the paddle again
            if (this.transform.position.y > 0f) {//if we're above center point then move computer paddle down
                _rigidbody.AddForce(Vector2.down * speed); 
            } else if (this.transform.position.y < 0f) {//if we're below center point then move computer paddle up
                _rigidbody.AddForce(Vector2.up * speed);
            }
        }
    }

}

