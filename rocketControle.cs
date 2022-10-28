using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketControle : MonoBehaviour
{
    private Rigidbody rocketRb;

    private bool goingUp;
    private bool goingLeft;
    private bool goingRight;

    void Start()
    {
        rocketRb = GetComponent<Rigidbody>();
        rocketRb.maxAngularVelocity = 10;
    }

    void Update()
    {
        
        goingUp = Input.GetKey(KeyCode.Space);
        
        goingLeft = Input.GetKey(KeyCode.LeftArrow);

        goingRight = Input.GetKey(KeyCode.RightArrow);

    }

    void FixedUpdate()
    {
        if (goingUp) 
            rocketRb.velocity += transform.up * 1;

        if (goingLeft) 
            transform.Rotate(0, 0, 1);

        if (goingRight) 
            transform.Rotate(0, 0, -1);
    }
}
