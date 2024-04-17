using UnityEngine;

namespace Physics_Demonstration
{
    public class GameStateManager : MonoBehaviour
    {
        public Transform ballTransform;
        public Transform aiTransform;
        private Vector3 initialBallPosition;
        private Vector3 initialAIPosition;

        private void Start()
        {
            initialBallPosition = ballTransform.position;
            initialAIPosition = aiTransform.position;
        }
        
        public void ResetGameState()
        {
            ballTransform.position = initialBallPosition;
            Rigidbody2D ballRigidbody = ballTransform.GetComponent<Rigidbody2D>();
            if (ballRigidbody != null)
            {
                ballRigidbody.velocity = Vector2.zero;
            }
            
            aiTransform.position = initialAIPosition;
        }
    }
}