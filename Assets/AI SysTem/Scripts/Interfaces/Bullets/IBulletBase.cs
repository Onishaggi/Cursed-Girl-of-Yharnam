using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBulletBase : IBullet
{
    

   public Rigidbody BulletRB { get; set; }
   public Vector3 Direction { get; set; }
   public Collider BulletCollider { get; set; }
}
