using UnityEngine;

public interface IAIMovingEnemy : IMovementStats,IAIEnemy
{
 
    public Rigidbody EnemyRB {  get; set; }
    public UtilityStatesPackageManager StatesPackageManager { get; set; }
}
