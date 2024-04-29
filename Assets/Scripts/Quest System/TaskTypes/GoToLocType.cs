using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Quests/Tasks/GoToLoc Task")]
public class GoToLocType : AQuestTask
{
    [SerializeField] private string _taskText;
    [SerializeField] private Vector3 _destination;
    [SerializeField] private GameObject _destinationTriggerObject;
    [SerializeField] private string _destinationTriggerObjectTag;
    //we dont need _isEnding
    [SerializeField] private bool _isEndingQuest;
    private bool _isCompleted;
    public GameObject DestinationTriggerObject {  get { return _destinationTriggerObject; } }
    public Vector3 Destination { get {  return _destination; } }
    public override string TaskText {  get { return _taskText; } }
    public override bool IsCompleted { get => _isCompleted; set => _isCompleted=value; }
    public override string ObjectRelatedTag { get => _destinationTriggerObjectTag; set => _destinationTriggerObjectTag = value; }

    public override bool IsEndingQuest { get => _isEndingQuest; set => _isEndingQuest = value; }

    //ignore the rest we inject it to AQuest Task
    public override void InitiateTask()
    {
        UpdateTaskText();
    }

    public override void UpdateCondition()
    {
        _isCompleted=true;
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
}
