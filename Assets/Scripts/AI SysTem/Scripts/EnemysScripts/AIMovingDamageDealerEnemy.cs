using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using Lean;
using Lean.Pool;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent (typeof(WeaponBase))]
public class AIMovingDamageDealerEnemy : MonoBehaviour, IAIMovingAggressorEnemy,IHealthStat
{
    [SerializeField] AIUtilityAggressorEnemyPresets _aiEnemyPresets;

    private AIUtilityAggressorEnemyPresets _myPresets;

    private GameObject _targetGO;

    private HybridStatesPackageManager _statesPackageManager;

    private AIHybridAnimatorManager _hybridAnimatorManager;

    private Rigidbody _currentRB;

    private Animator _animator;

    private WeaponBase _weapon;
    public Rigidbody EnemyRB { get { return _currentRB; } set { _currentRB = value; } }
    public WeaponBase Weapon { get { return _weapon; } set { } }
    public HybridStatesPackageManager StatesPackageManager { get { return _statesPackageManager; } set { _statesPackageManager = value; } }
    public AIHybridAnimatorManager AIHybridAnimatorManager { get { return _hybridAnimatorManager; } set { _hybridAnimatorManager = value; } }   
    public TargetInformation TargetInfo { get { return _myPresets.TargetInfo; } }
    public GameObject TargetGO { get { return _targetGO; } set { _targetGO = value; } }
    public AIUtilityAggressorEnemyPresets AIEnemyPresets { get { return _myPresets; } }
    public float MovementSpeed { get { return _myPresets.MovementStats.MovementSpeed; } set { } }
    public float RotationSpeed { get { return _myPresets.MovementStats.RotationSpeed; } set {} }


    //IHealthStats
    [SerializeField] HealthInfo _healthInfo;
    private UniEvent gotDamagedEvent = new UniEvent();
    public Notifier HealthNotifier { get { return _healthInfo.HealthNotifier; } }

    private float _health;
    private float _maxHealth;
    public float Health { get { return _health; } set { _health = value; } }
    public float MaxHealth { get { return _maxHealth; } set { _maxHealth = value; } }

    public UniEvent GotDamagedEvent { get => gotDamagedEvent; set => gotDamagedEvent = value; }

    private void OnEnable()
    {
        _health = _healthInfo.Health;
        _maxHealth = _healthInfo.MaxHealth;
        GotDamagedEvent.Notify();

    }

    //public StatesPackageManager StatesPackageManager { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }



    //public int DamageValue { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    private void Awake()
    {
        _myPresets = _aiEnemyPresets;
        _weapon = GetComponent<WeaponBase>();
        _currentRB = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        if (_myPresets.statesPackage == null)
        {
            Debug.LogError("AI Enemy Presets is not assigned.");
        }
        _statesPackageManager = new HybridStatesPackageManager(AIEnemyPresets.statesPackage);
        _hybridAnimatorManager = new AIHybridAnimatorManager(_animator, _statesPackageManager);
    }
    void Start()
    {
        _health = _healthInfo.Health;
        _maxHealth = _healthInfo.MaxHealth;
        _targetGO = GameObject.FindWithTag(TargetInfo.Tag);

       // _statesPackageManager = new HybridStatesPackageManager(AIEnemyPresets.statesPackage);
    }


    void Update()
    {
        if (_statesPackageManager==null)
        {
            Debug.Log("nukk");
        }
        if (_targetGO != null)
        {
            _statesPackageManager.GetCurrentState(this.transform, _targetGO.transform).Behaviour(this, transform);
        }
        else
        {
            Transform defaultTransform=null;
            //defaultTransform.position = Vector3.zero;
            //defaultTransform.rotation = Quaternion.identity;
            //defaultTransform.localScale = Vector3.one;
            _statesPackageManager.GetCurrentState(this.transform, defaultTransform).Behaviour(this,transform);
        }
    }

    //bad code
    bool died = false;
    public void GetDamaged(int _damageValue)
    {
        Health -= _damageValue;
        
        //HealthNotifier.Notify();
        GotDamagedEvent.Notify();
        if(Health <= 0) {

            if (died == false)
            {
                Debug.Log("GHOSTidied");
                //audioManager.PlayerSFX(audioManager.destruction);
                _animator.SetTrigger("Die");
                //turretController.enabled = false;
                died = true;
                Invoke("DestroyObject", _animator.GetCurrentAnimatorStateInfo(0).length);
            }

        }
    }
    void DestroyObject()
    {

        foreach (var task in ServiceLocator.Instance.GetService<QuestBase>().CurrentTasksClasses)//todo
        {
            if (this.gameObject.tag == task.ObjectRelatedTag)
            {
                task.UpdateCondition();
                //LeanPool.Despawn(this);
            }
        }
        _health = _healthInfo.Health;
        _maxHealth = _healthInfo.MaxHealth;
        died = false;
        LeanPool.Despawn(this.gameObject);
    }
}
