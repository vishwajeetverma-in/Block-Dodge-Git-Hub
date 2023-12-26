using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public Transform spawnPoint;
    public float maxX;
    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnBlock()
    {
        Vector2 spawnPos = spawnPoint.position; 
        spawnPos.x = Random.Range(-maxX, maxX);
        Instantiate(block , spawnPos, Quaternion.identity);
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
    }
}
