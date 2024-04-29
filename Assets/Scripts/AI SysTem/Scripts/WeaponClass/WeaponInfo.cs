using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Gear/Weapons/WeaponInfo")]
public class WeaponInfo :ScriptableObject ,IWeapon
{
    [SerializeField] GameObject _bullet;
    [SerializeField] float _fireRate;
    //[Header("------Mag Settings------")]
    //[SerializeField] private bool _collectionCheck;
    //[SerializeField] private int _defualtCapacity = 20;
    //[SerializeField] private int _maxSize = 100;

    public GameObject BulletGO { get { return _bullet; } set { _bullet = value; } }
    public float FireRate { get { return _fireRate; } set { _fireRate = value; } }

    //public bool CollectionCheck { get { return _collectionCheck; } set { _collectionCheck = value; } }
    //public int DefaultCapacity { get { return _defualtCapacity; } set { _defualtCapacity = value; } }
    //public int MaxSize { get { return _maxSize; } set { _maxSize = value; } }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
