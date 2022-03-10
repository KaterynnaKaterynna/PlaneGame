using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turel : MonoBehaviour
{
    [SerializeField] private PlayerController _player;


    void Start()
    {
        _player = FindObjectOfType<PlayerController>();
    }

   
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(_player.transform.position - transform.position);
    }
}
