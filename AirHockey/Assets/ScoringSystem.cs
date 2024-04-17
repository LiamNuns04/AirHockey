using UnityEngine;
using UnityEngine.UI;

namespace Physics_Demonstration
{
    public class ScoringSystem : MonoBehaviour
    {
        private int playerScore = 0;
        private int aiScore = 0;
        
        public Text playerScoreText;
        public Text aiScoreText;
        
        public Text gameResultText;
        
        public Button playAgainButton;
        
        public Text playAgainText;
        
        public PlayerInputController playerInputController;
        
        public int winningScore = 5;
        
        public void IncrementPlayerScore()
        {
            playerScore++;
            UpdateScores();
            CheckForGameEnd();
        }
        
        public void IncrementAIScore()
        {
            aiScore++;
            UpdateScores();
            CheckForGameEnd();
        }
        
        private void UpdateScores()
        {
            playerScoreText.text = playerScore.ToString();
            aiScoreText.text = aiScore.ToString();
        }
        
        private void CheckForGameEnd()
        {
            if (playerScore >= winningScore || aiScore >= winningScore)
            {
                if (playerScore >= winningScore)
                {
                    gameResultText.text = "Player wins!";
                }
                else
                {
                    gameResultText.text = "AI wins!";
                }

                playAgainButton.gameObject.SetActive(true); 
                playAgainText.gameObject.SetActive(true); 
                playerInputController.enabled = false;
            }
        }
        
        public void ResetGameState()
        {
            playerScore = 0;
            aiScore = 0;
            UpdateScores();
            gameResultText.text = "";
            playAgainButton.gameObject.SetActive(false);
            playAgainText.gameObject.SetActive(false);
            playerInputController.enabled = true;
        }
    }
}