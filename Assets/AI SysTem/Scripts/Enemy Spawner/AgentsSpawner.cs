using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean;
using Lean.Pool;

public class AgentsSpawner : MonoBehaviour ,ISpawnerInfo
{
    [SerializeField] SpawnerInfo _spawnerInfo;
    private float _spawnRate = 5;
    private GameObject _objectToSpawn;
    private int _numberOfSpawnedObjects;
    private int _spawnCount;
    public float SpawnRate { get { return _spawnRate; } set { _spawnRate = value; } }
    public GameObject SpawnedObject { get { return _objectToSpawn; } set { _objectToSpawn = value; } }

    public int NumberOfSpawnedObjects { get { return _numberOfSpawnedObjects; } set { _numberOfSpawnedObjects = value; } }

    // Start is called before the first frame update
    void Start()
    {
        _spawnRate = _spawnerInfo.SpawnRate;
        _objectToSpawn= _spawnerInfo.SpawnedObject;
        _numberOfSpawnedObjects = _spawnerInfo.NumberOfSpawnedObjects;
        StartCoroutine(Spawn());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn() {

        while (_spawnCount < NumberOfSpawnedObjects)
        {
            yield return new WaitForSeconds(SpawnRate);
            LeanPool.Spawn(SpawnedObject, transform.position, Quaternion.identity, this.transform);
            _spawnCount++;
        }

    }
}
