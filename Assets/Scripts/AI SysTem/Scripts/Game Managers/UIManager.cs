using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{
    private GameObject _playerGO;
    private UnityAction _updateQuestUIEvent;

    public GameObject PlayerGO { get { return _playerGO; } }

    public UnityAction UpdateQuestUIEvent { get => _updateQuestUIEvent; set => _updateQuestUIEvent = value; }

    private void Awake()
    {
        _playerGO = GameObject.FindWithTag("Player");
        ServiceLocator.Instance.RegisterService(this);
    }

    private void Start()
    {
        if(PlayerGO == null)
        {
            Debug.Log("Cant find player");
        }
    }
}
