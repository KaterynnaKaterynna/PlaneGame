using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointCloud : MonoBehaviour
{
    public GameObject starPrefab;
    private GameObject _newStar;
    public Transform spawnPoint;
    

    void Start()
    {
        _newStar = Instantiate(starPrefab, spawnPoint.position, Quaternion.identity);
        Destroy(_newStar, 6f);
        
    }

   
}
