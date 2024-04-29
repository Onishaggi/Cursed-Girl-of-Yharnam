using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHealth : MonoBehaviour, IListener
{
    [SerializeField] Notifier _gameEvent;
    private TextMeshProUGUI _textMeshPro;
    private GameObject _player;
    private void OnEnable()
    {
        _gameEvent.AddListener(this);
    }
    private void OnDisable()
    {
        _gameEvent.RemoveListener(this);
    }

    private void Start()
    {

        _player = ServiceLocator.Instance.GetService<UIManager>().PlayerGO;
        _textMeshPro = GetComponent<TextMeshProUGUI>();
        if(ServiceLocator.Instance.GetService<UIManager>().PlayerGO==null)
        {
            Debug.Log("Service manager not managing");
        }
        else
        {
            Debug.Log("Service Manager is functioning");
        }
    }
    public void OnNotify()
    {
        UpdateHealth();
    }
    void UpdateHealth() {
        
        float PlayerHealth = 0;
        if (_player != null)
        {
            PlayerHealth = _player.gameObject.GetComponent<PlayerBase>().Health;
            _textMeshPro.text = $"Health : {PlayerHealth}";
        }


       
    
    }
}
