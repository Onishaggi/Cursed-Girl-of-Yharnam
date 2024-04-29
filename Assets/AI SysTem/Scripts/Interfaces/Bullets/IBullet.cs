

using UnityEngine;

public interface IBullet:IDamageDealer
{
    public float BulletSpeed {  get; set; }
    public string DamadgedLayer { get; set;}
    //public GameObject BulletGO {  get; set; }  
}
