using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Gear/Bullets/BulletInfo")]
public class BulletInfo : ScriptableObject,IBullet
{
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private int _damageValue;
    [SerializeField] private string _damagedLayer;

    public float BulletSpeed { get { return _bulletSpeed; } set { _bulletSpeed = value; } }
    //public abstract GameObject BulletGO { get ; set; }
    public int DamageValue { get { return _damageValue; } set { _damageValue = value; } }

    public string DamadgedLayer { get { return _damagedLayer; } set { _damagedLayer = value; } }
}
