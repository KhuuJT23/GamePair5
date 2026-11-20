using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5f;
    Vector2 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(movement * playerSpeed * Time.deltaTime);
    }
}
