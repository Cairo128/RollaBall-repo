using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    public Vector3 spawnLocation;
    public GameObject[] spawnType;
    public int spawnIndex;
    public float yLocation;
    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = new Vector3(transform.position.x,yLocation,transform.position.z);
        StartCoroutine(SpawnRoutine());
    }
    // Update is called once per frame
    void Update()
    {
    }
    void SpawnObject()
    {
        Instantiate(spawnType[spawnIndex],spawnLocation,Quaternion.identity);
    }
    private IEnumerator SpawnRoutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnRate);
            SpawnObject();
        }
    }
}

