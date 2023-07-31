using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpwaner : MonoBehaviour
{

    public GameObject bread;
    public bool cubeIsSpawned = false;

    void Update()
    {
        if (!cubeIsSpawned)
        {
            cubeIsSpawned = true;
            Vector3 randomSpawnPositon = new Vector3(Random.Range(-10, 11), 0.1f, Random.Range(-10, 11));
            Instantiate(bread, randomSpawnPositon, Quaternion.identity);
        }

    }
}
