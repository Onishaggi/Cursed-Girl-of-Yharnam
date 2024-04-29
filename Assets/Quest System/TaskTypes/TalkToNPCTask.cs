using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quests/Tasks/TalkToNPC Task")]
public class TalkToNPCTask : AQuestTask
{
    [SerializeField] private string _taskText;
    [SerializeField] private string _npcTag;
    [SerializeField] private bool _isCompleted=false;
    [SerializeField] private bool _isEndingQuest;
    //public string NPCName {  get { return _npcName; } set {  _npcName = value; } }

    public override string TaskText { get { return _taskText; } }

    public override bool IsCompleted { get => _isCompleted; set => _isCompleted=value; }
    public override string ObjectRelatedTag { get { return _npcTag; } set { _npcTag = value; } }

    public override bool IsEndingQuest { get => _isEndingQuest; set => _isEndingQuest = value; }

    public override void InitiateTask()
    {
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
