using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="GameUtility/Spawners/SpawnerInfo")]
public class SpawnerInfo : ScriptableObject,ISpawnerInfo
{
    [SerializeField] private float _spawnRate = 5;
    [SerializeField] private GameObject _objectToSpawn;
    [SerializeField] private int _numberOfSpawnedObjects;
    public float SpawnRate { get { return _spawnRate; } set { _spawnRate = value; } }
    public GameObject SpawnedObject { get { return _objectToSpawn; } set { _objectToSpawn = value; } }

    public int NumberOfSpawnedObjects { get { return _numberOfSpawnedObjects; } set { _numberOfSpawnedObjects = value; } }
}
