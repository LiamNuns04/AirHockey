using UnityEngine;

namespace Physics_Demonstration
{
    public class GoalDetection : MonoBehaviour
    {
        public ScoringSystem scoringSystem;
        public GameStateManager gameStateManager;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Ball"))
            {
                if (gameObject.CompareTag("Goal1"))
                {
                    scoringSystem.IncrementAIScore();
                }
                else if (gameObject.CompareTag("Goal2"))
                {
                    scoringSystem.IncrementPlayerScore(); 
                }
                
                gameStateManager.ResetGameState();
            }
        }
    }
}