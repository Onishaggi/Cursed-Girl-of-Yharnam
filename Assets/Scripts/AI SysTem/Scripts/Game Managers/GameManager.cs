using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour,IListener
{
    private GameObject _playerGO;
    private Flowchart _flowchart;
    [SerializeField] Notifier _gameEvent;
    private GameObject _player;

    private void OnEnable()
    {
        _gameEvent.AddListener(this);
    }
    private void OnDisable()
    {
        _gameEvent.RemoveListener(this);
    }
    public GameObject PlayerGO { get { return _playerGO; } }

    public Flowchart Flowchart { get => _flowchart; set => _flowchart = value; }

    private void Awake()
    {
        _playerGO = GameObject.FindWithTag("Player");
        Flowchart = GameObject.FindWithTag("Flowchart").GetComponent<Flowchart>();
        ServiceLocator.Instance.RegisterService(this);
    }

    private void Start()
    {

        if (PlayerGO == null)
        {
            Debug.Log("Cant find player");
        }
    }
    private bool alreadydied = false;
    public void OnNotify()
    {
        if (PlayerGO != null)
        {
            if (PlayerGO.gameObject.GetComponent<PlayerBase>().Health <= 0&&alreadydied==false)
            {
                alreadydied = true;
                _flowchart.ExecuteBlock("PlayerDied");

                //UnityEditor.EditorApplication.isPlaying=false;
            }
        }
    }
}
