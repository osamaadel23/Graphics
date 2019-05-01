using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shagr : MonoBehaviour
{
    public GameObject[] tilesPrefabs;
    private Transform outer;
    private float spawnZ = 0.0f;
    private float tileLength = 2f;
    private int amountOfTilesOnScreen = 7;



    // Start is called before the first frame update
    void Start()
    {
        outer = GameObject.FindGameObjectWithTag("shagr").transform;
        SpawnTile(1);
    }

    // Update is called once per frame
    
    void Update()
    {
        
        if(outer.position.z > spawnZ - amountOfTilesOnScreen * tileLength){

            int index = Random.Range(0, tilesPrefabs.Length);
            SpawnTile(index);
        }

    }

    void SpawnTile(int index){


        GameObject tile;
        tile = Instantiate(tilesPrefabs[index]) as GameObject;
        tile.transform.SetParent(transform);
        tile.transform.position = Vector3.forward * (spawnZ + tileLength);
        spawnZ += tileLength;
    }
}
