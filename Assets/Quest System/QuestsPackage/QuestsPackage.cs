using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quests/Packages/Create Quests Package")]
public class QuestsPackage : ScriptableObject
{
    [SerializeField] private List<QuestTasksPackage> _questsPackageList;

    private List<QuestTasksPackage> _validQuestsPackageList;
    public List<QuestTasksPackage> QuestsPackageList {  get { return _questsPackageList; } }

    public List<QuestTasksPackage> ValidQuestsPackageList { get => _validQuestsPackageList; set => _validQuestsPackageList = value; }

    public List<QuestTasksPackage> GetValidTasksPackage()
    {
        List<QuestTasksPackage> validTasksPackage= new List<QuestTasksPackage>();
        foreach (QuestTasksPackage taskpackage in QuestsPackageList)
        {
            if (taskpackage.DontIncludeQuest == false)
            validTasksPackage.Add(taskpackage);
        }

        _validQuestsPackageList= validTasksPackage;
        return validTasksPackage;


    }
    private void OnEnable()
    {
        GetValidTasksPackage();
    }

    public void PlayQuestOnDemandThenResume(int questIndex,int QuestNumber)
    {

        _validQuestsPackageList.Insert(questIndex, _questsPackageList[QuestNumber]);
    }
    



}
