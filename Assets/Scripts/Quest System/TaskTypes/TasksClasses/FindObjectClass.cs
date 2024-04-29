using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObjectClass : QuestTaskClasses
{
    private string _taskText;
    private string _objectTag;
    private bool _isCompleted;
    private bool _isEndingQuest;

    public FindObjectClass(FindObjectTask task)
    {
        this._taskText = task.TaskText;
        this._objectTag = task.ObjectRelatedTag;
        this._isCompleted = task.IsCompleted;
        _isEndingQuest = task.IsEndingQuest;
    }
    public override string TaskText { get { return _taskText; } }

    public override bool IsCompleted { get => _isCompleted; set => _isCompleted = value; }
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
        return _taskText;
    }
}
