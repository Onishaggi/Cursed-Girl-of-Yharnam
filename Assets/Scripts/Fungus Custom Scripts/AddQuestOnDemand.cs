using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CommandInfo("Custom", "OnDemand Quests", "enable quests on demand and then resume the stalled quests")]
[AddComponentMenu("")]
public class AddQuestOnDemand : Command
{
    [SerializeField] private int _requestedQuestId=5;
    private Flowchart _flowChart;
    private GameObject _currentInteractableGO;
    private QuestBase _currentQuestBase;
    // Start is called before the first frame update
    void Start()
    {
        _currentQuestBase = ServiceLocator.Instance.GetService<QuestBase>();
        _flowChart = ServiceLocator.Instance.GetService<GameManager>().Flowchart;


    }
    public override void OnEnter()
    {
        base.OnEnter();
        _currentInteractableGO = _flowChart.GetGameObjectVariable("ActiveInteractableObject");
        //foreach (var task in _currentQuestBase.CurrentTasksClasses)//todo
        //{
        //    if (_currentInteractableGO.tag == task.ObjectRelatedTag)
        //    {
        //        task.UpdateCondition();
        //    }
        //}
        _currentQuestBase.QuestsPackage.PlayQuestOnDemandThenResume(_currentQuestBase.CurrentQuestTasksPackageIndex, _requestedQuestId);

        Continue();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
