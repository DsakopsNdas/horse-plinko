using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject horse;
    public float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 offset = new Vector3(movementX, 0, 0);
        transform.position += offset;

        Vector3 horseOffset = new Vector3 (0, +1, 0);
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(horse, transform.position - horseOffset, transform.rotation);
        }
    }
}
