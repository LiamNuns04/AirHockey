using UnityEngine;

namespace Physics_Demonstration
{
    public class BarrierCollisions : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Rigidbody2D playerRigidbody = other.gameObject.GetComponent<Rigidbody2D>();
                playerRigidbody.velocity = Vector2.zero;
            }
            else if (other.CompareTag("AI"))
            {
                AIPaddleController AIPaddle = other.gameObject.GetComponent<AIPaddleController>();
                if (AIPaddle != null)
                {
                    AIPaddle.StopAIMovement();
                }
            }
        }
    }
}
