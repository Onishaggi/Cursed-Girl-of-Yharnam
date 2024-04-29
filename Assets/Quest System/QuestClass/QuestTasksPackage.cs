using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quests/Packages/Create Quest Tasks Package")]
public class QuestTasksPackage : ScriptableObject
{
    private void OnEnable()
    {
        
    }
    [Header("-----------Go To Location Types----------")]
    [SerializeField] private List<GoToLocType> _goToLocTypes;
    [Header("-----------Talk TO NPC Types----------")]
    [SerializeField] private List<TalkToNPCTask> _talkToNPCTasks;
    [Header("-----------Find Object Types----------")]
    [SerializeField] private List<FindObjectTask> _findObjectTasks;
    [Header("-----------Eliminate Enemies Types----------")]
    [SerializeField] private List<EliminateEnemiesTask> _eleminateEnemiesTasks;

    [SerializeField] private bool _dontIncludeQuest = false;

    private List<QuestTaskClasses> totalTasksClasses;
    public List<GoToLocType> GoToLocTypes { get => _goToLocTypes; set => _goToLocTypes = value; }
    public List<TalkToNPCTask> TalkToNPCTasks { get => _talkToNPCTasks; set => _talkToNPCTasks = value; }
    public List<FindObjectTask> FindObjectTasks { get => _findObjectTasks; set => _findObjectTasks = value; }
    public List<EliminateEnemiesTask> EleminateEnemiesTasks { get => _eleminateEnemiesTasks; set => _eleminateEnemiesTasks = value; }
    public List<QuestTaskClasses> TotalTasksClasses { get => totalTasksClasses; set => totalTasksClasses = value; }
    public bool DontIncludeQuest { get => _dontIncludeQuest; set => _dontIncludeQuest = value; }

    public List<AQuestTask> GetTotalTasks()//we dont use this
    {
        List<AQuestTask> _totalTasks = new List<AQuestTask>();

        foreach(var  task in _talkToNPCTasks)
        {
            var temptask = task;
            _totalTasks.Add(temptask);
        }
        foreach(var task in EleminateEnemiesTasks)
        {
            var temptask = task;
            _totalTasks.Add(temptask);
        }
        foreach(var task in GoToLocTypes)
        {
            var temptask = task;
            _totalTasks.Add(temptask);
        }
        foreach(var task in FindObjectTasks)
        {
            var temptask = task;
            _totalTasks.Add(temptask);
        }
        

        return _totalTasks;
    }
    public List<QuestTaskClasses> GetTotalTasksClasses()
    {
        List<QuestTaskClasses> _totalTasks = new List<QuestTaskClasses>();

        foreach (var task in _talkToNPCTasks)
        {
            TalkToNPCClass temp = new TalkToNPCClass(task);
            _totalTasks.Add(temp);
        }
        foreach (var task in EleminateEnemiesTasks)
        {
            EliminateEnemiesClass temp = new EliminateEnemiesClass(task);
            _totalTasks.Add(temp);
        }
        foreach (var task in GoToLocTypes)
        {
            GoToLocClass temp = new GoToLocClass(task);
            _totalTasks.Add(temp);
        }
        foreach (var task in FindObjectTasks)
        {
            FindObjectClass temp = new FindObjectClass(task);
            _totalTasks.Add(temp);
        }

        totalTasksClasses = _totalTasks;
        return _totalTasks;
    }

    public bool CheckQuestTasksCondition()// we dont use this too
    {
        List<AQuestTask> totalTasks= GetTotalTasks();
        bool allCompleted=false;
        foreach(var task in totalTasks)
        {
            allCompleted = task.IsCompleted;
        }

        return allCompleted;
    }
    public bool CheckQuestTasksClassesCondition()
    {
        
        bool allCompleted = false;
        foreach (var task in totalTasksClasses)
        {
            if (!task.IsCompleted)
            {
                return false;
            }
            allCompleted = task.IsCompleted;
        }

        return allCompleted;
    }


}
