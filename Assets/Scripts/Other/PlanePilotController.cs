using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePilotController : MonoBehaviour
{
    public Vector3 cam;
    public GameObject _camera;

    void Update()
    {
        cam = transform.position - transform.forward * 25f + transform.up * 10f;
        _camera.transform.position = cam;

        transform.position += transform.forward * Time.deltaTime * 200f;
        transform.Rotate(Input.GetAxis("Vertical"), 0f, Input.GetAxis("Horizontal"));



    }
}
