using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTasksPackageClass
{
    private List<GoToLocType> _goToLocTypes;
    
    private List<TalkToNPCTask> _talkToNPCTasks;
    
    private List<FindObjectTask> _findObjectTasks;
    
    private List<EliminateEnemiesTask> _eleminateEnemiesTasks;

    private bool _isEndingQuest = false;

    public QuestTasksPackageClass(QuestTasksPackage questTasksPackage) {

        this._goToLocTypes = questTasksPackage.GoToLocTypes;
        this._talkToNPCTasks = questTasksPackage.TalkToNPCTasks;
        this._findObjectTasks = questTasksPackage.FindObjectTasks;
        this._eleminateEnemiesTasks = questTasksPackage.EleminateEnemiesTasks;
    
    }

    private List<QuestTaskClasses> totalTasksClasses;
    public List<GoToLocType> GoToLocTypes { get => _goToLocTypes; set => _goToLocTypes = value; }
    public List<TalkToNPCTask> TalkToNPCTasks { get => _talkToNPCTasks; set => _talkToNPCTasks = value; }
    public List<FindObjectTask> FindObjectTasks { get => _findObjectTasks; set => _findObjectTasks = value; }
    public List<EliminateEnemiesTask> EleminateEnemiesTasks { get => _eleminateEnemiesTasks; set => _eleminateEnemiesTasks = value; }
    public List<QuestTaskClasses> TotalTasksClasses { get => totalTasksClasses; set => totalTasksClasses = value; }
    public bool IsEndingQuest { get => _isEndingQuest; set => _isEndingQuest = value; }

    public List<AQuestTask> GetTotalTasks()
    {
        List<AQuestTask> _totalTasks = new List<AQuestTask>();

        foreach (var task in _talkToNPCTasks)
        {
            var temptask = task;
            _totalTasks.Add(temptask);
        }
        foreach (var task in EleminateEnemiesTasks)
        {
            var temptask = task;
            _totalTasks.Add(temptask);
        }
        foreach (var task in GoToLocTypes)
        {
            var temptask = task;
            _totalTasks.Add(temptask);
        }
        foreach (var task in FindObjectTasks)
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

    public bool CheckQuestTasksCondition()
    {
        List<AQuestTask> totalTasks = GetTotalTasks();
        bool allCompleted = false;
        foreach (var task in totalTasks)
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
