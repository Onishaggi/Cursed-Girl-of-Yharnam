using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealthUI : MonoBehaviour,IListener
{
    [SerializeField] AIMovingDamageDealerEnemy _mybody;
    private Image myHealthBar;

    private void OnEnable()
    {
        _mybody.GotDamagedEvent.AddListener(this);
    }
    private void OnDisable()
    {
        //_mybody.GotDamagedEvent.AddListener(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        myHealthBar = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void UpdateHealthBar()
    {
        //Debug.Log( 180/ _mybody.MaxHealth);
        if(myHealthBar&&_mybody)
        myHealthBar.fillAmount = _mybody.Health / _mybody.MaxHealth;
    }

    public void OnNotify()
    {
        UpdateHealthBar();
    }
}
