using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuestBase : MonoBehaviour
{
    [SerializeField] private QuestsPackage _questsPackage;

    private QuestsPackage _mQuestsPackage;

    private UnityAction _UpdateQuestsStatusEvent;
    public QuestsPackage QuestsPackage { get => _mQuestsPackage; set => _mQuestsPackage = value; }
    public UnityAction UpdateQuestsStatusEvent { get => _UpdateQuestsStatusEvent; set => _UpdateQuestsStatusEvent = value; }
    public List<AQuestTask> CurrentTasks { get => _currentTasks; set => _currentTasks = value; }
    public string CurrentQuestTasksDescription { get => _currentQuestTasksDescription; set => _currentQuestTasksDescription = value; }
    public List<QuestTaskClasses> CurrentTasksClasses { get => _currentTasksClasses; set => _currentTasksClasses = value; }
    public int CurrentQuestTasksPackageIndex { get => _currentQuestTasksPackageIndex; set => _currentQuestTasksPackageIndex = value; }

    private List<AQuestTask> _currentTasks;//we dont use this anymore
    private List<QuestTaskClasses> _currentTasksClasses;
    private QuestTasksPackage _currentQuestTasksPackage;
    private int _currentQuestTasksPackageIndex=1;
    private string _currentQuestTasksDescription;

    private void OnEnable()
    {
        UpdateQuestsStatusEvent += UpdateQuestStatus;
    }
    private void OnDisable()
    {
        UpdateQuestsStatusEvent -= UpdateQuestStatus;

    }

    private void Awake()
    {
        ServiceLocator.Instance.RegisterService(this);
        _mQuestsPackage = _questsPackage;
    }
    // Start is called before the first frame update
    void Start()
    {
        _currentQuestTasksPackage = QuestsPackage.ValidQuestsPackageList[0];
        //CurrentTasks = _currentQuestTasksPackage.GetTotalTasks();
        CurrentTasksClasses = _currentQuestTasksPackage.GetTotalTasksClasses();
        InitiateTasks();
        GetQuestTasksDescription();
        ServiceLocator.Instance.GetService<UIManager>().UpdateQuestUIEvent?.Invoke();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void InitiateTasks()
    {
        //foreach (var task in CurrentTasks)
        //{
        //    task.InitiateTask();
        //}
        foreach (var task in CurrentTasksClasses)
        {
            task.InitiateTask();
        }
    }
   
    public void UpdateQuestStatus()
    {
        
        if (_currentQuestTasksPackage.CheckQuestTasksClassesCondition()==true)
        {
            if (CurrentQuestTasksPackageIndex < _mQuestsPackage.ValidQuestsPackageList.Count)
            {
                CurrentQuestTasksDescription = "";
                _currentQuestTasksPackage = QuestsPackage.ValidQuestsPackageList[CurrentQuestTasksPackageIndex++];
                //CurrentTasks = _currentQuestTasksPackage.GetTotalTasks();
                CurrentTasksClasses = _currentQuestTasksPackage.GetTotalTasksClasses();
                InitiateTasks();
                GetQuestTasksDescription();

            }
        }

        ServiceLocator.Instance.GetService<UIManager>().UpdateQuestUIEvent?.Invoke();
    }

    public void GetQuestTasksDescription()
    {
        //foreach (var task in CurrentTasks)
        //{
        //    CurrentQuestTasksDescription += task.TaskText;
        //}
        CurrentQuestTasksDescription = "";
        foreach (var task in CurrentTasksClasses)
        {
            CurrentQuestTasksDescription += task.TaskText;
        }
    }
}
