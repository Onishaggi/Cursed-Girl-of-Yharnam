using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean;
using Lean.Pool;

public class WeaponBase : MonoBehaviour,IWeapon
{
    [SerializeField] private WeaponInfo _weaponInfo;
    private GameObject _bulletGO;
    private float _fireRate;
    private bool _collectionCheck;
    private int _defualtCapacity = 20;
    private int _maxSize = 100;
    private float _lastAttackTime;
    public GameObject BulletGO { get { return _bulletGO; } set { _bulletGO = value; } }
    public float FireRate { get { return _fireRate; } set { _fireRate = value; } }

    public bool CollectionCheck { get { return _collectionCheck; } set { _collectionCheck = value; } }
    public int DefaultCapacity { get { return _defualtCapacity; } set { _defualtCapacity = value; } }
    public int MaxSize { get { return _maxSize; } set { _maxSize = value; } }

    private void Awake()
    {
        _bulletGO = _weaponInfo.BulletGO;
        _fireRate = _weaponInfo.FireRate;
        //_maxSize = _weaponInfo.MaxSize;
        //_collectionCheck = _weaponInfo.CollectionCheck;
        //_defualtCapacity= _weaponInfo.DefaultCapacity;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void TriggerFire(Vector3 _weaponPosOffset)
    {
        if (Time.time - _lastAttackTime >= FireRate)
        {
            //GameObject currentbullet= Instantiate(BulletGO,transform.position,Quaternion.identity);
            GameObject currentbullet = LeanPool.Spawn(BulletGO, transform.position + _weaponPosOffset, Quaternion.identity);
            BulletBase bulletBase = currentbullet.GetComponent<BulletBase>();

            Vector3 dir = transform.forward;
            bulletBase.Direction = dir;

            _lastAttackTime = Time.time;
        }

    }
}
