
using UnityEngine;

public interface IAIMovingAggressorEnemy:IAIEnemy,IMovementStats
{

    public Rigidbody EnemyRB { get; set; }
    public WeaponBase Weapon { get; set; }

    public AIUtilityAggressorEnemyPresets AIEnemyPresets {  get; }
    public HybridStatesPackageManager StatesPackageManager { get; set; }

}
