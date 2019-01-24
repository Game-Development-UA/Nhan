using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    //void Start()
    //{
    //    rb.useGravity = false;
    //}
    public float ForwardForce = 2000f;
    public float SlideForce =500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        // force to go forward
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if ( Input.GetKey("d"))
        {
            rb.AddForce(SlideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SlideForce * Time.deltaTime, 0, 0);
        }
    }
}
