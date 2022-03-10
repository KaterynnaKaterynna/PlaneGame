using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float forwardSpeed = 60f, strafeSpeed = 60f, hoverSpeed = 60f; //our basic values
    private float activeForwardSpeed, activeStrafeSpeed, activeHoverSpeed; //to store the input

    public float turnSpeedSideways = 80f;
    public float turnSpeedTopBottom = 20f;



    private void FixedUpdate()
    {
        
        transform.position += transform.forward.normalized * activeForwardSpeed * Time.deltaTime;
        transform.position += transform.right.normalized * activeStrafeSpeed * Time.deltaTime;
        transform.position += transform.up.normalized * activeHoverSpeed * Time.deltaTime;

    }


    void Update()
    {

        activeForwardSpeed = Input.GetAxis("Vertical") * forwardSpeed;
        activeStrafeSpeed = Input.GetAxis("Horizontal") * strafeSpeed;
        activeHoverSpeed = Input.GetAxis("Hover") * hoverSpeed;

        if (activeStrafeSpeed < 0)
            transform.Rotate(Vector3.down, turnSpeedSideways * Time.deltaTime);
        else if (activeStrafeSpeed > 0)
            transform.Rotate(Vector3.up, turnSpeedSideways * Time.deltaTime);

        if (activeHoverSpeed > 0)
            transform.Rotate(Vector3.left, turnSpeedTopBottom * Time.deltaTime);
        else if(activeHoverSpeed < 0)
            transform.Rotate(Vector3.right, turnSpeedTopBottom * Time.deltaTime);


    }
}
