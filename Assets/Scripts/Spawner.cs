using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private Terrain terrain;

    private TerrainData _terrainData;
    // Start is called before the first frame update
    void Start()
    {
        _terrainData = terrain.terrainData;
        InvokeRepeating(nameof(CreateObject), 1f, 0.1f);
    }

    private void CreateObject()
    {
        int x = (int) Random.Range(0, _terrainData.size.x);
        int z = (int) Random.Range(0, _terrainData.size.z);

        Vector3 spawnPosition = new Vector3(x, 0, z);
        spawnPosition.y = terrain.SampleHeight(spawnPosition) + 10;

        GameObject instance = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
