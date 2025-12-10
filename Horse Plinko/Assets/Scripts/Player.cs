using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject horse;
    public float speed = 1;
    float movementX = 0;
    Vector3 movement = new Vector3(0, 0, 0);
    Vector3 horseOffset = new Vector3(0, +1, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        movement.x = movementX;
        transform.position += movement;

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(horse, transform.position - horseOffset, transform.rotation);
        }
    }
}
