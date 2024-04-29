

using UnityEngine;

public interface IWeapon
{
    public GameObject BulletGO { get; set; }
    public float FireRate { get; set;}

    //public bool CollectionCheck {  get; set; }
    //public int DefaultCapacity {  get; set; }
    //public int MaxSize { get; set; }

}
