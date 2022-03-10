using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowStars : MonoBehaviour
{
    public GameObject snowPrefab;
    private GameObject _newSnow;
    public Rigidbody rb;
    public float snowFallSpeed = 45f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        _newSnow = Instantiate(snowPrefab, transform.position, transform.rotation);
        rb.AddForce(0f, 0f, snowFallSpeed * Time.deltaTime);

    }
    private void Update()
    {
        Destroy(_newSnow, 5f);
    }
  
}
