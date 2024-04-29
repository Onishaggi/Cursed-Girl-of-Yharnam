using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CommandInfo("Custom", "Current Quest Related", "Check and Execute if Current Quest Related")]
[AddComponentMenu("")]
public class UpdateTask : Command
{
    private Flowchart _flowChart;
    private GameObject _currentInteractableGO;
    // Start is called before the first frame update
    void Start()
    {
        _flowChart = ServiceLocator.Instance.GetService<GameManager>().Flowchart;

    
    }
    public override void OnEnter()
    {
        base.OnEnter();
       _currentInteractableGO= _flowChart.GetGameObjectVariable("ActiveInteractableObject");
       foreach(var task in ServiceLocator.Instance.GetService<QuestBase>().CurrentTasksClasses)//todo
       {
            if (_currentInteractableGO.tag == task.ObjectRelatedTag)
            {
                task.UpdateCondition();
            }
       }

        Continue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
