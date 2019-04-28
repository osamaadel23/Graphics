using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilesPrefabs;
    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLength = 7.62f;
    private int amountOfTilesOnScreen = 7;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z > spawnZ - amountOfTilesOnScreen * tileLength){
            SpawnTile();
        }
    }

    void SpawnTile(int index = -1){
        GameObject tile;
        tile = Instantiate(tilesPrefabs[0]) as GameObject;
        tile.transform.SetParent(transform);
        tile.transform.position = Vector3.forward * (spawnZ + tileLength);
        spawnZ += tileLength;
    }
}
