using UnityEngine;

namespace Physics_Demonstration
{
    public class AIPaddleController : MonoBehaviour
    {
        public float movementSpeed = 5f; 
        public Transform barrier; 
        private GameObject Ball;
        private Rigidbody2D AIRigidBody;
        private bool CanHitBall = true; 

        void Start()
        {
            Ball = GameObject.FindGameObjectWithTag("Ball");
            
            AIRigidBody = GetComponent<Rigidbody2D>();
            
            StartAIMovement();
        }
        
        private void StartAIMovement()
        {
            StartCoroutine(MoveTowardsBall());
        }
        
        private System.Collections.IEnumerator MoveTowardsBall()
        {
            while (true) 
            {
                if (Ball != null && CanHitBall)
                {
                    Vector2 path = (Ball.transform.position - transform.position).normalized;
                    
                    if (Ball.transform.position.x > barrier.position.x)
                    {
                        AIRigidBody.MovePosition(AIRigidBody.position + path * movementSpeed * Time.deltaTime);
                    }
                    else
                    {
                        AIRigidBody.velocity = Vector2.zero;
                    }
                }

                yield return null;
            }
        }

        public void StopAIMovement()
        {
            StopCoroutine(MoveTowardsBall());
        }

        public void PreventHitBall()
        {
            CanHitBall = false;
        }

        public void AllowHitBall()
        {
            CanHitBall = true;
        }
    }
}
