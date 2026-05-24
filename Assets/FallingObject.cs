using UnityEngine;

public class FallingObject : MonoBehaviour
{

    float accel = 0.2f;
    float fallSpeed = 0f;
    float terminalVel = 12f;

    float destroyY = -5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fallSpeed >= terminalVel)
        {
            fallSpeed = terminalVel;

        } else
        {
            fallSpeed += accel;

        }
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

        if(transform.position.y < destroyY) {
            Destroy(gameObject);
        }
    }
}
