using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean;
using Lean.Pool;
using Fungus;

public class GoToLocClass : QuestTaskClasses
{
    private string _taskText;
    private Vector3 _destination;
    private GameObject _destinationTriggerObject;
    private string _destinationTriggerObjectTag;
    private bool _isCompleted;
    private bool _isEndingQuest;

    public GoToLocClass(GoToLocType task) {
    
        this._taskText = task.TaskText;
        this._destination = task.Destination;
        this._destinationTriggerObject = task.DestinationTriggerObject;
        this._destinationTriggerObjectTag = task.ObjectRelatedTag;
        this._isCompleted = task.IsCompleted;
        _isEndingQuest = task.IsEndingQuest;
    
    
    }
    public GameObject DestinationTriggerObject { get { return _destinationTriggerObject; } }
    public Vector3 Destination { get { return _destination; } }
    public override string TaskText { get { return _taskText; } }
    public override bool IsCompleted { get => _isCompleted; set => _isCompleted = value; }
    public override string ObjectRelatedTag { get => _destinationTriggerObjectTag; set => _destinationTriggerObjectTag = value; }

    public override bool IsEndingQuest { get => _isEndingQuest; set => _isEndingQuest = value; }

    public override void InitiateTask()
    {
        UpdateTaskText();
        SpawnDestinationTrigger();
    }

    public override void UpdateCondition()
    {
        _isCompleted = true;
        if (IsCompleted)
        {
            _taskText += " Completed";
        }
        else
        {
            UpdateTaskText();
        }
        ServiceLocator.Instance.GetService<QuestBase>().GetQuestTasksDescription();
        ServiceLocator.Instance.GetService<QuestBase>().UpdateQuestsStatusEvent?.Invoke();
    }

    public override string UpdateTaskText()
    {
        _taskText = "\n" + _taskText;
        return _taskText;
    }
    public void SpawnDestinationTrigger()
    {
        LeanPool.Spawn(DestinationTriggerObject, Destination, Quaternion.identity);
    }
}
