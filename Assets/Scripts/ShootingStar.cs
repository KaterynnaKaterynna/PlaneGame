using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    public Rigidbody rb;
    public float starFallSpeed = 45f;

    
    void FixedUpdate()
    {
       
        rb.AddForce(0f, -starFallSpeed * Time.deltaTime, 0f);
        
    }
}
