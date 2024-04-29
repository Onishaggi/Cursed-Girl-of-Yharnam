using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quests/Tasks/Eliminate Enemies Task")]
public class EliminateEnemiesTask : AQuestTask
{
    [SerializeField] private string _taskText;
    [SerializeField] private string _enemiesTag;
    [SerializeField] private int _targetCount;
    //we dont needd is ending quest
    [SerializeField] private bool _isEndingQuest;
    private int _currentCount;
    private bool _isCompleted;


    
    public int Count { get { return _targetCount; } set { _targetCount = value; } }
    public override string TaskText { get { return _taskText; } }
    public int CurrentCount { get { return _currentCount; } set { _currentCount = value; } }

    public override bool IsCompleted { get => _isCompleted; set => _isCompleted=value; }

    public override string ObjectRelatedTag { get { return _enemiesTag; } set { _enemiesTag = value; } }

    public override bool IsEndingQuest { get => _isEndingQuest; set => _isEndingQuest=value; }

    public override void InitiateTask()
    {
        
        //todo
        UpdateTaskText();
    }

    public override void UpdateCondition()
    {
        
        if (_isCompleted==false) {

            _currentCount++;

            UpdateTaskText();
        }
        
        if (_currentCount == _targetCount)
        {

            _isCompleted = true;
            ServiceLocator.Instance.GetService<QuestBase>().UpdateQuestsStatusEvent?.Invoke();
        }
        if(IsCompleted)
        {
            _taskText += " Completed";
        }
        ServiceLocator.Instance.GetService<QuestBase>().GetQuestTasksDescription();
    }

    public override string UpdateTaskText()
    {
        _taskText = "\n" + _taskText + $" {_currentCount}/{_targetCount}";
        return _taskText;

    }
}
