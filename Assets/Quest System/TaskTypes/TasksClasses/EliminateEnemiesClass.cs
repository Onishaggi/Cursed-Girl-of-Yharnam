using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminateEnemiesClass :QuestTaskClasses
{
    private string _taskText;
    private string _enemiesTag;
    private int _targetCount;
    private int _currentCount;
    private bool _isCompleted;

    private bool _isEndingQuest;
    //todo bad code
    private string _defaulttaskText;

    public EliminateEnemiesClass(EliminateEnemiesTask task)
    {
        _taskText = task.TaskText;
        _defaulttaskText = task.TaskText;
        this._enemiesTag = task.ObjectRelatedTag;
        this._targetCount=task.Count; this._currentCount=task.Count;
        this._isCompleted=task.IsCompleted;
        this._currentCount = task.CurrentCount;
        this._isEndingQuest=task.IsEndingQuest;

    }

    public int Count { get { return _targetCount; } set { _targetCount = value; } }
    public override string TaskText { get { return _taskText; } }
    public int CurrentCount { get { return _currentCount; } set { _currentCount = value; } }

    public override bool IsCompleted { get => _isCompleted; set => _isCompleted = value; }

    public override string ObjectRelatedTag { get { return _enemiesTag; } set { _enemiesTag = value; } }

    public override bool IsEndingQuest { get => _isEndingQuest; set => _isEndingQuest = value; }

    public override void InitiateTask()
    {
        //todo
        UpdateTaskText();
    }

    public override void UpdateCondition()
    {
        if (!IsCompleted)
        {

            if (_isCompleted == false)
            {

                _currentCount++;

                UpdateTaskText();
            }

            if (_currentCount == _targetCount)
            {

                _isCompleted = true;
                ServiceLocator.Instance.GetService<QuestBase>().UpdateQuestsStatusEvent?.Invoke();
            }
            if (IsCompleted)
            {
                _taskText += " Completed";
            }
            ServiceLocator.Instance.GetService<QuestBase>().GetQuestTasksDescription();
            ServiceLocator.Instance.GetService<QuestBase>().UpdateQuestStatus();
        }
    }

    public override string UpdateTaskText()
    {
        _taskText = "";
        _taskText = "\n" + _defaulttaskText + $" {_currentCount}/{_targetCount}";
        return _taskText;

    }
}
