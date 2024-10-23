using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    private int itemIndex;
    public float spawnRangeX = 4;
    public float spawnRangeZ = 4;
    private float startDelay = 2;
    private float spawnInterval = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomItem", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomItem()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 0);
        int itemIndex = Random.Range (0, itemPrefabs.Length);
        Instantiate(itemPrefabs[itemIndex], spawnPos, itemPrefabs[itemIndex].transform.rotation);
    }
}
