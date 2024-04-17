using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Transform barrier;

    private Rigidbody2D PlayerRigidbody;
    private bool isDragging = false;

    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; 

            if (mousePosition.x > barrier.position.x)
            {
                mousePosition.x = barrier.position.x;
            }
            else
            {
                PlayerRigidbody.MovePosition(mousePosition);
            }
        }
    }
}
