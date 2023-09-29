using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength = 15;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            //there could be multiple contact points, so we just want the first one
            Vector2 normal = collision.GetContact(0).normal; //get the contact point of the collision
            //we do negative here because we need to add the force in the opposite direction
            ball.AddForce(-normal * this.bounceStrength);
        }
    }

}