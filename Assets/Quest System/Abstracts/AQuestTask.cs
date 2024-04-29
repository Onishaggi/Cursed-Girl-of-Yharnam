using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AQuestTask : ScriptableObject
{
    public abstract string TaskText {  get; }
    public abstract string ObjectRelatedTag { get; set; }
    public abstract bool IsCompleted { get; set; }

    //we dont need the rest ignore we dont use functoins here we use those function at there corrosponding classes
    public abstract bool IsEndingQuest { get; set; }

    public abstract void UpdateCondition();
    public abstract void InitiateTask();

    public abstract string UpdateTaskText();

}
