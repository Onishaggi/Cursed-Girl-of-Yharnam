using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using Lean;
using Lean.Pool;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent (typeof(Collider))]
public class BulletBase : MonoBehaviour , IBulletBase
{
    [SerializeField] BulletInfo _bulletInfo;
    private float _bulletSpeed;
    //private GameObject _bulletGO;
    private int _damageValue;
    private Rigidbody _bulletRB;
    private Vector3 _direction;
    private Collider _bulletCollider;
    private string _damagedLayer;

    public float BulletSpeed { get { return _bulletSpeed; } set { _bulletSpeed = value; } }
   // public GameObject BulletGO { get { return _bulletGO; } set { _bulletGO=value; } }


    public int DamageValue { get { return _damageValue; } set { _damageValue = value; } }

    public Rigidbody BulletRB { get { return _bulletRB; } set { _bulletRB = value; } }

    public Vector3 Direction { get { return _direction; } set { _direction = value; } }

    public Collider BulletCollider {  get { return _bulletCollider; } set { } }

    public string DamadgedLayer { get { return _damagedLayer; } set { _damagedLayer = value; } }

    private void Awake()
    {

        _bulletSpeed = _bulletInfo.BulletSpeed;
        //_bulletGO = _bulletInfo.BulletGO;
        _damageValue = _bulletInfo.DamageValue;

        _damagedLayer = _bulletInfo.DamadgedLayer;
    }
    private void OnEnable()
    {
        StartCoroutine(DestroyOnCountdown());
    }
    private void Start()
    {

        _bulletRB = GetComponent<Rigidbody>();

        _bulletCollider = GetComponent<Collider>();
        _bulletCollider.isTrigger = true;

        //StartCoroutine(DestroyOnCountdown());
    }

    private void Update()
    {
        FuseBullet(_direction);
    }
    public void FuseBullet(Vector3 _direction) { 
    
        _bulletRB.velocity = _direction*BulletSpeed;
    
    }

    private IObjectPool<BulletBase> objectPool;

    public IObjectPool<BulletBase> ObjectPool { get {  return objectPool; } set { objectPool = value; } }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer==LayerMask.NameToLayer(DamadgedLayer))
        {
            other.gameObject.GetComponent<PlayerBase>().GetDamaged(_damageValue);
            Debug.Log("GetDamaged");
            BulletRB.velocity = Vector3.zero;
            BulletRB.angularVelocity = Vector3.zero;
            LeanPool.Despawn(this);
            //objectPool.Release(this);
            //Destroy(this.gameObject);
        }
        //Debug.Log("GetDamaged");
    }

    IEnumerator DestroyOnCountdown()
    {
        yield return new WaitForSeconds(2);

        BulletRB.velocity = Vector3.zero;
        BulletRB.angularVelocity = Vector3.zero;
        Debug.Log("DespawnPLz");
        LeanPool.Despawn(this);
        //Destroy(this.gameObject);
    }
}
