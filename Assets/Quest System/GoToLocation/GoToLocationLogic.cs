using Fungus;
using Lean.Pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class GoToLocationLogic : MonoBehaviour
{
    private Flowchart _flowChart;
    // Start is called before the first frame update
    void Start()
    {
        _flowChart = ServiceLocator.Instance.GetService<GameManager>().Flowchart;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IObjectPool<BulletBase> objectPool;

    public IObjectPool<BulletBase> ObjectPool { get { return objectPool; } set { objectPool = value; } }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer==LayerMask.NameToLayer("Player"))
        foreach (var task in ServiceLocator.Instance.GetService<QuestBase>().CurrentTasksClasses)//todo
        {
            if (this.gameObject.tag == task.ObjectRelatedTag)
            {
                task.UpdateCondition();
                LeanPool.Despawn(this);
            }
        }
    }
}
