using UnityEngine;

public class DirectionChanger : MonoBehaviour
{
    public Vector2 newDirection = new Vector2(1, 0);
    public float speed = 10.0f; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Rigidbody2D ballRigidbody = other.GetComponent<Rigidbody2D>();
            if (ballRigidbody != null)
            {
                ballRigidbody.velocity = newDirection.normalized * speed;
            }
        }
    }
}