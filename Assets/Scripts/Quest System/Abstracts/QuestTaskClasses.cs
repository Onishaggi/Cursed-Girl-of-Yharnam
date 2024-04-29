using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class QuestTaskClasses
{
    public abstract string TaskText { get; }
    public abstract string ObjectRelatedTag { get; set; }
    public abstract bool IsCompleted { get; set; }

    //Here we need the rest except IsEndingQuest we dont need
    public abstract bool IsEndingQuest {  get; set; }
    public abstract void UpdateCondition();
    public abstract void InitiateTask();
    public abstract string UpdateTaskText();
}
