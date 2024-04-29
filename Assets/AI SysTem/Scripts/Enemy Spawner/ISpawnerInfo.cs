using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawnerInfo
{
    public float SpawnRate {  get; set; }

    public int NumberOfSpawnedObjects {  get; set; }
    public GameObject SpawnedObject { get; set; }

}
