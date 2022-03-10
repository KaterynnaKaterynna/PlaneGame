using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObj : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rb.AddForce(0f, 0f, 2000f );
            Destroy(gameObject, 25f);
            
}
    }
}
