using UnityEngine;
using UnityEngine.InputSystem;

public class Car : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float upspeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, upspeed);
        }
    }
}
