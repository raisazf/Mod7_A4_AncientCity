using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 5f;

    public Rigidbody rb; // the player's rigidbody

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(direction * speed * Time.deltaTime);

        Vector3 localDirection = transform.TransformDirection(direction); // make world direction into local direction
        rb.MovePosition(rb.position +  (localDirection * speed * Time.deltaTime));
    }

    public void OnPlayerMove(InputValue value) 
    { 
    
        Vector2 inputVector = value.Get<Vector2>();

        // move in XZ plane
        direction.x = inputVector.x;
        direction.z = inputVector.y;



    }
}
