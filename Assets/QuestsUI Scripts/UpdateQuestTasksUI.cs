using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateQuestTasksUI : MonoBehaviour
{
    TextMeshProUGUI textMeshProUGUI;
    private UIManager manager;
    // Start is called before the first frame update
    private void OnEnable()
    {
        
    }
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        manager = ServiceLocator.Instance.GetService<UIManager>();
        manager.UpdateQuestUIEvent += UpdateUIText;
        UpdateUIText();
    }
    private void OnDisable()
    {
        manager.UpdateQuestUIEvent -= UpdateUIText;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateUIText(){
    

        textMeshProUGUI.text= ServiceLocator.Instance.GetService<QuestBase>().CurrentQuestTasksDescription;

    }

}
