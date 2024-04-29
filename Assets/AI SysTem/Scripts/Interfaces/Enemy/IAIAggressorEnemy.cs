
public interface IAIAggressorEnemy : IAIEnemy
{
    public IWeapon Weapon { get; set; }
    public AggressorStatesPackageManager StatesPackageManager { get; set; }
}
