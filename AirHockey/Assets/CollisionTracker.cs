using UnityEngine;

namespace Physics_Demonstration
{
    public class CollisionTracker : MonoBehaviour
    {
        public AIPaddleController AIPaddleController;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                if (gameObject.CompareTag("AI"))
                {
                    AIPaddleController.PreventHitBall();
                }
                else if (gameObject.CompareTag("Player"))
                {
                    AIPaddleController.AllowHitBall();
                }
            }
        }
    }
}