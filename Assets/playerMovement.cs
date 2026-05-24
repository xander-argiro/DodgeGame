using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{

    float inputX = 0f;
    float moveSpeed = 5f;
    float xLimit = 9.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed) {
            inputX = -1f;

        } else if(Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            inputX = 1f;

        } else
        {
            inputX = 0f;
        }
        
        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

        float clampedX = Mathf.Clamp(transform.position.x, -xLimit, xLimit);
        transform.position = new Vector3 (clampedX, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        FindAnyObjectByType<GameManager>().GameOver();

    }

}
