using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float rangeX = 14f;
    private float posZ = 30f;
    private float startDelay = 2;
    private float spawnInterval = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        Vector3 pos = new Vector3(Random.Range(-rangeX, rangeX), 0, posZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], pos, animalPrefabs[animalIndex].transform.rotation);
    }
}
