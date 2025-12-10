using UnityEngine;

public class Salvation : MonoBehaviour
{
    public float movementX = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 9)
        {
            movementX *= -1;
        }
        if (transform.position.x < -9)
        {
            movementX *= -1;
        }
        Vector3 movement = new Vector3(movementX, 0, 0);
        transform.position += movement;
    }
}
