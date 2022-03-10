using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBomber : MonoBehaviour
{
    [SerializeField] private PlayerController _player;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private float _speedRotate = 0.5f;
    
     


    void Start()
    {
        _player = FindObjectOfType<PlayerController>();
        
    }

   
    private void Update()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) < 50)
        {
            Fire();
        }

    }
    private void FixedUpdate()
    {
        var direction = _player.transform.position - transform.position;  //found vector btw two obj
        var stepRotate = Vector3.RotateTowards(transform.forward, direction, _speedRotate * Time.fixedDeltaTime, 0f);

        transform.rotation = Quaternion.LookRotation(stepRotate);
    }


    private void Fire()
    {
        


        var bulletObj = Instantiate(_bulletPrefab, _spawnPosition.position, _spawnPosition.rotation);
        var bullet = bulletObj.GetComponent<Bomb>();
        bullet.Init(_player.transform, 2f, 0.5f);
    }
}
