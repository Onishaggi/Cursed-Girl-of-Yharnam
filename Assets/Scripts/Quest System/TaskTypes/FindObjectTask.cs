using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quests/Tasks/Find Object Task")]
public class FindObjectTask : AQuestTask
{

    [SerializeField] private string _taskText;
    [SerializeField] private string _objectTag;
    //we dont need _isEnding Quest
    [SerializeField] private bool _isEndingQuest;
    private bool _isCompleted;

    public override string TaskText { get { return _taskText; } }

    public override bool IsCompleted { get => _isCompleted; set => _isCompleted=value; }
    public override string ObjectRelatedTag { get { return _objectTag; } set { _objectTag = value; } }

    public override bool IsEndingQuest { get => _isEndingQuest; set => _isEndingQuest = value; }

    public override void InitiateTask()
    {
        //todo
        UpdateTaskText();
    }

    public override void UpdateCondition()
    {
        IsCompleted = true;
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
        return  _taskText;
    }
}
