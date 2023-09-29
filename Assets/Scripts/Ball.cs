using UnityEngine;

public class Ball : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    public float speed = 200.0f;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        GameManager.Instance.ResetRound();
    }
    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero; 
        _rigidbody.velocity = Vector3.zero;
    }

    public void AddStartingForce()
    {
        // Flip a coin to determine if the ball starts left or right
        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        // Flip a coin to determine if the ball goes up or down. Set the range
        // between 0.5 -> 1.0 to ensure it does not move completely horizontal.
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1f);

        // Apply the initial force and set the current speed
        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * speed);
    }

    //call this from BouncySurface.cs
    public void AddForce(Vector2 force){
        _rigidbody.AddForce(force);
    }

}
