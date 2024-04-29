
using UnityEngine;

public interface IState : ILimitMovement {
    //public AIEnemy AIManager { get; set; }
    public string StateName {  get; set; }
    public bool IsStateActive {  get; set; }
}
