using Lean.Pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private int swordDamage=30;

    public int SwordDamage { get => swordDamage; set => swordDamage = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            other.gameObject.GetComponent<AIMovingDamageDealerEnemy>().GetDamaged(swordDamage);
            Debug.Log("PLAYER IS ATTACKING");
            
            //LeanPool.Despawn(this);
            //objectPool.Release(this);
            //Destroy(this.gameObject);
        }
    }
}
